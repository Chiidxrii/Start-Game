namespace Start_Game
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
            this.cloudjumperLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.saveoneButton = new System.Windows.Forms.Button();
            this.savetwoButton = new System.Windows.Forms.Button();
            this.savesLabel = new System.Windows.Forms.Label();
            this.countdownLabel1 = new System.Windows.Forms.Label();
            this.countdownLabel2 = new System.Windows.Forms.Label();
            this.countdownLabel3 = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cloudjumperLabel
            // 
            this.cloudjumperLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudjumperLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.cloudjumperLabel.Location = new System.Drawing.Point(156, 101);
            this.cloudjumperLabel.Name = "cloudjumperLabel";
            this.cloudjumperLabel.Size = new System.Drawing.Size(264, 152);
            this.cloudjumperLabel.TabIndex = 0;
            this.cloudjumperLabel.Text = "Cloud Jumper";
            this.cloudjumperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Transparent;
            this.startButton.Location = new System.Drawing.Point(229, 211);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(118, 42);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // saveoneButton
            // 
            this.saveoneButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.saveoneButton.FlatAppearance.BorderSize = 2;
            this.saveoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.saveoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveoneButton.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveoneButton.ForeColor = System.Drawing.Color.Transparent;
            this.saveoneButton.Location = new System.Drawing.Point(209, 155);
            this.saveoneButton.Name = "saveoneButton";
            this.saveoneButton.Size = new System.Drawing.Size(159, 50);
            this.saveoneButton.TabIndex = 2;
            this.saveoneButton.Text = "Save One";
            this.saveoneButton.UseVisualStyleBackColor = true;
            this.saveoneButton.Visible = false;
            this.saveoneButton.Click += new System.EventHandler(this.saveoneButton_Click);
            // 
            // savetwoButton
            // 
            this.savetwoButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.savetwoButton.FlatAppearance.BorderSize = 2;
            this.savetwoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.savetwoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.savetwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savetwoButton.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetwoButton.ForeColor = System.Drawing.Color.Transparent;
            this.savetwoButton.Location = new System.Drawing.Point(209, 259);
            this.savetwoButton.Name = "savetwoButton";
            this.savetwoButton.Size = new System.Drawing.Size(159, 50);
            this.savetwoButton.TabIndex = 3;
            this.savetwoButton.Text = "Save Two";
            this.savetwoButton.UseVisualStyleBackColor = true;
            this.savetwoButton.Visible = false;
            this.savetwoButton.Click += new System.EventHandler(this.savetwoButton_Click);
            // 
            // savesLabel
            // 
            this.savesLabel.AutoSize = true;
            this.savesLabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savesLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.savesLabel.Location = new System.Drawing.Point(234, 81);
            this.savesLabel.Name = "savesLabel";
            this.savesLabel.Size = new System.Drawing.Size(102, 30);
            this.savesLabel.TabIndex = 4;
            this.savesLabel.Text = "Saves";
            this.savesLabel.Visible = false;
            this.savesLabel.Click += new System.EventHandler(this.savesLabel_Click);
            // 
            // countdownLabel1
            // 
            this.countdownLabel1.AutoSize = true;
            this.countdownLabel1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.countdownLabel1.Location = new System.Drawing.Point(268, 211);
            this.countdownLabel1.Name = "countdownLabel1";
            this.countdownLabel1.Size = new System.Drawing.Size(32, 32);
            this.countdownLabel1.TabIndex = 5;
            this.countdownLabel1.Text = "1";
            this.countdownLabel1.Visible = false;
            // 
            // countdownLabel2
            // 
            this.countdownLabel2.AutoSize = true;
            this.countdownLabel2.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.countdownLabel2.Location = new System.Drawing.Point(268, 208);
            this.countdownLabel2.Name = "countdownLabel2";
            this.countdownLabel2.Size = new System.Drawing.Size(32, 32);
            this.countdownLabel2.TabIndex = 6;
            this.countdownLabel2.Text = "2";
            this.countdownLabel2.Visible = false;
            // 
            // countdownLabel3
            // 
            this.countdownLabel3.AutoSize = true;
            this.countdownLabel3.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.countdownLabel3.Location = new System.Drawing.Point(268, 208);
            this.countdownLabel3.Name = "countdownLabel3";
            this.countdownLabel3.Size = new System.Drawing.Size(32, 32);
            this.countdownLabel3.TabIndex = 7;
            this.countdownLabel3.Text = "3";
            this.countdownLabel3.Visible = false;
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.goLabel.Location = new System.Drawing.Point(253, 208);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(81, 41);
            this.goLabel.TabIndex = 8;
            this.goLabel.Text = "GO!";
            this.goLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(604, 471);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.countdownLabel3);
            this.Controls.Add(this.countdownLabel2);
            this.Controls.Add(this.countdownLabel1);
            this.Controls.Add(this.savesLabel);
            this.Controls.Add(this.savetwoButton);
            this.Controls.Add(this.saveoneButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.cloudjumperLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cloudjumperLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveoneButton;
        private System.Windows.Forms.Button savetwoButton;
        private System.Windows.Forms.Label savesLabel;
        private System.Windows.Forms.Label countdownLabel1;
        private System.Windows.Forms.Label countdownLabel2;
        private System.Windows.Forms.Label countdownLabel3;
        private System.Windows.Forms.Label goLabel;
    }
}

