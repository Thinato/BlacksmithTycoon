namespace BlacksmithSimulator
{
    partial class FrmInventory
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
            this.dgInventory = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSell = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sellSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pBack = new System.Windows.Forms.Panel();
            this.btnBlacksmithingLevel = new System.Windows.Forms.Button();
            this.lblLevelPoints = new System.Windows.Forms.Label();
            this.lblBlacksmithing = new System.Windows.Forms.Label();
            this.lblMining = new System.Windows.Forms.Label();
            this.btnMiningLevel = new System.Windows.Forms.Button();
            this.lblAllStats = new System.Windows.Forms.Label();
            this.lblHunger = new System.Windows.Forms.Label();
            this.lblSanity = new System.Windows.Forms.Label();
            this.btnHungerLevel = new System.Windows.Forms.Button();
            this.btnSanityLevel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgInventory
            // 
            this.dgInventory.AllowUserToAddRows = false;
            this.dgInventory.AllowUserToDeleteRows = false;
            this.dgInventory.AllowUserToResizeColumns = false;
            this.dgInventory.AllowUserToResizeRows = false;
            this.dgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInventory.Location = new System.Drawing.Point(3, 3);
            this.dgInventory.Name = "dgInventory";
            this.dgInventory.ReadOnly = true;
            this.dgInventory.RowHeadersVisible = false;
            this.dgInventory.Size = new System.Drawing.Size(226, 269);
            this.dgInventory.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 14);
            this.progressBar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.btnSell);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.groupBox1.Location = new System.Drawing.Point(235, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(6, 237);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 27);
            this.numericUpDown1.TabIndex = 1;
            // 
            // btnSell
            // 
            this.btnSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSell.Location = new System.Drawing.Point(64, 236);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(76, 27);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.dgInventory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 295);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellSelectedToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // sellSelectedToolStripMenuItem
            // 
            this.sellSelectedToolStripMenuItem.Image = global::BlacksmithSimulator.Properties.Resources.icons8_money_bag_30;
            this.sellSelectedToolStripMenuItem.Name = "sellSelectedToolStripMenuItem";
            this.sellSelectedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sellSelectedToolStripMenuItem.Text = "Sell selected";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Image = global::BlacksmithSimulator.Properties.Resources.icons8_trash_26;
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete selected";
            this.deleteSelectedToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 334);
            this.tabControl1.TabIndex = 4;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.tableLayoutPanel1);
            this.tabInventory.Location = new System.Drawing.Point(4, 29);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(393, 301);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pBack);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(393, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stats";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pBack
            // 
            this.pBack.AutoScroll = true;
            this.pBack.Controls.Add(this.btnSanityLevel);
            this.pBack.Controls.Add(this.btnHungerLevel);
            this.pBack.Controls.Add(this.lblSanity);
            this.pBack.Controls.Add(this.lblHunger);
            this.pBack.Controls.Add(this.lblAllStats);
            this.pBack.Controls.Add(this.btnMiningLevel);
            this.pBack.Controls.Add(this.lblMining);
            this.pBack.Controls.Add(this.lblBlacksmithing);
            this.pBack.Controls.Add(this.lblLevelPoints);
            this.pBack.Controls.Add(this.btnBlacksmithingLevel);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(3, 3);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(387, 295);
            this.pBack.TabIndex = 0;
            // 
            // btnBlacksmithingLevel
            // 
            this.btnBlacksmithingLevel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBlacksmithingLevel.Location = new System.Drawing.Point(153, 41);
            this.btnBlacksmithingLevel.Name = "btnBlacksmithingLevel";
            this.btnBlacksmithingLevel.Size = new System.Drawing.Size(80, 27);
            this.btnBlacksmithingLevel.TabIndex = 0;
            this.btnBlacksmithingLevel.Text = "Level Up";
            this.btnBlacksmithingLevel.UseVisualStyleBackColor = true;
            this.btnBlacksmithingLevel.Click += new System.EventHandler(this.btnBlacksmithingLevel_Click);
            // 
            // lblLevelPoints
            // 
            this.lblLevelPoints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLevelPoints.Location = new System.Drawing.Point(5, 7);
            this.lblLevelPoints.Name = "lblLevelPoints";
            this.lblLevelPoints.Size = new System.Drawing.Size(377, 21);
            this.lblLevelPoints.TabIndex = 1;
            this.lblLevelPoints.Text = "Available Points: 99";
            this.lblLevelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlacksmithing
            // 
            this.lblBlacksmithing.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblBlacksmithing.Location = new System.Drawing.Point(5, 43);
            this.lblBlacksmithing.Name = "lblBlacksmithing";
            this.lblBlacksmithing.Size = new System.Drawing.Size(142, 25);
            this.lblBlacksmithing.TabIndex = 2;
            this.lblBlacksmithing.Text = "Blacksmithing: 99";
            // 
            // lblMining
            // 
            this.lblMining.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMining.Location = new System.Drawing.Point(5, 76);
            this.lblMining.Name = "lblMining";
            this.lblMining.Size = new System.Drawing.Size(142, 25);
            this.lblMining.TabIndex = 3;
            this.lblMining.Text = "Mining: 99";
            // 
            // btnMiningLevel
            // 
            this.btnMiningLevel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMiningLevel.Location = new System.Drawing.Point(153, 74);
            this.btnMiningLevel.Name = "btnMiningLevel";
            this.btnMiningLevel.Size = new System.Drawing.Size(80, 27);
            this.btnMiningLevel.TabIndex = 4;
            this.btnMiningLevel.Text = "Level Up";
            this.btnMiningLevel.UseVisualStyleBackColor = true;
            this.btnMiningLevel.Click += new System.EventHandler(this.btnMiningLevel_Click);
            // 
            // lblAllStats
            // 
            this.lblAllStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllStats.Location = new System.Drawing.Point(3, 183);
            this.lblAllStats.Name = "lblAllStats";
            this.lblAllStats.Size = new System.Drawing.Size(379, 110);
            this.lblAllStats.TabIndex = 5;
            this.lblAllStats.Text = "Luck:";
            // 
            // lblHunger
            // 
            this.lblHunger.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHunger.Location = new System.Drawing.Point(5, 109);
            this.lblHunger.Name = "lblHunger";
            this.lblHunger.Size = new System.Drawing.Size(142, 25);
            this.lblHunger.TabIndex = 6;
            this.lblHunger.Text = "Hunger: 100";
            // 
            // lblSanity
            // 
            this.lblSanity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSanity.Location = new System.Drawing.Point(5, 142);
            this.lblSanity.Name = "lblSanity";
            this.lblSanity.Size = new System.Drawing.Size(142, 25);
            this.lblSanity.TabIndex = 7;
            this.lblSanity.Text = "Sanity: 100";
            // 
            // btnHungerLevel
            // 
            this.btnHungerLevel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHungerLevel.Location = new System.Drawing.Point(153, 107);
            this.btnHungerLevel.Name = "btnHungerLevel";
            this.btnHungerLevel.Size = new System.Drawing.Size(80, 27);
            this.btnHungerLevel.TabIndex = 8;
            this.btnHungerLevel.Text = "Level Up";
            this.btnHungerLevel.UseVisualStyleBackColor = true;
            this.btnHungerLevel.Click += new System.EventHandler(this.btnHungerLevel_Click);
            // 
            // btnSanityLevel
            // 
            this.btnSanityLevel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSanityLevel.Location = new System.Drawing.Point(153, 140);
            this.btnSanityLevel.Name = "btnSanityLevel";
            this.btnSanityLevel.Size = new System.Drawing.Size(80, 27);
            this.btnSanityLevel.TabIndex = 9;
            this.btnSanityLevel.Text = "Level Up";
            this.btnSanityLevel.UseVisualStyleBackColor = true;
            this.btnSanityLevel.Click += new System.EventHandler(this.btnSanityLevel_Click);
            // 
            // FrmInventory
            // 
            this.ClientSize = new System.Drawing.Size(401, 334);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabInventory.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progStorage;
        private System.Windows.Forms.DataGridView dgInventory;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sellSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pBack;
        private System.Windows.Forms.Label lblLevelPoints;
        private System.Windows.Forms.Button btnBlacksmithingLevel;
        private System.Windows.Forms.Button btnMiningLevel;
        private System.Windows.Forms.Label lblMining;
        private System.Windows.Forms.Label lblBlacksmithing;
        private System.Windows.Forms.Label lblAllStats;
        private System.Windows.Forms.Button btnSanityLevel;
        private System.Windows.Forms.Button btnHungerLevel;
        private System.Windows.Forms.Label lblSanity;
        private System.Windows.Forms.Label lblHunger;
    }
}