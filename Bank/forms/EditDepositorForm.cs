using System;
using System.Windows.Forms;
using Bank.db;
// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo

namespace Bank.forms {
    public partial class EditDepositorForm : Form {
        private readonly Depositor _depositor;

        public EditDepositorForm(Depositor depositor) {
            _depositor = depositor;
            InitializeComponent();
        }

        private void editDepositor_Click(object sender, EventArgs e) {
            try {
                if (long.Parse(passportNum.Text) < 1 || int.Parse(yearlyPercent.Text) < 1) {
                    MessageBox.Show("Введені дані не є коректними!", "Помилка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception) {
                MessageBox.Show("Введені числа не є коректними!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (firstName.Text.Trim() == "" || lastName.Text.Trim() == "" || surname.Text.Trim() == ""
                || passportS.Text.Trim() == "") {
                MessageBox.Show("Введені дані не є коректними!", "Помилка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Database.EditDepositor(_depositor.Id, firstName.Text.Trim(), lastName.Text.Trim(), surname.Text.Trim(),
                passportS.Text.Trim(), long.Parse(passportNum.Text), depositCategory.SelectedIndex,
                int.Parse(yearlyPercent.Text));
            Close();
        }

        private void EditDepositorForm_Load(object sender, EventArgs e) {
            firstName.Text = _depositor.FirstName;
            lastName.Text = _depositor.LastName;
            surname.Text = _depositor.SurName;
            passportS.Text = _depositor.PassportSeries;
            passportNum.Text = _depositor.PassportNum.ToString();
            depositCategory.SelectedIndex = _depositor.DepositCategory;
            yearlyPercent.Text = _depositor.YearlyPercent.ToString();
        }
    }
}