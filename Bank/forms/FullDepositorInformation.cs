using System;
using System.Windows.Forms;
using Bank.db;
// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo

namespace Bank.forms {
    public partial class FullDepositorInformation : Form {
        private readonly Depositor _depositor;

        public FullDepositorInformation(Depositor depositor) {
            _depositor = depositor;
            InitializeComponent();
        }

        private void FullDepositorInformation_Load(object sender, EventArgs e) {
            depositId.Text = _depositor.Id.ToString();
            fullName.Text = _depositor.FullName;
            passportSeries.Text = _depositor.PassportSeries;
            passportNum.Text = _depositor.PassportNum.ToString();
            depositAmount.Text = _depositor.DepositAmount.ToString("C");
            lastOpTime.Text = BankForm.TimestampToDateTime(_depositor.LastOperationTime).ToString("dd.MM.yyyy HH:mm");
            yearlyPercentage.Text = _depositor.YearlyPercent.ToString();
            lastProfitTime.Text = BankForm.TimestampToDateTime(_depositor.LastAccrTime * 86400).ToString("dd.MM.yyyy");
            switch (_depositor.DepositCategory) {
                case 0:
                    depositCategory.Text = "Накопичувальний";
                    break;
                case 1:
                    depositCategory.Text = "Ощадний";
                    break;
                case 2:
                    depositCategory.Text = "Універсальний";
                    break;
            }
        }
    }
}