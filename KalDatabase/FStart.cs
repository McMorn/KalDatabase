using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalDatabase
{
    public partial class FStart : Form
    {
        public FStart()
        {
            InitializeComponent();
        }

        private static void OpenFWeapon()
        {
            Application.Run(new FWeapon());
        }

        private void weaponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenFWeapon));
            t.Start();
            this.Close();
        }

        private static void OpenFArmor()
        {
            Application.Run(new FArmor());
        }

        private void armorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenFArmor));
            t.Start();
            this.Close();
        }
    }
}
