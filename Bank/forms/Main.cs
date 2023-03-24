using System;
using System.Windows.Forms;
using Bank.db;

namespace Bank {
    public partial class BankForm : Form {
        public BankForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new AddDepositorForm().ShowDialog();
            LoadDepositors();
        }
        
        private DateTime TimestampToDateTime(long ts) {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return dateTime.AddSeconds(ts).ToLocalTime();
        }
        
        private void LoadDepositors() {
            depositorsList.Items.Clear();
            foreach (Depositor depositor in Database.GetAllDepositors())  {
                depositorsList.Items.Add(new ListViewItem(new string[] {
                    depositor.Id.ToString(),
                    depositor.FirstName,
                    depositor.LastName,
                    depositor.SurName,
                    depositor.DepositAmount.ToString("C"),
                    depositor.YearlyPercent.ToString(),
                    TimestampToDateTime(depositor.LastOperationTime).ToString("dd.MM.yyyy HH:mm"),
                    TimestampToDateTime(depositor.LastProfTime).ToString("dd.MM.yyyy HH:mm")
                }));
            }
        }

        private void BankForm_Load(object sender, EventArgs e) {
            foreach (ColumnHeader column in depositorsList.Columns) {
                column.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            
            LoadDepositors();
        }
    }
}