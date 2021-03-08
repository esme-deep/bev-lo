
namespace Bovelo_SuperApp
{
    partial class MounterControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_week_orders_forMounter = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_GetBike_mounters = new System.Windows.Forms.Button();
            this.title_production_planning = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_titles_week_orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_titles_week_orders
            // 
            this.pnl_titles_week_orders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_titles_week_orders.Controls.Add(this.label7);
            this.pnl_titles_week_orders.Controls.Add(this.label1);
            this.pnl_titles_week_orders.Controls.Add(this.label5);
            this.pnl_titles_week_orders.Controls.Add(this.label6);
            this.pnl_titles_week_orders.Controls.Add(this.label3);
            this.pnl_titles_week_orders.Controls.Add(this.label8);
            this.pnl_titles_week_orders.Controls.Add(this.label2);
            this.pnl_titles_week_orders.Controls.Add(this.label4);
            this.pnl_titles_week_orders.Location = new System.Drawing.Point(3, 92);
            this.pnl_titles_week_orders.Name = "pnl_titles_week_orders";
            this.pnl_titles_week_orders.Size = new System.Drawing.Size(1077, 40);
            this.pnl_titles_week_orders.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "business";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnl_week_orders_forMounter
            // 
            this.pnl_week_orders_forMounter.AutoScroll = true;
            this.pnl_week_orders_forMounter.Location = new System.Drawing.Point(7, 137);
            this.pnl_week_orders_forMounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_week_orders_forMounter.Name = "pnl_week_orders_forMounter";
            this.pnl_week_orders_forMounter.Size = new System.Drawing.Size(1073, 248);
            this.pnl_week_orders_forMounter.TabIndex = 5;
            this.pnl_week_orders_forMounter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_week_orders_Paint);
            // 
            // btn_GetBike_mounters
            // 
            this.btn_GetBike_mounters.Location = new System.Drawing.Point(459, 413);
            this.btn_GetBike_mounters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GetBike_mounters.Name = "btn_GetBike_mounters";
            this.btn_GetBike_mounters.Size = new System.Drawing.Size(160, 52);
            this.btn_GetBike_mounters.TabIndex = 7;
            this.btn_GetBike_mounters.Text = "Get Bike";
            this.btn_GetBike_mounters.UseVisualStyleBackColor = true;
            this.btn_GetBike_mounters.Click += new System.EventHandler(this.btn_set_mounters_Click);
            // 
            // title_production_planning
            // 
            this.title_production_planning.AutoSize = true;
            this.title_production_planning.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_production_planning.Location = new System.Drawing.Point(484, 27);
            this.title_production_planning.Name = "title_production_planning";
            this.title_production_planning.Size = new System.Drawing.Size(135, 35);
            this.title_production_planning.TabIndex = 8;
            this.title_production_planning.Text = "Welcome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label7.Location = new System.Drawing.Point(931, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Statut";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // MounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title_production_planning);
            this.Controls.Add(this.btn_GetBike_mounters);
            this.Controls.Add(this.pnl_week_orders_forMounter);
            this.Controls.Add(this.pnl_titles_week_orders);
            this.Name = "MounterControl";
            this.Size = new System.Drawing.Size(1083, 537);
            this.pnl_titles_week_orders.ResumeLayout(false);
            this.pnl_titles_week_orders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnl_titles_week_orders;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GetBike_mounters;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_production_planning;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.FlowLayoutPanel pnl_week_orders_forMounter;
    }
}
