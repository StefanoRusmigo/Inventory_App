using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;


namespace Inventory
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void artifactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artifactsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void artifactsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
 
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    
                    string path1 = textBox1.Text;
                    string fileName = Path.GetFileName(path1);
                    string path2 = AppDomain.CurrentDomain.BaseDirectory + "images/" + artifact_codeTextBox.Text + ".jpg";
                    File.Copy(path1, path2);
                    imagePictureBox.Image = Image.FromFile(path2);


                }
                textBox1.Clear();

                this.Validate();
                this.artifactsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet1);

                System.Windows.Forms.MessageBox.Show("Updated Record");

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.Chronologies' table. You can move, or remove it, as needed.
            this.chronologiesTableAdapter.Fill(this.database1DataSet11.Chronologies);
            // TODO: This line of code loads data into the 'database1DataSet11.ArtifactTypes' table. You can move, or remove it, as needed.
            this.artifactTypesTableAdapter.Fill(this.database1DataSet11.ArtifactTypes);
            // TODO: This line of code loads data into the 'database1DataSet11.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.database1DataSet11.Materials);
            // TODO: This line of code loads data into the 'database1DataSet11.Locations' table. You can move, or remove it, as needed.
            this.locationsTableAdapter.Fill(this.database1DataSet11.Locations);
            // TODO: This line of code loads data into the 'database1DataSet1.Artifacts' table. You can move, or remove it, as needed.
            this.artifactsTableAdapter.Fill(this.database1DataSet1.Artifacts);

            textBox1.Clear();

            toolStripComboBox1.ComboBox.Items.Clear();
            toolStripComboBox2.ComboBox.Items.Clear();
            toolStripComboBox3.ComboBox.Items.Clear();
            toolStripComboBox4.ComboBox.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //type
            cmd.CommandText = "SELECT type FROM ArtifactTypes";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                toolStripComboBox3.ComboBox.Items.Add(dr1["type"].ToString().Trim());
            }
            //location
            cmd.CommandText = "SELECT name FROM Locations";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                toolStripComboBox1.ComboBox.Items.Add(dr2["name"].ToString().Trim());
            }

            cmd.CommandText = "SELECT name FROM Materials";
            cmd.ExecuteNonQuery();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(cmd);
            da3.Fill(dt3);
            foreach (DataRow dr3 in dt3.Rows)
            {
                toolStripComboBox4.ComboBox.Items.Add(dr3["name"].ToString().Trim());
            }

            cmd.CommandText = "SELECT Chronology FROM Chronologies";
            cmd.ExecuteNonQuery();
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter(cmd);
            da4.Fill(dt4);
            foreach (DataRow dr4 in dt4.Rows)
            {
                toolStripComboBox2.ComboBox.Items.Add(dr4["Chronology"].ToString().Trim());
            }

            con.Close();
            //focus
            artifact_codeTextBox.Focus();

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            artifactsBindingSource.Filter = "Artifact_code LIKE '" + "%" + toolStripTextBox1.Text + "%'";


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var formType = new frmType();
            formType.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var formType = new frmMaterial();
            formType.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var formType = new frmChronology();
            formType.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (toolStripButton4.Text == "Submit")
            {
                try
                {
                    this.artifactsTableAdapter.FillByMultibleFilters(this.database1DataSet1.Artifacts, toolStripComboBox3.Text, toolStripComboBox4.Text, toolStripComboBox1.Text, toolStripComboBox2.Text);
                    toolStripButton4.Text = "Clear";
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
            else if (toolStripButton4.Text == "Clear")
            {
                Form1_Load(e, e);

                toolStripButton4.Text = "Submit";
            }
        }


        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void artifactsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form1_Load(e, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(e, e);

        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formType = new frmType();
            formType.Show();
        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMaterial = new frmMaterial();
            formMaterial.Show();
        }

        private void chronologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formChrono = new frmChronology();
            formChrono.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                   openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
                try
                {
                    imagePictureBox.Image = Image.FromFile(textBox1.Text);

                }
                catch
                {
                    textBox1.Text = "";
                }
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void usageLabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }



        private void artifact_codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }



        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.artifactsBindingSource.AddNew();


            location_district_ComboBox.SelectedIndex = -1;
            chronologyComboBox.SelectedIndex = -1;
            materialComboBox.SelectedIndex = -1;
            type_of_the_artifactComboBox.SelectedIndex = -1;

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            DialogResult myResult;
            myResult = MessageBox.Show("Are you really delete the item?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                this.artifactsBindingSource.RemoveCurrent();
                this.Validate();
                this.artifactsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet1);

            }
            else
            {
                //No delete
            }


        }



        private void exportInWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */


            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;


            object oTemplate = AppDomain.CurrentDomain.BaseDirectory + "template.docx";
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing,
            ref oMissing, ref oMissing);

            object oBookMark = "artifact_code";
            Word.Bookmark bkm = oDoc.Bookmarks.get_Item(ref oBookMark);
            bkm.Range.Text = artifact_codeTextBox.Text;

            object oBookMark1 = "museum_code";
            Word.Bookmark bkm1 = oDoc.Bookmarks.get_Item(ref oBookMark1);
            bkm1.Range.Text = museum_codeTextBox.Text;

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "images/" + artifact_codeTextBox.Text + ".jpg"))
            {
                object oBookMark2 = "image";
                Word.Bookmark bkm2 = oDoc.Bookmarks.get_Item(ref oBookMark2);
                object oRange = bkm2.Range;
                object saveWithDocument = true;
                string pictureName = AppDomain.CurrentDomain.BaseDirectory + "images/" + artifact_codeTextBox.Text + ".jpg";

                var shape = oDoc.InlineShapes.AddPicture(pictureName, ref oMissing, ref saveWithDocument, ref oRange);
                shape.Width = 200;
                shape.Height = 150;

            }

            object oBookMark3 = "district";
            Word.Bookmark bkm3 = oDoc.Bookmarks.get_Item(ref oBookMark3);
            bkm3.Range.Text = location_district_ComboBox.Text;

            object oBookMark4 = "place_name";
            Word.Bookmark bkm4 = oDoc.Bookmarks.get_Item(ref oBookMark4);
            bkm4.Range.Text = location_Place_Name_TextBox.Text;

            object oBookMark5 = "coordinates";
            Word.Bookmark bkm5 = oDoc.Bookmarks.get_Item(ref oBookMark5);
            bkm5.Range.Text = gPS_coordinatesTextBox.Text;

            object oBookMark6 = "material";
            Word.Bookmark bkm6 = oDoc.Bookmarks.get_Item(ref oBookMark6);
            bkm6.Range.Text = materialComboBox.Text;

            object oBookMark7 = "type";
            Word.Bookmark bkm7 = oDoc.Bookmarks.get_Item(ref oBookMark7);
            bkm7.Range.Text = type_of_the_artifactComboBox.Text;

            object oBookMark8 = "chrono";
            Word.Bookmark bkm8 = oDoc.Bookmarks.get_Item(ref oBookMark8);
            bkm8.Range.Text = chronologyComboBox.Text;


            object oBookMark9 = "based_on";
            Word.Bookmark bkm9 = oDoc.Bookmarks.get_Item(ref oBookMark9);
            bkm9.Range.Text = based_onTextBox.Text;

            object oBookMark10 = "height";
            Word.Bookmark bkm10 = oDoc.Bookmarks.get_Item(ref oBookMark10);
            bkm10.Range.Text = heightTextBox.Text;

            object oBookMark11 = "width";
            Word.Bookmark bkm11 = oDoc.Bookmarks.get_Item(ref oBookMark11);
            bkm11.Range.Text = widthTextBox.Text;

            object oBookMark12 = "length";
            Word.Bookmark bkm12 = oDoc.Bookmarks.get_Item(ref oBookMark12);
            bkm12.Range.Text = lengthTextBox.Text;

            object oBookMark13 = "thick";
            Word.Bookmark bkm13 = oDoc.Bookmarks.get_Item(ref oBookMark13);
            bkm13.Range.Text = thicknessTextBox.Text;

            object oBookMark14 = "weight";
            Word.Bookmark bkm14 = oDoc.Bookmarks.get_Item(ref oBookMark14);
            bkm14.Range.Text = weightTextBox.Text;

            object oBookMark15 = "description";
            Word.Bookmark bkm15 = oDoc.Bookmarks.get_Item(ref oBookMark15);
            bkm15.Range.Text = descriptionTextBox.Text;

            object oBookMark16 = "usage";
            Word.Bookmark bkm16 = oDoc.Bookmarks.get_Item(ref oBookMark16);
            bkm16.Range.Text = usageTextBox.Text;

            object oBookMark17 = "bibliography";
            Word.Bookmark bkm17 = oDoc.Bookmarks.get_Item(ref oBookMark17);
            bkm17.Range.Text = bibliographyTextBox.Text;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */


            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;


            object oTemplate = AppDomain.CurrentDomain.BaseDirectory + "template.docx";
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing,
            ref oMissing, ref oMissing);

            object oBookMark = "artifact_code";
            Word.Bookmark bkm = oDoc.Bookmarks.get_Item(ref oBookMark);
            bkm.Range.Text = artifact_codeTextBox.Text;

            object oBookMark1 = "museum_code";
            Word.Bookmark bkm1 = oDoc.Bookmarks.get_Item(ref oBookMark1);
            bkm1.Range.Text = museum_codeTextBox.Text;

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "images/" + artifact_codeTextBox.Text + ".jpg"))
            {
                object oBookMark2 = "image";
                Word.Bookmark bkm2 = oDoc.Bookmarks.get_Item(ref oBookMark2);
                object oRange = bkm2.Range;
                object saveWithDocument = true;
                string pictureName = AppDomain.CurrentDomain.BaseDirectory + "images/" + artifact_codeTextBox.Text + ".jpg";

                var shape = oDoc.InlineShapes.AddPicture(pictureName, ref oMissing, ref saveWithDocument, ref oRange);
                shape.Width = 200;
                shape.Height = 150;

            }

            object oBookMark3 = "district";
            Word.Bookmark bkm3 = oDoc.Bookmarks.get_Item(ref oBookMark3);
            bkm3.Range.Text = location_district_ComboBox.Text;

            object oBookMark4 = "place_name";
            Word.Bookmark bkm4 = oDoc.Bookmarks.get_Item(ref oBookMark4);
            bkm4.Range.Text = location_Place_Name_TextBox.Text;

            object oBookMark5 = "coordinates";
            Word.Bookmark bkm5 = oDoc.Bookmarks.get_Item(ref oBookMark5);
            bkm5.Range.Text = gPS_coordinatesTextBox.Text;

            object oBookMark6 = "material";
            Word.Bookmark bkm6 = oDoc.Bookmarks.get_Item(ref oBookMark6);
            bkm6.Range.Text = materialComboBox.Text;

            object oBookMark7 = "type";
            Word.Bookmark bkm7 = oDoc.Bookmarks.get_Item(ref oBookMark7);
            bkm7.Range.Text = type_of_the_artifactComboBox.Text;

            object oBookMark8 = "chrono";
            Word.Bookmark bkm8 = oDoc.Bookmarks.get_Item(ref oBookMark8);
            bkm8.Range.Text = chronologyComboBox.Text;


            object oBookMark9 = "based_on";
            Word.Bookmark bkm9 = oDoc.Bookmarks.get_Item(ref oBookMark9);
            bkm9.Range.Text = based_onTextBox.Text;

            object oBookMark10 = "height";
            Word.Bookmark bkm10 = oDoc.Bookmarks.get_Item(ref oBookMark10);
            bkm10.Range.Text = heightTextBox.Text;

            object oBookMark11 = "width";
            Word.Bookmark bkm11 = oDoc.Bookmarks.get_Item(ref oBookMark11);
            bkm11.Range.Text = widthTextBox.Text;

            object oBookMark12 = "length";
            Word.Bookmark bkm12 = oDoc.Bookmarks.get_Item(ref oBookMark12);
            bkm12.Range.Text = lengthTextBox.Text;

            object oBookMark13 = "thick";
            Word.Bookmark bkm13 = oDoc.Bookmarks.get_Item(ref oBookMark13);
            bkm13.Range.Text = thicknessTextBox.Text;

            object oBookMark14 = "weight";
            Word.Bookmark bkm14 = oDoc.Bookmarks.get_Item(ref oBookMark14);
            bkm14.Range.Text = weightTextBox.Text;

            object oBookMark15 = "description";
            Word.Bookmark bkm15 = oDoc.Bookmarks.get_Item(ref oBookMark15);
            bkm15.Range.Text = descriptionTextBox.Text;

            object oBookMark16 = "usage";
            Word.Bookmark bkm16 = oDoc.Bookmarks.get_Item(ref oBookMark16);
            bkm16.Range.Text = usageTextBox.Text;

            object oBookMark17 = "bibliography";
            Word.Bookmark bkm17 = oDoc.Bookmarks.get_Item(ref oBookMark17);
            bkm17.Range.Text = bibliographyTextBox.Text;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (!String.IsNullOrEmpty(textBox1.Text))
                {

                    string path1 = textBox1.Text;
                    string fileName = Path.GetFileName(path1);
                    string path2 = AppDomain.CurrentDomain.BaseDirectory + "images/" + artifact_codeTextBox.Text + ".jpg";
                    File.Copy(path1, path2);
                    imagePictureBox.Image = Image.FromFile(path2);


                }
                textBox1.Clear();

                this.Validate();
                this.artifactsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet1);

                System.Windows.Forms.MessageBox.Show("Updated Record");

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
