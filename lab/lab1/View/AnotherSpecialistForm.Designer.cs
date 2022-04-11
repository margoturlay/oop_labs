
namespace lab1
{
    partial class AnotherSpecialistForm
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
            this.SalPrjButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AccBox = new System.Windows.Forms.ComboBox();
            this.SalPrjEdit = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TransferSumEdit = new System.Windows.Forms.TextBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.MyAccsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SalPrjButton
            // 
            this.SalPrjButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.SalPrjButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalPrjButton.Location = new System.Drawing.Point(346, 77);
            this.SalPrjButton.Name = "SalPrjButton";
            this.SalPrjButton.Size = new System.Drawing.Size(143, 52);
            this.SalPrjButton.TabIndex = 0;
            this.SalPrjButton.Text = "Take Salary project";
            this.SalPrjButton.UseVisualStyleBackColor = false;
            this.SalPrjButton.Click += new System.EventHandler(this.SalPrjButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sum";
            // 
            // AccBox
            // 
            this.AccBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.AccBox.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccBox.FormattingEnabled = true;
            this.AccBox.Location = new System.Drawing.Point(346, 214);
            this.AccBox.Name = "AccBox";
            this.AccBox.Size = new System.Drawing.Size(143, 25);
            this.AccBox.TabIndex = 2;
            this.AccBox.SelectedIndexChanged += new System.EventHandler(this.AccBox_SelectedIndexChanged);
            // 
            // SalPrjEdit
            // 
            this.SalPrjEdit.BackColor = System.Drawing.Color.LavenderBlush;
            this.SalPrjEdit.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalPrjEdit.Location = new System.Drawing.Point(346, 49);
            this.SalPrjEdit.Name = "SalPrjEdit";
            this.SalPrjEdit.Size = new System.Drawing.Size(143, 28);
            this.SalPrjEdit.TabIndex = 3;
            this.SalPrjEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalPrjEdit_KeyPress);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.LogoutButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(19, 353);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(87, 45);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // TransferSumEdit
            // 
            this.TransferSumEdit.BackColor = System.Drawing.Color.LavenderBlush;
            this.TransferSumEdit.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferSumEdit.Location = new System.Drawing.Point(346, 266);
            this.TransferSumEdit.Name = "TransferSumEdit";
            this.TransferSumEdit.Size = new System.Drawing.Size(143, 28);
            this.TransferSumEdit.TabIndex = 6;
            this.TransferSumEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransferSumEdit_KeyPress);
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.TransferButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferButton.Location = new System.Drawing.Point(346, 294);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(88, 36);
            this.TransferButton.TabIndex = 8;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // MyAccsBox
            // 
            this.MyAccsBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.MyAccsBox.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyAccsBox.FormattingEnabled = true;
            this.MyAccsBox.Location = new System.Drawing.Point(346, 164);
            this.MyAccsBox.Name = "MyAccsBox";
            this.MyAccsBox.Size = new System.Drawing.Size(143, 25);
            this.MyAccsBox.TabIndex = 9;
            this.MyAccsBox.SelectedIndexChanged += new System.EventHandler(this.MyAccsBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(346, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sum";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.richTextBox1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(19, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 295);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(220, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnotherSpecialistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(562, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MyAccsBox);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.TransferSumEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SalPrjEdit);
            this.Controls.Add(this.AccBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalPrjButton);
            this.Name = "AnotherSpecialistForm";
            this.Text = "AnotherSpecialistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalPrjButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AccBox;
        private System.Windows.Forms.TextBox SalPrjEdit;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TransferSumEdit;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.ComboBox MyAccsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}