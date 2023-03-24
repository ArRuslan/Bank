using System;
using System.Windows.Forms;
using Bank.db;

namespace Bank.forms {
    public partial class EditDepositorForm : Form {
        private Depositor depositor;
    
        public EditDepositorForm(Depositor depositor) {
            this.depositor = depositor;
            InitializeComponent();
        }

        private void editDepositor_Click(object sender, EventArgs e) {
            try {
                if(long.Parse(passportNum.Text) < 1 || int.Parse(yearlyPercent.Text) < 1) {
                    MessageBox.Show("Введені дані не є коректними!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Введені числа не є коректними!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(firstName.Text.Trim() == "" || lastName.Text.Trim() == "" || surname.Text.Trim() == "" 
               || passportS.Text.Trim() == "") {
                MessageBox.Show("Введені дані не є коректними!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Database.EditDepositor(depositor.Id, firstName.Text.Trim(), lastName.Text.Trim(), surname.Text.Trim(),
                passportS.Text.Trim(), long.Parse(passportNum.Text), depositCategory.SelectedIndex, 
                int.Parse(yearlyPercent.Text));
            Close();
        }

        private void EditDepositorForm_Load(object sender, EventArgs e) {
            firstName.Text = depositor.FirstName;
            lastName.Text = depositor.LastName;
            surname.Text = depositor.SurName;
            passportS.Text = depositor.PassportSeries;
            passportNum.Text = depositor.PassportNum.ToString();
            depositCategory.SelectedIndex = depositor.DepositCategory;
            yearlyPercent.Text = depositor.YearlyPercent.ToString();
        }
    }
}