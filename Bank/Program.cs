using System;
using System.Windows.Forms;
using Bank.db;

namespace Bank {
    static class Program {
        [STAThread]
        static void Main() {
            string dbName = Environment.GetEnvironmentVariable("DB_NAME");
            if(dbName == null) dbName = "bank";
            Database.init(dbName);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankForm());
        }
    }
}