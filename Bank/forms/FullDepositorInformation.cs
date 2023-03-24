using System;
using System.Windows.Forms;
using Bank.db;

namespace Bank.forms {
    public partial class FullDepositorInformation : Form {
        private Depositor depositor;
        
        public FullDepositorInformation(Depositor depositor) {
            this.depositor = depositor;
            InitializeComponent();
        }

        private void FullDepositorInformation_Load(object sender, EventArgs e) {
            depositId.Text = depositor.Id.ToString();
            fullName.Text = depositor.FullName;
            passportSeries.Text = depositor.PassportSeries;
            passportNum.Text = depositor.PassportNum.ToString();
            depositAmount.Text = depositor.DepositAmount.ToString("C");
            lastOpTime.Text = BankForm.TimestampToDateTime(depositor.LastOperationTime).ToString("dd.MM.yyyy HH:mm");
            yearlyPercentage.Text = depositor.YearlyPercent.ToString();
            lastProfitTime.Text = BankForm.TimestampToDateTime(depositor.LastProfTime).ToString("dd.MM.yyyy HH:mm");
        }

    }
}