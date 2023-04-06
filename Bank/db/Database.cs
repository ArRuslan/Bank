using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Bank.db {
    public class Database {
        private static SQLiteConnection connection;
        
        public static void init(string fileName = "bank") {
            connection = new SQLiteConnection($"Data Source={fileName}.db;Version=3;New=True;Compress=True;AutoCommit=True;");
            connection.Open();
            
            CreateTables();
        }
        
        private static void CreateTables() {
            SQLiteCommand cmd = connection.CreateCommand();
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

    public static void AddDepositor(string firstName, string lastName, string surName, string passportS, long passportN, double depositAmount, int depositCategory, int yearlyPercent) {
            SQLiteCommand cmd = connection.CreateCommand();
            long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long aTime = currentTime/86400;
            cmd.CommandText = $@"
                INSERT INTO `deposits` 
                (`firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `yearlyP`, `lastOperationTime`, `lastAccrTime`) 
                VALUES 
                (""{firstName}"", ""{lastName}"", ""{surName}"", ""{passportS}"", {passportN}, {depositAmount}, {depositCategory}, {yearlyPercent}, {currentTime}, {aTime});
            ";
            cmd.ExecuteNonQuery();
        }
        
        public static List<Depositor> GetAllDepositors() {
            List<Depositor>  depositors = new List<Depositor>();
            SQLiteDataReader reader;
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT 
                `id`, `firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `lastOperationTime`, `yearlyP`, `lastAccrTime` 
                FROM `deposits`;
            ";
            reader = cmd.ExecuteReader();
            while(reader.Read()) {
                depositors.Add(new Depositor(
                    reader.GetInt32(0), 
                    reader.GetString(1), 
                    reader.GetString(2), 
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetInt64(5),
                    reader.GetDouble(6),
                    reader.GetInt32(7),
                    reader.GetInt64(8),
                    reader.GetInt32(9),
                    reader.GetInt64(10)
                ));
            }
            return depositors;
        }
        
        public static Depositor GetDepositor(int id) {
            SQLiteDataReader reader;
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = $@"
                SELECT 
                `id`, `firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `lastOperationTime`, `yearlyP`, `lastAccrTime` 
                FROM `deposits` WHERE `id`={id};
            ";
            reader = cmd.ExecuteReader();
            if(reader.Read()) {
                return new Depositor(
                    reader.GetInt32(0), // Id
                    reader.GetString(1), // First name
                    reader.GetString(2), // Last name
                    reader.GetString(3), // Surname
                    reader.GetString(4), // Passport series
                    reader.GetInt64(5), // Passport number
                    reader.GetDouble(6), // Deposit amount
                    reader.GetInt32(7), // Deposit category
                    reader.GetInt64(8), // Last operation timestamp
                    reader.GetInt32(9), // Yearly percentage
                    reader.GetInt64(10) // Last accrual timestamp
                );
            }
            return null;
        }
        
        public static void EditDepositor(long id, string firstName, string lastName, string surName, string passportSeries, long passportNum, int depositCategory, int yearlyPercent) {
            SQLiteCommand cmd = connection.CreateCommand();
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
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = $@"
                DELETE FROM `deposits` WHERE `id`={depositor.Id};
            ";
            cmd.ExecuteNonQuery();
        }
        
        public static void SetDepositAmount(long id, double depositAmount, bool accr=false) {
            SQLiteCommand cmd = connection.CreateCommand();
            long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            currentTime = accr ? currentTime/86400 : currentTime;
            string op = accr ? "lastAccrTime" : "lastOperationTime";
            cmd.CommandText = $@"
                UPDATE `deposits` SET `depositAmount`=:depositAmount, `{op}`=:lastOpTime WHERE `id`=:id;
            ";
            cmd.Parameters.Add("depositAmount", DbType.Double).Value = depositAmount;
            cmd.Parameters.Add("lastOpTime", DbType.Int64).Value = currentTime;
            cmd.Parameters.Add("id", DbType.Int64).Value = id;
            cmd.ExecuteNonQuery();
        }
    }
}