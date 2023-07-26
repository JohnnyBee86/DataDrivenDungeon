using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDrivenDungeon.Views
{
    /// <summary>
    /// This is the form for all the dungeon fights. Depending on the dungeon they're in,
    /// their inventory, and the enemies they're fighting, the data will change.
    /// </summary>
    public partial class DungeonForm : Form
    {
        public DungeonForm()
        {
            InitializeComponent();
        }
    }
}
