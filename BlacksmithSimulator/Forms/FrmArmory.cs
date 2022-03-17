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
    public partial class FrmArmory : Form
    { 
        //
        // Discontinued
        //
        PictureBox picSlot, picSlot2, picSlot3, picSlot4, picSlot5, picSlot6;
        public FrmArmory()
        {
            InitializeComponent();
            picSlot = new PictureBox();
            picSlot.Anchor = AnchorStyles.None;
            picSlot.Parent = picPlayerShadow;
            picSlot.Location = new Point(20, 30);
            picSlot.Size = new Size(40, 40);
            picSlot.BackColor = Color.FromArgb(30, 30, 30);

            picSlot2 = new PictureBox();
            picSlot2.Anchor = AnchorStyles.None;
            picSlot2.Parent = picPlayerShadow;
            picSlot2.Location = new Point(85, 110);
            picSlot2.Size = new Size(40, 40);
            picSlot2.BackColor = Color.FromArgb(30, 30, 30);

            picSlot3 = new PictureBox();
            picSlot3.Anchor = AnchorStyles.None;
            picSlot3.Parent = picPlayerShadow;
            picSlot3.Location = new Point(75, 175);
            picSlot3.Size = new Size(40, 40);
            picSlot3.BackColor = Color.FromArgb(30,30,30);

            picSlot4 = new PictureBox();
            picSlot4.Anchor = AnchorStyles.None;
            picSlot4.Parent = picPlayerShadow;
            picSlot4.Location = new Point(160, 20);
            picSlot4.Size = new Size(40, 40);
            picSlot4.BackColor = Color.FromArgb(30, 30, 30);

            picSlot5 = new PictureBox();
            picSlot5.Anchor = AnchorStyles.None;
            picSlot5.Parent = picPlayerShadow;
            picSlot5.Location = new Point(160, 65);
            picSlot5.Size = new Size(40, 40);
            picSlot5.BackColor = Color.FromArgb(30, 30, 30);

            picSlot6 = new PictureBox();
            picSlot6.Anchor = AnchorStyles.None;
            picSlot6.Parent = picPlayerShadow;
            picSlot6.Location = new Point(75, 65);
            picSlot6.Size = new Size(40, 40);
            picSlot6.BackColor = Color.FromArgb(30, 30, 30);
        }
    }
}