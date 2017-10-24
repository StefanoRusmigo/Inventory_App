using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmMaterial : Form
    {
        public frmMaterial()
        {
            InitializeComponent();
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.database1DataSet1.Materials);

        }
    }
}
