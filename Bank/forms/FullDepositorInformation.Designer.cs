using System.ComponentModel;

namespace Bank.forms
{ partial class FullDepositorInformation
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.depositId = new System.Windows.Forms.Label();
      this.fullName = new System.Windows.Forms.Label();
      this.passportSeries = new System.Windows.Forms.Label();
      this.passportNum = new System.Windows.Forms.Label();
      this.depositAmount = new System.Windows.Forms.Label();
      this.lastOpTime = new System.Windows.Forms.Label();
      this.yearlyPercentage = new System.Windows.Forms.Label();
      this.lastProfitTime = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(172, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Номер рахунку:";
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label2.Location = new System.Drawing.Point(12, 25);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(172, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "ПІБ:";
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label3.Location = new System.Drawing.Point(12, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(172, 16);
      this.label3.TabIndex = 2;
      this.label3.Text = "Серія паспорту:";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label4.Location = new System.Drawing.Point(12, 57);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(172, 16);
      this.label4.TabIndex = 3;
      this.label4.Text = "Номер паспорту:";
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label5.Location = new System.Drawing.Point(12, 73);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(172, 16);
      this.label5.TabIndex = 4;
      this.label5.Text = "Поточна сума вкладу:";
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label6.Location = new System.Drawing.Point(12, 89);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(172, 16);
      this.label6.TabIndex = 5;
      this.label6.Text = "Час останнью операції:";
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label7.Location = new System.Drawing.Point(12, 105);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(172, 16);
      this.label7.TabIndex = 6;
      this.label7.Text = "% річних:";
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.label8.Location = new System.Drawing.Point(12, 121);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(172, 16);
      this.label8.TabIndex = 7;
      this.label8.Text = "Останнє нарахування %;";
      // 
      // depositId
      // 
      this.depositId.Location = new System.Drawing.Point(190, 9);
      this.depositId.Name = "depositId";
      this.depositId.Size = new System.Drawing.Size(222, 16);
      this.depositId.TabIndex = 8;
      this.depositId.Text = "-";
      // 
      // fullName
      // 
      this.fullName.Location = new System.Drawing.Point(190, 25);
      this.fullName.Name = "fullName";
      this.fullName.Size = new System.Drawing.Size(222, 16);
      this.fullName.TabIndex = 9;
      this.fullName.Text = "-";
      // 
      // passportSeries
      // 
      this.passportSeries.Location = new System.Drawing.Point(190, 41);
      this.passportSeries.Name = "passportSeries";
      this.passportSeries.Size = new System.Drawing.Size(222, 16);
      this.passportSeries.TabIndex = 10;
      this.passportSeries.Text = "-";
      // 
      // passportNum
      // 
      this.passportNum.Location = new System.Drawing.Point(190, 57);
      this.passportNum.Name = "passportNum";
      this.passportNum.Size = new System.Drawing.Size(222, 16);
      this.passportNum.TabIndex = 11;
      this.passportNum.Text = "-";
      // 
      // depositAmount
      // 
      this.depositAmount.Location = new System.Drawing.Point(190, 73);
      this.depositAmount.Name = "depositAmount";
      this.depositAmount.Size = new System.Drawing.Size(222, 16);
      this.depositAmount.TabIndex = 12;
      this.depositAmount.Text = "-";
      // 
      // lastOpTime
      // 
      this.lastOpTime.Location = new System.Drawing.Point(190, 89);
      this.lastOpTime.Name = "lastOpTime";
      this.lastOpTime.Size = new System.Drawing.Size(222, 16);
      this.lastOpTime.TabIndex = 13;
      this.lastOpTime.Text = "-";
      // 
      // yearlyPercentage
      // 
      this.yearlyPercentage.Location = new System.Drawing.Point(190, 105);
      this.yearlyPercentage.Name = "yearlyPercentage";
      this.yearlyPercentage.Size = new System.Drawing.Size(222, 16);
      this.yearlyPercentage.TabIndex = 14;
      this.yearlyPercentage.Text = "-";
      // 
      // lastProfitTime
      // 
      this.lastProfitTime.Location = new System.Drawing.Point(190, 121);
      this.lastProfitTime.Name = "lastProfitTime";
      this.lastProfitTime.Size = new System.Drawing.Size(222, 16);
      this.lastProfitTime.TabIndex = 15;
      this.lastProfitTime.Text = "-";
      // 
      // FullDepositorInformation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(424, 151);
      this.Controls.Add(this.lastProfitTime);
      this.Controls.Add(this.yearlyPercentage);
      this.Controls.Add(this.lastOpTime);
      this.Controls.Add(this.depositAmount);
      this.Controls.Add(this.passportNum);
      this.Controls.Add(this.passportSeries);
      this.Controls.Add(this.fullName);
      this.Controls.Add(this.depositId);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Location = new System.Drawing.Point(15, 15);
      this.MaximumSize = new System.Drawing.Size(440, 190);
      this.MinimumSize = new System.Drawing.Size(440, 190);
      this.Name = "FullDepositorInformation";
      this.Load += FullDepositorInformation_Load;
      this.ResumeLayout(false);
  }

  private System.Windows.Forms.Label label6;
  private System.Windows.Forms.Label label7;
  private System.Windows.Forms.Label label8;
  private System.Windows.Forms.Label depositId;
  private System.Windows.Forms.Label fullName;
  private System.Windows.Forms.Label passportSeries;
  private System.Windows.Forms.Label passportNum;
  private System.Windows.Forms.Label depositAmount;
  private System.Windows.Forms.Label lastOpTime;
  private System.Windows.Forms.Label yearlyPercentage;
  private System.Windows.Forms.Label lastProfitTime;

  private System.Windows.Forms.Label label2;
  private System.Windows.Forms.Label label3;
  private System.Windows.Forms.Label label4;
  private System.Windows.Forms.Label label5;

  private System.Windows.Forms.Label label1;

  #endregion
  } }