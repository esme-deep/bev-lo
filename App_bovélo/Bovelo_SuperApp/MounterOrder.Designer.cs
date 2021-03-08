
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
            this.color_mounter = new System.Windows.Forms.Label();
            this.order_mounter = new System.Windows.Forms.Label();
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
            this.pnl_titles_week_orders.Controls.Add(this.color_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.order_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.business_name_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.client_name_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.size_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.time_mounter);
            this.pnl_titles_week_orders.Controls.Add(this.model_mounter);
            this.pnl_titles_week_orders.Location = new System.Drawing.Point(3, 13);
            this.pnl_titles_week_orders.Name = "pnl_titles_week_orders";
            this.pnl_titles_week_orders.Size = new System.Drawing.Size(1070, 40);
            this.pnl_titles_week_orders.TabIndex = 5;
            // 
            // color_mounter
            // 
            this.color_mounter.AutoSize = true;
            this.color_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_mounter.Location = new System.Drawing.Point(138, 0);
            this.color_mounter.Name = "color_mounter";
            this.color_mounter.Size = new System.Drawing.Size(96, 39);
            this.color_mounter.TabIndex = 4;
            this.color_mounter.Text = "Color";
            this.color_mounter.Click += new System.EventHandler(this.label1_Click);
            // 
            // order_mounter
            // 
            this.order_mounter.AutoSize = true;
            this.order_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.order_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_mounter.Location = new System.Drawing.Point(949, -1);
            this.order_mounter.Name = "order_mounter";
            this.order_mounter.Size = new System.Drawing.Size(94, 39);
            this.order_mounter.TabIndex = 2;
            this.order_mounter.Text = "order";
            // 
            // business_name_mounter
            // 
            this.business_name_mounter.AutoSize = true;
            this.business_name_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.business_name_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_name_mounter.Location = new System.Drawing.Point(587, 0);
            this.business_name_mounter.Name = "business_name_mounter";
            this.business_name_mounter.Size = new System.Drawing.Size(234, 39);
            this.business_name_mounter.TabIndex = 6;
            this.business_name_mounter.Text = "business name";
            // 
            // client_name_mounter
            // 
            this.client_name_mounter.AutoSize = true;
            this.client_name_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.client_name_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_name_mounter.Location = new System.Drawing.Point(367, -1);
            this.client_name_mounter.Name = "client_name_mounter";
            this.client_name_mounter.Size = new System.Drawing.Size(189, 39);
            this.client_name_mounter.TabIndex = 5;
            this.client_name_mounter.Text = "Client name";
            this.client_name_mounter.Click += new System.EventHandler(this.label3_Click);
            // 
            // size_mounter
            // 
            this.size_mounter.AutoSize = true;
            this.size_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.size_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_mounter.Location = new System.Drawing.Point(259, -1);
            this.size_mounter.Name = "size_mounter";
            this.size_mounter.Size = new System.Drawing.Size(80, 39);
            this.size_mounter.TabIndex = 3;
            this.size_mounter.Text = "Size";
            // 
            // time_mounter
            // 
            this.time_mounter.AutoSize = true;
            this.time_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_mounter.Location = new System.Drawing.Point(847, -1);
            this.time_mounter.Name = "time_mounter";
            this.time_mounter.Size = new System.Drawing.Size(79, 39);
            this.time_mounter.TabIndex = 0;
            this.time_mounter.Text = "time";
            // 
            // model_mounter
            // 
            this.model_mounter.AutoSize = true;
            this.model_mounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.model_mounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_mounter.Location = new System.Drawing.Point(6, -1);
            this.model_mounter.Name = "model_mounter";
            this.model_mounter.Size = new System.Drawing.Size(105, 39);
            this.model_mounter.TabIndex = 1;
            this.model_mounter.Text = "Model";
            // 
            // MounterOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_titles_week_orders);
            this.Name = "MounterOrder";
            this.Size = new System.Drawing.Size(1076, 68);
            this.Load += new System.EventHandler(this.MounterOrder_Load);
            this.pnl_titles_week_orders.ResumeLayout(false);
            this.pnl_titles_week_orders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_titles_week_orders;
        public System.Windows.Forms.Label color_mounter;
        public System.Windows.Forms.Label order_mounter;
        public System.Windows.Forms.Label business_name_mounter;
        public System.Windows.Forms.Label client_name_mounter;
        public System.Windows.Forms.Label size_mounter;
        public System.Windows.Forms.Label time_mounter;
        public System.Windows.Forms.Label model_mounter;
    }
}
