namespace _1v1MeBro.WinForm
{
    partial class MainForm
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
            this.Summoner1Textbox = new System.Windows.Forms.TextBox();
            this.Summoner1Label = new System.Windows.Forms.Label();
            this.APILable = new System.Windows.Forms.Label();
            this.APITextBox = new System.Windows.Forms.TextBox();
            this.Summoner2Label = new System.Windows.Forms.Label();
            this.Summoner2Textbox = new System.Windows.Forms.TextBox();
            this.ChampionLabel = new System.Windows.Forms.Label();
            this.MasteryPointsLabel = new System.Windows.Forms.Label();
            this.Summoner1MP_Textbox = new System.Windows.Forms.TextBox();
            this.Summoner2MP_Textbox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.Summoner2AL_TextBox = new System.Windows.Forms.TextBox();
            this.Summoner1AL_TextBox = new System.Windows.Forms.TextBox();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.AccountLevel_Label = new System.Windows.Forms.Label();
            this.ChampID_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Summoner1Textbox
            // 
            this.Summoner1Textbox.Location = new System.Drawing.Point(66, 81);
            this.Summoner1Textbox.Name = "Summoner1Textbox";
            this.Summoner1Textbox.Size = new System.Drawing.Size(170, 20);
            this.Summoner1Textbox.TabIndex = 0;
            // 
            // Summoner1Label
            // 
            this.Summoner1Label.AutoSize = true;
            this.Summoner1Label.Location = new System.Drawing.Point(120, 65);
            this.Summoner1Label.Name = "Summoner1Label";
            this.Summoner1Label.Size = new System.Drawing.Size(69, 13);
            this.Summoner1Label.TabIndex = 1;
            this.Summoner1Label.Text = "Summoner 1:";
            // 
            // APILable
            // 
            this.APILable.AutoSize = true;
            this.APILable.Location = new System.Drawing.Point(12, 22);
            this.APILable.Name = "APILable";
            this.APILable.Size = new System.Drawing.Size(48, 13);
            this.APILable.TabIndex = 2;
            this.APILable.Text = "API Key:";
            // 
            // APITextBox
            // 
            this.APITextBox.Location = new System.Drawing.Point(66, 19);
            this.APITextBox.Name = "APITextBox";
            this.APITextBox.Size = new System.Drawing.Size(450, 20);
            this.APITextBox.TabIndex = 3;
            // 
            // Summoner2Label
            // 
            this.Summoner2Label.AutoSize = true;
            this.Summoner2Label.Location = new System.Drawing.Point(398, 65);
            this.Summoner2Label.Name = "Summoner2Label";
            this.Summoner2Label.Size = new System.Drawing.Size(69, 13);
            this.Summoner2Label.TabIndex = 4;
            this.Summoner2Label.Text = "Summoner 2:";
            // 
            // Summoner2Textbox
            // 
            this.Summoner2Textbox.Location = new System.Drawing.Point(356, 81);
            this.Summoner2Textbox.Name = "Summoner2Textbox";
            this.Summoner2Textbox.Size = new System.Drawing.Size(160, 20);
            this.Summoner2Textbox.TabIndex = 5;
            this.Summoner2Textbox.TextChanged += new System.EventHandler(this.Summoner2Textbox_TextChanged);
            // 
            // ChampionLabel
            // 
            this.ChampionLabel.AutoSize = true;
            this.ChampionLabel.Location = new System.Drawing.Point(160, 140);
            this.ChampionLabel.Name = "ChampionLabel";
            this.ChampionLabel.Size = new System.Drawing.Size(81, 13);
            this.ChampionLabel.TabIndex = 7;
            this.ChampionLabel.Text = "Champion ID #:";
            // 
            // MasteryPointsLabel
            // 
            this.MasteryPointsLabel.AutoSize = true;
            this.MasteryPointsLabel.Location = new System.Drawing.Point(256, 289);
            this.MasteryPointsLabel.Name = "MasteryPointsLabel";
            this.MasteryPointsLabel.Size = new System.Drawing.Size(79, 13);
            this.MasteryPointsLabel.TabIndex = 8;
            this.MasteryPointsLabel.Text = "Mastery Points:";
            // 
            // Summoner1MP_Textbox
            // 
            this.Summoner1MP_Textbox.Location = new System.Drawing.Point(66, 312);
            this.Summoner1MP_Textbox.Name = "Summoner1MP_Textbox";
            this.Summoner1MP_Textbox.ReadOnly = true;
            this.Summoner1MP_Textbox.Size = new System.Drawing.Size(170, 20);
            this.Summoner1MP_Textbox.TabIndex = 9;
            // 
            // Summoner2MP_Textbox
            // 
            this.Summoner2MP_Textbox.Location = new System.Drawing.Point(356, 312);
            this.Summoner2MP_Textbox.Name = "Summoner2MP_Textbox";
            this.Summoner2MP_Textbox.ReadOnly = true;
            this.Summoner2MP_Textbox.Size = new System.Drawing.Size(170, 20);
            this.Summoner2MP_Textbox.TabIndex = 10;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(259, 176);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 11;
            this.StartButton.Text = "Go!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Summoner2AL_TextBox
            // 
            this.Summoner2AL_TextBox.Location = new System.Drawing.Point(356, 237);
            this.Summoner2AL_TextBox.Name = "Summoner2AL_TextBox";
            this.Summoner2AL_TextBox.ReadOnly = true;
            this.Summoner2AL_TextBox.Size = new System.Drawing.Size(170, 20);
            this.Summoner2AL_TextBox.TabIndex = 13;
            // 
            // Summoner1AL_TextBox
            // 
            this.Summoner1AL_TextBox.Location = new System.Drawing.Point(66, 237);
            this.Summoner1AL_TextBox.Name = "Summoner1AL_TextBox";
            this.Summoner1AL_TextBox.ReadOnly = true;
            this.Summoner1AL_TextBox.Size = new System.Drawing.Size(170, 20);
            this.Summoner1AL_TextBox.TabIndex = 12;
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Location = new System.Drawing.Point(279, 392);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(44, 13);
            this.WinnerLabel.TabIndex = 16;
            this.WinnerLabel.Text = "Winner:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(215, 408);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(170, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // AccountLevel_Label
            // 
            this.AccountLevel_Label.AutoSize = true;
            this.AccountLevel_Label.Location = new System.Drawing.Point(255, 220);
            this.AccountLevel_Label.Name = "AccountLevel_Label";
            this.AccountLevel_Label.Size = new System.Drawing.Size(79, 13);
            this.AccountLevel_Label.TabIndex = 18;
            this.AccountLevel_Label.Text = "Account Level:";
            // 
            // ChampID_TextBox
            // 
            this.ChampID_TextBox.Location = new System.Drawing.Point(245, 137);
            this.ChampID_TextBox.Name = "ChampID_TextBox";
            this.ChampID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ChampID_TextBox.TabIndex = 19;
            this.ChampID_TextBox.TextChanged += new System.EventHandler(this.ChampID_TextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.ChampID_TextBox);
            this.Controls.Add(this.AccountLevel_Label);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.WinnerLabel);
            this.Controls.Add(this.Summoner2AL_TextBox);
            this.Controls.Add(this.Summoner1AL_TextBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Summoner2MP_Textbox);
            this.Controls.Add(this.Summoner1MP_Textbox);
            this.Controls.Add(this.MasteryPointsLabel);
            this.Controls.Add(this.ChampionLabel);
            this.Controls.Add(this.Summoner2Textbox);
            this.Controls.Add(this.Summoner2Label);
            this.Controls.Add(this.APITextBox);
            this.Controls.Add(this.APILable);
            this.Controls.Add(this.Summoner1Label);
            this.Controls.Add(this.Summoner1Textbox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "1V1 ME, BRO - an amazing application developed by the one and only Carlton Ragsda" +
    "le the absolute genious programmer brought to you by the University of Cent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Summoner1Textbox;
        private System.Windows.Forms.Label Summoner1Label;
        private System.Windows.Forms.Label APILable;
        private System.Windows.Forms.TextBox APITextBox;
        private System.Windows.Forms.Label Summoner2Label;
        private System.Windows.Forms.TextBox Summoner2Textbox;
        private System.Windows.Forms.Label ChampionLabel;
        private System.Windows.Forms.Label MasteryPointsLabel;
        private System.Windows.Forms.TextBox Summoner1MP_Textbox;
        private System.Windows.Forms.TextBox Summoner2MP_Textbox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox Summoner2AL_TextBox;
        private System.Windows.Forms.TextBox Summoner1AL_TextBox;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label AccountLevel_Label;
        private System.Windows.Forms.TextBox ChampID_TextBox;
    }
}

