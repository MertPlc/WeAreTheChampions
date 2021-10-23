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
        }

        private void Relist()
        {
            dgvColors.DataSource = null;
            dgvColors.DataSource = db.Colors.ToList();
        }

        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = hsbRed.Value.ToString();
            gbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbBlue.Value, hsbGreen.Value);
            lblRed.Text = hsbRed.Value.ToString();
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = hsbGreen.Value.ToString();
            gbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbBlue.Value, hsbGreen.Value);
            lblGreen.Text = hsbGreen.Value.ToString();
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = hsbBlue.Value.ToString();
            gbBackgroundColor.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbBlue.Value, hsbGreen.Value);
            lblBlue.Text = hsbBlue.Value.ToString();
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
                Blue = (byte)hsbBlue.Value,
                Green = (byte)hsbGreen.Value
            });

            db.SaveChanges();
            Relist();
        }
    }
}
