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
            this.RedBox = new System.Windows.Forms.TextBox();
            this.YellowBox = new System.Windows.Forms.TextBox();
            this.GreenBox = new System.Windows.Forms.TextBox();
            this.RedButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
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
            // RedBox
            // 
            this.RedBox.Location = new System.Drawing.Point(218, 12);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(100, 20);
            this.RedBox.TabIndex = 3;
            // 
            // YellowBox
            // 
            this.YellowBox.Location = new System.Drawing.Point(218, 218);
            this.YellowBox.Name = "YellowBox";
            this.YellowBox.Size = new System.Drawing.Size(100, 20);
            this.YellowBox.TabIndex = 4;
            // 
            // GreenBox
            // 
            this.GreenBox.Location = new System.Drawing.Point(218, 424);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(100, 20);
            this.GreenBox.TabIndex = 5;
            // 
            // RedButton
            // 
            this.RedButton.Location = new System.Drawing.Point(324, 12);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(108, 23);
            this.RedButton.TabIndex = 6;
            this.RedButton.Text = "Set Red Interval";
            this.RedButton.UseVisualStyleBackColor = true;
            // 
            // YellowButton
            // 
            this.YellowButton.Location = new System.Drawing.Point(324, 218);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(108, 23);
            this.YellowButton.TabIndex = 7;
            this.YellowButton.Text = "Set Yellow Interval";
            this.YellowButton.UseVisualStyleBackColor = true;
            // 
            // GreenButton
            // 
            this.GreenButton.Location = new System.Drawing.Point(324, 424);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(108, 23);
            this.GreenButton.TabIndex = 8;
            this.GreenButton.Text = "Set Green Interval";
            this.GreenButton.UseVisualStyleBackColor = true;
            // 
            // TraficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 636);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.YellowBox);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.RedLight);
            this.Name = "TraficLights";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox YellowLight;
        private System.Windows.Forms.PictureBox GreenLight;
        private System.Windows.Forms.TextBox RedBox;
        private System.Windows.Forms.TextBox YellowBox;
        private System.Windows.Forms.TextBox GreenBox;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button GreenButton;
    }
}

