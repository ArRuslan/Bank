namespace Bank.db {
    public enum DepositCategory {
        Accumulative = 0,
        Thrifty = 1,
        Universal = 2,
    }

    public class Depositor {
        public Depositor(int id, string firstName, string lastName, string surName, string passportS,
            long passportN, double depositAmount, DepositCategory depositCategory, long lastOperationTime, int yearlyPercent,
            long lastAccrTime) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            SurName = surName;
            PassportSeries = passportS;
            PassportNum = passportN;
            DepositAmount = depositAmount;
            DepositCategory = depositCategory;
            LastOperationTime = lastOperationTime;
            YearlyPercent = yearlyPercent;
            LastAccrTime = lastAccrTime;
        }

        public long Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string SurName { get; }
        public string PassportSeries { get; }
        public long PassportNum { get; }
        public double DepositAmount { get; }
        public DepositCategory DepositCategory { get; }
        public long LastOperationTime { get; }
        public int YearlyPercent { get; }
        public long LastAccrTime { get; }

        public string FullName => $"{LastName}  {FirstName}  {SurName}";
    }
}