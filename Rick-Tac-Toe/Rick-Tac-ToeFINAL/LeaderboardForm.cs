using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSC240_ProjectTicTacToe_LDM
{
    public partial class LeaderboardForm : Form
    {
        public LeaderboardForm()
        {
            InitializeComponent();
        }

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            // Style the DataGridView
            dgvLeaderboard.EnableHeadersVisualStyles = false;
            dgvLeaderboard.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            dgvLeaderboard.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLeaderboard.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvLeaderboard.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 60);
            dgvLeaderboard.DefaultCellStyle.ForeColor = Color.White;
            dgvLeaderboard.DefaultCellStyle.SelectionBackColor = Color.DarkGreen;
            dgvLeaderboard.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            LoadLeaderboard();
        }

        private void LoadLeaderboard()
        {
            dgvLeaderboard.Rows.Clear();

            var leaderboard = GameData.GetLeaderboard();
            int rank = 1;

            foreach (var player in leaderboard)
            {
                // Use rank number for all positions
                string rankDisplay = rank.ToString();

                dgvLeaderboard.Rows.Add(rankDisplay, player.Name, player.Wins, player.Losses);
                rank++;
            }

            if (leaderboard.Count == 0)
            {
                dgvLeaderboard.Rows.Add("-", "No players yet", "-", "-");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
