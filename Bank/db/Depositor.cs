﻿namespace Bank.db {
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
        private long lastProfTime;
        
        public Depositor(int id, string firstName, string lastName, string surName, string passportS, 
        long passportN, double depositAmount, int depositCategory, long lastOperationTime, int yearlyPercent, long lastProfTime) {
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
            this.lastProfTime = lastProfTime;
        }
        
    public long Id {
        get { return id; }
    }
    
    public string FirstName {
        get { return firstName; }
    }
    
    public string LastName {
        get { return lastName; }
    }
    
    public string SurName {
        get { return surName; }
    }
    
    public string PassportSN {
        get { return passportS; }
    }
    
    public long PassportNum {
        get { return passportN; }
    }
    
    public double DepositAmount {
        get { return depositAmount; }
    }
    
    public int DepositCategory {
        get { return depositCategory; }
    }
    
    public long LastOperationTime {
        get { return lastOperationTime; }
    }
    
    public int YearlyPercent {
        get { return yearlyPercent; }
    }
    
    public long LastProfTime {
        get { return lastProfTime; }
    }
    
    }
}