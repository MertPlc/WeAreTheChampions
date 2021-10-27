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
    public partial class EditMatch : Form
    {
        private readonly WAChampionsContext db;
        private readonly Match match;

        public EditMatch(WAChampionsContext db, Match match)
        {
            this.db = db;
            this.match = match;
            InitializeComponent();
            GetValues();
        }

        private void GetValues()
        {
            cboHomeTeam.DataSource = db.Teams.ToList();
            cboAwayTeams.DataSource = db.Teams.ToList();

            DateTime dt = (DateTime)match.MatchTime;

            cboHomeTeam.SelectedItem = match.Team1;
            cboAwayTeams.SelectedItem = match.Team2;

            nudHour.Value = (decimal)dt.Hour;
            nudMinute.Value = (decimal)dt.Minute;
            nudMonth.Value = (decimal)dt.Month;
            nudDay.Value = (decimal)dt.Day;
            nudYear.Value = (decimal)dt.Year;

            nudHomeTeamScore.Value = (int)match.Score1;
            nudAwayTeamScore.Value = (int)match.Score2;
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (cboHomeTeam.SelectedItem == cboAwayTeams.SelectedItem)
            {
                MessageBox.Show("Two same teams can't match each other");
                return;
            }

            DateTime date = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value, (int)nudHour.Value, (int)nudMinute.Value, 0);

            if (date < DateTime.Now)
            {
                MessageBox.Show("Invalid date!");
                return;
            }
            match.Team1 = (Team)cboHomeTeam.SelectedItem;
            match.Team2 = (Team)cboAwayTeams.SelectedItem;
            match.Score1 = (int)nudHomeTeamScore.Value;
            match.Score2 = (int)nudAwayTeamScore.Value;
            match.MatchTime = date;
            db.SaveChanges();

            Close();
        }
    }
}
