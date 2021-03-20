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
            this.lblChercher = new System.Windows.Forms.Label();
            this.txtChercher = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idmodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemodeitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizemodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourmodelitemcolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricemodelitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.btnChercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChercher
            // 
            this.lblChercher.AutoSize = true;
            this.lblChercher.Location = new System.Drawing.Point(35, 65);
            this.lblChercher.Name = "lblChercher";
            this.lblChercher.Size = new System.Drawing.Size(53, 13);
            this.lblChercher.TabIndex = 0;
            this.lblChercher.Text = "Chercher:";
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
            this.namemodeitemDataGridViewTextBoxColumn,
            this.sizemodelitemDataGridViewTextBoxColumn,
            this.colourmodelitemcolDataGridViewTextBoxColumn,
            this.pricemodelitemDataGridViewTextBoxColumn,
            this.idstockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 244);
            this.dataGridView1.TabIndex = 2;
            // 
            // idmodelitemDataGridViewTextBoxColumn
            // 
            this.idmodelitemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idmodelitemDataGridViewTextBoxColumn.DataPropertyName = "Id_model_item";
            this.idmodelitemDataGridViewTextBoxColumn.HeaderText = "Id_model_item";
            this.idmodelitemDataGridViewTextBoxColumn.Name = "idmodelitemDataGridViewTextBoxColumn";
            // 
            // namemodeitemDataGridViewTextBoxColumn
            // 
            this.namemodeitemDataGridViewTextBoxColumn.DataPropertyName = "Name_mode_item";
            this.namemodeitemDataGridViewTextBoxColumn.HeaderText = "Name_mode_item";
            this.namemodeitemDataGridViewTextBoxColumn.Name = "namemodeitemDataGridViewTextBoxColumn";
            // 
            // sizemodelitemDataGridViewTextBoxColumn
            // 
            this.sizemodelitemDataGridViewTextBoxColumn.DataPropertyName = "Size_model_item";
            this.sizemodelitemDataGridViewTextBoxColumn.HeaderText = "Size_model_item";
            this.sizemodelitemDataGridViewTextBoxColumn.Name = "sizemodelitemDataGridViewTextBoxColumn";
            // 
            // colourmodelitemcolDataGridViewTextBoxColumn
            // 
            this.colourmodelitemcolDataGridViewTextBoxColumn.DataPropertyName = "Colour_model_itemcol";
            this.colourmodelitemcolDataGridViewTextBoxColumn.HeaderText = "Colour_model_itemcol";
            this.colourmodelitemcolDataGridViewTextBoxColumn.Name = "colourmodelitemcolDataGridViewTextBoxColumn";
            // 
            // pricemodelitemDataGridViewTextBoxColumn
            // 
            this.pricemodelitemDataGridViewTextBoxColumn.DataPropertyName = "Price_model_item";
            this.pricemodelitemDataGridViewTextBoxColumn.HeaderText = "Price_model_item";
            this.pricemodelitemDataGridViewTextBoxColumn.Name = "pricemodelitemDataGridViewTextBoxColumn";
            // 
            // idstockDataGridViewTextBoxColumn
            // 
            this.idstockDataGridViewTextBoxColumn.DataPropertyName = "Id_stock";
            this.idstockDataGridViewTextBoxColumn.HeaderText = "Id_stock";
            this.idstockDataGridViewTextBoxColumn.Name = "idstockDataGridViewTextBoxColumn";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(Bovelo_SuperApp.Items);
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
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(350, 60);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(75, 23);
            this.btnChercher.TabIndex = 4;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChercher);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtChercher);
            this.Controls.Add(this.lblChercher);
            this.Name = "Stock";
            this.Size = new System.Drawing.Size(812, 436);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChercher;
        private System.Windows.Forms.TextBox txtChercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemodeitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizemodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourmodelitemcolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricemodelitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.Button btnChercher;
    }
}
