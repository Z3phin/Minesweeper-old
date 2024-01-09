
namespace Minesweeper_v._1._2_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WonLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlagLbl = new System.Windows.Forms.Label();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.timeTakenLb = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xValueBox = new System.Windows.Forms.TextBox();
            this.yValueBox = new System.Windows.Forms.TextBox();
            this.BombValueBox = new System.Windows.Forms.TextBox();
            this.LostLb = new System.Windows.Forms.Label();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WonLb
            // 
            this.WonLb.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WonLb.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WonLb.Location = new System.Drawing.Point(442, 44);
            this.WonLb.Name = "WonLb";
            this.WonLb.Size = new System.Drawing.Size(134, 30);
            this.WonLb.TabIndex = 0;
            this.WonLb.Text = "You Won!";
            this.WonLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.FlagLbl);
            this.panel1.Controls.Add(this.PlayBtn);
            this.panel1.Controls.Add(this.timeTakenLb);
            this.panel1.Location = new System.Drawing.Point(2, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 159);
            this.panel1.TabIndex = 1;
            // 
            // FlagLbl
            // 
            this.FlagLbl.BackColor = System.Drawing.SystemColors.Info;
            this.FlagLbl.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlagLbl.Location = new System.Drawing.Point(10, 114);
            this.FlagLbl.Name = "FlagLbl";
            this.FlagLbl.Size = new System.Drawing.Size(65, 37);
            this.FlagLbl.TabIndex = 2;
            this.FlagLbl.Text = "000";
            this.FlagLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayBtn
            // 
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayBtn.Image = global::Minesweeper_v._1._2_.Properties.Resources.MinesweeperResetBtn_Happy;
            this.PlayBtn.Location = new System.Drawing.Point(10, 51);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(63, 60);
            this.PlayBtn.TabIndex = 1;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // timeTakenLb
            // 
            this.timeTakenLb.BackColor = System.Drawing.SystemColors.Info;
            this.timeTakenLb.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeTakenLb.Location = new System.Drawing.Point(11, 11);
            this.timeTakenLb.Name = "timeTakenLb";
            this.timeTakenLb.Size = new System.Drawing.Size(64, 37);
            this.timeTakenLb.TabIndex = 0;
            this.timeTakenLb.Text = "000";
            this.timeTakenLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.xValueBox);
            this.SettingsPanel.Controls.Add(this.yValueBox);
            this.SettingsPanel.Controls.Add(this.BombValueBox);
            this.SettingsPanel.Location = new System.Drawing.Point(93, 9);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(133, 116);
            this.SettingsPanel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Default value is 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bombs:";
            // 
            // xValueBox
            // 
            this.xValueBox.Location = new System.Drawing.Point(79, 67);
            this.xValueBox.Name = "xValueBox";
            this.xValueBox.Size = new System.Drawing.Size(47, 23);
            this.xValueBox.TabIndex = 2;
            this.xValueBox.TextChanged += new System.EventHandler(this.xValueBox_TextChanged);
            // 
            // yValueBox
            // 
            this.yValueBox.Location = new System.Drawing.Point(79, 38);
            this.yValueBox.Name = "yValueBox";
            this.yValueBox.Size = new System.Drawing.Size(47, 23);
            this.yValueBox.TabIndex = 1;
            this.yValueBox.TextChanged += new System.EventHandler(this.yValueBox_TextChanged);
            // 
            // BombValueBox
            // 
            this.BombValueBox.Location = new System.Drawing.Point(79, 9);
            this.BombValueBox.Name = "BombValueBox";
            this.BombValueBox.Size = new System.Drawing.Size(47, 23);
            this.BombValueBox.TabIndex = 0;
            this.BombValueBox.TextChanged += new System.EventHandler(this.BombValueBox_TextChanged);
            // 
            // LostLb
            // 
            this.LostLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LostLb.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LostLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LostLb.Location = new System.Drawing.Point(442, 9);
            this.LostLb.Name = "LostLb";
            this.LostLb.Size = new System.Drawing.Size(134, 31);
            this.LostLb.TabIndex = 3;
            this.LostLb.Text = "You Lost!";
            this.LostLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(2, 9);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(85, 23);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.TabStop = false;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.LostLb);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WonLb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WonLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeTakenLb;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label FlagLbl;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Label LostLb;
        private System.Windows.Forms.TextBox xValueBox;
        private System.Windows.Forms.TextBox yValueBox;
        private System.Windows.Forms.TextBox BombValueBox;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

