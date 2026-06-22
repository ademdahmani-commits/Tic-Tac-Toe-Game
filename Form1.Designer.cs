namespace Tic_Tac_Toe_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnBlock9 = new System.Windows.Forms.Button();
            this.btnBlock8 = new System.Windows.Forms.Button();
            this.btnBlock7 = new System.Windows.Forms.Button();
            this.btnBlock6 = new System.Windows.Forms.Button();
            this.btnBlock5 = new System.Windows.Forms.Button();
            this.btnBlock4 = new System.Windows.Forms.Button();
            this.btnBlock3 = new System.Windows.Forms.Button();
            this.btnBlock2 = new System.Windows.Forms.Button();
            this.btnBlock1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(698, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(80, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn :";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer.Location = new System.Drawing.Point(80, 381);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(256, 69);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "Player 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(80, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 69);
            this.label4.TabIndex = 3;
            this.label4.Text = "Winner :";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(80, 581);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(346, 69);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(92, 671);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(269, 62);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnBlock9
            // 
            this.btnBlock9.BackColor = System.Drawing.Color.Black;
            this.btnBlock9.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock9.Location = new System.Drawing.Point(1158, 581);
            this.btnBlock9.Name = "btnBlock9";
            this.btnBlock9.Size = new System.Drawing.Size(190, 168);
            this.btnBlock9.TabIndex = 14;
            this.btnBlock9.UseVisualStyleBackColor = false;
            this.btnBlock9.Click += new System.EventHandler(this.btnBlock9_Click);
            // 
            // btnBlock8
            // 
            this.btnBlock8.BackColor = System.Drawing.Color.Black;
            this.btnBlock8.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock8.Location = new System.Drawing.Point(875, 581);
            this.btnBlock8.Name = "btnBlock8";
            this.btnBlock8.Size = new System.Drawing.Size(190, 168);
            this.btnBlock8.TabIndex = 13;
            this.btnBlock8.UseVisualStyleBackColor = false;
            this.btnBlock8.Click += new System.EventHandler(this.btnBlock8_Click);
            // 
            // btnBlock7
            // 
            this.btnBlock7.BackColor = System.Drawing.Color.Black;
            this.btnBlock7.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock7.Location = new System.Drawing.Point(582, 581);
            this.btnBlock7.Name = "btnBlock7";
            this.btnBlock7.Size = new System.Drawing.Size(190, 168);
            this.btnBlock7.TabIndex = 12;
            this.btnBlock7.UseVisualStyleBackColor = false;
            this.btnBlock7.Click += new System.EventHandler(this.btnBlock7_Click);
            // 
            // btnBlock6
            // 
            this.btnBlock6.BackColor = System.Drawing.Color.Black;
            this.btnBlock6.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock6.Location = new System.Drawing.Point(1158, 381);
            this.btnBlock6.Name = "btnBlock6";
            this.btnBlock6.Size = new System.Drawing.Size(190, 168);
            this.btnBlock6.TabIndex = 11;
            this.btnBlock6.UseVisualStyleBackColor = false;
            this.btnBlock6.Click += new System.EventHandler(this.btnBlock6_Click);
            // 
            // btnBlock5
            // 
            this.btnBlock5.BackColor = System.Drawing.Color.Black;
            this.btnBlock5.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock5.Location = new System.Drawing.Point(875, 381);
            this.btnBlock5.Name = "btnBlock5";
            this.btnBlock5.Size = new System.Drawing.Size(190, 168);
            this.btnBlock5.TabIndex = 10;
            this.btnBlock5.UseVisualStyleBackColor = false;
            this.btnBlock5.Click += new System.EventHandler(this.btnBlock5_Click);
            // 
            // btnBlock4
            // 
            this.btnBlock4.BackColor = System.Drawing.Color.Black;
            this.btnBlock4.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock4.Location = new System.Drawing.Point(582, 381);
            this.btnBlock4.Name = "btnBlock4";
            this.btnBlock4.Size = new System.Drawing.Size(190, 168);
            this.btnBlock4.TabIndex = 9;
            this.btnBlock4.UseVisualStyleBackColor = false;
            this.btnBlock4.Click += new System.EventHandler(this.btnBlock4_Click);
            // 
            // btnBlock3
            // 
            this.btnBlock3.BackColor = System.Drawing.Color.Black;
            this.btnBlock3.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock3.Location = new System.Drawing.Point(1158, 178);
            this.btnBlock3.Name = "btnBlock3";
            this.btnBlock3.Size = new System.Drawing.Size(190, 168);
            this.btnBlock3.TabIndex = 8;
            this.btnBlock3.UseVisualStyleBackColor = false;
            this.btnBlock3.Click += new System.EventHandler(this.btnBlock3_Click);
            // 
            // btnBlock2
            // 
            this.btnBlock2.BackColor = System.Drawing.Color.Black;
            this.btnBlock2.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock2.Location = new System.Drawing.Point(875, 178);
            this.btnBlock2.Name = "btnBlock2";
            this.btnBlock2.Size = new System.Drawing.Size(190, 168);
            this.btnBlock2.TabIndex = 7;
            this.btnBlock2.UseVisualStyleBackColor = false;
            this.btnBlock2.Click += new System.EventHandler(this.btnBlock2_Click);
            // 
            // btnBlock1
            // 
            this.btnBlock1.BackColor = System.Drawing.Color.Black;
            this.btnBlock1.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.btnBlock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlock1.ForeColor = System.Drawing.Color.Beige;
            this.btnBlock1.Location = new System.Drawing.Point(582, 178);
            this.btnBlock1.Name = "btnBlock1";
            this.btnBlock1.Size = new System.Drawing.Size(190, 168);
            this.btnBlock1.TabIndex = 6;
            this.btnBlock1.UseVisualStyleBackColor = false;
            this.btnBlock1.Click += new System.EventHandler(this.btnBlock1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tic_Tac_Toe_Game.Properties.Resources.logo_xo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(68, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 221);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(1320, 800);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Made By Adem Dahmani";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1509, 825);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBlock1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBlock9);
            this.Controls.Add(this.btnBlock8);
            this.Controls.Add(this.btnBlock7);
            this.Controls.Add(this.btnBlock6);
            this.Controls.Add(this.btnBlock5);
            this.Controls.Add(this.btnBlock4);
            this.Controls.Add(this.btnBlock3);
            this.Controls.Add(this.btnBlock2);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnBlock1;
        private System.Windows.Forms.Button btnBlock2;
        private System.Windows.Forms.Button btnBlock3;
        private System.Windows.Forms.Button btnBlock6;
        private System.Windows.Forms.Button btnBlock5;
        private System.Windows.Forms.Button btnBlock4;
        private System.Windows.Forms.Button btnBlock9;
        private System.Windows.Forms.Button btnBlock8;
        private System.Windows.Forms.Button btnBlock7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

