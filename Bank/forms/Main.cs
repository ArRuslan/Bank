using System;
using System.Windows.Forms;
using Bank.db;

namespace Bank.forms {
    public partial class BankForm : Form {
        public BankForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            new AddDepositorForm().ShowDialog();
            LoadDepositors();
        }
        
        public static DateTime TimestampToDateTime(long ts) {
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
        
        private void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            string menuText = e.ClickedItem.Text;
            int depositortId = int.Parse(depositorsList.FocusedItem.SubItems[0].Text);
            Depositor depositor = Database.GetDepositor(depositortId);
            if(depositor == null) return;
            
            switch(menuText) {
                case "Повна інформація":
                    new FullDepositorInformation(depositor).ShowDialog();
                    break;
                case "Поповнити вклад":
                    string am = new PromptForm().GetText("Введіть суму поповнення:");
                    if(am == "") return;
                    long a;
                    try {
                        a = long.Parse(am);
                        if(a < 1) {
                            MessageBox.Show("Число має бути більше 0!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    } catch (Exception) {
                        MessageBox.Show("Введене число не є коректним!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Database.SetDepositAmount(depositor.Id, depositor.DepositAmount+a);
                    LoadDepositors();
                    break;
                case "Зняти з вкладу":
                    string tm = new PromptForm().GetText("Введіть суму зняття:");
                    if(tm == "") return;
                    long t;
                    try {
                        t = long.Parse(tm);
                        if(t+1 > depositor.DepositAmount) {
                            MessageBox.Show("Число має бути менше ніж поточна сума вкладу!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if(t <= 0) {
                            MessageBox.Show("Число має бути більше 0!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    } catch (Exception) {
                        MessageBox.Show("Введене число не є коректним!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Database.SetDepositAmount(depositor.Id, depositor.DepositAmount-t);
                    LoadDepositors();
                    break;
                case "Редагувати":
                    new EditDepositorForm(depositor).ShowDialog();
                    LoadDepositors();
                    break;
                case "Видалити":
                    var confirmResult =  MessageBox.Show(
                    $"Ви впевнені що ви хочете видалити вклад №{depositor.Id} ({depositor.FullName})?",
                        "Підтверждення видалення",
                        MessageBoxButtons.YesNo
                    );
                    if(confirmResult == DialogResult.Yes) {
                        Database.DeleteDepositor(depositor);
                        LoadDepositors();
                    }
                    break;
            }
        }
        
        private void depositorsList_MouseClick(object sender, MouseEventArgs e) {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Повна інформація");
            contextMenu.Items.Add("Поповнити вклад");
            contextMenu.Items.Add("Зняти з вкладу");
            contextMenu.Items.Add("Редагувати");
            contextMenu.Items.Add("Видалити");
            contextMenu.ItemClicked += contexMenu_ItemClicked;
            if (e.Button == MouseButtons.Right) {
                var focusedItem = depositorsList.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location)) {
                    contextMenu.Show(Cursor.Position);
                }
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