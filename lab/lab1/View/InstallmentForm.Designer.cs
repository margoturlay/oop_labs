
namespace lab1
{
    partial class InstallmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SumEdit = new System.Windows.Forms.TextBox();
            this.MonthsBox = new System.Windows.Forms.ComboBox();
            this.RequestButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.BankBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installment";
            // 
            // SumEdit
            // 
            this.SumEdit.BackColor = System.Drawing.Color.LavenderBlush;
            this.SumEdit.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumEdit.Location = new System.Drawing.Point(85, 219);
            this.SumEdit.Name = "SumEdit";
            this.SumEdit.Size = new System.Drawing.Size(195, 35);
            this.SumEdit.TabIndex = 1;
            this.SumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SumEdit_KeyPress);
            // 
            // MonthsBox
            // 
            this.MonthsBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.MonthsBox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthsBox.FormattingEnabled = true;
            this.MonthsBox.Location = new System.Drawing.Point(87, 161);
            this.MonthsBox.Name = "MonthsBox";
            this.MonthsBox.Size = new System.Drawing.Size(195, 30);
            this.MonthsBox.TabIndex = 2;
            // 
            // RequestButton
            // 
            this.RequestButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.RequestButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestButton.Location = new System.Drawing.Point(125, 269);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(109, 43);
            this.RequestButton.TabIndex = 3;
            this.RequestButton.Text = "Request";
            this.RequestButton.UseVisualStyleBackColor = false;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sum";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BackButton.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 370);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 46);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BankBox
            // 
            this.BankBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.BankBox.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankBox.FormattingEnabled = true;
            this.BankBox.Location = new System.Drawing.Point(85, 103);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(195, 30);
            this.BankBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bank";
            // 
            // InstallmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(415, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BankBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.MonthsBox);
            this.Controls.Add(this.SumEdit);
            this.Controls.Add(this.label1);
            this.Name = "InstallmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SumEdit;
        private System.Windows.Forms.ComboBox MonthsBox;
        private System.Windows.Forms.Button RequestButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ComboBox BankBox;
        private System.Windows.Forms.Label label5;
    }
}