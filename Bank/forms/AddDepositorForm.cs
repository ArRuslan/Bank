using System;
using System.Windows.Forms;
using Bank.db;

namespace Bank.forms {
    public partial class AddDepositorForm : Form {
        public AddDepositorForm() {
            InitializeComponent();
        }

        private void AddDepositorForm_Load(object sender, EventArgs e) {
            depositCategory.SelectedIndex = 0;
        }

        private void addDepositor_Click(object sender, EventArgs e) {
            try {
                if(long.Parse(passportNum.Text) < 1 || long.Parse(depositAmount.Text) < 1 || int.Parse(yearlyPercent.Text) < 1) {
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
            Database.AddDepositor(firstName.Text.Trim(), lastName.Text.Trim(), surname.Text.Trim(),
            passportS.Text.Trim(), long.Parse(passportNum.Text), long.Parse(depositAmount.Text),
            depositCategory.SelectedIndex, int.Parse(yearlyPercent.Text));
            Close();
        }
    }
}