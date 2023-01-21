namespace Button_Clicker2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ClickBtn = new System.Windows.Forms.Button();
            this.text_Button = new System.Windows.Forms.Label();
            this.counterLbl = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickBtn
            // 
            this.ClickBtn.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ClickBtn.Location = new System.Drawing.Point(129, 222);
            this.ClickBtn.Name = "ClickBtn";
            this.ClickBtn.Size = new System.Drawing.Size(150, 53);
            this.ClickBtn.TabIndex = 0;
            this.ClickBtn.Text = "Button";
            this.ClickBtn.UseVisualStyleBackColor = true;
            this.ClickBtn.Click += new System.EventHandler(this.ClickBtn_Click);
            // 
            // text_Button
            // 
            this.text_Button.AutoSize = true;
            this.text_Button.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Button.Location = new System.Drawing.Point(45, 9);
            this.text_Button.Name = "text_Button";
            this.text_Button.Size = new System.Drawing.Size(324, 50);
            this.text_Button.TabIndex = 1;
            this.text_Button.Text = "Buttons Clicked";
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLbl.Location = new System.Drawing.Point(190, 119);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(21, 23);
            this.counterLbl.TabIndex = 2;
            this.counterLbl.Text = "0";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 295);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset?";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(406, 330);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.counterLbl);
            this.Controls.Add(this.text_Button);
            this.Controls.Add(this.ClickBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Button Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickBtn;
        private System.Windows.Forms.Label text_Button;
        private System.Windows.Forms.Label counterLbl;
        private System.Windows.Forms.Button resetBtn;
    }
}

