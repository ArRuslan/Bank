using System;
using System.Windows.Forms;

namespace Bank.forms {
    public partial class PromptForm : Form {
        bool returnText = false;

        public PromptForm() {
            InitializeComponent();
            promptTextBox.KeyDown += OnKeyDownHandler;
        }

        public string GetText(string prompt) {
            promptTextLabel.Text = prompt;
            ShowDialog();
            return returnText ? promptTextBox.Text : "";
        }

        private void btn_Ok_Click(object sender, EventArgs e) {
            returnText = true;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            promptTextBox.Text = "";
            Close();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                returnText = true;
                Close();
            }
        }
    }
}