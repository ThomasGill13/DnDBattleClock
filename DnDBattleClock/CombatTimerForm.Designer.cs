namespace DnDBattleClock
{
    partial class CombatTimerForm
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
            this.components = new System.ComponentModel.Container();
            this.CombatSecondsTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.CurrentInitiativeLabel = new System.Windows.Forms.Label();
            this.TimeRemainingLabel = new System.Windows.Forms.Label();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.RestartTurnButton = new System.Windows.Forms.Button();
            this.EndCombatButton = new System.Windows.Forms.Button();
            this.PauseTurnButton = new System.Windows.Forms.Button();
            this.NextPlayerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CombatSecondsTimer
            // 
            this.CombatSecondsTimer.Interval = 1000;
            this.CombatSecondsTimer.Tick += new System.EventHandler(this.CombatSecondsTimer_Tick);
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(334, 27);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(74, 15);
            this.PlayerNameLabel.TabIndex = 0;
            this.PlayerNameLabel.Text = "Player Name";
            // 
            // CurrentInitiativeLabel
            // 
            this.CurrentInitiativeLabel.AutoSize = true;
            this.CurrentInitiativeLabel.Location = new System.Drawing.Point(325, 66);
            this.CurrentInitiativeLabel.Name = "CurrentInitiativeLabel";
            this.CurrentInitiativeLabel.Size = new System.Drawing.Size(95, 15);
            this.CurrentInitiativeLabel.TabIndex = 1;
            this.CurrentInitiativeLabel.Text = "Current Initiative";
            // 
            // TimeRemainingLabel
            // 
            this.TimeRemainingLabel.AutoSize = true;
            this.TimeRemainingLabel.Location = new System.Drawing.Point(361, 115);
            this.TimeRemainingLabel.Name = "TimeRemainingLabel";
            this.TimeRemainingLabel.Size = new System.Drawing.Size(27, 15);
            this.TimeRemainingLabel.TabIndex = 2;
            this.TimeRemainingLabel.Text = "60 s";
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Location = new System.Drawing.Point(713, 367);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(75, 23);
            this.EndTurnButton.TabIndex = 3;
            this.EndTurnButton.Text = "End Turn";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // RestartTurnButton
            // 
            this.RestartTurnButton.Location = new System.Drawing.Point(334, 367);
            this.RestartTurnButton.Name = "RestartTurnButton";
            this.RestartTurnButton.Size = new System.Drawing.Size(86, 23);
            this.RestartTurnButton.TabIndex = 4;
            this.RestartTurnButton.Text = "Restart Turn";
            this.RestartTurnButton.UseVisualStyleBackColor = true;
            this.RestartTurnButton.Click += new System.EventHandler(this.RestartTurnButton_Click);
            // 
            // EndCombatButton
            // 
            this.EndCombatButton.Location = new System.Drawing.Point(334, 415);
            this.EndCombatButton.Name = "EndCombatButton";
            this.EndCombatButton.Size = new System.Drawing.Size(86, 23);
            this.EndCombatButton.TabIndex = 5;
            this.EndCombatButton.Text = "End Combat";
            this.EndCombatButton.UseVisualStyleBackColor = true;
            this.EndCombatButton.Click += new System.EventHandler(this.EndCombatButton_Click);
            // 
            // PauseTurnButton
            // 
            this.PauseTurnButton.Location = new System.Drawing.Point(12, 367);
            this.PauseTurnButton.Name = "PauseTurnButton";
            this.PauseTurnButton.Size = new System.Drawing.Size(86, 23);
            this.PauseTurnButton.TabIndex = 6;
            this.PauseTurnButton.Text = "Pause Turn";
            this.PauseTurnButton.UseVisualStyleBackColor = true;
            this.PauseTurnButton.Click += new System.EventHandler(this.PauseTurnButton_Click);
            // 
            // NextPlayerLabel
            // 
            this.NextPlayerLabel.AutoSize = true;
            this.NextPlayerLabel.Location = new System.Drawing.Point(334, 220);
            this.NextPlayerLabel.Name = "NextPlayerLabel";
            this.NextPlayerLabel.Size = new System.Drawing.Size(73, 15);
            this.NextPlayerLabel.TabIndex = 7;
            this.NextPlayerLabel.Text = "Next Player: ";
            // 
            // CombatTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextPlayerLabel);
            this.Controls.Add(this.PauseTurnButton);
            this.Controls.Add(this.EndCombatButton);
            this.Controls.Add(this.RestartTurnButton);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.TimeRemainingLabel);
            this.Controls.Add(this.CurrentInitiativeLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Name = "CombatTimerForm";
            this.Text = "CombatTimerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer CombatSecondsTimer;
        private Label PlayerNameLabel;
        private Label CurrentInitiativeLabel;
        private Label TimeRemainingLabel;
        private Button EndTurnButton;
        private Button RestartTurnButton;
        private Button EndCombatButton;
        private Button PauseTurnButton;
        private Label NextPlayerLabel;
    }
}