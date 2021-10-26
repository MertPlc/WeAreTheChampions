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
using Color = WeAreTheChampions.Data.Color;

namespace WeAreTheChampions
{
    public partial class Colors : Form
    {
        private readonly WAChampionsContext db;

        public Colors(WAChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            Relist(); 
            this.dgvColors.Columns[0].Visible = false;
            this.dgvColors.Columns[2].Visible = false;
            this.dgvColors.Columns[3].Visible = false;
            this.dgvColors.Columns[4].Visible = false;
            this.dgvColors.Columns[5].Visible = false;
        }

        private void Relist()
        {
            dgvColors.DataSource = db.Colors.ToList();
        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsbRed.Value.ToString();
            gbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblRed.Text = hsbRed.Value.ToString();
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsbGreen.Value.ToString();
            gbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblGreen.Text = hsbGreen.Value.ToString();
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsbBlue.Value.ToString();
            gbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblBlue.Text = hsbBlue.Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = dgvColors.SelectedRows[0];
            Color deleted = (Color)row.DataBoundItem;
            db.Colors.Remove(deleted);
            db.SaveChanges();
            Relist();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtColorName.Text.Trim() == "")
            {
                MessageBox.Show("Please identify a color name");
                return;
            }

            db.Colors.Add(new Color
            {
                ColorName = txtColorName.Text.Trim(),
                Red = (byte)hsbRed.Value,
                Green = (byte)hsbGreen.Value,
                Blue = (byte)hsbBlue.Value
            });

            db.SaveChanges();
            Relist();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selected = (int)dgvColors.SelectedRows[0].Cells[0].Value;

            var update = db.Colors.Find(selected);

            update.Red = (byte)hsbRed.Value;
            update.Blue = (byte)hsbBlue.Value;
            update.Green = (byte)hsbGreen.Value;

            db.SaveChanges();
            Relist();
        }
    }
}
