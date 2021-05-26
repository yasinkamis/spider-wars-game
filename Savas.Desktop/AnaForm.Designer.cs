namespace Savas.Desktop
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.spiderPanel = new System.Windows.Forms.Panel();
            this.scoreTable = new System.Windows.Forms.Panel();
            this.endScore = new System.Windows.Forms.Label();
            this.textEnd = new System.Windows.Forms.Label();
            this.savasAlaniPanel = new System.Windows.Forms.Panel();
            this.gameOver = new System.Windows.Forms.Label();
            this.TekrarButton = new System.Windows.Forms.Button();
            this.bilgiPanel.SuspendLayout();
            this.spiderPanel.SuspendLayout();
            this.scoreTable.SuspendLayout();
            this.savasAlaniPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.Black;
            this.bilgiPanel.Controls.Add(this.TekrarButton);
            this.bilgiPanel.Controls.Add(this.scoreLabel);
            this.bilgiPanel.Controls.Add(this.sureLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(1660, 155);
            this.bilgiPanel.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Pixellari", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(1038, 39);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(246, 71);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.Font = new System.Drawing.Font("Pixellari", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.ForeColor = System.Drawing.Color.White;
            this.sureLabel.Location = new System.Drawing.Point(1379, 32);
            this.sureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(268, 84);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.Text = "0:00";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.Font = new System.Drawing.Font("Pixellari", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.ForeColor = System.Drawing.Color.White;
            this.bilgiLabel.Location = new System.Drawing.Point(37, 31);
            this.bilgiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(947, 112);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "Oyunu başlatmak için ENTER, Durdurup başlatmak için P tuşuna basın.\r\nUçaksavarı h" +
    "areket ettirmek için SAĞ/SOL yön tuşlarına basın.\r\nAteş etmek için BOŞLUK tuşuna" +
    " basın.\r\n\r\n";
            // 
            // spiderPanel
            // 
            this.spiderPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.spiderPanel.Controls.Add(this.scoreTable);
            this.spiderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spiderPanel.Location = new System.Drawing.Point(0, 634);
            this.spiderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.spiderPanel.Name = "spiderPanel";
            this.spiderPanel.Size = new System.Drawing.Size(1660, 107);
            this.spiderPanel.TabIndex = 1;
            // 
            // scoreTable
            // 
            this.scoreTable.BackColor = System.Drawing.Color.Maroon;
            this.scoreTable.Controls.Add(this.endScore);
            this.scoreTable.Controls.Add(this.textEnd);
            this.scoreTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreTable.Location = new System.Drawing.Point(0, 0);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.Size = new System.Drawing.Size(1660, 107);
            this.scoreTable.TabIndex = 1;
            this.scoreTable.Visible = false;
            // 
            // endScore
            // 
            this.endScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.endScore.AutoSize = true;
            this.endScore.Font = new System.Drawing.Font("Pixellari", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.endScore.ForeColor = System.Drawing.SystemColors.Control;
            this.endScore.Location = new System.Drawing.Point(871, 26);
            this.endScore.Name = "endScore";
            this.endScore.Size = new System.Drawing.Size(113, 40);
            this.endScore.TabIndex = 3;
            this.endScore.Text = "0000";
            // 
            // textEnd
            // 
            this.textEnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEnd.AutoSize = true;
            this.textEnd.Font = new System.Drawing.Font("Pixellari", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEnd.ForeColor = System.Drawing.SystemColors.Control;
            this.textEnd.Location = new System.Drawing.Point(671, 26);
            this.textEnd.Name = "textEnd";
            this.textEnd.Size = new System.Drawing.Size(173, 40);
            this.textEnd.TabIndex = 2;
            this.textEnd.Text = "SCORE :";
            // 
            // savasAlaniPanel
            // 
            this.savasAlaniPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.savasAlaniPanel.Controls.Add(this.gameOver);
            this.savasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniPanel.Location = new System.Drawing.Point(0, 155);
            this.savasAlaniPanel.Margin = new System.Windows.Forms.Padding(4);
            this.savasAlaniPanel.Name = "savasAlaniPanel";
            this.savasAlaniPanel.Size = new System.Drawing.Size(1660, 479);
            this.savasAlaniPanel.TabIndex = 2;
            // 
            // gameOver
            // 
            this.gameOver.BackColor = System.Drawing.Color.Maroon;
            this.gameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOver.Font = new System.Drawing.Font("Pixellari", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOver.ForeColor = System.Drawing.Color.White;
            this.gameOver.Location = new System.Drawing.Point(0, 0);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(1660, 479);
            this.gameOver.TabIndex = 0;
            this.gameOver.Text = "GAME OVER";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOver.Visible = false;
            // 
            // TekrarButton
            // 
            this.TekrarButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TekrarButton.Font = new System.Drawing.Font("Pixellari", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TekrarButton.Location = new System.Drawing.Point(0, 0);
            this.TekrarButton.Name = "TekrarButton";
            this.TekrarButton.Size = new System.Drawing.Size(1660, 155);
            this.TekrarButton.TabIndex = 3;
            this.TekrarButton.Text = "Ana Menüye Dön";
            this.TekrarButton.UseVisualStyleBackColor = true;
            this.TekrarButton.Visible = false;
            this.TekrarButton.Click += new System.EventHandler(this.TekrarButton_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 741);
            this.Controls.Add(this.savasAlaniPanel);
            this.Controls.Add(this.spiderPanel);
            this.Controls.Add(this.bilgiPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaForm";
            this.Text = "Savaş Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnaForm_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.spiderPanel.ResumeLayout(false);
            this.scoreTable.ResumeLayout(false);
            this.scoreTable.PerformLayout();
            this.savasAlaniPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Panel spiderPanel;
        private System.Windows.Forms.Panel savasAlaniPanel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Panel scoreTable;
        private System.Windows.Forms.Label endScore;
        private System.Windows.Forms.Label textEnd;
        private System.Windows.Forms.Button TekrarButton;
    }
}

