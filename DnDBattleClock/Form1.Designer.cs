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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitiativeRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(35, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.InitiativeBonus,
            this.InitRoll,
            this.InitScore,
            this.InitiativeRank});
            this.dataGridView1.Location = new System.Drawing.Point(97, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Player Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // InitiativeBonus
            // 
            this.InitiativeBonus.HeaderText = "Initiative Bonus";
            this.InitiativeBonus.Name = "InitiativeBonus";
            // 
            // InitRoll
            // 
            this.InitRoll.HeaderText = "Initiative Roll";
            this.InitRoll.Name = "InitRoll";
            // 
            // InitScore
            // 
            this.InitScore.HeaderText = "Initiative Score";
            this.InitScore.Name = "InitScore";
            this.InitScore.ReadOnly = true;
            // 
            // InitiativeRank
            // 
            this.InitiativeRank.HeaderText = "Initiative Rank";
            this.InitiativeRank.Name = "InitiativeRank";
            this.InitiativeRank.ReadOnly = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Players";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Start Combat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update Initiative";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 508);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save Players";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "D&D Battle Clock";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PlayerName;
        private DataGridViewTextBoxColumn InitBonus;
        private DataGridViewTextBoxColumn InitiativeRoll;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn InitiativeBonus;
        private DataGridViewTextBoxColumn InitRoll;
        private DataGridViewTextBoxColumn InitScore;
        private DataGridViewTextBoxColumn InitiativeRank;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}