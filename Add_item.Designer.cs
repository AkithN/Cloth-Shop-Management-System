namespace Course_Work_GAD
{
    partial class Add_item
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_removeS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblitemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLSHOPDataSet = new Course_Work_GAD.CLSHOPDataSet();
            this.btnviwe = new System.Windows.Forms.Button();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.lbl_pno = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lpl_price = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.txt_pno = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.numericUpDown_qty = new System.Windows.Forms.NumericUpDown();
            this.btn_iback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblitemTableAdapter = new Course_Work_GAD.CLSHOPDataSetTableAdapters.tblitemTableAdapter();
            this.btn_browse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Black;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_update.Location = new System.Drawing.Point(657, 82);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(189, 52);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update Items";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_removeS
            // 
            this.btn_removeS.BackColor = System.Drawing.Color.Black;
            this.btn_removeS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_removeS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_removeS.Location = new System.Drawing.Point(886, 82);
            this.btn_removeS.Margin = new System.Windows.Forms.Padding(4);
            this.btn_removeS.Name = "btn_removeS";
            this.btn_removeS.Size = new System.Drawing.Size(189, 52);
            this.btn_removeS.TabIndex = 1;
            this.btn_removeS.Text = "Remove Items";
            this.btn_removeS.UseVisualStyleBackColor = false;
            this.btn_removeS.Click += new System.EventHandler(this.btn_removeS_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.icodeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn,
            this.photoUrlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblitemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(501, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 200;
            this.dataGridView1.Size = new System.Drawing.Size(893, 434);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // icodeDataGridViewTextBoxColumn
            // 
            this.icodeDataGridViewTextBoxColumn.DataPropertyName = "icode";
            this.icodeDataGridViewTextBoxColumn.HeaderText = "icode";
            this.icodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.icodeDataGridViewTextBoxColumn.Name = "icodeDataGridViewTextBoxColumn";
            this.icodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.icodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.FillWeight = 50F;
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.photoDataGridViewImageColumn.MinimumWidth = 6;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            this.photoDataGridViewImageColumn.Width = 250;
            // 
            // photoUrlDataGridViewTextBoxColumn
            // 
            this.photoUrlDataGridViewTextBoxColumn.DataPropertyName = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.HeaderText = "PhotoUrl";
            this.photoUrlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.photoUrlDataGridViewTextBoxColumn.Name = "photoUrlDataGridViewTextBoxColumn";
            this.photoUrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.photoUrlDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblitemBindingSource
            // 
            this.tblitemBindingSource.DataMember = "tblitem";
            this.tblitemBindingSource.DataSource = this.cLSHOPDataSet;
            // 
            // cLSHOPDataSet
            // 
            this.cLSHOPDataSet.DataSetName = "CLSHOPDataSet";
            this.cLSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnviwe
            // 
            this.btnviwe.BackColor = System.Drawing.Color.Black;
            this.btnviwe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnviwe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviwe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnviwe.Location = new System.Drawing.Point(1195, 618);
            this.btnviwe.Margin = new System.Windows.Forms.Padding(4);
            this.btnviwe.Name = "btnviwe";
            this.btnviwe.Size = new System.Drawing.Size(196, 62);
            this.btnviwe.TabIndex = 3;
            this.btnviwe.Text = "View item Details";
            this.btnviwe.UseVisualStyleBackColor = false;
            this.btnviwe.Click += new System.EventHandler(this.btnviwe_Click);
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_pname.Location = new System.Drawing.Point(33, 136);
            this.lbl_pname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(194, 32);
            this.lbl_pname.TabIndex = 4;
            this.lbl_pname.Text = "Product Name";
            this.lbl_pname.Click += new System.EventHandler(this.lbl_pname_Click);
            // 
            // lbl_pno
            // 
            this.lbl_pno.AutoSize = true;
            this.lbl_pno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_pno.Location = new System.Drawing.Point(33, 190);
            this.lbl_pno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pno.Name = "lbl_pno";
            this.lbl_pno.Size = new System.Drawing.Size(219, 32);
            this.lbl_pno.TabIndex = 5;
            this.lbl_pno.Text = "Product Number";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_qty.Location = new System.Drawing.Point(33, 293);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(121, 32);
            this.lbl_qty.TabIndex = 6;
            this.lbl_qty.Text = "Quantity";
            // 
            // lpl_price
            // 
            this.lpl_price.AutoSize = true;
            this.lpl_price.BackColor = System.Drawing.Color.Transparent;
            this.lpl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lpl_price.Location = new System.Drawing.Point(33, 351);
            this.lpl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lpl_price.Name = "lpl_price";
            this.lpl_price.Size = new System.Drawing.Size(137, 32);
            this.lpl_price.TabIndex = 7;
            this.lpl_price.Text = "Unit Price";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.BackColor = System.Drawing.Color.Transparent;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_category.Location = new System.Drawing.Point(31, 243);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(129, 32);
            this.lbl_category.TabIndex = 8;
            this.lbl_category.Text = "Category";
            // 
            // txt_pname
            // 
            this.txt_pname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pname.Location = new System.Drawing.Point(260, 135);
            this.txt_pname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pname.Multiline = true;
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(207, 33);
            this.txt_pname.TabIndex = 9;
            // 
            // txt_pno
            // 
            this.txt_pno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_pno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pno.Location = new System.Drawing.Point(260, 190);
            this.txt_pno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pno.Multiline = true;
            this.txt_pno.Name = "txt_pno";
            this.txt_pno.Size = new System.Drawing.Size(207, 32);
            this.txt_pno.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(260, 351);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(207, 26);
            this.txt_price.TabIndex = 12;
            // 
            // cmb_category
            // 
            this.cmb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.cmb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "Party Outfits",
            "Casual Outfits",
            "Couple Outfits",
            "Sporty Outfits",
            "Kids Special"});
            this.cmb_category.Location = new System.Drawing.Point(260, 247);
            this.cmb_category.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(207, 28);
            this.cmb_category.TabIndex = 13;
            // 
            // numericUpDown_qty
            // 
            this.numericUpDown_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.numericUpDown_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_qty.Location = new System.Drawing.Point(260, 299);
            this.numericUpDown_qty.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_qty.Name = "numericUpDown_qty";
            this.numericUpDown_qty.Size = new System.Drawing.Size(208, 26);
            this.numericUpDown_qty.TabIndex = 14;
            // 
            // btn_iback
            // 
            this.btn_iback.BackColor = System.Drawing.Color.Black;
            this.btn_iback.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_iback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_iback.Location = new System.Drawing.Point(16, 645);
            this.btn_iback.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iback.Name = "btn_iback";
            this.btn_iback.Size = new System.Drawing.Size(107, 34);
            this.btn_iback.TabIndex = 22;
            this.btn_iback.Text = "Back";
            this.btn_iback.UseVisualStyleBackColor = false;
            this.btn_iback.Click += new System.EventHandler(this.btn_iback_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(161, 552);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 52);
            this.label1.TabIndex = 30;
            this.label1.Text = "INFINITY PRODUCTS";
            // 
            // tblitemTableAdapter
            // 
            this.tblitemTableAdapter.ClearBeforeFill = true;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.Black;
            this.btn_browse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_browse.Location = new System.Drawing.Point(308, 492);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(107, 34);
            this.btn_browse.TabIndex = 31;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.pictureBox1.Location = new System.Drawing.Point(122, 415);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Course_Work_GAD.Properties.Resources.Registation_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1407, 694);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_iback);
            this.Controls.Add(this.numericUpDown_qty);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_pno);
            this.Controls.Add(this.txt_pname);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lpl_price);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_pno);
            this.Controls.Add(this.lbl_pname);
            this.Controls.Add(this.btnviwe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_removeS);
            this.Controls.Add(this.btn_update);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add items";
            this.Load += new System.EventHandler(this.Add_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblitemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_removeS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnviwe;
        private System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.Label lbl_pno;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lpl_price;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.TextBox txt_pno;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.NumericUpDown numericUpDown_qty;
        private System.Windows.Forms.Button btn_iback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CLSHOPDataSet cLSHOPDataSet;
        private System.Windows.Forms.BindingSource tblitemBindingSource;
        private CLSHOPDataSetTableAdapters.tblitemTableAdapter tblitemTableAdapter;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoUrlDataGridViewTextBoxColumn;
    }
}