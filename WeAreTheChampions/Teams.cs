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
        private void Teams_Load(object sender, EventArgs e)
        {
            dgvColors.Rows.Clear();

            foreach (var item in db.Colors)
            {
                dgvColors.Rows.Add(item.Id, item.ColorName);
            }
        }

        private void Relist()
        {
            dgvTeams.Rows.Clear();

            foreach (var item in db.Teams)
            {
                dgvTeams.Rows.Add(item.Id, item.TeamName);
            }
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
                TeamName = txtTeamName.Text.Trim(),
            });

            db.SaveChanges();
            Relist();
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTeams.SelectedRows[0];
            Team deleted = (Team)row.DataBoundItem;

            if (dgvTeams.Rows.Count > -1)
            {

                //if (db.Matches.Any(x => x.Team1Id == deleted.Id || db.Matches.Any(y => y.Team2Id == deleted.Id)))
                //{
                //    MessageBox.Show("This team has a match. You should cancel the match.");
                //    return;
                //}

                DialogResult dr = MessageBox.Show("Are you sure you want to remove it?", "Delete Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    db.Teams.Remove(deleted);
                    db.SaveChanges();
                    Relist();
                }
            }       
        }

        private void lblColor1_MouseClick(object sender, MouseEventArgs e)
        {
            int id = (int)dgvColors.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (id == item.Id)
                {
                    lblColor1.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }
        }

        private void lblColor2_MouseClick(object sender, MouseEventArgs e)
        {
            int id = (int)dgvColors.SelectedRows[0].Cells[0].Value;

            foreach (var item in db.Colors)
            {
                if (id == item.Id)
                {
                    lblColor2.BackColor = System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue);
                }
            }
        }
    }
}
