
namespace lab1
{
    partial class ChoosingOptionForm
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
            this.SignIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.LavenderBlush;
            this.SignIn.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SignIn.Location = new System.Drawing.Point(225, 190);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(134, 44);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Sign up";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.LavenderBlush;
            this.SignUp.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(225, 126);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(134, 45);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Sign in";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the option";
            // 
            // ChoosingOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(573, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SignIn);
            this.Name = "ChoosingOptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoosingOptionForm";
            this.Load += new System.EventHandler(this.ChoosingOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label label1;
    }
}

