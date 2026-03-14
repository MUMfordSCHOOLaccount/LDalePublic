namespace CSC240_ProjectTicTacToe_LDM
{
    partial class StartScreen
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
            this.picTitleImage = new System.Windows.Forms.PictureBox();
            this.pnlPlayerSetup = new System.Windows.Forms.Panel();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpGameMode = new System.Windows.Forms.GroupBox();
            this.rdo2Player = new System.Windows.Forms.RadioButton();
            this.rdo1Player = new System.Windows.Forms.RadioButton();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnViewLeaderboard = new System.Windows.Forms.Button();
            this.lblDiceResult = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.pnlLeaderboard = new System.Windows.Forms.Panel();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLeaderboardTitle = new System.Windows.Forms.Label();
            this.btnCloseLeaderboard = new System.Windows.Forms.Button();
            this.titleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).BeginInit();
            this.pnlPlayerSetup.SuspendLayout();
            this.grpGameMode.SuspendLayout();
            this.pnlLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitleImage
            // 
            this.picTitleImage.BackColor = System.Drawing.Color.Black;
            this.picTitleImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTitleImage.Location = new System.Drawing.Point(0, 0);
            this.picTitleImage.Name = "picTitleImage";
            this.picTitleImage.Size = new System.Drawing.Size(800, 600);
            this.picTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitleImage.TabIndex = 0;
            this.picTitleImage.TabStop = false;
            // 
            // pnlPlayerSetup
            // 
            this.pnlPlayerSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.pnlPlayerSetup.Controls.Add(this.btnStartGame);
            this.pnlPlayerSetup.Controls.Add(this.lblDiceResult);
            this.pnlPlayerSetup.Controls.Add(this.btnViewLeaderboard);
            this.pnlPlayerSetup.Controls.Add(this.btnRollDice);
            this.pnlPlayerSetup.Controls.Add(this.txtPlayer2Name);
            this.pnlPlayerSetup.Controls.Add(this.lblPlayer2Name);
            this.pnlPlayerSetup.Controls.Add(this.txtPlayer1Name);
            this.pnlPlayerSetup.Controls.Add(this.lblPlayer1Name);
            this.pnlPlayerSetup.Controls.Add(this.grpGameMode);
            this.pnlPlayerSetup.Controls.Add(this.lblTitle);
            this.pnlPlayerSetup.Controls.Add(this.lblInstructions);
            this.pnlPlayerSetup.Controls.Add(this.pnlLeaderboard);
            this.pnlPlayerSetup.Location = new System.Drawing.Point(0, 0);
            this.pnlPlayerSetup.Name = "pnlPlayerSetup";
            this.pnlPlayerSetup.Size = new System.Drawing.Size(800, 600);
            this.pnlPlayerSetup.TabIndex = 1;
            this.pnlPlayerSetup.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(50, 450);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(700, 60);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "HOW TO PLAY:\r\nTake turns placing your piece on the board. Get 3 in a row (horizontal, vertical, or diagonal) to win!\r\nRoll the dice to see who goes first!";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(0, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(800, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "RICK-TAC-TOE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpGameMode
            // 
            this.grpGameMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.grpGameMode.Controls.Add(this.rdo2Player);
            this.grpGameMode.Controls.Add(this.rdo1Player);
            this.grpGameMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGameMode.ForeColor = System.Drawing.Color.Black;
            this.grpGameMode.Location = new System.Drawing.Point(275, 120);
            this.grpGameMode.Name = "grpGameMode";
            this.grpGameMode.Size = new System.Drawing.Size(250, 80);
            this.grpGameMode.TabIndex = 2;
            this.grpGameMode.TabStop = false;
            this.grpGameMode.Text = "Game Mode";
            // 
            // rdo2Player
            // 
            this.rdo2Player.AutoSize = true;
            this.rdo2Player.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo2Player.ForeColor = System.Drawing.Color.Black;
            this.rdo2Player.Location = new System.Drawing.Point(130, 35);
            this.rdo2Player.Name = "rdo2Player";
            this.rdo2Player.Size = new System.Drawing.Size(85, 24);
            this.rdo2Player.TabIndex = 1;
            this.rdo2Player.Text = "2 Players";
            this.rdo2Player.UseVisualStyleBackColor = true;
            this.rdo2Player.CheckedChanged += new System.EventHandler(this.rdo2Player_CheckedChanged);
            // 
            // rdo1Player
            // 
            this.rdo1Player.AutoSize = true;
            this.rdo1Player.Checked = true;
            this.rdo1Player.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo1Player.ForeColor = System.Drawing.Color.Black;
            this.rdo1Player.Location = new System.Drawing.Point(20, 35);
            this.rdo1Player.Name = "rdo1Player";
            this.rdo1Player.Size = new System.Drawing.Size(73, 24);
            this.rdo1Player.TabIndex = 0;
            this.rdo1Player.TabStop = true;
            this.rdo1Player.Text = "vs CPU";
            this.rdo1Player.UseVisualStyleBackColor = true;
            this.rdo1Player.CheckedChanged += new System.EventHandler(this.rdo1Player_CheckedChanged);
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lblPlayer1Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer1Name.Location = new System.Drawing.Point(150, 220);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(150, 25);
            this.lblPlayer1Name.TabIndex = 3;
            this.lblPlayer1Name.Text = "Player 1 Name:";
            this.lblPlayer1Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.Location = new System.Drawing.Point(310, 217);
            this.txtPlayer1Name.MaxLength = 20;
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(200, 29);
            this.txtPlayer1Name.TabIndex = 4;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lblPlayer2Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer2Name.Location = new System.Drawing.Point(150, 260);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(150, 25);
            this.lblPlayer2Name.TabIndex = 5;
            this.lblPlayer2Name.Text = "Player 2 Name:";
            this.lblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlayer2Name.Visible = false;
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2Name.Location = new System.Drawing.Point(310, 257);
            this.txtPlayer2Name.MaxLength = 20;
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(200, 29);
            this.txtPlayer2Name.TabIndex = 6;
            this.txtPlayer2Name.Visible = false;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.Color.Green;
            this.btnRollDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollDice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.ForeColor = System.Drawing.Color.White;
            this.btnRollDice.Location = new System.Drawing.Point(275, 290);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(250, 50);
            this.btnRollDice.TabIndex = 7;
            this.btnRollDice.Text = "Roll Dice to Start";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnViewLeaderboard
            // 
            this.btnViewLeaderboard.BackColor = System.Drawing.Color.DarkBlue;
            this.btnViewLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLeaderboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnViewLeaderboard.Location = new System.Drawing.Point(300, 530);
            this.btnViewLeaderboard.Name = "btnViewLeaderboard";
            this.btnViewLeaderboard.Size = new System.Drawing.Size(200, 40);
            this.btnViewLeaderboard.TabIndex = 8;
            this.btnViewLeaderboard.Text = "View Leaderboard";
            this.btnViewLeaderboard.UseVisualStyleBackColor = false;
            this.btnViewLeaderboard.Click += new System.EventHandler(this.btnViewLeaderboard_Click);
            // 
            // lblDiceResult
            // 
            this.lblDiceResult.BackColor = System.Drawing.Color.Transparent;
            this.lblDiceResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceResult.ForeColor = System.Drawing.Color.Yellow;
            this.lblDiceResult.Location = new System.Drawing.Point(100, 350);
            this.lblDiceResult.Name = "lblDiceResult";
            this.lblDiceResult.Size = new System.Drawing.Size(600, 30);
            this.lblDiceResult.TabIndex = 9;
            this.lblDiceResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStartGame.Enabled = false;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.FlatAppearance.BorderSize = 2;
            this.btnStartGame.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnStartGame.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.White;
            this.btnStartGame.Location = new System.Drawing.Point(300, 390);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(200, 50);
            this.btnStartGame.TabIndex = 10;
            this.btnStartGame.Text = "";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // pnlLeaderboard
            // 
            this.pnlLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnlLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeaderboard.Controls.Add(this.btnCloseLeaderboard);
            this.pnlLeaderboard.Controls.Add(this.dgvLeaderboard);
            this.pnlLeaderboard.Controls.Add(this.lblLeaderboardTitle);
            this.pnlLeaderboard.Location = new System.Drawing.Point(500, 80);
            this.pnlLeaderboard.Name = "pnlLeaderboard";
            this.pnlLeaderboard.Size = new System.Drawing.Size(280, 430);
            this.pnlLeaderboard.TabIndex = 11;
            this.pnlLeaderboard.Visible = false;
            // 
            // lblLeaderboardTitle
            // 
            this.lblLeaderboardTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderboardTitle.ForeColor = System.Drawing.Color.Gold;
            this.lblLeaderboardTitle.Location = new System.Drawing.Point(0, 10);
            this.lblLeaderboardTitle.Name = "lblLeaderboardTitle";
            this.lblLeaderboardTitle.Size = new System.Drawing.Size(278, 35);
            this.lblLeaderboardTitle.TabIndex = 0;
            this.lblLeaderboardTitle.Text = "LEADERBOARD";
            this.lblLeaderboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.AllowUserToDeleteRows = false;
            this.dgvLeaderboard.AllowUserToResizeRows = false;
            this.dgvLeaderboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRank,
            this.colName,
            this.colWins,
            this.colLosses});
            this.dgvLeaderboard.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvLeaderboard.Location = new System.Drawing.Point(10, 55);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersVisible = false;
            this.dgvLeaderboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaderboard.Size = new System.Drawing.Size(258, 320);
            this.dgvLeaderboard.TabIndex = 1;
            // 
            // colRank
            // 
            this.colRank.HeaderText = "Rank";
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.Width = 45;
            // 
            // colName
            // 
            this.colName.HeaderText = "Player";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 110;
            // 
            // colWins
            // 
            this.colWins.HeaderText = "W";
            this.colWins.Name = "colWins";
            this.colWins.ReadOnly = true;
            this.colWins.Width = 45;
            // 
            // colLosses
            // 
            this.colLosses.HeaderText = "L";
            this.colLosses.Name = "colLosses";
            this.colLosses.ReadOnly = true;
            this.colLosses.Width = 45;
            // 
            // btnCloseLeaderboard
            // 
            this.btnCloseLeaderboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCloseLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLeaderboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnCloseLeaderboard.Location = new System.Drawing.Point(80, 385);
            this.btnCloseLeaderboard.Name = "btnCloseLeaderboard";
            this.btnCloseLeaderboard.Size = new System.Drawing.Size(120, 30);
            this.btnCloseLeaderboard.TabIndex = 2;
            this.btnCloseLeaderboard.Text = "Close";
            this.btnCloseLeaderboard.UseVisualStyleBackColor = false;
            this.btnCloseLeaderboard.Click += new System.EventHandler(this.btnCloseLeaderboard_Click);
            // 
            // titleTimer
            // 
            this.titleTimer.Interval = 20000;
            this.titleTimer.Tick += new System.EventHandler(this.titleTimer_Tick);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlPlayerSetup);
            this.Controls.Add(this.picTitleImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rick-Tac-Toe - Welcome";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).EndInit();
            this.pnlPlayerSetup.ResumeLayout(false);
            this.pnlPlayerSetup.PerformLayout();
            this.grpGameMode.ResumeLayout(false);
            this.grpGameMode.PerformLayout();
            this.pnlLeaderboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTitleImage;
        private System.Windows.Forms.Panel pnlPlayerSetup;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpGameMode;
        private System.Windows.Forms.RadioButton rdo2Player;
        private System.Windows.Forms.RadioButton rdo1Player;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnViewLeaderboard;
        private System.Windows.Forms.Label lblDiceResult;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel pnlLeaderboard;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLosses;
        private System.Windows.Forms.Label lblLeaderboardTitle;
        private System.Windows.Forms.Button btnCloseLeaderboard;
        private System.Windows.Forms.Timer titleTimer;
    }
}
