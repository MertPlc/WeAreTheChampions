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
            Relist();
        }

        private void Relist()
        {
            dgvScore.Rows.Clear();

            foreach (var item in db.Matches)
            {
                dgvScore.Rows.Add(item.Id, item.Team1, item.Team2, item.MatchTime, item.Score1, item.Score2, item.ResultId);
            }
        }

        private void btnNewMatch_Click(object sender, EventArgs e)
        {
            new New_Match(db).ShowDialog();
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
            if (dgvScore.Rows.Count > 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to remove it?", "Delete Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvScore.SelectedRows[0];
                    Team deleted = (Team)row.DataBoundItem;
                    db.Teams.Remove(deleted);
                    db.SaveChanges();
                }
            }

            Relist();
        }
    }
}
