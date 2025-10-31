namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            initJewelryDbBindingSource = new BindingSource(components);
            productDataView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            saleDataView = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleBindingSource = new BindingSource(components);
            materialBindingSource = new BindingSource(components);
            materialDataView = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            MatAdd = new Button();
            MatEdit = new Button();
            matDel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            prodDel = new Button();
            prodRed = new Button();
            prodAdd = new Button();
            saleDel = new Button();
            saleRed = new Button();
            saleAdd = new Button();
            tb_ID = new TextBox();
            tb_Material = new TextBox();
            tb_proID = new TextBox();
            tb_proName = new TextBox();
            tb_proType = new TextBox();
            tb_proPrice = new TextBox();
            tb_saleID = new TextBox();
            tb_saleLast = new TextBox();
            tb_saleFirst = new TextBox();
            tb_saleDate = new TextBox();
            tb_proMat = new TextBox();
            tb_proWei = new TextBox();
            tb_saleMidd = new TextBox();
            tb_saleProd = new TextBox();
            tb_filterMaterial = new TextBox();
            tb_filterType = new TextBox();
            btnFilter = new Button();
            btnResetFilter = new Button();
            btnGenerateTable = new Button();
            btnGenerateInvoice = new Button();
            btnGenerateCatalog = new Button();
            btnChooseTemplateTable = new Button();
            btnChooseTemplateInvoice = new Button();
            tbTemplateTable = new TextBox();
            tbTemplateInvoice = new TextBox();
            btnExportReport1 = new Button();
            btnExportReport2 = new Button();
            btnImportExcel = new Button();
            openFileDialog1 = new OpenFileDialog();
            ofdExcel = new OpenFileDialog();
            sfdExcel = new SaveFileDialog();
            btnGenerateHtmlCombined = new Button();
            btnGenerateHtmlCatalog = new Button();
            ((System.ComponentModel.ISupportInitialize)initJewelryDbBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialDataView).BeginInit();
            SuspendLayout();
            // 
            // initJewelryDbBindingSource
            // 
            initJewelryDbBindingSource.DataSource = typeof(Migrations.InitJewelryDb);
            // 
            // productDataView
            // 
            productDataView.AutoGenerateColumns = false;
            productDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, materialIdDataGridViewTextBoxColumn, materialDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            productDataView.DataSource = productBindingSource;
            productDataView.Location = new Point(12, 216);
            productDataView.Name = "productDataView";
            productDataView.Size = new Size(746, 150);
            productDataView.TabIndex = 2;
            productDataView.CellClick += productDataView_CellClick;
            productDataView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            materialIdDataGridViewTextBoxColumn.DataPropertyName = "MaterialId";
            materialIdDataGridViewTextBoxColumn.HeaderText = "MaterialId";
            materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            materialIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            materialDataGridViewTextBoxColumn.DataPropertyName = "Material";
            materialDataGridViewTextBoxColumn.HeaderText = "Material";
            materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(JewelryWorkshop.Data.Product);
            // 
            // saleDataView
            // 
            saleDataView.AutoGenerateColumns = false;
            saleDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            saleDataView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, productIdDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn, saleDateDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn });
            saleDataView.DataSource = saleBindingSource;
            saleDataView.Location = new Point(12, 385);
            saleDataView.Name = "saleDataView";
            saleDataView.Size = new Size(746, 150);
            saleDataView.TabIndex = 3;
            saleDataView.CellClick += saleDataView_CellClick;
            saleDataView.CellContentClick += saleDataView_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(JewelryWorkshop.Data.Sale);
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(JewelryWorkshop.Data.Material);
            // 
            // materialDataView
            // 
            materialDataView.AutoGenerateColumns = false;
            materialDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materialDataView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, nameDataGridViewTextBoxColumn1 });
            materialDataView.DataSource = materialBindingSource;
            materialDataView.Location = new Point(12, 41);
            materialDataView.Name = "materialDataView";
            materialDataView.Size = new Size(746, 150);
            materialDataView.TabIndex = 4;
            materialDataView.CellClick += materialDataView_CellClick;
            materialDataView.CellContentClick += materialDataView_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // MatAdd
            // 
            MatAdd.Location = new Point(1292, 46);
            MatAdd.Name = "MatAdd";
            MatAdd.Size = new Size(139, 23);
            MatAdd.TabIndex = 5;
            MatAdd.Text = "Добавить";
            MatAdd.UseVisualStyleBackColor = true;
            MatAdd.Click += MatAdd_Click;
            // 
            // MatEdit
            // 
            MatEdit.Location = new Point(1292, 70);
            MatEdit.Name = "MatEdit";
            MatEdit.Size = new Size(139, 23);
            MatEdit.TabIndex = 6;
            MatEdit.Text = "Редактировать";
            MatEdit.UseVisualStyleBackColor = true;
            MatEdit.Click += MatEdit_Click;
            // 
            // matDel
            // 
            matDel.Location = new Point(1292, 99);
            matDel.Name = "matDel";
            matDel.Size = new Size(139, 23);
            matDel.TabIndex = 7;
            matDel.Text = "Удалить";
            matDel.UseVisualStyleBackColor = true;
            matDel.Click += matDel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 8;
            label1.Text = "Материалы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "Товары";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 369);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 10;
            label3.Text = "Продажи";
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // prodDel
            // 
            prodDel.Location = new Point(1292, 274);
            prodDel.Name = "prodDel";
            prodDel.Size = new Size(139, 23);
            prodDel.TabIndex = 31;
            prodDel.Text = "Удалить";
            prodDel.UseVisualStyleBackColor = true;
            prodDel.Click += prodDel_Click;
            // 
            // prodRed
            // 
            prodRed.Location = new Point(1292, 245);
            prodRed.Name = "prodRed";
            prodRed.Size = new Size(139, 23);
            prodRed.TabIndex = 30;
            prodRed.Text = "Редактировать";
            prodRed.UseVisualStyleBackColor = true;
            prodRed.Click += prodRed_Click;
            // 
            // prodAdd
            // 
            prodAdd.Location = new Point(1292, 216);
            prodAdd.Name = "prodAdd";
            prodAdd.Size = new Size(139, 23);
            prodAdd.TabIndex = 29;
            prodAdd.Text = "Добавить";
            prodAdd.UseVisualStyleBackColor = true;
            prodAdd.Click += prodAdd_Click;
            // 
            // saleDel
            // 
            saleDel.Location = new Point(1292, 443);
            saleDel.Name = "saleDel";
            saleDel.Size = new Size(139, 23);
            saleDel.TabIndex = 34;
            saleDel.Text = "Удалить";
            saleDel.UseVisualStyleBackColor = true;
            saleDel.Click += saleDel_Click;
            // 
            // saleRed
            // 
            saleRed.Location = new Point(1292, 414);
            saleRed.Name = "saleRed";
            saleRed.Size = new Size(139, 23);
            saleRed.TabIndex = 33;
            saleRed.Text = "Редактировать";
            saleRed.UseVisualStyleBackColor = true;
            saleRed.Click += saleRed_Click;
            // 
            // saleAdd
            // 
            saleAdd.Location = new Point(1292, 385);
            saleAdd.Name = "saleAdd";
            saleAdd.Size = new Size(139, 23);
            saleAdd.TabIndex = 32;
            saleAdd.Text = "Добавить";
            saleAdd.UseVisualStyleBackColor = true;
            saleAdd.Click += saleAdd_Click;
            // 
            // tb_ID
            // 
            tb_ID.Location = new Point(764, 41);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new Size(100, 23);
            tb_ID.TabIndex = 35;
            tb_ID.TextChanged += tb_ID_TextChanged;
            // 
            // tb_Material
            // 
            tb_Material.Location = new Point(764, 70);
            tb_Material.Name = "tb_Material";
            tb_Material.Size = new Size(100, 23);
            tb_Material.TabIndex = 36;
            tb_Material.TextChanged += tb_Material_TextChanged;
            // 
            // tb_proID
            // 
            tb_proID.Location = new Point(773, 216);
            tb_proID.Name = "tb_proID";
            tb_proID.Size = new Size(100, 23);
            tb_proID.TabIndex = 37;
            // 
            // tb_proName
            // 
            tb_proName.Location = new Point(773, 244);
            tb_proName.Name = "tb_proName";
            tb_proName.Size = new Size(100, 23);
            tb_proName.TabIndex = 38;
            // 
            // tb_proType
            // 
            tb_proType.Location = new Point(773, 273);
            tb_proType.Name = "tb_proType";
            tb_proType.Size = new Size(100, 23);
            tb_proType.TabIndex = 39;
            // 
            // tb_proPrice
            // 
            tb_proPrice.Location = new Point(879, 300);
            tb_proPrice.Name = "tb_proPrice";
            tb_proPrice.Size = new Size(100, 23);
            tb_proPrice.TabIndex = 40;
            // 
            // tb_saleID
            // 
            tb_saleID.Location = new Point(773, 386);
            tb_saleID.Name = "tb_saleID";
            tb_saleID.Size = new Size(100, 23);
            tb_saleID.TabIndex = 41;
            // 
            // tb_saleLast
            // 
            tb_saleLast.Location = new Point(773, 416);
            tb_saleLast.Name = "tb_saleLast";
            tb_saleLast.Size = new Size(100, 23);
            tb_saleLast.TabIndex = 42;
            // 
            // tb_saleFirst
            // 
            tb_saleFirst.Location = new Point(773, 445);
            tb_saleFirst.Name = "tb_saleFirst";
            tb_saleFirst.Size = new Size(100, 23);
            tb_saleFirst.TabIndex = 43;
            // 
            // tb_saleDate
            // 
            tb_saleDate.Location = new Point(879, 503);
            tb_saleDate.Name = "tb_saleDate";
            tb_saleDate.Size = new Size(100, 23);
            tb_saleDate.TabIndex = 44;
            tb_saleDate.TextChanged += tb_saleDate_TextChanged;
            // 
            // tb_proMat
            // 
            tb_proMat.Location = new Point(773, 302);
            tb_proMat.Name = "tb_proMat";
            tb_proMat.Size = new Size(100, 23);
            tb_proMat.TabIndex = 45;
            // 
            // tb_proWei
            // 
            tb_proWei.Location = new Point(879, 273);
            tb_proWei.Name = "tb_proWei";
            tb_proWei.Size = new Size(100, 23);
            tb_proWei.TabIndex = 46;
            // 
            // tb_saleMidd
            // 
            tb_saleMidd.Location = new Point(773, 474);
            tb_saleMidd.Name = "tb_saleMidd";
            tb_saleMidd.Size = new Size(100, 23);
            tb_saleMidd.TabIndex = 47;
            // 
            // tb_saleProd
            // 
            tb_saleProd.Location = new Point(773, 503);
            tb_saleProd.Name = "tb_saleProd";
            tb_saleProd.Size = new Size(100, 23);
            tb_saleProd.TabIndex = 48;
            // 
            // tb_filterMaterial
            // 
            tb_filterMaterial.Location = new Point(1059, 41);
            tb_filterMaterial.Name = "tb_filterMaterial";
            tb_filterMaterial.Size = new Size(151, 23);
            tb_filterMaterial.TabIndex = 49;
            tb_filterMaterial.TextChanged += tb_filterMaterial_TextChanged;
            // 
            // tb_filterType
            // 
            tb_filterType.Location = new Point(1059, 71);
            tb_filterType.Name = "tb_filterType";
            tb_filterType.Size = new Size(151, 23);
            tb_filterType.TabIndex = 50;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(1089, 100);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(96, 23);
            btnFilter.TabIndex = 51;
            btnFilter.Text = "Фильтровать";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(1089, 129);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(96, 23);
            btnResetFilter.TabIndex = 52;
            btnResetFilter.Text = "Сброс фильтра";
            btnResetFilter.UseVisualStyleBackColor = true;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnGenerateTable
            // 
            btnGenerateTable.Location = new Point(1455, 46);
            btnGenerateTable.Name = "btnGenerateTable";
            btnGenerateTable.Size = new Size(118, 47);
            btnGenerateTable.TabIndex = 53;
            btnGenerateTable.Text = "Сформировать таблицу (Word)";
            btnGenerateTable.UseVisualStyleBackColor = true;
            btnGenerateTable.Click += btnGenerateTable_Click;
            // 
            // btnGenerateInvoice
            // 
            btnGenerateInvoice.Location = new Point(1455, 99);
            btnGenerateInvoice.Name = "btnGenerateInvoice";
            btnGenerateInvoice.Size = new Size(118, 47);
            btnGenerateInvoice.TabIndex = 54;
            btnGenerateInvoice.Text = "Сформировать накладную (Word)";
            btnGenerateInvoice.UseVisualStyleBackColor = true;
            btnGenerateInvoice.Click += btnGenerateInvoice_Click;
            // 
            // btnGenerateCatalog
            // 
            btnGenerateCatalog.Location = new Point(1455, 152);
            btnGenerateCatalog.Name = "btnGenerateCatalog";
            btnGenerateCatalog.Size = new Size(118, 47);
            btnGenerateCatalog.TabIndex = 55;
            btnGenerateCatalog.Text = "Сформировать каталог (Word)";
            btnGenerateCatalog.UseVisualStyleBackColor = true;
            btnGenerateCatalog.Click += btnGenerateCatalog_Click;
            // 
            // btnChooseTemplateTable
            // 
            btnChooseTemplateTable.Location = new Point(1455, 205);
            btnChooseTemplateTable.Name = "btnChooseTemplateTable";
            btnChooseTemplateTable.Size = new Size(118, 47);
            btnChooseTemplateTable.TabIndex = 56;
            btnChooseTemplateTable.Text = "Выбрать шаблон таблицы";
            btnChooseTemplateTable.UseVisualStyleBackColor = true;
            btnChooseTemplateTable.Click += btnChooseTemplateTable_Click;
            // 
            // btnChooseTemplateInvoice
            // 
            btnChooseTemplateInvoice.Location = new Point(1455, 258);
            btnChooseTemplateInvoice.Name = "btnChooseTemplateInvoice";
            btnChooseTemplateInvoice.Size = new Size(118, 47);
            btnChooseTemplateInvoice.TabIndex = 57;
            btnChooseTemplateInvoice.Text = "Выбрать шаблон накладной";
            btnChooseTemplateInvoice.UseVisualStyleBackColor = true;
            btnChooseTemplateInvoice.Click += btnChooseTemplateInvoice_Click;
            // 
            // tbTemplateTable
            // 
            tbTemplateTable.Location = new Point(1455, 311);
            tbTemplateTable.Name = "tbTemplateTable";
            tbTemplateTable.Size = new Size(100, 23);
            tbTemplateTable.TabIndex = 58;
            // 
            // tbTemplateInvoice
            // 
            tbTemplateInvoice.Location = new Point(1455, 343);
            tbTemplateInvoice.Name = "tbTemplateInvoice";
            tbTemplateInvoice.Size = new Size(100, 23);
            tbTemplateInvoice.TabIndex = 59;
            // 
            // btnExportReport1
            // 
            btnExportReport1.Location = new Point(1579, 47);
            btnExportReport1.Name = "btnExportReport1";
            btnExportReport1.Size = new Size(118, 47);
            btnExportReport1.TabIndex = 60;
            btnExportReport1.Text = "Экспорт: Продажи (полная таблица)";
            btnExportReport1.UseVisualStyleBackColor = true;
            btnExportReport1.Click += btnExportReport1_Click;
            // 
            // btnExportReport2
            // 
            btnExportReport2.Location = new Point(1579, 100);
            btnExportReport2.Name = "btnExportReport2";
            btnExportReport2.Size = new Size(118, 47);
            btnExportReport2.TabIndex = 61;
            btnExportReport2.Text = "Экспорт: Сводка материалов";
            btnExportReport2.UseVisualStyleBackColor = true;
            btnExportReport2.Click += btnExportReport2_Click;
            // 
            // btnImportExcel
            // 
            btnImportExcel.Location = new Point(1579, 153);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(118, 47);
            btnImportExcel.TabIndex = 62;
            btnImportExcel.Text = "Импорт из Excel";
            btnImportExcel.UseVisualStyleBackColor = true;
            btnImportExcel.Click += btnImportExcel_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ofdExcel
            // 
            ofdExcel.FileName = "openFileDialog2";
            // 
            // btnGenerateHtmlCombined
            // 
            btnGenerateHtmlCombined.Location = new Point(1579, 206);
            btnGenerateHtmlCombined.Name = "btnGenerateHtmlCombined";
            btnGenerateHtmlCombined.Size = new Size(118, 23);
            btnGenerateHtmlCombined.TabIndex = 63;
            btnGenerateHtmlCombined.Text = "HTML — отчёт";
            btnGenerateHtmlCombined.UseVisualStyleBackColor = true;
            // 
            // btnGenerateHtmlCatalog
            // 
            btnGenerateHtmlCatalog.Location = new Point(1579, 235);
            btnGenerateHtmlCatalog.Name = "btnGenerateHtmlCatalog";
            btnGenerateHtmlCatalog.Size = new Size(118, 23);
            btnGenerateHtmlCatalog.TabIndex = 64;
            btnGenerateHtmlCatalog.Text = "HTML — каталог изделий";
            btnGenerateHtmlCatalog.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1738, 582);
            Controls.Add(btnGenerateHtmlCatalog);
            Controls.Add(btnGenerateHtmlCombined);
            Controls.Add(btnImportExcel);
            Controls.Add(btnExportReport2);
            Controls.Add(btnExportReport1);
            Controls.Add(tbTemplateInvoice);
            Controls.Add(tbTemplateTable);
            Controls.Add(btnChooseTemplateInvoice);
            Controls.Add(btnChooseTemplateTable);
            Controls.Add(btnGenerateCatalog);
            Controls.Add(btnGenerateInvoice);
            Controls.Add(btnGenerateTable);
            Controls.Add(btnResetFilter);
            Controls.Add(btnFilter);
            Controls.Add(tb_filterType);
            Controls.Add(tb_filterMaterial);
            Controls.Add(tb_saleProd);
            Controls.Add(tb_saleMidd);
            Controls.Add(tb_proWei);
            Controls.Add(tb_proMat);
            Controls.Add(tb_saleDate);
            Controls.Add(tb_saleFirst);
            Controls.Add(tb_saleLast);
            Controls.Add(tb_saleID);
            Controls.Add(tb_proPrice);
            Controls.Add(tb_proType);
            Controls.Add(tb_proName);
            Controls.Add(tb_proID);
            Controls.Add(tb_Material);
            Controls.Add(tb_ID);
            Controls.Add(saleDel);
            Controls.Add(saleRed);
            Controls.Add(saleAdd);
            Controls.Add(prodDel);
            Controls.Add(prodRed);
            Controls.Add(prodAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(matDel);
            Controls.Add(MatEdit);
            Controls.Add(MatAdd);
            Controls.Add(materialDataView);
            Controls.Add(saleDataView);
            Controls.Add(productDataView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)initJewelryDbBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource initJewelryDbBindingSource;
        private BindingSource productBindingSource;
        private DataGridView saleDataView;
        private BindingSource saleBindingSource;
        private BindingSource materialBindingSource;
        private DataGridView materialDataView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private Button MatAdd;
        private Button MatEdit;
        private Button matDel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox lable2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label PriceProduct;
        private Label NameProduct;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label IdSale;
        private Label ProductSale;
        private Button prodDel;
        private Button prodRed;
        private Button prodAdd;
        private Button saleDel;
        private Button saleRed;
        private Button saleAdd;
        private TextBox tb_ID;
        private TextBox tb_Material;
        private TextBox tb_proID;
        private TextBox tb_proName;
        private TextBox tb_proType;
        private TextBox tb_proPrice;
        private TextBox tb_saleID;
        private TextBox tb_saleLast;
        private TextBox tb_saleFirst;
        private TextBox tb_saleDate;
        private TextBox tb_proMat;
        private TextBox tb_proWei;
        private TextBox tb_saleMidd;
        private TextBox tb_saleProd;
        private TextBox tb_filterMaterial;
        private TextBox tb_filterType;
        private Button btnFilter;
        private Button btnResetFilter;
        private DataGridView productDataView;
        private Button btnGenerateTable;
        private Button btnGenerateInvoice;
        private Button btnGenerateCatalog;
        private Button btnChooseTemplateTable;
        private Button btnChooseTemplateInvoice;
        private TextBox tbTemplateTable;
        private TextBox tbTemplateInvoice;
        private Button btnExportReport1;
        private Button btnExportReport2;
        private Button btnImportExcel;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog ofdExcel;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialog2;
        private SaveFileDialog saveFileDialog3;
        private SaveFileDialog saveFileDialog4;
        private SaveFileDialog sfdExcel;
        private Button btnGenerateHtmlCombined;
        private Button btnGenerateHtmlCatalog;
    }
}
