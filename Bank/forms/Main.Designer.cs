using System.Windows.Forms;

namespace Bank.forms
{ partial class BankForm
  {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing) {
      if (disposing && (components != null))
      {
          components.Dispose();
      }

      base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
      this.add_depositor = new System.Windows.Forms.Button();
      this.depositorsList = new System.Windows.Forms.ListView();
      this.column_id = new System.Windows.Forms.ColumnHeader();
      this.column_firstName = new System.Windows.Forms.ColumnHeader();
      this.column_lastName = new System.Windows.Forms.ColumnHeader();
      this.column_surName = new System.Windows.Forms.ColumnHeader();
      this.column_amount = new System.Windows.Forms.ColumnHeader();
      this.column_yearly = new System.Windows.Forms.ColumnHeader();
      this.column_lastOp = new System.Windows.Forms.ColumnHeader();
      this.column_lastProf = new System.Windows.Forms.ColumnHeader();
      this.searchTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // add_depositor
      // 
      this.add_depositor.Location = new System.Drawing.Point(12, 399);
      this.add_depositor.Name = "add_depositor";
      this.add_depositor.Size = new System.Drawing.Size(680, 41);
      this.add_depositor.TabIndex = 1;
      this.add_depositor.Text = "Додати вклад";
      this.add_depositor.UseVisualStyleBackColor = true;
      this.add_depositor.Click += new System.EventHandler(this.button1_Click);
      // 
      // depositorsList
      // 
      this.depositorsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.column_id, this.column_firstName, this.column_lastName, this.column_surName, this.column_amount, this.column_yearly, this.column_lastOp, this.column_lastProf});
      this.depositorsList.FullRowSelect = true;
      this.depositorsList.GridLines = true;
      this.depositorsList.Location = new System.Drawing.Point(12, 36);
      this.depositorsList.MultiSelect = false;
      this.depositorsList.Name = "depositorsList";
      this.depositorsList.Size = new System.Drawing.Size(680, 357);
      this.depositorsList.TabIndex = 2;
      this.depositorsList.UseCompatibleStateImageBehavior = false;
      this.depositorsList.View = System.Windows.Forms.View.Details;
      this.depositorsList.MouseClick += new MouseEventHandler(depositorsList_MouseClick);
      // 
      // column_id
      // 
      this.column_id.Text = "№";
      this.column_id.Width = 30;
      // 
      // column_firstName
      // 
      this.column_firstName.Text = "Ім\'я";
      this.column_firstName.Width = 89;
      // 
      // column_lastName
      // 
      this.column_lastName.Text = "Прізвище";
      this.column_lastName.Width = 96;
      // 
      // column_surName
      // 
      this.column_surName.Text = "По-батькові";
      this.column_surName.Width = 85;
      // 
      // column_amount
      // 
      this.column_amount.Text = "Сума вкладу";
      this.column_amount.Width = 85;
      // 
      // column_yearly
      // 
      this.column_yearly.Text = "% річних";
      this.column_yearly.Width = 43;
      // 
      // column_lastOp
      // 
      this.column_lastOp.Text = "Остання операція";
      this.column_lastOp.Width = 112;
      // 
      // column_lastProf
      // 
      this.column_lastProf.Text = "Останнє нарахування";
      this.column_lastProf.Width = 143;
      // 
      // searchTextBox
      // 
      this.searchTextBox.Location = new System.Drawing.Point(62, 10);
      this.searchTextBox.Name = "searchTextBox";
      this.searchTextBox.Size = new System.Drawing.Size(630, 20);
      this.searchTextBox.TabIndex = 3;
      this.searchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = "Пошук:";
      // 
      // BankForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(704, 441);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.searchTextBox);
      this.Controls.Add(this.depositorsList);
      this.Controls.Add(this.add_depositor);
      this.MaximumSize = new System.Drawing.Size(720, 480);
      this.MinimumSize = new System.Drawing.Size(720, 480);
      this.Name = "BankForm";
      this.Text = "Bank";
      this.Load += new System.EventHandler(this.BankForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
  }

  private System.Windows.Forms.Label label1;

  private System.Windows.Forms.TextBox searchTextBox;

  private System.Windows.Forms.ColumnHeader column_lastOp;
  private System.Windows.Forms.ColumnHeader column_lastProf;

  private System.Windows.Forms.ColumnHeader column_yearly;

  private System.Windows.Forms.ColumnHeader column_firstName;
  private System.Windows.Forms.ColumnHeader column_lastName;
  private System.Windows.Forms.ColumnHeader column_surName;
  private System.Windows.Forms.ColumnHeader column_amount;

  private System.Windows.Forms.ColumnHeader column_id;

  private System.Windows.Forms.ListView depositorsList;

  private System.Windows.Forms.Button add_depositor;

  #endregion
  } }