namespace Trafic_lights
{
    partial class TraficLights
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
            this.RedLight = new System.Windows.Forms.PictureBox();
            this.YellowLight = new System.Windows.Forms.PictureBox();
            this.GreenLight = new System.Windows.Forms.PictureBox();
            this.RedButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.RedNumeric = new System.Windows.Forms.NumericUpDown();
            this.YellowNumeric = new System.Windows.Forms.NumericUpDown();
            this.GreenNumeric = new System.Windows.Forms.NumericUpDown();
            this.greenBlinkCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(12, 12);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(200, 200);
            this.RedLight.TabIndex = 0;
            this.RedLight.TabStop = false;
            // 
            // YellowLight
            // 
            this.YellowLight.Location = new System.Drawing.Point(12, 218);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(200, 200);
            this.YellowLight.TabIndex = 1;
            this.YellowLight.TabStop = false;
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(12, 424);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(200, 200);
            this.GreenLight.TabIndex = 2;
            this.GreenLight.TabStop = false;
            // 
            // RedButton
            // 
            this.RedButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedButton.Location = new System.Drawing.Point(218, 40);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(120, 23);
            this.RedButton.TabIndex = 6;
            this.RedButton.Tag = "R";
            this.RedButton.Text = "Set Red Interval";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.Click += new System.EventHandler(this.Buttons_click);
            // 
            // YellowButton
            // 
            this.YellowButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowButton.Location = new System.Drawing.Point(218, 246);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(120, 23);
            this.YellowButton.TabIndex = 7;
            this.YellowButton.Tag = "Y";
            this.YellowButton.Text = "Set Yellow Interval";
            this.YellowButton.UseVisualStyleBackColor = true;
            this.YellowButton.Click += new System.EventHandler(this.Buttons_click);
            // 
            // GreenButton
            // 
            this.GreenButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenButton.Location = new System.Drawing.Point(218, 452);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(120, 23);
            this.GreenButton.TabIndex = 8;
            this.GreenButton.Tag = "G";
            this.GreenButton.Text = "Set Green Interval";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.Click += new System.EventHandler(this.Buttons_click);
            // 
            // RedNumeric
            // 
            this.RedNumeric.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedNumeric.Location = new System.Drawing.Point(218, 12);
            this.RedNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RedNumeric.Name = "RedNumeric";
            this.RedNumeric.Size = new System.Drawing.Size(120, 22);
            this.RedNumeric.TabIndex = 9;
            // 
            // YellowNumeric
            // 
            this.YellowNumeric.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowNumeric.Location = new System.Drawing.Point(218, 218);
            this.YellowNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YellowNumeric.Name = "YellowNumeric";
            this.YellowNumeric.Size = new System.Drawing.Size(120, 22);
            this.YellowNumeric.TabIndex = 10;
            // 
            // GreenNumeric
            // 
            this.GreenNumeric.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenNumeric.Location = new System.Drawing.Point(218, 424);
            this.GreenNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.GreenNumeric.Name = "GreenNumeric";
            this.GreenNumeric.Size = new System.Drawing.Size(120, 22);
            this.GreenNumeric.TabIndex = 11;
            // 
            // greenBlinkCheck
            // 
            this.greenBlinkCheck.AutoSize = true;
            this.greenBlinkCheck.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenBlinkCheck.Location = new System.Drawing.Point(218, 481);
            this.greenBlinkCheck.Name = "greenBlinkCheck";
            this.greenBlinkCheck.Size = new System.Drawing.Size(87, 19);
            this.greenBlinkCheck.TabIndex = 12;
            this.greenBlinkCheck.Text = "Green Blink";
            this.greenBlinkCheck.UseVisualStyleBackColor = true;
            this.greenBlinkCheck.Click += new System.EventHandler(this.greenBlinkCheck_Click);
            // 
            // TraficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 636);
            this.Controls.Add(this.greenBlinkCheck);
            this.Controls.Add(this.GreenNumeric);
            this.Controls.Add(this.YellowNumeric);
            this.Controls.Add(this.RedNumeric);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.RedLight);
            this.Name = "TraficLights";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox YellowLight;
        private System.Windows.Forms.PictureBox GreenLight;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.NumericUpDown RedNumeric;
        private System.Windows.Forms.NumericUpDown YellowNumeric;
        private System.Windows.Forms.NumericUpDown GreenNumeric;
        private System.Windows.Forms.CheckBox greenBlinkCheck;
    }
}

