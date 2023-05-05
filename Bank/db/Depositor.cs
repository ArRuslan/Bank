namespace Bank.db {
    public class Depositor {
        private long id;
        private string firstName;
        private string lastName;
        private string surName;
        private string passportS;
        private long passportN;
        private double depositAmount;
        private int depositCategory;
        private long lastOperationTime;
        private int yearlyPercent;
        private long _lastAccrTime;
        
        public Depositor(int id, string firstName, string lastName, string surName, string passportS, 
        long passportN, double depositAmount, int depositCategory, long lastOperationTime, int yearlyPercent, long lastAccrTime) {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.surName = surName;
            this.passportS = passportS;
            this.passportN = passportN;
            this.depositAmount = depositAmount;
            this.depositCategory = depositCategory;
            this.lastOperationTime = lastOperationTime;
            this.yearlyPercent = yearlyPercent;
            _lastAccrTime = lastAccrTime;
        }
        
        public long Id => id;
        public string FirstName => firstName;
        public string LastName => lastName;
        public string SurName => surName;
        public string PassportSeries => passportS;
        public long PassportNum => passportN;
        public double DepositAmount => depositAmount;
        public int DepositCategory => depositCategory;
        public long LastOperationTime => lastOperationTime;
        public int YearlyPercent => yearlyPercent;
        public long LastAccrTime => _lastAccrTime;
        public string FullName => $"{LastName}  {FirstName}  {SurName}"; }
}