namespace DnDBattleClock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerDataGridView = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadPlayersButton = new System.Windows.Forms.Button();
            this.StartCombatButton = new System.Windows.Forms.Button();
            this.UpdateInitiativeButton = new System.Windows.Forms.Button();
            this.SavePlayersButton = new System.Windows.Forms.Button();
            this.SavePlayersDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TurnTimeNumUD = new System.Windows.Forms.NumericUpDown();
            this.TurnTimeLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeBonusRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeSecretScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnTimeNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlayerDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(35, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PlayerDataGridView
            // 
            this.PlayerDataGridView.AllowUserToAddRows = false;
            this.PlayerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.InitiativeBonus,
            this.InitRoll,
            this.InitScore,
            this.InitiativeRank,
            this.InitiativeBonusRank,
            this.InitiativeSecretScore});
            this.PlayerDataGridView.Location = new System.Drawing.Point(89, 22);
            this.PlayerDataGridView.Name = "PlayerDataGridView";
            this.PlayerDataGridView.RowTemplate.Height = 25;
            this.PlayerDataGridView.Size = new System.Drawing.Size(546, 412);
            this.PlayerDataGridView.TabIndex = 0;
            this.PlayerDataGridView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.PlayerDataGridView_SortCompare);
            this.PlayerDataGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayerDataGridView_KeyPress);
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.Name = "PlayerName";
            // 
            // InitBonus
            // 
            this.InitBonus.HeaderText = "Initiative Bonus";
            this.InitBonus.Name = "InitBonus";
            // 
            // InitiativeRoll
            // 
            this.InitiativeRoll.HeaderText = "Initiative Roll";
            this.InitiativeRoll.Name = "InitiativeRoll";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Player Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // LoadPlayersButton
            // 
            this.LoadPlayersButton.Location = new System.Drawing.Point(35, 508);
            this.LoadPlayersButton.Name = "LoadPlayersButton";
            this.LoadPlayersButton.Size = new System.Drawing.Size(145, 42);
            this.LoadPlayersButton.TabIndex = 1;
            this.LoadPlayersButton.Text = "Load Players";
            this.LoadPlayersButton.UseVisualStyleBackColor = true;
            this.LoadPlayersButton.Click += new System.EventHandler(this.LoadPlayersButton_Click);
            // 
            // StartCombatButton
            // 
            this.StartCombatButton.Location = new System.Drawing.Point(596, 508);
            this.StartCombatButton.Name = "StartCombatButton";
            this.StartCombatButton.Size = new System.Drawing.Size(145, 42);
            this.StartCombatButton.TabIndex = 2;
            this.StartCombatButton.Text = "Start Combat";
            this.StartCombatButton.UseVisualStyleBackColor = true;
            this.StartCombatButton.Click += new System.EventHandler(this.StartCombatButton_Click);
            // 
            // UpdateInitiativeButton
            // 
            this.UpdateInitiativeButton.Location = new System.Drawing.Point(412, 508);
            this.UpdateInitiativeButton.Name = "UpdateInitiativeButton";
            this.UpdateInitiativeButton.Size = new System.Drawing.Size(145, 42);
            this.UpdateInitiativeButton.TabIndex = 3;
            this.UpdateInitiativeButton.Text = "Update Initiative";
            this.UpdateInitiativeButton.UseVisualStyleBackColor = true;
            this.UpdateInitiativeButton.Click += new System.EventHandler(this.UpdateInitiativeButton_Click);
            // 
            // SavePlayersButton
            // 
            this.SavePlayersButton.Location = new System.Drawing.Point(224, 508);
            this.SavePlayersButton.Name = "SavePlayersButton";
            this.SavePlayersButton.Size = new System.Drawing.Size(145, 42);
            this.SavePlayersButton.TabIndex = 4;
            this.SavePlayersButton.Text = "Save Players";
            this.SavePlayersButton.UseVisualStyleBackColor = true;
            this.SavePlayersButton.Click += new System.EventHandler(this.SavePlayersButton_Click);
            // 
            // TurnTimeNumUD
            // 
            this.TurnTimeNumUD.Location = new System.Drawing.Point(344, 575);
            this.TurnTimeNumUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TurnTimeNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TurnTimeNumUD.Name = "TurnTimeNumUD";
            this.TurnTimeNumUD.Size = new System.Drawing.Size(62, 23);
            this.TurnTimeNumUD.TabIndex = 5;
            this.TurnTimeNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TurnTimeLabel
            // 
            this.TurnTimeLabel.AutoSize = true;
            this.TurnTimeLabel.Location = new System.Drawing.Point(262, 577);
            this.TurnTimeLabel.Name = "TurnTimeLabel";
            this.TurnTimeLabel.Size = new System.Drawing.Size(79, 15);
            this.TurnTimeLabel.TabIndex = 6;
            this.TurnTimeLabel.Text = "Turn Time (s):";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Player Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // InitiativeBonus
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.InitiativeBonus.DefaultCellStyle = dataGridViewCellStyle2;
            this.InitiativeBonus.HeaderText = "Initiative Bonus";
            this.InitiativeBonus.Name = "InitiativeBonus";
            // 
            // InitRoll
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.InitRoll.DefaultCellStyle = dataGridViewCellStyle3;
            this.InitRoll.HeaderText = "Initiative Roll";
            this.InitRoll.Name = "InitRoll";
            // 
            // InitScore
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.InitScore.DefaultCellStyle = dataGridViewCellStyle4;
            this.InitScore.HeaderText = "Initiative Score";
            this.InitScore.Name = "InitScore";
            this.InitScore.ReadOnly = true;
            // 
            // InitiativeRank
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.InitiativeRank.DefaultCellStyle = dataGridViewCellStyle5;
            this.InitiativeRank.HeaderText = "Initiative Rank";
            this.InitiativeRank.Name = "InitiativeRank";
            this.InitiativeRank.ReadOnly = true;
            // 
            // InitiativeBonusRank
            // 
            this.InitiativeBonusRank.HeaderText = "Initiative Bonus Rank";
            this.InitiativeBonusRank.Name = "InitiativeBonusRank";
            this.InitiativeBonusRank.ReadOnly = true;
            this.InitiativeBonusRank.Visible = false;
            // 
            // InitiativeSecretScore
            // 
            this.InitiativeSecretScore.HeaderText = "Initiative Secret Score";
            this.InitiativeSecretScore.Name = "InitiativeSecretScore";
            this.InitiativeSecretScore.ReadOnly = true;
            this.InitiativeSecretScore.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.TurnTimeLabel);
            this.Controls.Add(this.TurnTimeNumUD);
            this.Controls.Add(this.SavePlayersButton);
            this.Controls.Add(this.UpdateInitiativeButton);
            this.Controls.Add(this.StartCombatButton);
            this.Controls.Add(this.LoadPlayersButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "D&D Battle Clock";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnTimeNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView PlayerDataGridView;
        private DataGridViewTextBoxColumn PlayerName;
        private DataGridViewTextBoxColumn InitBonus;
        private DataGridViewTextBoxColumn InitiativeRoll;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button LoadPlayersButton;
        private Button StartCombatButton;
        private Button UpdateInitiativeButton;
        private Button SavePlayersButton;
        private SaveFileDialog SavePlayersDialog;
        private OpenFileDialog LoadFileDialog;
        private NumericUpDown TurnTimeNumUD;
        private Label TurnTimeLabel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn InitiativeBonus;
        private DataGridViewTextBoxColumn InitRoll;
        private DataGridViewTextBoxColumn InitScore;
        private DataGridViewTextBoxColumn InitiativeRank;
        private DataGridViewTextBoxColumn InitiativeBonusRank;
        private DataGridViewTextBoxColumn InitiativeSecretScore;
    }
}