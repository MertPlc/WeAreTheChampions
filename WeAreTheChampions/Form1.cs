using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Data;

namespace WeAreTheChampions
{
    public partial class Form1 : Form
    {
        WAChampionsContext db = new WAChampionsContext();
        public Form1()
        {
            InitializeComponent();
            dgvScore.AutoGenerateColumns = false;
            ListMatches();
            ShowResults();
        }

        private void ShowResults()
        {
            var matches = db.Matches.ToList();
            foreach (Match item in matches)
            {
                if (item.Score1 > item.Score2)
                {
                    item.ResultId = Data.Result.Team1Win;
                }
                else if (item.Score1 < item.Score2)
                {
                    item.ResultId = Data.Result.Team2Win;
                }
                else if (item.Score1 == item.Score2)
                {
                    item.ResultId = Data.Result.Draw;
                }
                else
                {
                    item.ResultId = null;
                }
                db.SaveChanges();
            }
        }

        private void ListMatches()
        {
            var matches = db.Matches.ToList().Select(
                x => new
                {
                    MatchId = x.Id,
                    Team1 = x.Team1,
                    Team2 = x.Team2,
                    Date = x.MatchTime?.ToShortDateString(),
                    Time = x.MatchTime?.ToShortTimeString(),
                    Score = x.Score1 + " - " + x.Score2,
                    MatchResult = x.ResultId
                });
            dgvScore.DataSource = matches.ToList();
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            new New_Match(db).ShowDialog();
            ListMatches();
        }

        private void tsmiTeams_Click(object sender, EventArgs e)
        {
            new Teams(db).ShowDialog();
        }

        private void tsmiColors_Click(object sender, EventArgs e)
        {
            new Colors(db).ShowDialog();
        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            new Players(db).ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvScore.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove it?", "Delete Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    int matchId = (int)dgvScore.SelectedRows[0].Cells[0].Value;
                    Match match = db.Matches.ToList().FirstOrDefault(x => x.Id == matchId);

                    db.Matches.Remove(match);
                    db.SaveChanges();
                }
            }

            ListMatches();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvScore.SelectedRows.Count == 0)
            {
                return;
            }

            int matchId2 = (int)dgvScore.SelectedRows[0].Cells[0].Value;
            Match match2 = db.Matches.ToList().FirstOrDefault(x => x.Id == matchId2);

            new EditMatch(db, match2).ShowDialog();
            ListMatches();
        }
    }
}
