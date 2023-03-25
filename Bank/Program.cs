using System;
using System.Windows.Forms;
using Bank.db;
using Bank.forms;

namespace Bank {
    static class Program {
        [STAThread]
        static void Main() {
            string dbName = Environment.GetEnvironmentVariable("DB_NAME");
            if(dbName == null) dbName = "bank";
            Database.init(dbName);
            addAccr();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankForm());
        }
        
        static public void addAccr() {
            long currentDay = DateTimeOffset.UtcNow.ToUnixTimeSeconds() / 86400;
            foreach (Depositor depositor in Database.GetAllDepositors()) {
                if(currentDay > depositor.LastAccrTime) {
                    double newAmount = depositor.DepositAmount + 
                    depositor.DepositAmount / 100 * depositor.YearlyPercent / 365 * (currentDay-depositor.LastAccrTime);
                    Database.SetDepositAmount(depositor.Id, newAmount, true);
                }
            }
        }
    }
}