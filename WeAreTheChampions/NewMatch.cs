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

        public New_Match(WAChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (cboHomeTeam.SelectedItem == cboAwayTeams.SelectedItem)
            {
                MessageBox.Show("Two same teams can't match each other");
            }
            else
            {
                DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);

                if (date < DateTime.Now)
                {
                    MessageBox.Show("Invalid date!");
                    return;
                }
                db.Matches.Add(new Match()
                {
                    MatchTime = date,
                    Score1 = (int)nudHomeTeamScore.Value,
                    Score2 = (int)nudAwayTeamScore.Value,
                    Team1 = (Team)cboHomeTeam.SelectedItem,
                    Team2 = (Team)cboAwayTeams.SelectedItem
                });
                db.SaveChanges();
                Close();
            }
        }

        private void New_Match_Load(object sender, EventArgs e)
        {
            cboHomeTeam.DataSource = db.Teams.ToList();
            cboAwayTeams.DataSource = db.Teams.ToList();
            cboHomeTeam.SelectedIndex = -1;
            cboAwayTeams.SelectedIndex = -1;
        }
    }
}
