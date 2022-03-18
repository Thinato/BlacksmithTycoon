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
        ItemList items;
        public FrmInventory()
        {
            InitializeComponent();
            items = new ItemList();
            MessageBox.Show($"{items.Items[0].Name}\n{items.Items[0].Description}\n{items.Items[0].Value}\n{items.Items[0].Ingredients}");
        }

        private void deleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {

            }
        }
    }
}
