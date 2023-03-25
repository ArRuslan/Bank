using System.ComponentModel;
using System.Windows.Forms;

namespace Bank.forms
{ partial class AddDepositorForm
  {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private IContainer components = null;

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
      this.firstName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lastName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.surname = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label124 = new System.Windows.Forms.Label();
      this.passportS = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.passportNum = new System.Windows.Forms.TextBox();
      this.depositCategory = new System.Windows.Forms.ComboBox();
      this.label6 = new System.Windows.Forms.Label();
      this.depositAmount = new System.Windows.Forms.TextBox();
      this.label123 = new System.Windows.Forms.Label();
      this.yearlyPercent = new System.Windows.Forms.TextBox();
      this.addDepositor = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // firstName
      // 
      this.firstName.Location = new System.Drawing.Point(118, 9);
      this.firstName.Name = "firstName";
      this.firstName.Size = new System.Drawing.Size(174, 20);
      this.firstName.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Ім\'я";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(12, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "Прізвище";
      // 
      // lastName
      // 
      this.lastName.Location = new System.Drawing.Point(118, 35);
      this.lastName.Name = "lastName";
      this.lastName.Size = new System.Drawing.Size(174, 20);
      this.lastName.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(12, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 20);
      this.label3.TabIndex = 5;
      this.label3.Text = "По батькові";
      // 
      // surname
      // 
      this.surname.Location = new System.Drawing.Point(118, 61);
      this.surname.Name = "surname";
      this.surname.Size = new System.Drawing.Size(174, 20);
      this.surname.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(12, 142);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(100, 20);
      this.label4.TabIndex = 7;
      this.label4.Text = "Категорія вкладу";
      // 
      // label124
      // 
      this.label124.Location = new System.Drawing.Point(12, 87);
      this.label124.Name = "label124";
      this.label124.Size = new System.Drawing.Size(100, 20);
      this.label124.TabIndex = 9;
      this.label124.Text = "Серія паспорта";
      // 
      // passportS
      // 
      this.passportS.Location = new System.Drawing.Point(118, 87);
      this.passportS.Name = "passportS";
      this.passportS.Size = new System.Drawing.Size(174, 20);
      this.passportS.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(12, 113);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 20);
      this.label5.TabIndex = 11;
      this.label5.Text = "Номер паспорта";
      // 
      // passportNum
      // 
      this.passportNum.Location = new System.Drawing.Point(118, 113);
      this.passportNum.Name = "passportNum";
      this.passportNum.Size = new System.Drawing.Size(174, 20);
      this.passportNum.TabIndex = 10;
      // 
      // depositCategory
      // 
      this.depositCategory.FormattingEnabled = true;
      this.depositCategory.Items.AddRange(new object[] {"Накопичувальний", "Ощадний", "Універсальний"});
      this.depositCategory.Location = new System.Drawing.Point(118, 139);
      this.depositCategory.Name = "depositCategory";
      this.depositCategory.Size = new System.Drawing.Size(174, 21);
      this.depositCategory.TabIndex = 12;
      this.depositCategory.DropDownStyle = ComboBoxStyle.DropDownList;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(12, 166);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(100, 20);
      this.label6.TabIndex = 14;
      this.label6.Text = "Сума вкладу";
      // 
      // depositAmount
      // 
      this.depositAmount.Location = new System.Drawing.Point(118, 166);
      this.depositAmount.Name = "depositAmount";
      this.depositAmount.Size = new System.Drawing.Size(174, 20);
      this.depositAmount.TabIndex = 13;
      // 
      // label123
      // 
      this.label123.Location = new System.Drawing.Point(12, 192);
      this.label123.Name = "label123";
      this.label123.Size = new System.Drawing.Size(100, 20);
      this.label123.TabIndex = 16;
      this.label123.Text = "% річних";
      // 
      // yearlyPercent
      // 
      this.yearlyPercent.Location = new System.Drawing.Point(118, 192);
      this.yearlyPercent.Name = "yearlyPercent";
      this.yearlyPercent.Size = new System.Drawing.Size(174, 20);
      this.yearlyPercent.TabIndex = 15;
      // 
      // addDepositor
      // 
      this.addDepositor.Location = new System.Drawing.Point(12, 225);
      this.addDepositor.Name = "addDepositor";
      this.addDepositor.Size = new System.Drawing.Size(280, 23);
      this.addDepositor.TabIndex = 17;
      this.addDepositor.Text = "Додати";
      this.addDepositor.UseVisualStyleBackColor = true;
      this.addDepositor.Click += new System.EventHandler(this.addDepositor_Click);
      // 
      // AddDepositorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(304, 261);
      this.Controls.Add(this.addDepositor);
      this.Controls.Add(this.label123);
      this.Controls.Add(this.yearlyPercent);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.depositAmount);
      this.Controls.Add(this.depositCategory);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.passportNum);
      this.Controls.Add(this.label124);
      this.Controls.Add(this.passportS);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.surname);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lastName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.firstName);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "AddDepositorForm";
      this.Load += new System.EventHandler(this.AddDepositorForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
  }

  private System.Windows.Forms.Button addDepositor;
  private System.Windows.Forms.TextBox depositAmount;

  private System.Windows.Forms.Label label123;

  private System.Windows.Forms.ComboBox depositCategory;

  private System.Windows.Forms.Label label124;
  private System.Windows.Forms.TextBox passportS;
  private System.Windows.Forms.Label label5;

  private System.Windows.Forms.TextBox firstName;

  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.TextBox surname;
  private System.Windows.Forms.TextBox passportNum;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.TextBox yearlyPercent;

  private System.Windows.Forms.TextBox lastName;
  private System.Windows.Forms.Label label1;

  #endregion
  } }