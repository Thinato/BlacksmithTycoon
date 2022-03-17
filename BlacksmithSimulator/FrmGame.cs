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
    public partial class FrmGame : Form
    {
        Form activeForm = null;
        Player p;
        public FrmGame()
        {
            InitializeComponent();
            LoadToolTips();
            p = new Player();

            picHunger.BringToFront();
            picSanity.BringToFront();
            picExp.BringToFront();
            UpdateValues();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if (activeForm.Name == childForm.Name)
                {
                    activeForm.Close();
                    activeForm = null;
                    return;
                }
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pMDI.Controls.Add(childForm);
            pMDI.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void LoadToolTips()
        {
            toolTip1.SetToolTip(btnInventory, "Inventory");
            toolTip1.SetToolTip(btnQuests, "Quests");
            toolTip1.SetToolTip(btnMap, "Map");
            toolTip1.SetToolTip(btnAchievment, "Achievments");
            toolTip1.SetToolTip(btnSettings, "Settings");
        }

        
        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.B:
                    btnInventory.PerformClick();
                    break;
                case Keys.M:
                    btnMap.PerformClick();
                    break;
                case Keys.Y:
                    btnAchievment.PerformClick();
                    break;
                case Keys.C:
                    btnQuests.PerformClick();
                    break;
                case Keys.Escape:
                    if (activeForm != null)
                    {
                        activeForm.Close();
                        activeForm = null;
                    }
                    else
                        btnSettings.PerformClick();
                    break;
            }

        }
        private void btnInventory_Click(object sender, EventArgs e) => OpenChildForm(new FrmInventory());

        private void btnArmory_Click(object sender, EventArgs e) => OpenChildForm(new FrmArmory());

        private void btnMap_Click(object sender, EventArgs e) => OpenChildForm(new FrmMap());

        private void btnAchievment_Click(object sender, EventArgs e) => OpenChildForm(new FrmAchievment());

        private void btnSettings_Click(object sender, EventArgs e) => OpenChildForm(new FrmSettings());

        private void UpdateValues()
        {
            gbStats.Text = "Name | " + p.Level; // Update Level
            int w;

            //Update hunger
            double d = p.Hunger;
            d /= p.HungerMax;
            w = Convert.ToInt32(244 * d); // algorithm for hunger bar width
            picHunger.Width = w; // set hunger bar width
            //set hunger text
            lblHunger.Text = $"Hunger: {p.Hunger}/{p.HungerMax} ({Math.Round(d * 100, 1)}%)";

            //same as the other but for Sanity
            d = p.Sanity;
            d /= p.SanityMax;
            w = Convert.ToInt32(244 * d);
            picSanity.Width = w;
            lblSanity.Text = $"Sanity: {p.Sanity}/{p.SanityMax} ({Math.Round(d * 100, 1)}%)";

            //same as the other but for Exp
            d = p.Exp;
            d /= p.ExpMax;
            w = Convert.ToInt32(244 * d);
            picExp.Width = w;
            lblExp.Text = $"Exp: {p.Exp}/{p.ExpMax} ({Math.Round(d * 100, 1)}%)";

            //Scroll log to bottom
            txtLog.Select(txtLog.TextLength + 1, 0);
            txtLog.ScrollToCaret();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            gpForge.Text = e.Node.Text;
        }
    }
}
