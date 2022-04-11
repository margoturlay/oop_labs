
namespace lab1
{
    partial class OperatorForm
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
            this.StatusMemo = new System.Windows.Forms.RichTextBox();
            this.ProjectsBox = new System.Windows.Forms.ComboBox();
            this.AllprgButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StatusMemo
            // 
            this.StatusMemo.BackColor = System.Drawing.Color.LavenderBlush;
            this.StatusMemo.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusMemo.Location = new System.Drawing.Point(620, 22);
            this.StatusMemo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusMemo.Name = "StatusMemo";
            this.StatusMemo.Size = new System.Drawing.Size(515, 476);
            this.StatusMemo.TabIndex = 0;
            this.StatusMemo.Text = "";
            // 
            // ProjectsBox
            // 
            this.ProjectsBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.ProjectsBox.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsBox.FormattingEnabled = true;
            this.ProjectsBox.Location = new System.Drawing.Point(93, 81);
            this.ProjectsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectsBox.Name = "ProjectsBox";
            this.ProjectsBox.Size = new System.Drawing.Size(286, 36);
            this.ProjectsBox.TabIndex = 1;
            // 
            // AllprgButton
            // 
            this.AllprgButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.AllprgButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllprgButton.Location = new System.Drawing.Point(620, 509);
            this.AllprgButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AllprgButton.Name = "AllprgButton";
            this.AllprgButton.Size = new System.Drawing.Size(234, 47);
            this.AllprgButton.TabIndex = 2;
            this.AllprgButton.Text = "Show all projects";
            this.AllprgButton.UseVisualStyleBackColor = false;
            this.AllprgButton.Click += new System.EventHandler(this.AllprgButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(160, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projects";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.ConfirmButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(18, 150);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(140, 47);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button4.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(18, 469);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 88);
            this.button4.TabIndex = 6;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeclineButton
            // 
            this.DeclineButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.DeclineButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeclineButton.Location = new System.Drawing.Point(166, 150);
            this.DeclineButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(140, 47);
            this.DeclineButton.TabIndex = 7;
            this.DeclineButton.Text = "Decline";
            this.DeclineButton.UseVisualStyleBackColor = false;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.ShowButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(315, 150);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(140, 47);
            this.ShowButton.TabIndex = 8;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClearButton.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearButton.Location = new System.Drawing.Point(1024, 22);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 41);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(862, 509);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show account logs";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1177, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllprgButton);
            this.Controls.Add(this.ProjectsBox);
            this.Controls.Add(this.StatusMemo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OperatorForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox StatusMemo;
        private System.Windows.Forms.ComboBox ProjectsBox;
        private System.Windows.Forms.Button AllprgButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button1;
    }
}