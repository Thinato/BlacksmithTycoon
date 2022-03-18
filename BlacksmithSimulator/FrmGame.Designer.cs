namespace BlacksmithSimulator
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Cooper");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tin");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Bronze");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Iron");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Silver");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Steel Helmet");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Steel", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Gold Ring");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Gold Trinket");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Gold Necklace");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Gold", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Platinum Ring");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Platinum Necklace");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Platinum", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Mithril");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("True Silver");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Adamantium");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Orichalcum");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Thokcha");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Shaduko");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Aracum");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Electrum");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.picBackExp = new System.Windows.Forms.PictureBox();
            this.picBackSanity = new System.Windows.Forms.PictureBox();
            this.picBackHunger = new System.Windows.Forms.PictureBox();
            this.picExp = new System.Windows.Forms.PictureBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.picHunger = new System.Windows.Forms.PictureBox();
            this.lblSanity = new System.Windows.Forms.Label();
            this.picSanity = new System.Windows.Forms.PictureBox();
            this.lblHunger = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pMDI = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gpForge = new System.Windows.Forms.GroupBox();
            this.btnForge = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAchievment = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnQuests = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackSanity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackHunger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHunger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanity)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pMDI.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gpForge.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.picBackExp);
            this.gbStats.Controls.Add(this.picBackSanity);
            this.gbStats.Controls.Add(this.picBackHunger);
            this.gbStats.Controls.Add(this.picExp);
            this.gbStats.Controls.Add(this.lblExp);
            this.gbStats.Controls.Add(this.picHunger);
            this.gbStats.Controls.Add(this.lblSanity);
            this.gbStats.Controls.Add(this.picSanity);
            this.gbStats.Controls.Add(this.lblHunger);
            this.gbStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStats.Location = new System.Drawing.Point(4, 5);
            this.gbStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStats.Name = "gbStats";
            this.gbStats.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbStats.Size = new System.Drawing.Size(258, 165);
            this.gbStats.TabIndex = 0;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "{PlayerName} | {Level}";
            // 
            // picBackExp
            // 
            this.picBackExp.Image = global::BlacksmithSimulator.Properties.Resources.back_bar;
            this.picBackExp.Location = new System.Drawing.Point(7, 140);
            this.picBackExp.Name = "picBackExp";
            this.picBackExp.Size = new System.Drawing.Size(244, 20);
            this.picBackExp.TabIndex = 8;
            this.picBackExp.TabStop = false;
            // 
            // picBackSanity
            // 
            this.picBackSanity.Image = global::BlacksmithSimulator.Properties.Resources.back_bar;
            this.picBackSanity.Location = new System.Drawing.Point(7, 94);
            this.picBackSanity.Name = "picBackSanity";
            this.picBackSanity.Size = new System.Drawing.Size(244, 20);
            this.picBackSanity.TabIndex = 7;
            this.picBackSanity.TabStop = false;
            // 
            // picBackHunger
            // 
            this.picBackHunger.Image = global::BlacksmithSimulator.Properties.Resources.back_bar;
            this.picBackHunger.Location = new System.Drawing.Point(7, 48);
            this.picBackHunger.Name = "picBackHunger";
            this.picBackHunger.Size = new System.Drawing.Size(244, 20);
            this.picBackHunger.TabIndex = 6;
            this.picBackHunger.TabStop = false;
            // 
            // picExp
            // 
            this.picExp.Image = global::BlacksmithSimulator.Properties.Resources.exp_bar;
            this.picExp.Location = new System.Drawing.Point(7, 140);
            this.picExp.Name = "picExp";
            this.picExp.Size = new System.Drawing.Size(244, 20);
            this.picExp.TabIndex = 5;
            this.picExp.TabStop = false;
            // 
            // lblExp
            // 
            this.lblExp.BackColor = System.Drawing.Color.Transparent;
            this.lblExp.ForeColor = System.Drawing.Color.Black;
            this.lblExp.Location = new System.Drawing.Point(7, 117);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(244, 20);
            this.lblExp.TabIndex = 4;
            this.lblExp.Text = "Exp: 99999/99999 (100%)";
            // 
            // picHunger
            // 
            this.picHunger.Image = global::BlacksmithSimulator.Properties.Resources.hunger_bar_dark;
            this.picHunger.Location = new System.Drawing.Point(7, 48);
            this.picHunger.Name = "picHunger";
            this.picHunger.Size = new System.Drawing.Size(244, 20);
            this.picHunger.TabIndex = 3;
            this.picHunger.TabStop = false;
            // 
            // lblSanity
            // 
            this.lblSanity.BackColor = System.Drawing.Color.Transparent;
            this.lblSanity.ForeColor = System.Drawing.Color.Black;
            this.lblSanity.Location = new System.Drawing.Point(7, 71);
            this.lblSanity.Name = "lblSanity";
            this.lblSanity.Size = new System.Drawing.Size(244, 20);
            this.lblSanity.TabIndex = 1;
            this.lblSanity.Text = "Sanity: 9999/9999 (100%)";
            // 
            // picSanity
            // 
            this.picSanity.Image = global::BlacksmithSimulator.Properties.Resources.sanity_bar;
            this.picSanity.Location = new System.Drawing.Point(7, 94);
            this.picSanity.Name = "picSanity";
            this.picSanity.Size = new System.Drawing.Size(244, 20);
            this.picSanity.TabIndex = 2;
            this.picSanity.TabStop = false;
            // 
            // lblHunger
            // 
            this.lblHunger.BackColor = System.Drawing.Color.Transparent;
            this.lblHunger.Location = new System.Drawing.Point(7, 25);
            this.lblHunger.Name = "lblHunger";
            this.lblHunger.Size = new System.Drawing.Size(244, 20);
            this.lblHunger.TabIndex = 0;
            this.lblHunger.Text = "Hunger: 9999/9999 (100%)";
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 178);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(260, 249);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbStats, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLog, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pMDI
            // 
            this.pMDI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMDI.Controls.Add(this.tabControl1);
            this.pMDI.Location = new System.Drawing.Point(284, 12);
            this.pMDI.Name = "pMDI";
            this.pMDI.Size = new System.Drawing.Size(407, 378);
            this.pMDI.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(407, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(399, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Forge";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gpForge, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(393, 339);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "rootCooper";
            treeNode1.Text = "Cooper";
            treeNode2.Name = "rootTin";
            treeNode2.Text = "Tin";
            treeNode3.Name = "rootBronze";
            treeNode3.Text = "Bronze";
            treeNode4.Name = "rootIron";
            treeNode4.Text = "Iron";
            treeNode5.Name = "rootSilver";
            treeNode5.Text = "Silver";
            treeNode6.Name = "steelHelmet";
            treeNode6.Text = "Steel Helmet";
            treeNode7.Name = "rootSteel";
            treeNode7.Text = "Steel";
            treeNode8.Name = "goldRing";
            treeNode8.Text = "Gold Ring";
            treeNode9.Name = "goldTrinket";
            treeNode9.Text = "Gold Trinket";
            treeNode10.Name = "goldNecklace";
            treeNode10.Text = "Gold Necklace";
            treeNode11.Name = "rootGold";
            treeNode11.Text = "Gold";
            treeNode12.Name = "platinumRing";
            treeNode12.Text = "Platinum Ring";
            treeNode13.Name = "platinumNecklace";
            treeNode13.Text = "Platinum Necklace";
            treeNode14.Name = "rootPlatinum";
            treeNode14.Text = "Platinum";
            treeNode15.Name = "rootMithril";
            treeNode15.Text = "Mithril";
            treeNode16.Name = "rootTrueSilver";
            treeNode16.Text = "True Silver";
            treeNode17.Name = "rootAdamantium";
            treeNode17.Text = "Adamantium";
            treeNode18.Name = "rootOrichalcum";
            treeNode18.Text = "Orichalcum";
            treeNode19.Name = "rootThokcha";
            treeNode19.Text = "Thokcha";
            treeNode20.Name = "rootShaduko";
            treeNode20.Text = "Shaduko";
            treeNode21.Name = "rootAracum";
            treeNode21.Text = "Aracum";
            treeNode22.Name = "rootElectrum";
            treeNode22.Text = "Electrum";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode7,
            treeNode11,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(190, 333);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // gpForge
            // 
            this.gpForge.Controls.Add(this.btnForge);
            this.gpForge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpForge.Location = new System.Drawing.Point(199, 3);
            this.gpForge.Name = "gpForge";
            this.gpForge.Size = new System.Drawing.Size(191, 333);
            this.gpForge.TabIndex = 1;
            this.gpForge.TabStop = false;
            // 
            // btnForge
            // 
            this.btnForge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForge.Location = new System.Drawing.Point(6, 299);
            this.btnForge.Name = "btnForge";
            this.btnForge.Size = new System.Drawing.Size(84, 28);
            this.btnForge.TabIndex = 0;
            this.btnForge.Text = "Forge";
            this.btnForge.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(399, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mine";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSettings, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAchievment, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInventory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnMap, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQuests, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(372, 396);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 46);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(187, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAchievment
            // 
            this.btnAchievment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAchievment.Image = global::BlacksmithSimulator.Properties.Resources.icons8_trophy_30;
            this.btnAchievment.Location = new System.Drawing.Point(141, 3);
            this.btnAchievment.Name = "btnAchievment";
            this.btnAchievment.Size = new System.Drawing.Size(40, 40);
            this.btnAchievment.TabIndex = 2;
            this.btnAchievment.UseVisualStyleBackColor = true;
            this.btnAchievment.Click += new System.EventHandler(this.btnAchievment_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInventory.Image = global::BlacksmithSimulator.Properties.Resources.icons8_backpack_30;
            this.btnInventory.Location = new System.Drawing.Point(3, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(40, 40);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnMap
            // 
            this.btnMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMap.Image = global::BlacksmithSimulator.Properties.Resources.icons8_map_30;
            this.btnMap.Location = new System.Drawing.Point(95, 3);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(40, 40);
            this.btnMap.TabIndex = 1;
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnQuests
            // 
            this.btnQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuests.Image = global::BlacksmithSimulator.Properties.Resources.icons8_scroll_30;
            this.btnQuests.Location = new System.Drawing.Point(49, 3);
            this.btnQuests.Name = "btnQuests";
            this.btnQuests.Size = new System.Drawing.Size(40, 40);
            this.btnQuests.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnQuests, "Armory");
            this.btnQuests.UseVisualStyleBackColor = true;
            this.btnQuests.Click += new System.EventHandler(this.btnArmory_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 454);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pMDI);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(575, 320);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.gbStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackSanity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackHunger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHunger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanity)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pMDI.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gpForge.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pMDI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnQuests;
        private System.Windows.Forms.Button btnAchievment;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblHunger;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblSanity;
        private System.Windows.Forms.PictureBox picSanity;
        private System.Windows.Forms.PictureBox picHunger;
        private System.Windows.Forms.PictureBox picExp;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.PictureBox picBackHunger;
        private System.Windows.Forms.PictureBox picBackExp;
        private System.Windows.Forms.PictureBox picBackSanity;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox gpForge;
        private System.Windows.Forms.Button btnForge;
    }
}