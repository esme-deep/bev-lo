
namespace Bovelo_SuperApp
{
    partial class MounterOrder
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_titles_week_orders = new System.Windows.Forms.Panel();
            this.Status_bike = new System.Windows.Forms.ComboBox();
            this.color_mounter = new System.Windows.Forms.Label();
            this.business_name_mounter = new System.Windows.Forms.Label();
            this.client_name_mounter = new System.Windows.Forms.Label();
            this.size_mounter = new System.Windows.Forms.Label();
            this.time_mounter = new System.Windows.Forms.Label();
            this.model_mounter = new System.Windows.Forms.Label();
            this.pnl_titles_week_orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titles_week_orders
            // 
            this.pnl_titles_week_orders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_titles_week_orders.Controls.Add(this.Status_bike);
            this.pnl_titles_week_orders.Controls.Add(this.color_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.business_name_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.client_name_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.size_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.time_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.model_mounter);
            this.pnl_titles_week_orders.Location = new System.Drawing.Point(2, 11);
            this.pnl_titles_week_orders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_titles_week_orders.Name = "pnl_titles_week_orders";
            this.pnl_titles_week_orders.Size = new System.Drawing.Size(789, 33);
            this.pnl_titles_week_orders.TabIndex = 5;
            // 
            // Status_bike
            // 
            this.Status_bike.FormattingEnabled = true;
            this.Status_bike.Items.AddRange(new object[] {
            "Waiting",
            "In Production",
            "Done"});
            this.Status_bike.Location = new System.Drawing.Point(663, 6);
            this.Status_bike.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Status_bike.Name = "Status_bike";
            this.Status_bike.Size = new System.Drawing.Size(92, 21);
            this.Status_bike.TabIndex = 7;
            this.Status_bike.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // color_mounter
            // 
            this.color_mounter.AutoSize = true;
            this.color_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_mounter.Location = new System.Drawing.Point(104, 0);
            this.color_mounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color_mounter.Name = "color_mounter";
            this.color_mounter.Size = new System.Drawing.Size(77, 32);
            this.color_mounter.TabIndex = 4;
            this.color_mounter.Text = "Color";
            this.color_mounter.Click += new System.EventHandler(this.label1_Click);
            // 
            // business_name_mounter
            // 
            this.business_name_mounter.AutoSize = true;
            this.business_name_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_name_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_name_mounter.Location = new System.Drawing.Point(391, -1);
            this.business_name_mounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.business_name_mounter.Name = "business_name_mounter";
            this.business_name_mounter.Size = new System.Drawing.Size(187, 32);
            this.business_name_mounter.TabIndex = 6;
            this.business_name_mounter.Text = "business name";
            // 
            // client_name_mounter
            // 
            this.client_name_mounter.AutoSize = true;
            this.client_name_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.client_name_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_name_mounter.Location = new System.Drawing.Point(244, -1);
            this.client_name_mounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.client_name_mounter.Name = "client_name_mounter";
            this.client_name_mounter.Size = new System.Drawing.Size(152, 32);
            this.client_name_mounter.TabIndex = 5;
            this.client_name_mounter.Text = "Client name";
            // 
            // size_mounter
            // 
            this.size_mounter.AutoSize = true;
            this.size_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_mounter.Location = new System.Drawing.Point(180, -1);
            this.size_mounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.size_mounter.Name = "size_mounter";
            this.size_mounter.Size = new System.Drawing.Size(65, 32);
            this.size_mounter.TabIndex = 3;
            this.size_mounter.Text = "Size";
            // 
            // time_mounter
            // 
            this.time_mounter.AutoSize = true;
            this.time_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_mounter.Location = new System.Drawing.Point(562, -1);
            this.time_mounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_mounter.Name = "time_mounter";
            this.time_mounter.Size = new System.Drawing.Size(64, 32);
            this.time_mounter.TabIndex = 0;
            this.time_mounter.Text = "time";
            // 
            // model_mounter
            // 
            this.model_mounter.AutoSize = true;
            this.model_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.model_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_mounter.Location = new System.Drawing.Point(-1, -1);
            this.model_mounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.model_mounter.Name = "model_mounter";
            this.model_mounter.Size = new System.Drawing.Size(85, 32);
            this.model_mounter.TabIndex = 1;
            this.model_mounter.Text = "Model";
            // 
            // MounterOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_titles_week_orders);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MounterOrder";
            this.Size = new System.Drawing.Size(807, 55);
            this.Load += new System.EventHandler(this.MounterOrder_Load);
            this.pnl_titles_week_orders.ResumeLayout(false);
            this.pnl_titles_week_orders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_titles_week_orders;
        public System.Windows.Forms.Label color_mounter;
        public System.Windows.Forms.Label business_name_mounter;
        public System.Windows.Forms.Label client_name_mounter;
        public System.Windows.Forms.Label size_mounter;
        public System.Windows.Forms.Label time_mounter;
        public System.Windows.Forms.Label model_mounter;
        public System.Windows.Forms.ComboBox Status_bike;
    }
}

