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
    public partial class Teams : Form
    {
        private readonly WAChampionsContext db;

        public Teams(WAChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            Relist();
        }

        private void Relist()
        {
            dgvTeams.DataSource = null;
            dgvTeams.DataSource = db.Teams.ToList();
        }

        private void btnTeamAdd_Click(object sender, EventArgs e)
        {
            if (txtTeamName.Text.Trim() == "")
            {
                MessageBox.Show("Please identify a team name");
                return;
            }

            if (db.Teams.Any(x => x.TeamName == txtTeamName.Text.Trim()))
            {
                MessageBox.Show("There is already a Team with this name");
                return;
            }

            db.Teams.Add(new Team
            {
                TeamName = txtTeamName.Text.Trim()
            });

            db.SaveChanges();
            Relist();
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTeams.SelectedRows[0];
            Team deleted = (Team)row.DataBoundItem;

            if (dgvTeams.Rows.Count > 1)
            {
                if (db.Matches.Any(x => x.Team1Id == deleted.Id || db.Matches.Any(y => y.Team2Id == deleted.Id)))
                {
                    MessageBox.Show("This team has a match. You should cancel the match.");
                    return;
                }

                DialogResult dr = MessageBox.Show("Are you sure you want to remove it?", "Delete Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    db.Teams.Remove(deleted);
                    db.SaveChanges();
                    Relist();
                }
            }       
        }

        private void lblColor1_Click(object sender, EventArgs e)
        {

        }
    }
}
