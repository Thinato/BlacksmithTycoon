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
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabForge = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gpForge = new System.Windows.Forms.GroupBox();
            this.lblItemForgeDesc = new System.Windows.Forms.Label();
            this.listItemForgeIngredients = new System.Windows.Forms.ListBox();
            this.btnForge = new System.Windows.Forms.Button();
            this.tabMine = new System.Windows.Forms.TabPage();
            this.lblMineMining = new System.Windows.Forms.Label();
            this.progMine = new System.Windows.Forms.ProgressBar();
            this.lblMineTime = new System.Windows.Forms.Label();
            this.tableMine = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMineGold = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMineIron = new System.Windows.Forms.Button();
            this.gbMineCopper = new System.Windows.Forms.GroupBox();
            this.btnMineCopper = new System.Windows.Forms.Button();
            this.gbMineTin = new System.Windows.Forms.GroupBox();
            this.btnMineTin = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnMineMeteorite = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnMineOrichalcum = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMinePlatinum = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMineMithril = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnMineSilver = new System.Windows.Forms.Button();
            this.tabMiners = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAchievment = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnQuests = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.timerSaveGame = new System.Windows.Forms.Timer(this.components);
            this.timerMine = new System.Windows.Forms.Timer(this.components);
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
            this.tabForge.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gpForge.SuspendLayout();
            this.tabMine.SuspendLayout();
            this.tableMine.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMineCopper.SuspendLayout();
            this.gbMineTin.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.label2);
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
            this.gbStats.Size = new System.Drawing.Size(258, 196);
            this.gbStats.TabIndex = 0;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "{PlayerName} | {Level}";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gold: 0000000000";
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
            this.txtLog.Location = new System.Drawing.Point(3, 209);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(260, 282);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 494);
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
            this.pMDI.Size = new System.Drawing.Size(447, 442);
            this.pMDI.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabForge);
            this.tabControl1.Controls.Add(this.tabMine);
            this.tabControl1.Controls.Add(this.tabMiners);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabForge
            // 
            this.tabForge.Controls.Add(this.tableLayoutPanel3);
            this.tabForge.Location = new System.Drawing.Point(4, 29);
            this.tabForge.Name = "tabForge";
            this.tabForge.Padding = new System.Windows.Forms.Padding(3);
            this.tabForge.Size = new System.Drawing.Size(439, 409);
            this.tabForge.TabIndex = 0;
            this.tabForge.Text = "Forge";
            this.tabForge.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(433, 403);
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
            this.treeView1.Size = new System.Drawing.Size(210, 397);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // gpForge
            // 
            this.gpForge.Controls.Add(this.lblItemForgeDesc);
            this.gpForge.Controls.Add(this.listItemForgeIngredients);
            this.gpForge.Controls.Add(this.btnForge);
            this.gpForge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpForge.Location = new System.Drawing.Point(219, 3);
            this.gpForge.Name = "gpForge";
            this.gpForge.Size = new System.Drawing.Size(211, 397);
            this.gpForge.TabIndex = 1;
            this.gpForge.TabStop = false;
            // 
            // lblItemForgeDesc
            // 
            this.lblItemForgeDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemForgeDesc.Location = new System.Drawing.Point(2, 23);
            this.lblItemForgeDesc.Name = "lblItemForgeDesc";
            this.lblItemForgeDesc.Size = new System.Drawing.Size(203, 112);
            this.lblItemForgeDesc.TabIndex = 2;
            this.lblItemForgeDesc.Text = "{Desciption}";
            // 
            // listItemForgeIngredients
            // 
            this.listItemForgeIngredients.FormattingEnabled = true;
            this.listItemForgeIngredients.ItemHeight = 20;
            this.listItemForgeIngredients.Location = new System.Drawing.Point(6, 143);
            this.listItemForgeIngredients.Name = "listItemForgeIngredients";
            this.listItemForgeIngredients.Size = new System.Drawing.Size(179, 84);
            this.listItemForgeIngredients.TabIndex = 1;
            // 
            // btnForge
            // 
            this.btnForge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForge.Location = new System.Drawing.Point(6, 363);
            this.btnForge.Name = "btnForge";
            this.btnForge.Size = new System.Drawing.Size(84, 28);
            this.btnForge.TabIndex = 0;
            this.btnForge.Text = "Forge";
            this.btnForge.UseVisualStyleBackColor = true;
            // 
            // tabMine
            // 
            this.tabMine.Controls.Add(this.lblMineMining);
            this.tabMine.Controls.Add(this.progMine);
            this.tabMine.Controls.Add(this.lblMineTime);
            this.tabMine.Controls.Add(this.tableMine);
            this.tabMine.Location = new System.Drawing.Point(4, 29);
            this.tabMine.Name = "tabMine";
            this.tabMine.Padding = new System.Windows.Forms.Padding(3);
            this.tabMine.Size = new System.Drawing.Size(439, 409);
            this.tabMine.TabIndex = 1;
            this.tabMine.Text = "Mine";
            this.tabMine.UseVisualStyleBackColor = true;
            // 
            // lblMineMining
            // 
            this.lblMineMining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMineMining.Location = new System.Drawing.Point(6, 366);
            this.lblMineMining.Name = "lblMineMining";
            this.lblMineMining.Size = new System.Drawing.Size(339, 18);
            this.lblMineMining.TabIndex = 5;
            this.lblMineMining.Text = "{Currently Mining}";
            this.lblMineMining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progMine
            // 
            this.progMine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progMine.Location = new System.Drawing.Point(6, 387);
            this.progMine.Name = "progMine";
            this.progMine.Size = new System.Drawing.Size(424, 16);
            this.progMine.Step = 1;
            this.progMine.TabIndex = 0;
            // 
            // lblMineTime
            // 
            this.lblMineTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMineTime.Location = new System.Drawing.Point(351, 366);
            this.lblMineTime.Name = "lblMineTime";
            this.lblMineTime.Size = new System.Drawing.Size(79, 18);
            this.lblMineTime.TabIndex = 2;
            this.lblMineTime.Text = "2000 sec";
            this.lblMineTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableMine
            // 
            this.tableMine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMine.AutoScroll = true;
            this.tableMine.ColumnCount = 2;
            this.tableMine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMine.Controls.Add(this.groupBox2, 1, 1);
            this.tableMine.Controls.Add(this.groupBox1, 0, 1);
            this.tableMine.Controls.Add(this.gbMineCopper, 0, 0);
            this.tableMine.Controls.Add(this.gbMineTin, 1, 0);
            this.tableMine.Controls.Add(this.groupBox5, 0, 4);
            this.tableMine.Controls.Add(this.groupBox6, 1, 3);
            this.tableMine.Controls.Add(this.groupBox4, 1, 2);
            this.tableMine.Controls.Add(this.groupBox3, 0, 3);
            this.tableMine.Controls.Add(this.groupBox7, 0, 2);
            this.tableMine.Location = new System.Drawing.Point(3, 6);
            this.tableMine.Name = "tableMine";
            this.tableMine.RowCount = 5;
            this.tableMine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableMine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableMine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableMine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableMine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMine.Size = new System.Drawing.Size(427, 331);
            this.tableMine.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnMineGold);
            this.groupBox2.Location = new System.Drawing.Point(216, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gold Vein";
            // 
            // btnMineGold
            // 
            this.btnMineGold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineGold.Location = new System.Drawing.Point(3, 23);
            this.btnMineGold.Name = "btnMineGold";
            this.btnMineGold.Size = new System.Drawing.Size(202, 34);
            this.btnMineGold.TabIndex = 1;
            this.btnMineGold.Text = "Mine";
            this.btnMineGold.UseVisualStyleBackColor = true;
            this.btnMineGold.Click += new System.EventHandler(this.btnMineGold_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnMineIron);
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iron Vein";
            // 
            // btnMineIron
            // 
            this.btnMineIron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineIron.Location = new System.Drawing.Point(3, 23);
            this.btnMineIron.Name = "btnMineIron";
            this.btnMineIron.Size = new System.Drawing.Size(201, 34);
            this.btnMineIron.TabIndex = 1;
            this.btnMineIron.Text = "Mine";
            this.btnMineIron.UseVisualStyleBackColor = true;
            this.btnMineIron.Click += new System.EventHandler(this.btnMineIron_Click);
            // 
            // gbMineCopper
            // 
            this.gbMineCopper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMineCopper.Controls.Add(this.btnMineCopper);
            this.gbMineCopper.Location = new System.Drawing.Point(3, 3);
            this.gbMineCopper.Name = "gbMineCopper";
            this.gbMineCopper.Size = new System.Drawing.Size(207, 60);
            this.gbMineCopper.TabIndex = 0;
            this.gbMineCopper.TabStop = false;
            this.gbMineCopper.Text = "Copper Vein";
            // 
            // btnMineCopper
            // 
            this.btnMineCopper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineCopper.Location = new System.Drawing.Point(3, 23);
            this.btnMineCopper.Name = "btnMineCopper";
            this.btnMineCopper.Size = new System.Drawing.Size(201, 34);
            this.btnMineCopper.TabIndex = 1;
            this.btnMineCopper.Text = "Mine";
            this.btnMineCopper.UseVisualStyleBackColor = true;
            this.btnMineCopper.Click += new System.EventHandler(this.btnMineCopper_Click);
            // 
            // gbMineTin
            // 
            this.gbMineTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMineTin.Controls.Add(this.btnMineTin);
            this.gbMineTin.Location = new System.Drawing.Point(216, 3);
            this.gbMineTin.Name = "gbMineTin";
            this.gbMineTin.Size = new System.Drawing.Size(208, 60);
            this.gbMineTin.TabIndex = 3;
            this.gbMineTin.TabStop = false;
            this.gbMineTin.Text = "Tin Vein";
            // 
            // btnMineTin
            // 
            this.btnMineTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineTin.Location = new System.Drawing.Point(3, 23);
            this.btnMineTin.Name = "btnMineTin";
            this.btnMineTin.Size = new System.Drawing.Size(202, 34);
            this.btnMineTin.TabIndex = 1;
            this.btnMineTin.Text = "Mine";
            this.btnMineTin.UseVisualStyleBackColor = true;
            this.btnMineTin.Click += new System.EventHandler(this.btnMineTin_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnMineMeteorite);
            this.groupBox5.Location = new System.Drawing.Point(3, 267);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 60);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Meteorite Fragments";
            // 
            // btnMineMeteorite
            // 
            this.btnMineMeteorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineMeteorite.Location = new System.Drawing.Point(3, 23);
            this.btnMineMeteorite.Name = "btnMineMeteorite";
            this.btnMineMeteorite.Size = new System.Drawing.Size(201, 34);
            this.btnMineMeteorite.TabIndex = 1;
            this.btnMineMeteorite.Text = "Mine";
            this.btnMineMeteorite.UseVisualStyleBackColor = true;
            this.btnMineMeteorite.Click += new System.EventHandler(this.btnMineMeteorite_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.btnMineOrichalcum);
            this.groupBox6.Location = new System.Drawing.Point(216, 201);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 60);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Orichalcum Vein";
            // 
            // btnMineOrichalcum
            // 
            this.btnMineOrichalcum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineOrichalcum.Location = new System.Drawing.Point(3, 23);
            this.btnMineOrichalcum.Name = "btnMineOrichalcum";
            this.btnMineOrichalcum.Size = new System.Drawing.Size(202, 34);
            this.btnMineOrichalcum.TabIndex = 1;
            this.btnMineOrichalcum.Text = "Mine";
            this.btnMineOrichalcum.UseVisualStyleBackColor = true;
            this.btnMineOrichalcum.Click += new System.EventHandler(this.btnMineOrichalcum_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnMinePlatinum);
            this.groupBox4.Location = new System.Drawing.Point(216, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 60);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Platinum Vein";
            // 
            // btnMinePlatinum
            // 
            this.btnMinePlatinum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinePlatinum.Location = new System.Drawing.Point(3, 23);
            this.btnMinePlatinum.Name = "btnMinePlatinum";
            this.btnMinePlatinum.Size = new System.Drawing.Size(202, 34);
            this.btnMinePlatinum.TabIndex = 1;
            this.btnMinePlatinum.Text = "Mine";
            this.btnMinePlatinum.UseVisualStyleBackColor = true;
            this.btnMinePlatinum.Click += new System.EventHandler(this.btnMinePlatinum_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnMineMithril);
            this.groupBox3.Location = new System.Drawing.Point(3, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mithril Vein";
            // 
            // btnMineMithril
            // 
            this.btnMineMithril.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineMithril.Location = new System.Drawing.Point(3, 23);
            this.btnMineMithril.Name = "btnMineMithril";
            this.btnMineMithril.Size = new System.Drawing.Size(201, 34);
            this.btnMineMithril.TabIndex = 1;
            this.btnMineMithril.Text = "Mine";
            this.btnMineMithril.UseVisualStyleBackColor = true;
            this.btnMineMithril.Click += new System.EventHandler(this.btnMineMithril_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.btnMineSilver);
            this.groupBox7.Location = new System.Drawing.Point(3, 135);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(207, 60);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Silver Vein";
            // 
            // btnMineSilver
            // 
            this.btnMineSilver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMineSilver.Location = new System.Drawing.Point(3, 23);
            this.btnMineSilver.Name = "btnMineSilver";
            this.btnMineSilver.Size = new System.Drawing.Size(201, 34);
            this.btnMineSilver.TabIndex = 1;
            this.btnMineSilver.Text = "Mine";
            this.btnMineSilver.UseVisualStyleBackColor = true;
            this.btnMineSilver.Click += new System.EventHandler(this.btnMineSilver_Click);
            // 
            // tabMiners
            // 
            this.tabMiners.Location = new System.Drawing.Point(4, 29);
            this.tabMiners.Name = "tabMiners";
            this.tabMiners.Padding = new System.Windows.Forms.Padding(3);
            this.tabMiners.Size = new System.Drawing.Size(439, 409);
            this.tabMiners.TabIndex = 2;
            this.tabMiners.Text = "Miners";
            this.tabMiners.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(392, 460);
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
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // timerSaveGame
            // 
            this.timerSaveGame.Interval = 60000;
            this.timerSaveGame.Tick += new System.EventHandler(this.timerSaveGame_Tick);
            // 
            // timerMine
            // 
            this.timerMine.Interval = 500;
            this.timerMine.Tick += new System.EventHandler(this.timerMine_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 518);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
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
            this.tabForge.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gpForge.ResumeLayout(false);
            this.tabMine.ResumeLayout(false);
            this.tableMine.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbMineCopper.ResumeLayout(false);
            this.gbMineTin.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabForge;
        private System.Windows.Forms.TabPage tabMine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox gpForge;
        private System.Windows.Forms.Button btnForge;
        private System.Windows.Forms.Label lblItemForgeDesc;
        private System.Windows.Forms.ListBox listItemForgeIngredients;
        private System.Windows.Forms.GroupBox gbMineCopper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMineTime;
        private System.Windows.Forms.Button btnMineCopper;
        private System.Windows.Forms.ProgressBar progMine;
        private System.Windows.Forms.GroupBox gbMineTin;
        private System.Windows.Forms.Button btnMineTin;
        private System.Windows.Forms.TabPage tabMiners;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Timer timerSaveGame;
        private System.Windows.Forms.Timer timerMine;
        private System.Windows.Forms.TableLayoutPanel tableMine;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMinePlatinum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMineMithril;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMineGold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMineIron;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnMineOrichalcum;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnMineMeteorite;
        private System.Windows.Forms.Label lblMineMining;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnMineSilver;
    }
}