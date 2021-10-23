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
    public partial class Players : Form
    {
        private readonly WAChampionsContext db;

        public Players(WAChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            Relist();
        }

        private void Relist()
        {
            dgvPlayer.Rows.Clear();

            foreach (var item in db.Players)
            {
                dgvPlayer.Rows.Add(item.PlayerName);
            }
        }

        private void cboPlayerTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPlayerTeams.Items.Clear();

            foreach (var item in db.Teams)
            {
                cboPlayerTeams.Items.Add(item.TeamName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
            {
                MessageBox.Show("You must identify the Player Name");
                return;
            }

            string playerName = txtPlayerName.Text.Trim();
            var team = cboPlayerTeams.SelectedIndex + 1;

            db.Players.Add(new Player
            {
                PlayerName = playerName,
                TeamId = team
            });

            db.SaveChanges();
            Relist();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPlayer.SelectedRows[0];
            Player deleted = (Player)row.DataBoundItem;
            db.Players.Remove(deleted);
            db.SaveChanges();
            Relist();
        }

        private void cboTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTeamsFilter.Rows.Clear();

            int id = 0;
            string team = "";

            foreach (var item in db.Teams)
            {
                if (cboTeams.Text == item.TeamName)
                {
                    id = item.Id;
                    team = item.TeamName;
                }
            }

            foreach (var item in db.Players)
            {
                if (id == item.TeamId)
                {
                    dgvTeamsFilter.Rows.Add(item.PlayerName);
                }
            }
        }
    }
}
