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
                this.Validate();
                this.artifactsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet1);
                textBox1.Clear();
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
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
            imagePictureBox.Image = Image.FromFile(textBox1.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);

            //Insert a paragraph at the beginning of the document.
            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = "\bArtifact Code: " + artifact_codeTextBox.Text + Environment.NewLine +
            "Museum Code: " + museum_codeTextBox.Text; 
            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 6;    //6 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter();



            //Insert another paragraph.
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;

            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.InsertParagraphBefore();
      
            oPara3.Range.Text = "Location:" + System.Environment.NewLine + 
                "Location(district): " + location_district_ComboBox.Text + System.Environment.NewLine +
                "Location(place name): " + location_Place_Name_TextBox.Text + Environment.NewLine +
                "Coordinates: " + gPS_coordinatesTextBox.Text ;
            oPara3.Range.Font.Bold = 0;
            oPara3.Format.SpaceAfter = 6;
            oPara3.Range.InsertParagraphAfter();

            //Insert another paragraph.
            Word.Paragraph oPara4;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara4.Range.InsertParagraphBefore();
            oPara4.Range.Text = "Attributes:" + System.Environment.NewLine +
                "Material: " + materialComboBox.Text + System.Environment.NewLine +
                "Type of the artifact: " + type_of_the_artifactComboBox.Text + Environment.NewLine +
                "Description: " + descriptionTextBox.Text + Environment.NewLine +
                "Usage: " + usageTextBox.Text;
            oPara4.Format.SpaceAfter =6;
            oPara4.Range.InsertParagraphAfter();



            //Insert another paragraph.
            Word.Paragraph oPara5;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara5 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara5.Range.InsertParagraphBefore();
            oPara5.Range.Text = "Chronology:" + Environment.NewLine +
                "Period: " + chronologyComboBox.Text + Environment.NewLine +
                "Based on: " + based_onTextBox.Text;
            oPara5.Format.SpaceAfter = 6;
            oPara5.Range.InsertParagraphAfter();


            //Insert another paragraph.
            Word.Paragraph oPara6;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara6 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara6.Range.InsertParagraphBefore();
            oPara6.Range.Text = "Dimentions:" + Environment.NewLine +
                "Height: " + heightTextBox.Text + Environment.NewLine +
                "Width: " + widthTextBox.Text + Environment.NewLine +
                "Length: " + lengthTextBox.Text + Environment.NewLine +
                "Thickness: " + thicknessTextBox.Text + Environment.NewLine +
                "Weight: " + weightTextBox.Text;
            oPara6.Format.SpaceAfter = 6;
            oPara6.Range.InsertParagraphAfter();


            //Insert another paragraph.
            Word.Paragraph oPara7;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara7 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara7.Range.InsertParagraphBefore();
            oPara7.Range.Text = "Bibliography: " + bibliographyTextBox.Text;
            oPara7.Format.SpaceAfter = 6;
            oPara7.Range.InsertParagraphAfter();

            //Close this form.
            this.Close();
        }

        private void artifact_codeTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */


            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;


            object oTemplate = "C:/Users/Stefa/documents/visual studio 2017/Projects/inventory/Inventory/template.docx";
            oDoc = oWord.Documents.Add(ref oTemplate, ref oMissing,
            ref oMissing, ref oMissing);

            object oBookMark = "artifact_code";
            Word.Bookmark bkm = oDoc.Bookmarks.get_Item(ref oBookMark);
            bkm.Range.Text = artifact_codeTextBox.Text;

            object oBookMark1 = "museum_code";
            Word.Bookmark bkm1 = oDoc.Bookmarks.get_Item(ref oBookMark1);
            bkm1.Range.Text = museum_codeTextBox.Text;


            object oBookMark2 = "image";
            Word.Bookmark bkm2 = oDoc.Bookmarks.get_Item(ref oBookMark2);
            object oRange = bkm2.Range;
            object saveWithDocument = true;
            string pictureName = imagePictureBox.ImageLocation;
            oDoc.InlineShapes.AddPicture(pictureName, ref oMissing, ref saveWithDocument, ref oRange);
        }
    }
}
