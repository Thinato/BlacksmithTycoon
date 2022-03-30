using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static BlacksmithSimulator.XmlManager;
using static BlacksmithSimulator.Player;

namespace BlacksmithSimulator
{
    public partial class FrmGame : Form
    {
        Form activeForm = null;
        Player p;
        Config cfg;
        Connection c;

        private double mineTime = 0;
        private Ore mining;

        private int PlayerID;

        public FrmGame(int _PlayerID)
        {
            InitializeComponent();
            LoadToolTips();

            PlayerID = _PlayerID;

            p = new Player();
            cfg = new Config();
            c = new Connection();



            c.Connect();

            LoadTables();
            LoadPlayer();

            cfg.DetachWindows = true;
            cfg.AllowMultipleWindows = true;

            picHunger.BringToFront();
            picSanity.BringToFront();
            picExp.BringToFront();
            UpdateValues();
        }
        private void LoadPlayer()
        {
            DataTable dt = new DataTable();
            string query = "select * from player where ID=" + PlayerID + ';';
            SQLiteDataAdapter data = new SQLiteDataAdapter(query, c.conn);
            data.Fill(dt);

            p.Name =        dt.Rows[0].Field<string>(1);
            p.Gold =        Convert.ToInt32(dt.Rows[0][2]);
            p.Level =       Convert.ToInt32(dt.Rows[0].Field<Int64>(3));
            p.Hunger =      Convert.ToInt32(dt.Rows[0].Field<Int64>(4));
            p.HungerMax =   Convert.ToInt32(dt.Rows[0].Field<Int64>(5));
            p.Sanity =      Convert.ToInt32(dt.Rows[0].Field<Int64>(6));
            p.SanityMax =   Convert.ToInt32(dt.Rows[0].Field<Int64>(7));
            p.Exp =         Convert.ToInt32(dt.Rows[0].Field<Int64>(8));
            p.ExpMax =      Convert.ToInt32(dt.Rows[0].Field<Int64>(9));
            p.ExpDiff =     Convert.ToInt32(dt.Rows[0].Field<Int64>(10));
            p.Blacksmithing=Convert.ToInt32(dt.Rows[0].Field<Int64>(11));
            p.Mining =      Convert.ToInt32(dt.Rows[0].Field<Int64>(12));
           // p.Name =        dt.Rows[0].Field<string>(1);
        }

