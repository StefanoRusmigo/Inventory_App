namespace Inventory
{
    partial class Form1
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
            System.Windows.Forms.Label artifact_codeLabel;
            System.Windows.Forms.Label museum_codeLabel;
            System.Windows.Forms.Label location_district_Label;
            System.Windows.Forms.Label location_Place_Name_Label;
            System.Windows.Forms.Label gPS_coordinatesLabel;
            System.Windows.Forms.Label type_of_the_artifactLabel;
            System.Windows.Forms.Label materialLabel;
            System.Windows.Forms.Label chronologyLabel;
            System.Windows.Forms.Label based_onLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label usageLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label widthLabel;
            System.Windows.Forms.Label thicknessLabel;
            System.Windows.Forms.Label lengthLabel;
            System.Windows.Forms.Label weightLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.artifactsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.artifactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Inventory.Database1DataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.artifactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.artifactsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artifact_codeTextBox = new System.Windows.Forms.TextBox();
            this.museum_codeTextBox = new System.Windows.Forms.TextBox();
            this.location_district_ComboBox = new System.Windows.Forms.ComboBox();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet11 = new Inventory.Database1DataSet1();
            this.location_Place_Name_TextBox = new System.Windows.Forms.TextBox();
            this.gPS_coordinatesTextBox = new System.Windows.Forms.TextBox();
            this.type_of_the_artifactComboBox = new System.Windows.Forms.ComboBox();
            this.artifactTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chronologyComboBox = new System.Windows.Forms.ComboBox();
            this.chronologiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.based_onTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.artifactsTableAdapter = new Inventory.Database1DataSet1TableAdapters.ArtifactsTableAdapter();
            this.tableAdapterManager = new Inventory.Database1DataSet1TableAdapters.TableAdapterManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chronologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportInWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsTableAdapter = new Inventory.Database1DataSet1TableAdapters.LocationsTableAdapter();
            this.materialsTableAdapter = new Inventory.Database1DataSet1TableAdapters.MaterialsTableAdapter();
            this.artifactTypesTableAdapter = new Inventory.Database1DataSet1TableAdapters.ArtifactTypesTableAdapter();
            this.chronologiesTableAdapter = new Inventory.Database1DataSet1TableAdapters.ChronologiesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bibliographyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.thicknessTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            artifact_codeLabel = new System.Windows.Forms.Label();
            museum_codeLabel = new System.Windows.Forms.Label();
            location_district_Label = new System.Windows.Forms.Label();
            location_Place_Name_Label = new System.Windows.Forms.Label();
            gPS_coordinatesLabel = new System.Windows.Forms.Label();
            type_of_the_artifactLabel = new System.Windows.Forms.Label();
            materialLabel = new System.Windows.Forms.Label();
            chronologyLabel = new System.Windows.Forms.Label();
            based_onLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            usageLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            widthLabel = new System.Windows.Forms.Label();
            thicknessLabel = new System.Windows.Forms.Label();
            lengthLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.artifactsBindingNavigator)).BeginInit();
            this.artifactsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artifactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronologiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // artifact_codeLabel
            // 
            artifact_codeLabel.AutoSize = true;
            artifact_codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            artifact_codeLabel.Location = new System.Drawing.Point(538, 39);
            artifact_codeLabel.Name = "artifact_codeLabel";
            artifact_codeLabel.Size = new System.Drawing.Size(174, 31);
            artifact_codeLabel.TabIndex = 2;
            artifact_codeLabel.Text = "Artifact code:";
            // 
            // museum_codeLabel
            // 
            museum_codeLabel.AutoSize = true;
            museum_codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            museum_codeLabel.Location = new System.Drawing.Point(576, 87);
            museum_codeLabel.Name = "museum_codeLabel";
            museum_codeLabel.Size = new System.Drawing.Size(113, 20);
            museum_codeLabel.TabIndex = 4;
            museum_codeLabel.Text = "Museum code:";
            // 
            // location_district_Label
            // 
            location_district_Label.AutoSize = true;
            location_district_Label.Location = new System.Drawing.Point(7, 31);
            location_district_Label.Name = "location_district_Label";
            location_district_Label.Size = new System.Drawing.Size(87, 13);
            location_district_Label.TabIndex = 6;
            location_district_Label.Text = "Location(district):";
            // 
            // location_Place_Name_Label
            // 
            location_Place_Name_Label.AutoSize = true;
            location_Place_Name_Label.Location = new System.Drawing.Point(7, 58);
            location_Place_Name_Label.Name = "location_Place_Name_Label";
            location_Place_Name_Label.Size = new System.Drawing.Size(115, 13);
            location_Place_Name_Label.TabIndex = 8;
            location_Place_Name_Label.Text = "Location(Place Name):";
            // 
            // gPS_coordinatesLabel
            // 
            gPS_coordinatesLabel.AutoSize = true;
            gPS_coordinatesLabel.Location = new System.Drawing.Point(7, 84);
            gPS_coordinatesLabel.Name = "gPS_coordinatesLabel";
            gPS_coordinatesLabel.Size = new System.Drawing.Size(90, 13);
            gPS_coordinatesLabel.TabIndex = 10;
            gPS_coordinatesLabel.Text = "GPS coordinates:";
            // 
            // type_of_the_artifactLabel
            // 
            type_of_the_artifactLabel.AutoSize = true;
            type_of_the_artifactLabel.Location = new System.Drawing.Point(7, 63);
            type_of_the_artifactLabel.Name = "type_of_the_artifactLabel";
            type_of_the_artifactLabel.Size = new System.Drawing.Size(99, 13);
            type_of_the_artifactLabel.TabIndex = 12;
            type_of_the_artifactLabel.Text = "Type of the artifact:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new System.Drawing.Point(8, 33);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new System.Drawing.Size(47, 13);
            materialLabel.TabIndex = 14;
            materialLabel.Text = "Material:";
            // 
            // chronologyLabel
            // 
            chronologyLabel.AutoSize = true;
            chronologyLabel.Location = new System.Drawing.Point(6, 35);
            chronologyLabel.Name = "chronologyLabel";
            chronologyLabel.Size = new System.Drawing.Size(40, 13);
            chronologyLabel.TabIndex = 26;
            chronologyLabel.Text = "Period:";
            // 
            // based_onLabel
            // 
            based_onLabel.AutoSize = true;
            based_onLabel.Location = new System.Drawing.Point(6, 62);
            based_onLabel.Name = "based_onLabel";
            based_onLabel.Size = new System.Drawing.Size(55, 13);
            based_onLabel.TabIndex = 28;
            based_onLabel.Text = "Based on:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 90);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 30;
            descriptionLabel.Text = "Description:";
            descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // usageLabel
            // 
            usageLabel.AutoSize = true;
            usageLabel.Location = new System.Drawing.Point(8, 159);
            usageLabel.Name = "usageLabel";
            usageLabel.Size = new System.Drawing.Size(41, 13);
            usageLabel.TabIndex = 39;
            usageLabel.Text = "Usage:";
            usageLabel.Click += new System.EventHandler(this.usageLabel_Click);
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(10, 32);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(41, 13);
            heightLabel.TabIndex = 16;
            heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new System.Drawing.Point(166, 41);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new System.Drawing.Size(38, 13);
            widthLabel.TabIndex = 17;
            widthLabel.Text = "Width:";
            // 
            // thicknessLabel
            // 
            thicknessLabel.AutoSize = true;
            thicknessLabel.Location = new System.Drawing.Point(10, 91);
            thicknessLabel.Name = "thicknessLabel";
            thicknessLabel.Size = new System.Drawing.Size(59, 13);
            thicknessLabel.TabIndex = 18;
            thicknessLabel.Text = "Thickness:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new System.Drawing.Point(10, 62);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new System.Drawing.Size(43, 13);
            lengthLabel.TabIndex = 19;
            lengthLabel.Text = "Length:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(166, 65);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 20;
            weightLabel.Text = "Weight:";
            // 
            // artifactsBindingNavigator
            // 
            this.artifactsBindingNavigator.AddNewItem = null;
            this.artifactsBindingNavigator.BackColor = System.Drawing.SystemColors.Control;
            this.artifactsBindingNavigator.BindingSource = this.artifactsBindingSource;
            this.artifactsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.artifactsBindingNavigator.DeleteItem = null;
            this.artifactsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.artifactsBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton8,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripButton2,
            this.toolStripComboBox3,
            this.toolStripLabel3,
            this.toolStripButton1,
            this.toolStripComboBox4,
            this.toolStripLabel4,
            this.toolStripComboBox1,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.toolStripButton3,
            this.toolStripComboBox2,
            this.toolStripButton4});
            this.artifactsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.artifactsBindingNavigator.MinimumSize = new System.Drawing.Size(0, 25);
            this.artifactsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.artifactsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.artifactsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.artifactsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.artifactsBindingNavigator.Name = "artifactsBindingNavigator";
            this.artifactsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.artifactsBindingNavigator.Size = new System.Drawing.Size(1375, 25);
            this.artifactsBindingNavigator.TabIndex = 0;
            this.artifactsBindingNavigator.Text = "bindingNavigator1";
            this.artifactsBindingNavigator.RefreshItems += new System.EventHandler(this.artifactsBindingNavigator_RefreshItems);
            // 
            // artifactsBindingSource
            // 
            this.artifactsBindingSource.DataMember = "Artifacts";
            this.artifactsBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Add new";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Delete";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // artifactsBindingNavigatorSaveItem
            // 
            this.artifactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.artifactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("artifactsBindingNavigatorSaveItem.Image")));
            this.artifactsBindingNavigatorSaveItem.Name = "artifactsBindingNavigatorSaveItem";
            this.artifactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.artifactsBindingNavigatorSaveItem.Text = "Save Data";
            this.artifactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.artifactsBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "SearchByCode";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.artifactsBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "Type:";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Add new";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel3.Text = "Material:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel4.Text = "Location";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel6.Text = "Chronology:";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Add new";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton4.Text = "Submit";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // artifactsDataGridView
            // 
            this.artifactsDataGridView.AutoGenerateColumns = false;
            this.artifactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artifactsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.artifactsDataGridView.DataSource = this.artifactsBindingSource;
            this.artifactsDataGridView.Location = new System.Drawing.Point(7, 523);
            this.artifactsDataGridView.Name = "artifactsDataGridView";
            this.artifactsDataGridView.Size = new System.Drawing.Size(1348, 175);
            this.artifactsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Artifact_code";
            this.dataGridViewTextBoxColumn1.HeaderText = "Artifact_code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Museum_code";
            this.dataGridViewTextBoxColumn2.HeaderText = "Museum_code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location(district)";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location(district)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Location(Place Name)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Location(Place Name)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GPS_coordinates";
            this.dataGridViewTextBoxColumn5.HeaderText = "GPS_coordinates";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Type_of_the_artifact";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type_of_the_artifact";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn7.HeaderText = "Material";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Chronology";
            this.dataGridViewTextBoxColumn13.HeaderText = "Chronology";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Height";
            this.dataGridViewTextBoxColumn8.HeaderText = "Height";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Width";
            this.dataGridViewTextBoxColumn14.HeaderText = "Width";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn15.HeaderText = "Length";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Thickness";
            this.dataGridViewTextBoxColumn16.HeaderText = "Thickness";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn17.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // artifact_codeTextBox
            // 
            this.artifact_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Artifact_code", true));
            this.artifact_codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artifact_codeTextBox.Location = new System.Drawing.Point(736, 37);
            this.artifact_codeTextBox.Name = "artifact_codeTextBox";
            this.artifact_codeTextBox.Size = new System.Drawing.Size(121, 38);
            this.artifact_codeTextBox.TabIndex = 3;
            this.artifact_codeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.artifact_codeTextBox.TextChanged += new System.EventHandler(this.artifact_codeTextBox_TextChanged);
            // 
            // museum_codeTextBox
            // 
            this.museum_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Museum_code", true));
            this.museum_codeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.museum_codeTextBox.Location = new System.Drawing.Point(736, 87);
            this.museum_codeTextBox.Name = "museum_codeTextBox";
            this.museum_codeTextBox.Size = new System.Drawing.Size(95, 26);
            this.museum_codeTextBox.TabIndex = 5;
            this.museum_codeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // location_district_ComboBox
            // 
            this.location_district_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Location(district)", true));
            this.location_district_ComboBox.DataSource = this.locationsBindingSource;
            this.location_district_ComboBox.DisplayMember = "name";
            this.location_district_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.location_district_ComboBox.FormattingEnabled = true;
            this.location_district_ComboBox.Location = new System.Drawing.Point(128, 28);
            this.location_district_ComboBox.Name = "location_district_ComboBox";
            this.location_district_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.location_district_ComboBox.TabIndex = 7;
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            this.locationsBindingSource.DataSource = this.database1DataSet11;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet1";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // location_Place_Name_TextBox
            // 
            this.location_Place_Name_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Location(Place Name)", true));
            this.location_Place_Name_TextBox.Location = new System.Drawing.Point(128, 55);
            this.location_Place_Name_TextBox.Name = "location_Place_Name_TextBox";
            this.location_Place_Name_TextBox.Size = new System.Drawing.Size(121, 20);
            this.location_Place_Name_TextBox.TabIndex = 9;
            // 
            // gPS_coordinatesTextBox
            // 
            this.gPS_coordinatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "GPS_coordinates", true));
            this.gPS_coordinatesTextBox.Location = new System.Drawing.Point(128, 81);
            this.gPS_coordinatesTextBox.Name = "gPS_coordinatesTextBox";
            this.gPS_coordinatesTextBox.Size = new System.Drawing.Size(121, 20);
            this.gPS_coordinatesTextBox.TabIndex = 11;
            // 
            // type_of_the_artifactComboBox
            // 
            this.type_of_the_artifactComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Type_of_the_artifact", true));
            this.type_of_the_artifactComboBox.DataSource = this.artifactTypesBindingSource;
            this.type_of_the_artifactComboBox.DisplayMember = "type";
            this.type_of_the_artifactComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_of_the_artifactComboBox.FormattingEnabled = true;
            this.type_of_the_artifactComboBox.Location = new System.Drawing.Point(128, 60);
            this.type_of_the_artifactComboBox.Name = "type_of_the_artifactComboBox";
            this.type_of_the_artifactComboBox.Size = new System.Drawing.Size(183, 21);
            this.type_of_the_artifactComboBox.TabIndex = 13;
            // 
            // artifactTypesBindingSource
            // 
            this.artifactTypesBindingSource.DataMember = "ArtifactTypes";
            this.artifactTypesBindingSource.DataSource = this.database1DataSet11;
            // 
            // materialComboBox
            // 
            this.materialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Material", true));
            this.materialComboBox.DataSource = this.materialsBindingSource;
            this.materialComboBox.DisplayMember = "Name";
            this.materialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(129, 30);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(182, 21);
            this.materialComboBox.TabIndex = 15;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "Materials";
            this.materialsBindingSource.DataSource = this.database1DataSet11;
            // 
            // chronologyComboBox
            // 
            this.chronologyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Chronology", true));
            this.chronologyComboBox.DataSource = this.chronologiesBindingSource;
            this.chronologyComboBox.DisplayMember = "Chronology";
            this.chronologyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chronologyComboBox.FormattingEnabled = true;
            this.chronologyComboBox.Location = new System.Drawing.Point(127, 32);
            this.chronologyComboBox.Name = "chronologyComboBox";
            this.chronologyComboBox.Size = new System.Drawing.Size(173, 21);
            this.chronologyComboBox.TabIndex = 27;
            // 
            // chronologiesBindingSource
            // 
            this.chronologiesBindingSource.DataMember = "Chronologies";
            this.chronologiesBindingSource.DataSource = this.database1DataSet11;
            // 
            // based_onTextBox
            // 
            this.based_onTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Based_on", true));
            this.based_onTextBox.Location = new System.Drawing.Point(127, 59);
            this.based_onTextBox.Multiline = true;
            this.based_onTextBox.Name = "based_onTextBox";
            this.based_onTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.based_onTextBox.Size = new System.Drawing.Size(173, 41);
            this.based_onTextBox.TabIndex = 29;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(127, 90);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(184, 62);
            this.descriptionTextBox.TabIndex = 31;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.artifactsBindingSource, "Image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(20, 23);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(284, 171);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 33;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // artifactsTableAdapter
            // 
            this.artifactsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtifactsTableAdapter = this.artifactsTableAdapter;
            this.tableAdapterManager.ArtifactTypesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChronologiesTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inventory.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportInWordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.materialToolStripMenuItem,
            this.chronologyToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // materialToolStripMenuItem
            // 
            this.materialToolStripMenuItem.Name = "materialToolStripMenuItem";
            this.materialToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.materialToolStripMenuItem.Text = "Material";
            this.materialToolStripMenuItem.Click += new System.EventHandler(this.materialToolStripMenuItem_Click);
            // 
            // chronologyToolStripMenuItem
            // 
            this.chronologyToolStripMenuItem.Name = "chronologyToolStripMenuItem";
            this.chronologyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.chronologyToolStripMenuItem.Text = "Chronology";
            this.chronologyToolStripMenuItem.Click += new System.EventHandler(this.chronologyToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // exportInWordToolStripMenuItem
            // 
            this.exportInWordToolStripMenuItem.Name = "exportInWordToolStripMenuItem";
            this.exportInWordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportInWordToolStripMenuItem.Text = "Export in Word";
            this.exportInWordToolStripMenuItem.Click += new System.EventHandler(this.exportInWordToolStripMenuItem_Click);
            // 
            // locationsTableAdapter
            // 
            this.locationsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // artifactTypesTableAdapter
            // 
            this.artifactTypesTableAdapter.ClearBeforeFill = true;
            // 
            // chronologiesTableAdapter
            // 
            this.chronologiesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gPS_coordinatesTextBox);
            this.groupBox1.Controls.Add(gPS_coordinatesLabel);
            this.groupBox1.Controls.Add(this.location_Place_Name_TextBox);
            this.groupBox1.Controls.Add(location_Place_Name_Label);
            this.groupBox1.Controls.Add(this.location_district_ComboBox);
            this.groupBox1.Controls.Add(location_district_Label);
            this.groupBox1.Location = new System.Drawing.Point(99, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 117);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(type_of_the_artifactLabel);
            this.groupBox2.Controls.Add(this.materialComboBox);
            this.groupBox2.Controls.Add(usageLabel);
            this.groupBox2.Controls.Add(this.type_of_the_artifactComboBox);
            this.groupBox2.Controls.Add(this.usageTextBox);
            this.groupBox2.Controls.Add(descriptionLabel);
            this.groupBox2.Controls.Add(materialLabel);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Location = new System.Drawing.Point(531, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 241);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // usageTextBox
            // 
            this.usageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Usage", true));
            this.usageTextBox.Location = new System.Drawing.Point(127, 159);
            this.usageTextBox.Multiline = true;
            this.usageTextBox.Name = "usageTextBox";
            this.usageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usageTextBox.Size = new System.Drawing.Size(183, 65);
            this.usageTextBox.TabIndex = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(based_onLabel);
            this.groupBox4.Controls.Add(this.based_onTextBox);
            this.groupBox4.Controls.Add(this.chronologyComboBox);
            this.groupBox4.Controls.Add(chronologyLabel);
            this.groupBox4.Location = new System.Drawing.Point(99, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 111);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chronology";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.imagePictureBox);
            this.groupBox5.Location = new System.Drawing.Point(948, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(329, 244);
            this.groupBox5.TabIndex = 39;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Image";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Browse..";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bibliographyTextBox
            // 
            this.bibliographyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Bibliography", true));
            this.bibliographyTextBox.Location = new System.Drawing.Point(129, 22);
            this.bibliographyTextBox.Multiline = true;
            this.bibliographyTextBox.Name = "bibliographyTextBox";
            this.bibliographyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bibliographyTextBox.Size = new System.Drawing.Size(188, 72);
            this.bibliographyTextBox.TabIndex = 41;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bibliographyTextBox);
            this.groupBox6.Location = new System.Drawing.Point(531, 401);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(326, 112);
            this.groupBox6.TabIndex = 42;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bibliography";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Height", true));
            this.heightTextBox.Location = new System.Drawing.Point(93, 32);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(44, 20);
            this.heightTextBox.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(weightLabel);
            this.groupBox3.Controls.Add(this.weightTextBox);
            this.groupBox3.Controls.Add(lengthLabel);
            this.groupBox3.Controls.Add(this.lengthTextBox);
            this.groupBox3.Controls.Add(thicknessLabel);
            this.groupBox3.Controls.Add(this.thicknessTextBox);
            this.groupBox3.Controls.Add(widthLabel);
            this.groupBox3.Controls.Add(this.widthTextBox);
            this.groupBox3.Controls.Add(this.heightTextBox);
            this.groupBox3.Controls.Add(heightLabel);
            this.groupBox3.Location = new System.Drawing.Point(99, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 112);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Attributes";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(224, 62);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(44, 20);
            this.weightTextBox.TabIndex = 21;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Length", true));
            this.lengthTextBox.Location = new System.Drawing.Point(93, 58);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(44, 20);
            this.lengthTextBox.TabIndex = 20;
            // 
            // thicknessTextBox
            // 
            this.thicknessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Thickness", true));
            this.thicknessTextBox.Location = new System.Drawing.Point(93, 84);
            this.thicknessTextBox.Name = "thicknessTextBox";
            this.thicknessTextBox.Size = new System.Drawing.Size(44, 20);
            this.thicknessTextBox.TabIndex = 19;
            // 
            // widthTextBox
            // 
            this.widthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artifactsBindingSource, "Width", true));
            this.widthTextBox.Location = new System.Drawing.Point(224, 34);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(44, 20);
            this.widthTextBox.TabIndex = 18;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.ToolTipText = "Export to word";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1375, 698);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(artifact_codeLabel);
            this.Controls.Add(this.artifact_codeTextBox);
            this.Controls.Add(museum_codeLabel);
            this.Controls.Add(this.museum_codeTextBox);
            this.Controls.Add(this.artifactsDataGridView);
            this.Controls.Add(this.artifactsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artifactsBindingNavigator)).EndInit();
            this.artifactsBindingNavigator.ResumeLayout(false);
            this.artifactsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artifactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artifactTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chronologiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource artifactsBindingSource;
        private Database1DataSet1TableAdapters.ArtifactsTableAdapter artifactsTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator artifactsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton artifactsBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.DataGridView artifactsDataGridView;
        private System.Windows.Forms.TextBox artifact_codeTextBox;
        private System.Windows.Forms.TextBox museum_codeTextBox;
        private System.Windows.Forms.ComboBox location_district_ComboBox;
        private System.Windows.Forms.TextBox location_Place_Name_TextBox;
        private System.Windows.Forms.TextBox gPS_coordinatesTextBox;
        private System.Windows.Forms.ComboBox type_of_the_artifactComboBox;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.ComboBox chronologyComboBox;
        private System.Windows.Forms.TextBox based_onTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chronologyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Database1DataSet1 database1DataSet11;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private Database1DataSet1TableAdapters.LocationsTableAdapter locationsTableAdapter;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private Database1DataSet1TableAdapters.MaterialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.BindingSource artifactTypesBindingSource;
        private Database1DataSet1TableAdapters.ArtifactTypesTableAdapter artifactTypesTableAdapter;
        private System.Windows.Forms.BindingSource chronologiesBindingSource;
        private Database1DataSet1TableAdapters.ChronologiesTableAdapter chronologiesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox usageTextBox;
        private System.Windows.Forms.TextBox bibliographyTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox thicknessTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripMenuItem exportInWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

