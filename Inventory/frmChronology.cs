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
    public partial class frmChronology : Form
    {
        public frmChronology()
        {
            InitializeComponent();
        }

        private void chronologiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chronologiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
     


        }

        private void frmChronology_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Chronologies' table. You can move, or remove it, as needed.
            this.chronologiesTableAdapter.Fill(this.database1DataSet1.Chronologies);

        }
    }
}
