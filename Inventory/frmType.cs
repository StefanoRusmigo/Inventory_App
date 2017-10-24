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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        private void artifactTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artifactTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void frmType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.ArtifactTypes' table. You can move, or remove it, as needed.
            this.artifactTypesTableAdapter.Fill(this.database1DataSet1.ArtifactTypes);

        }

        private void artifactTypesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
