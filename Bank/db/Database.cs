using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Bank.db {
    public static class Database {
        private static SQLiteConnection _connection;

        public static void Init(string fileName = "bank") {
            _connection =
                new SQLiteConnection($"Data Source={fileName}.db;Version=3;New=True;Compress=True;AutoCommit=True;");
            _connection.Open();

            CreateTables();
        }

        private static void CreateTables() {
            SQLiteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS `deposits` (
                    'id'	INTEGER NOT NULL,
                    'firstName'	TEXT NOT NULL,
                    'lastName'	TEXT NOT NULL,
                    'surName'	TEXT NOT NULL,
                    'passportS'	TEXT NOT NULL,
                    'passportN'	INTEGER NOT NULL,
                    'depositAmount'	NUMERIC NOT NULL,
                    'depositCategory'	INTEGER NOT NULL,
                    'lastOperationTime'	INTEGER NOT NULL,
                    'yearlyP'	INTEGER NOT NULL,
                    'lastAccrTime'	INTEGER NOT NULL,
                    PRIMARY KEY(`id` AUTOINCREMENT)
                );";
            cmd.ExecuteNonQuery();
        }

        public static void AddDepositor(string firstName, string lastName, string surName, string passportS,
            long passportN, double depositAmount, int depositCategory, int yearlyPercent) {
            SQLiteCommand cmd = _connection.CreateCommand();
            long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long aTime = currentTime / 86400;
            cmd.CommandText = $@"
                INSERT INTO `deposits` 
                (`firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `yearlyP`, `lastOperationTime`, `lastAccrTime`) 
                VALUES 
                (""{firstName}"", ""{lastName}"", ""{surName}"", ""{passportS}"", {passportN}, {depositAmount}, {depositCategory}, {yearlyPercent}, {currentTime}, {aTime});
            ";
            cmd.ExecuteNonQuery();
        }

        private static Depositor ReaderToDepositor(SQLiteDataReader reader) {
            return new Depositor(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3),
                reader.GetString(4),
                reader.GetInt64(5),
                reader.GetDouble(6),
                (DepositCategory)reader.GetInt32(7),
                reader.GetInt64(8),
                reader.GetInt32(9),
                reader.GetInt64(10)
            );
        }

        public static List<Depositor> GetAllDepositors() {
            List<Depositor> depositors = new List<Depositor>();
            SQLiteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = @"
                SELECT 
                `id`, `firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `lastOperationTime`, `yearlyP`, `lastAccrTime` 
                FROM `deposits`;
            ";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                depositors.Add(ReaderToDepositor(reader));
            }

            return depositors;
        }

        public static Depositor GetDepositor(int id) {
            SQLiteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = $@"
                SELECT 
                `id`, `firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `lastOperationTime`, `yearlyP`, `lastAccrTime` 
                FROM `deposits` WHERE `id`={id};
            ";
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) {
                return ReaderToDepositor(reader);
            }

            return null;
        }

        public static void EditDepositor(long id, string firstName, string lastName, string surName,
            string passportSeries, long passportNum, int depositCategory, int yearlyPercent) {
            SQLiteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = $@"
                UPDATE `deposits` SET
                `firstName`=:firstName, `lastName`=:lastName, `surName`=:surName, `passportS`=:passportS, `passportN`=:passportNum, 
                `depositCategory`=:depositCategory, `yearlyP`=:yearlyPercent
                WHERE `id`=:id;
            ";
            cmd.Parameters.Add("firstName", DbType.String).Value = firstName;
            cmd.Parameters.Add("lastName", DbType.String).Value = lastName;
            cmd.Parameters.Add("surName", DbType.String).Value = surName;
            cmd.Parameters.Add("passportS", DbType.String).Value = passportSeries;
            cmd.Parameters.Add("passportNum", DbType.Int64).Value = passportNum;
            cmd.Parameters.Add("depositCategory", DbType.Int32).Value = depositCategory;
            cmd.Parameters.Add("yearlyPercent", DbType.Int32).Value = yearlyPercent;
            cmd.Parameters.Add("id", DbType.Int64).Value = id;
            cmd.ExecuteNonQuery();
        }

        public static void DeleteDepositor(Depositor depositor) {
            SQLiteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = $@"
                DELETE FROM `deposits` WHERE `id`={depositor.Id};
            ";
            cmd.ExecuteNonQuery();
        }

        public static void SetDepositAmount(long id, double depositAmount, bool accr = false) {
            SQLiteCommand cmd = _connection.CreateCommand();
            long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            currentTime = accr ? currentTime / 86400 : currentTime;
            string op = accr ? "lastAccrTime" : "lastOperationTime";
            cmd.CommandText = $@"
                UPDATE `deposits` SET `depositAmount`=:depositAmount, `{op}`=:lastOpTime WHERE `id`=:id;
            ";
            cmd.Parameters.Add("depositAmount", DbType.Double).Value = depositAmount;
            cmd.Parameters.Add("lastOpTime", DbType.Int64).Value = currentTime;
            cmd.Parameters.Add("id", DbType.Int64).Value = id;
            cmd.ExecuteNonQuery();
        }

        public static List<Depositor> Search(List<string> stringSq, List<int> numberSq) {
            if (!stringSq.Any() && !numberSq.Any()) return GetAllDepositors();

            List<Depositor> result = new List<Depositor>();
            List<int> ids = null;
            List<int> oldIds;

            SQLiteDataReader reader;
            SQLiteCommand cmd;
            string idFilter;

            foreach (string val in stringSq) {
                oldIds = ids;
                ids = new List<int>();
                idFilter = oldIds == null ? "" : $" AND `id` in ({String.Join(",", oldIds)})";

                cmd = _connection.CreateCommand();
                cmd.CommandText = $@"
                    SELECT `id` FROM `deposits` 
                    WHERE (`firstName` LIKE :value OR `lastName` LIKE :value OR `surName` LIKE :value OR `passportS` LIKE :value) 
                    {idFilter};
                ";
                cmd.Parameters.Add("value", DbType.String).Value = $"%{val}%";
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    if (ids.Contains(reader.GetInt32(0))) continue;
                    ids.Add(reader.GetInt32(0));
                }
            }

            foreach (int val in numberSq) {
                oldIds = ids;
                ids = new List<int>();
                idFilter = oldIds == null ? "" : $" AND `id` in ({String.Join(",", oldIds)})";

                cmd = _connection.CreateCommand();
                cmd.CommandText = $@"
                    SELECT `id` FROM `deposits` 
                    WHERE (CAST(`id` AS TEXT) LIKE :value OR CAST(`passportN` AS TEXT) LIKE :value OR CAST(`yearlyP` AS TEXT) LIKE :value)
                    {idFilter};
                ";
                cmd.Parameters.Add("value", DbType.String).Value = $"%{val}%";
                reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    if (ids.Contains(reader.GetInt32(0))) continue;
                    ids.Add(reader.GetInt32(0));
                }
            }

            cmd = _connection.CreateCommand();
            idFilter = ids == null ? "" : $"`id` in ({String.Join(",", ids)})";
            cmd.CommandText = $@"
                    SELECT `id`, `firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `lastOperationTime`, `yearlyP`, `lastAccrTime` 
                    FROM `deposits` 
                    WHERE {idFilter};
                ";
            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                result.Add(ReaderToDepositor(reader));
            }

            return result;
        }
    }
}