        private void LoadTables()
        {
            string query = "select * from Items;";
            SQLiteDataAdapter data = new SQLiteDataAdapter(query, c.conn);
            data.Fill(p.DataItems);

            data.SelectCommand.CommandText = "select ITEM_ID, ITEM as Item, QUANTITY as Qty from Inventory where PLAYER_ID=" + PlayerID + ';';
            data.Fill(p.DataInventory);


        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Button b in tableLayoutPanel2.Controls.OfType<Button>())
                b.BackColor = SystemColors.Control;
            switch (childForm.Name)
            {
                case "FrmInventory":
                    btnInventory.BackColor = SystemColors.ActiveCaption;
                    break;
                case "FrmQuest":
                    btnQuests.BackColor = SystemColors.ActiveCaption;
                    break;
                case "FrmMap":
                    btnMap.BackColor = SystemColors.ActiveCaption;
                    break;
                case "FrmAchievment":
                    btnAchievment.BackColor = SystemColors.ActiveCaption;
                    break;
                case "FrmSettings":
                    btnSettings.BackColor = SystemColors.ActiveCaption;
                    break;
            }
            if (activeForm != null)
            {
                if (activeForm.Name == childForm.Name)
                {
                    activeForm.Close();
                    activeForm = null;
                    foreach (Button b in tableLayoutPanel2.Controls.OfType<Button>())
                        b.BackColor = SystemColors.Control;
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
            toolTip1.SetToolTip(btnInventory, "Inventory (B)");
            toolTip1.SetToolTip(btnQuests, "Quests (J)");
            toolTip1.SetToolTip(btnMap, "Map (M)");
            toolTip1.SetToolTip(btnAchievment, "Achievments (Y)");
            toolTip1.SetToolTip(btnSettings, "Settings (Esc)");
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
                case Keys.J:
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

        private void btnInventory_Click(object sender, EventArgs e) => OpenChildForm(new FrmInventory(p));

        private void btnArmory_Click(object sender, EventArgs e) => OpenChildForm(new FrmArmory());

        private void btnMap_Click(object sender, EventArgs e) => OpenChildForm(new FrmMap());

        private void btnAchievment_Click(object sender, EventArgs e) => OpenChildForm(new FrmAchievment());

        private void btnSettings_Click(object sender, EventArgs e) => OpenChildForm(new FrmSettings());

        private void UpdateValues()
        {
            gbStats.Text = p.Name + " | " + p.Level; // Update Level
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


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            gpForge.Text = e.Node.Text;
        }
        private void MineOre(Ore ore)
        {
            progMine.Value = 0;
            ((Control)tabForge).Enabled = false;
            
            mining = ore;
            DataRow[] result;
            if (ore == Ore.Meteorite)
                result = p.DataItems.Select($"ID=25");
            else
                result = p.DataItems.Select($"NAME='{ore} ore'");
            mineTime = result[0].Field<Int64>(6) * 5;
            //mineTime = p.DataItems.Rows[0].Field<Int64>(6) * 5;
            progMine.Maximum = Convert.ToInt32(mineTime * 2);

            btnMineCopper.Enabled = false;
            btnMineTin.Enabled = false;
            btnMineIron.Enabled = false;
            btnMineSilver.Enabled = false;
            btnMineGold.Enabled = false;
            btnMinePlatinum.Enabled = false;
            btnMineMithril.Enabled = false;
            btnMineOrichalcum.Enabled = false;
            btnMineMeteorite.Enabled = false;

            if (mining == Ore.Meteorite)
                lblMineMining.Text = "Mining Meteorite Fragments";
            else
                lblMineMining.Text = $"Mining {mining} Vein";
            timerMine.Start();
            timerMine_Tick(null, null);
            UpdateValues();
        }
        private void btnMineCopper_Click(object sender, EventArgs e) => MineOre(Ore.Copper);

        private void btnMineTin_Click(object sender, EventArgs e) => MineOre(Ore.Tin);

        private void btnMineIron_Click(object sender, EventArgs e) => MineOre(Ore.Iron);

        private void btnMineSilver_Click(object sender, EventArgs e) => MineOre(Ore.Silver);

        private void btnMineGold_Click(object sender, EventArgs e) => MineOre(Ore.Gold);

        private void btnMinePlatinum_Click(object sender, EventArgs e) => MineOre(Ore.Platinum);

        private void btnMineMithril_Click(object sender, EventArgs e) => MineOre(Ore.Mithril);

        private void btnMineOrichalcum_Click(object sender, EventArgs e) => MineOre(Ore.Orichalcum);

        private void btnMineMeteorite_Click(object sender, EventArgs e) => MineOre(Ore.Meteorite);

        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e) 
        {
            c.Disconnect();
            Environment.Exit(0);
        }

        private void timerSaveGame_Tick(object sender, EventArgs e) => SaveGame();

        private void SaveGame()
        {
            //update player where id =playerID
            
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (p.LevelPoints > 0)
            {
                if (btnInventory.BackColor == SystemColors.Control)
                    btnInventory.BackColor = SystemColors.ActiveCaption;
                else
                    btnInventory.BackColor = SystemColors.Control;
            }
            UpdateValues();
        }

        private void timerMine_Tick(object sender, EventArgs e)
        {
            if (mineTime <= 0)
            {
                mineTime = 0;
                timerMine.Stop();
                OreMined(mining);
                lblMineTime.Text = "Success!";
            }
            
            lblMineTime.Text = mineTime.ToString("0.0") + " sec";
            

            mineTime -= 0.5;
            progMine.PerformStep();

        }
        private void AddItem(int ItemID)
        {
            string query = "UPDATE Inventory SET QUANTITY = QUANTITY + 1 WHERE ITEM_ID=" + ItemID + " AND PLAYER_ID=" + PlayerID + ';';

        }
        private void OreMined(Ore ore)
        {
            btnMineCopper.Enabled = true;
            btnMineTin.Enabled = true;
            btnMineIron.Enabled = true;
            btnMineSilver.Enabled = true;
            btnMineGold.Enabled = true;
            btnMinePlatinum.Enabled = true;
            btnMineMithril.Enabled = true;
            btnMineOrichalcum.Enabled = true;
            btnMineMeteorite.Enabled = true;

            ((Control)tabForge).Enabled = true;

            switch (ore)
            {
                case Ore.Copper:
                    AddItem(1);
                    txtLog.Text += p.GainExp(6);
                    break;
                case Ore.Tin:
                    AddItem(3);
                    txtLog.Text += p.GainExp(10);
                    break;
                case Ore.Iron:
                    AddItem(6);
                    txtLog.Text += p.GainExp(32);
                    break;
                case Ore.Silver:
                    AddItem(8);
                    txtLog.Text += p.GainExp(55);
                    break;
                case Ore.Gold:
                    AddItem(11);
                    txtLog.Text += p.GainExp(80);
                    break;
                case Ore.Platinum:
                    AddItem(13);
                    txtLog.Text += p.GainExp(145);
                    break;
                case Ore.Mithril:
                    AddItem(15);
                    txtLog.Text += p.GainExp(210);
                    break;
                case Ore.Orichalcum:
                    AddItem(19);
                    txtLog.Text += p.GainExp(290);
                    break;
                case Ore.Meteorite:
                    AddItem(25);
                    txtLog.Text += p.GainExp(300);
                    break;
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            //Scroll log to bottom
            txtLog.Select(txtLog.TextLength + 1, 0);
            txtLog.ScrollToCaret();
        }

    }
}
