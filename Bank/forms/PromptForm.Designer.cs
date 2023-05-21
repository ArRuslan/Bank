using System.ComponentModel;

namespace Bank.forms
{ partial class PromptForm
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
      this.promptTextLabel = new System.Windows.Forms.Label();
      this.promptTextBox = new System.Windows.Forms.TextBox();
      this.btn_Ok = new System.Windows.Forms.Button();
      this.btn_Cancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // promptTextLabel
      // 
      this.promptTextLabel.Location = new System.Drawing.Point(12, 9);
      this.promptTextLabel.Name = "promptTextLabel";
      this.promptTextLabel.Size = new System.Drawing.Size(372, 26);
      this.promptTextLabel.TabIndex = 0;
      this.promptTextLabel.Text = "...";
      // 
      // promptTextBox
      // 
      this.promptTextBox.Location = new System.Drawing.Point(12, 38);
      this.promptTextBox.Name = "promptTextBox";
      this.promptTextBox.Size = new System.Drawing.Size(372, 20);
      this.promptTextBox.TabIndex = 1;
      // 
      // btn_Ok
      // 
      this.btn_Ok.Location = new System.Drawing.Point(12, 64);
      this.btn_Ok.Name = "btn_Ok";
      this.btn_Ok.Size = new System.Drawing.Size(183, 23);
      this.btn_Ok.TabIndex = 2;
      this.btn_Ok.Text = "Ок";
      this.btn_Ok.UseVisualStyleBackColor = true;
      this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
      // 
      // btn_Cancel
      // 
      this.btn_Cancel.Location = new System.Drawing.Point(201, 64);
      this.btn_Cancel.Name = "btn_Cancel";
      this.btn_Cancel.Size = new System.Drawing.Size(183, 23);
      this.btn_Cancel.TabIndex = 3;
      this.btn_Cancel.Text = "Назад";
      this.btn_Cancel.UseVisualStyleBackColor = true;
      this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
      // 
      // PromptForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(396, 99);
      this.Controls.Add(this.btn_Cancel);
      this.Controls.Add(this.btn_Ok);
      this.Controls.Add(this.promptTextBox);
      this.Controls.Add(this.promptTextLabel);
      this.MaximumSize = new System.Drawing.Size(412, 138);
      this.MinimumSize = new System.Drawing.Size(412, 138);
      this.Name = "PromptForm";
      this.Text = "Ввод";
      this.ResumeLayout(false);
      this.PerformLayout();
  }

  private System.Windows.Forms.Label promptTextLabel;
  private System.Windows.Forms.TextBox promptTextBox;
  private System.Windows.Forms.Button btn_Ok;
  private System.Windows.Forms.Button btn_Cancel;

  #endregion
  } }