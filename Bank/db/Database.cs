using System;
using System.Collections.Generic;
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
                    'lastProfTime'	INTEGER NOT NULL,
                    PRIMARY KEY(`id` AUTOINCREMENT)
                );";
            cmd.ExecuteNonQuery();
        }
        
        public SQLiteConnection Connection {
            get {
                if(connection == null) init();
                return connection;
            }
        }
        
        public static void AddDepositor(string firstName, string lastName, string surName, string passportS, long passportN, double depositAmount, int depositCategory, int yearlyPercent) {
            SQLiteCommand cmd = connection.CreateCommand();
            long currentTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            cmd.CommandText = $@"
                INSERT INTO `deposits` 
                (`firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `yearlyP`, `lastOperationTime`, `lastProfTime`) 
                VALUES 
                (""{firstName}"", ""{lastName}"", ""{surName}"", ""{passportS}"", {passportN}, {depositAmount}, {depositCategory}, {yearlyPercent}, {currentTime}, {currentTime});
            ";
            cmd.ExecuteNonQuery();
        }
        
        public static List<Depositor> GetAllDepositors() {
            List<Depositor>  depositors = new List<Depositor>();
            SQLiteDataReader reader;
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = @"
                SELECT 
                `id`, `firstName`, `lastName`, `surName`, `passportS`, `passportN`, `depositAmount`, `depositCategory`, `lastOperationTime`, `yearlyP`, `lastProfTime` 
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
                    reader.GetInt64(6),
                    reader.GetInt32(7),
                    reader.GetInt64(8),
                    reader.GetInt32(9),
                    reader.GetInt64(10)
                ));
            }
            return depositors;
        }
    }
}