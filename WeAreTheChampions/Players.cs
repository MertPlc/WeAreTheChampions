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
            dgvPlayers.AutoGenerateColumns = false;
            cboTeams.DataSource = db.Teams.ToList();
            cboTeams.SelectedIndex = -1;
            Relist();
        }

        private void Relist()
        {
            dgvPlayers.DataSource = null;
            dgvPlayers.DataSource = db.Players.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player player;

            if (txtPlayerName.Text.Trim() == "")
            {
                MessageBox.Show("You must identify the Player Name");
                return;
            }
            if (btnAdd.Text == "Add")
            {
                player = new Player();
                player.PlayerName = txtPlayerName.Text.Trim();

                if (cboTeams.SelectedIndex != -1)
                {
                    player.Team = (Team)cboTeams.SelectedItem;
                }

                db.Players.Add(player);
            }
            else if (btnAdd.Text == "Edit Player")
            {
                player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
                player.PlayerName = txtPlayerName.Text.Trim();

                if (cboTeams.SelectedIndex != -1)
                {
                    player.Team = (Team)cboTeams.SelectedItem;
                }
                btnEdit.Visible = true;
            }
            db.SaveChanges();
            btnAdd.Text = "Add";
            txtPlayerName.Clear();
            cboTeams.SelectedIndex = -1;
            Relist();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Player player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
            db.Players.Remove(player);
            db.SaveChanges();
            Relist();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Player player = (Player)dgvPlayers.SelectedRows[0].DataBoundItem;
            txtPlayerName.Text = player.PlayerName;
            cboTeams.SelectedItem = player.Team;
            dgvPlayers.Enabled = false;
            btnAdd.Text = "Edit Player";
            btnEdit.Visible = false;
        }

        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {
            if (txtTeamName.Text.Trim() == "")
            {
                Relist();
            }
            else
            {
                dgvPlayers.DataSource = db.Players.Where(x => x.Team.TeamName.Contains(txtTeamName.Text.Trim())).ToList();
            }
        }
    }
}
