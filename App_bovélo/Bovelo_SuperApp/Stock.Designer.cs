namespace Bovelo_SuperApp
{
    partial class Stock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.txtItem_ID = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.itemsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Id_model_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizemodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourmodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricemodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qttusedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qttcomingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qttavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(58, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search :";
            // 
            // txtChercher
            // 
            this.txtChercher.Location = new System.Drawing.Point(117, 41);
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(250, 20);
            this.txtChercher.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_model_item,
            this.namemodelitemDataGridViewTextBoxColumn,
            this.sizemodelitemDataGridViewTextBoxColumn,
            this.colourmodelitemDataGridViewTextBoxColumn,
            this.pricemodelitemDataGridViewTextBoxColumn,
            this.qttusedDataGridViewTextBoxColumn,
            this.qttcomingDataGridViewTextBoxColumn,
            this.qttavailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(60, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(412, 294);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.btnClearItem);
            this.grpItem.Controls.Add(this.btnSaveItem);
            this.grpItem.Controls.Add(this.txtItem_ID);
            this.grpItem.Controls.Add(this.cmbStatus);
            this.grpItem.Controls.Add(this.label6);
            this.grpItem.Controls.Add(this.txtQuantity);
            this.grpItem.Controls.Add(this.label5);
            this.grpItem.Controls.Add(this.txtPrice);
            this.grpItem.Controls.Add(this.label4);
            this.grpItem.Controls.Add(this.txtColour);
            this.grpItem.Controls.Add(this.label3);
            this.grpItem.Controls.Add(this.txtSize);
            this.grpItem.Controls.Add(this.label2);
            this.grpItem.Controls.Add(this.txtItem);
            this.grpItem.Controls.Add(this.label1);
            this.grpItem.Location = new System.Drawing.Point(500, 100);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(254, 295);
            this.grpItem.TabIndex = 3;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            this.grpItem.Enter += new System.EventHandler(this.grpItem_Enter);
            // 
            // btnClearItem
            // 
            this.btnClearItem.Location = new System.Drawing.Point(158, 266);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(75, 23);
            this.btnClearItem.TabIndex = 13;
            this.btnClearItem.Text = "Clear";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(19, 266);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(75, 23);
            this.btnSaveItem.TabIndex = 12;
            this.btnSaveItem.Text = "Save";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // txtItem_ID
            // 
            this.txtItem_ID.Location = new System.Drawing.Point(68, 232);
            this.txtItem_ID.Name = "txtItem_ID";
            this.txtItem_ID.Size = new System.Drawing.Size(100, 20);
            this.txtItem_ID.TabIndex = 11;
            this.txtItem_ID.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available\t",
            "Coming soon",
            "Used"});
            this.cmbStatus.Location = new System.Drawing.Point(68, 205);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(128, 21);
            this.cmbStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(68, 171);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(128, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(68, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price";
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(68, 100);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(128, 20);
            this.txtColour.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colour";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(68, 65);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(128, 20);
            this.txtSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(68, 29);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(128, 20);
            this.txtItem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(56, 401);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateItem.TabIndex = 13;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(147, 401);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem.TabIndex = 14;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Filter by status :";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Available\t",
            "Coming soon"});
            this.cmbFilter.Location = new System.Drawing.Point(138, 72);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(229, 21);
            this.cmbFilter.TabIndex = 16;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(374, 72);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // itemsBindingSource3
            // 
            this.itemsBindingSource3.DataSource = typeof(Bovelo_SuperApp.Items);
            // 
            // itemsBindingSource2
            // 
            this.itemsBindingSource2.DataSource = typeof(Bovelo_SuperApp.Items);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(Bovelo_SuperApp.Items);
            this.itemsBindingSource.CurrentChanged += new System.EventHandler(this.itemsBindingSource_CurrentChanged);
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataSource = typeof(Bovelo_SuperApp.Items);
            // 
            // Id_model_item
            // 
            this.Id_model_item.DataPropertyName = "Id_model_item";
            this.Id_model_item.HeaderText = "ID";
            this.Id_model_item.Name = "Id_model_item";
            this.Id_model_item.ReadOnly = true;
            this.Id_model_item.Visible = false;
            // 
            // namemodelitemDataGridViewTextBoxColumn
            // 
            this.namemodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.namemodelitemDataGridViewTextBoxColumn.DataPropertyName = "Name_model_item";
            this.namemodelitemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.namemodelitemDataGridViewTextBoxColumn.Name = "namemodelitemDataGridViewTextBoxColumn";
            this.namemodelitemDataGridViewTextBoxColumn.ReadOnly = true;
            this.namemodelitemDataGridViewTextBoxColumn.Width = 52;
            // 
            // sizemodelitemDataGridViewTextBoxColumn
            // 
            this.sizemodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sizemodelitemDataGridViewTextBoxColumn.DataPropertyName = "Size_model_item";
            this.sizemodelitemDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizemodelitemDataGridViewTextBoxColumn.Name = "sizemodelitemDataGridViewTextBoxColumn";
            this.sizemodelitemDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizemodelitemDataGridViewTextBoxColumn.Width = 52;
            // 
            // colourmodelitemDataGridViewTextBoxColumn
            // 
            this.colourmodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colourmodelitemDataGridViewTextBoxColumn.DataPropertyName = "Colour_model_item";
            this.colourmodelitemDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourmodelitemDataGridViewTextBoxColumn.Name = "colourmodelitemDataGridViewTextBoxColumn";
            this.colourmodelitemDataGridViewTextBoxColumn.ReadOnly = true;
            this.colourmodelitemDataGridViewTextBoxColumn.Width = 62;
            // 
            // pricemodelitemDataGridViewTextBoxColumn
            // 
            this.pricemodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pricemodelitemDataGridViewTextBoxColumn.DataPropertyName = "Price_model_item";
            this.pricemodelitemDataGridViewTextBoxColumn.HeaderText = "Price";
            this.pricemodelitemDataGridViewTextBoxColumn.Name = "pricemodelitemDataGridViewTextBoxColumn";
            this.pricemodelitemDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricemodelitemDataGridViewTextBoxColumn.Width = 56;
            // 
            // qttusedDataGridViewTextBoxColumn
            // 
            this.qttusedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qttusedDataGridViewTextBoxColumn.DataPropertyName = "Qtt_used";
            this.qttusedDataGridViewTextBoxColumn.HeaderText = "Used";
            this.qttusedDataGridViewTextBoxColumn.Name = "qttusedDataGridViewTextBoxColumn";
            this.qttusedDataGridViewTextBoxColumn.ReadOnly = true;
            this.qttusedDataGridViewTextBoxColumn.Width = 57;
            // 
            // qttcomingDataGridViewTextBoxColumn
            // 
            this.qttcomingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qttcomingDataGridViewTextBoxColumn.DataPropertyName = "Qtt_coming";
            this.qttcomingDataGridViewTextBoxColumn.HeaderText = "Coming Soon";
            this.qttcomingDataGridViewTextBoxColumn.Name = "qttcomingDataGridViewTextBoxColumn";
            this.qttcomingDataGridViewTextBoxColumn.ReadOnly = true;
            this.qttcomingDataGridViewTextBoxColumn.Width = 95;
            // 
            // qttavailableDataGridViewTextBoxColumn
            // 
            this.qttavailableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qttavailableDataGridViewTextBoxColumn.DataPropertyName = "Qtt_available";
            this.qttavailableDataGridViewTextBoxColumn.HeaderText = "Available ";
            this.qttavailableDataGridViewTextBoxColumn.Name = "qttavailableDataGridViewTextBoxColumn";
            this.qttavailableDataGridViewTextBoxColumn.ReadOnly = true;
            this.qttavailableDataGridViewTextBoxColumn.Width = 78;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.lblSearch);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(812, 436);
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnSaveItem;
        private System.Windows.Forms.TextBox txtItem_ID;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.BindingSource itemsBindingSource2;
        private System.Windows.Forms.BindingSource itemsBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_model_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizemodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourmodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricemodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qttusedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qttcomingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qttavailableDataGridViewTextBoxColumn;
    }
}
