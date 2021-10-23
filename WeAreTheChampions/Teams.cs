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
        }
    }
}
