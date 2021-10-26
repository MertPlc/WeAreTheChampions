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
    public partial class New_Match : Form
    {
        private readonly WAChampionsContext db;
        Team Home;
        Team Away;

        public New_Match(WAChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            int score = 0;
            int home = 0;
            int away = 0;

            if (cboHomeTeam.SelectedItem == cboAwayTeams.SelectedItem)
            {
                MessageBox.Show("Two same teams can't match each other");
            }
            else
            {
                foreach (var item in db.Teams)
                {
                    if (cboHomeTeam.Text == item.TeamName)
                    {
                        home = item.Id;
                    }
                    else
                    {
                        away = item.Id;
                    }
                }
                if (nudHomeTeamScore.Value == nudAwayTeamScore.Value)
                {
                    score = 0;
                }
                else if (nudHomeTeamScore.Value > nudAwayTeamScore.Value)
                {
                    score = 1;
                }
                else if (nudHomeTeamScore.Value < nudAwayTeamScore.Value)
                {
                    score = 2;
                }

                Match match = new Match();
                match.Score1 = (int)nudHomeTeamScore.Value;
                match.Score2 = (int)nudAwayTeamScore.Value;
                match.Scores = score;
                match.Team1Id = home;
                match.Team1 = Home;
                match.Team2Id = away;
                match.Team2 = Away;
                match.MatchTime = dtpDate.Value;

                db.Matches.Add(match);
                db.SaveChanges();
                ShowResults();
                Close();
            }
        }

        private void ShowResults()
        {
            
        }

        private void New_Match_Load(object sender, EventArgs e)
        {
            cboHomeTeam.DataSource = db.Teams.ToList();
            cboHomeTeam.SelectedIndex = -1;
        }
    }
}
