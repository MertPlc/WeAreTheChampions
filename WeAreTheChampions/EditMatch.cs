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
        }
    }
}
