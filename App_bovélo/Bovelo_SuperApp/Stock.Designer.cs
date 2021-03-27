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
            this.btnSearch = new System.Windows.Forms.Button();
            this.Name_model_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour_model_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizemodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricemodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(35, 65);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // txtChercher
            // 
            this.txtChercher.Location = new System.Drawing.Point(94, 62);
            this.txtChercher.Name = "txtChercher";
            this.txtChercher.Size = new System.Drawing.Size(250, 20);
            this.txtChercher.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmodelitemDataGridViewTextBoxColumn,
            this.Name_model_item,
            this.sizemodelitemDataGridViewTextBoxColumn,
            this.Colour_model_item,
            this.pricemodelitemDataGridViewTextBoxColumn,
            this.Item_quantity});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 294);
            this.dataGridView1.TabIndex = 2;
            // 
            // grpItem
            // 
            this.grpItem.Location = new System.Drawing.Point(527, 88);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(253, 244);
            this.grpItem.TabIndex = 3;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Pièce";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(350, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Name_model_item
            // 
            this.Name_model_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Name_model_item.DataPropertyName = "Name_model_item";
            this.Name_model_item.HeaderText = "Item";
            this.Name_model_item.Name = "Name_model_item";
            this.Name_model_item.Width = 52;
            // 
            // Colour_model_item
            // 
            this.Colour_model_item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Colour_model_item.DataPropertyName = "Colour_model_item";
            this.Colour_model_item.HeaderText = "Colour";
            this.Colour_model_item.Name = "Colour_model_item";
            this.Colour_model_item.Width = 62;
            // 
            // Item_quantity
            // 
            this.Item_quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Item_quantity.DataPropertyName = "Item_quantity";
            this.Item_quantity.HeaderText = "Quantity";
            this.Item_quantity.Name = "Item_quantity";
            this.Item_quantity.Width = 71;
            // 
            // idmodelitemDataGridViewTextBoxColumn
            // 
            this.idmodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idmodelitemDataGridViewTextBoxColumn.DataPropertyName = "Id_model_item";
            this.idmodelitemDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idmodelitemDataGridViewTextBoxColumn.Name = "idmodelitemDataGridViewTextBoxColumn";
            this.idmodelitemDataGridViewTextBoxColumn.Width = 43;
            // 
            // sizemodelitemDataGridViewTextBoxColumn
            // 
            this.sizemodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sizemodelitemDataGridViewTextBoxColumn.DataPropertyName = "Size_model_item";
            this.sizemodelitemDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizemodelitemDataGridViewTextBoxColumn.Name = "sizemodelitemDataGridViewTextBoxColumn";
            this.sizemodelitemDataGridViewTextBoxColumn.Width = 52;
            // 
            // pricemodelitemDataGridViewTextBoxColumn
            // 
            this.pricemodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pricemodelitemDataGridViewTextBoxColumn.DataPropertyName = "Price_model_item";
            this.pricemodelitemDataGridViewTextBoxColumn.HeaderText = "Price";
            this.pricemodelitemDataGridViewTextBoxColumn.Name = "pricemodelitemDataGridViewTextBoxColumn";
            this.pricemodelitemDataGridViewTextBoxColumn.Width = 56;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(Bovelo_SuperApp.Items);
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataSource = typeof(Bovelo_SuperApp.Items);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.lblSearch);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(812, 436);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_model_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizemodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colour_model_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricemodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_quantity;
    }
}
