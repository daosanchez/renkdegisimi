namespace form22
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
            this.cbBlue = new System.Windows.Forms.CheckBox();
            this.cbPurple = new System.Windows.Forms.CheckBox();
            this.cbBrown = new System.Windows.Forms.CheckBox();
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbYellow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbBlue
            // 
            this.cbBlue.AutoSize = true;
            this.cbBlue.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBlue.Location = new System.Drawing.Point(45, 75);
            this.cbBlue.Name = "cbBlue";
            this.cbBlue.Size = new System.Drawing.Size(58, 19);
            this.cbBlue.TabIndex = 0;
            this.cbBlue.Text = "Mavi";
            this.cbBlue.UseVisualStyleBackColor = true;
            this.cbBlue.CheckedChanged += new System.EventHandler(this.cbBlue_CheckedChanged);
            // 
            // cbPurple
            // 
            this.cbPurple.AutoSize = true;
            this.cbPurple.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPurple.Location = new System.Drawing.Point(45, 119);
            this.cbPurple.Name = "cbPurple";
            this.cbPurple.Size = new System.Drawing.Size(52, 19);
            this.cbPurple.TabIndex = 1;
            this.cbPurple.Text = "Mor";
            this.cbPurple.UseVisualStyleBackColor = true;
            this.cbPurple.CheckedChanged += new System.EventHandler(this.cbPurple_CheckedChanged);
            // 
            // cbBrown
            // 
            this.cbBrown.AutoSize = true;
            this.cbBrown.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrown.Location = new System.Drawing.Point(45, 161);
            this.cbBrown.Name = "cbBrown";
            this.cbBrown.Size = new System.Drawing.Size(106, 19);
            this.cbBrown.TabIndex = 2;
            this.cbBrown.Text = "Kahverengi";
            this.cbBrown.UseVisualStyleBackColor = true;
            this.cbBrown.CheckedChanged += new System.EventHandler(this.cbBrown_CheckedChanged);
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRed.Location = new System.Drawing.Point(45, 202);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(73, 19);
            this.cbRed.TabIndex = 3;
            this.cbRed.Text = "Kirmizi";
            this.cbRed.UseVisualStyleBackColor = true;
            this.cbRed.CheckedChanged += new System.EventHandler(this.cbRed_CheckedChanged);
            // 
            // cbYellow
            // 
            this.cbYellow.AutoSize = true;
            this.cbYellow.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYellow.Location = new System.Drawing.Point(45, 244);
            this.cbYellow.Name = "cbYellow";
            this.cbYellow.Size = new System.Drawing.Size(55, 19);
            this.cbYellow.TabIndex = 4;
            this.cbYellow.Text = "Sari";
            this.cbYellow.UseVisualStyleBackColor = true;
            this.cbYellow.CheckedChanged += new System.EventHandler(this.cbYellow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 368);
            this.Controls.Add(this.cbYellow);
            this.Controls.Add(this.cbRed);
            this.Controls.Add(this.cbBrown);
            this.Controls.Add(this.cbPurple);
            this.Controls.Add(this.cbBlue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbBlue;
        private System.Windows.Forms.CheckBox cbPurple;
        private System.Windows.Forms.CheckBox cbBrown;
        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbYellow;
    }
}

