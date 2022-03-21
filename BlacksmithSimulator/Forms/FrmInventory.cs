using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithSimulator
{
    public partial class FrmInventory : Form
    {
        Player p;
        public FrmInventory(Player _p)
        {
            InitializeComponent();
            p = _p;

            dgInventory.DataSource = p.DataInventory;
            dgInventory.ContextMenuStrip = contextMenuStrip1;
            dgInventory.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgInventory.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            UpdateValues();
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                foreach ( DataGridViewCell cell in dgInventory.SelectedCells)
                {
                    dgInventory.Rows.RemoveAt(cell.RowIndex);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgInventory.SelectedCells.Count < 1)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
            }
        }

        private void btnBlacksmithingLevel_Click(object sender, EventArgs e) => LevelUpAbility(0);
        
        private void btnMiningLevel_Click(object sender, EventArgs e) => LevelUpAbility(1);

        private void btnHungerLevel_Click(object sender, EventArgs e) => LevelUpAbility(2);

        private void btnSanityLevel_Click(object sender, EventArgs e) => LevelUpAbility(3);

        private void LevelUpAbility(int ability)
        {
            switch (ability)
            {
                case 0:
                    p.Blacksmithing++;
                    break;
                case 1:
                    p.Mining++;
                    break;
                case 2:
                    p.Hunger += 20;
                    p.HungerMax += 20;
                    break;
                case 3:
                    p.Sanity += 20;
                    p.SanityMax += 20;
                    break;
            }
            p.LevelPoints--;
            UpdateValues();
        }
        private void UpdateValues()
        {
            lblLevelPoints.Text = "Available Points: " + p.LevelPoints;
            lblBlacksmithing.Text = "Blacksmithing: " + p.Blacksmithing;
            lblMining.Text = "Mining: " + p.Mining;
            lblHunger.Text = "Hunger: " + p.HungerMax;
            lblSanity.Text = "Sanity: " + p.SanityMax;

            if (p.LevelPoints < 1)
                foreach (Button b in pBack.Controls.OfType<Button>())
                    b.Enabled = false;
        }
    }
}
