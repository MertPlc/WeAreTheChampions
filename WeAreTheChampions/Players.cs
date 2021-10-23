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
        }
    }
}
