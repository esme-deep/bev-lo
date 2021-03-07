
namespace Bovelo_SuperApp
{
    partial class production_planning
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
            this.title_production_planning = new System.Windows.Forms.Label();
            this.btn_get_orders = new System.Windows.Forms.Button();
            this.pnl_titles_week_orders = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_week_orders = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_set_mounters = new System.Windows.Forms.Button();
            this.pnl_titles_week_orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_production_planning
            // 
            this.title_production_planning.AutoSize = true;
            this.title_production_planning.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_production_planning.Location = new System.Drawing.Point(536, 23);
            this.title_production_planning.Name = "title_production_planning";
            this.title_production_planning.Size = new System.Drawing.Size(162, 41);
            this.title_production_planning.TabIndex = 0;
            this.title_production_planning.Text = "Welcome";
            this.title_production_planning.Click += new System.EventHandler(this.title_production_planning_Click);
            // 
            // btn_get_orders
            // 
            this.btn_get_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_orders.Location = new System.Drawing.Point(538, 381);
            this.btn_get_orders.Name = "btn_get_orders";
            this.btn_get_orders.Size = new System.Drawing.Size(160, 67);
            this.btn_get_orders.TabIndex = 1;
            this.btn_get_orders.Text = "Get this week orders";
            this.btn_get_orders.UseVisualStyleBackColor = true;
            this.btn_get_orders.Click += new System.EventHandler(this.btn_get_orders_Click);
            // 
            // pnl_titles_week_orders
            // 
            this.pnl_titles_week_orders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_titles_week_orders.Controls.Add(this.label5);
            this.pnl_titles_week_orders.Controls.Add(this.label1);
            this.pnl_titles_week_orders.Controls.Add(this.label6);
            this.pnl_titles_week_orders.Controls.Add(this.label3);
            this.pnl_titles_week_orders.Controls.Add(this.label8);
            this.pnl_titles_week_orders.Controls.Add(this.label2);
            this.pnl_titles_week_orders.Controls.Add(this.label4);
            this.pnl_titles_week_orders.Location = new System.Drawing.Point(3, 88);
            this.pnl_titles_week_orders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_titles_week_orders.Name = "pnl_titles_week_orders";
            this.pnl_titles_week_orders.Size = new System.Drawing.Size(1228, 50);
            this.pnl_titles_week_orders.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1068, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 46);
            this.label5.TabIndex = 2;
            this.label5.Text = "order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(885, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "mounter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(499, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 46);
            this.label6.TabIndex = 6;
            this.label6.Text = "business name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 46);
            this.label8.TabIndex = 3;
            this.label8.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(783, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model";
            // 
            // pnl_week_orders
            // 
            this.pnl_week_orders.AutoScroll = true;
            this.pnl_week_orders.Location = new System.Drawing.Point(7, 138);
            this.pnl_week_orders.Name = "pnl_week_orders";
            this.pnl_week_orders.Size = new System.Drawing.Size(1211, 310);
            this.pnl_week_orders.TabIndex = 4;
            this.pnl_week_orders.Visible = false;
            // 
            // btn_set_mounters
            // 
            this.btn_set_mounters.Location = new System.Drawing.Point(529, 488);
            this.btn_set_mounters.Name = "btn_set_mounters";
            this.btn_set_mounters.Size = new System.Drawing.Size(180, 65);
            this.btn_set_mounters.TabIndex = 6;
            this.btn_set_mounters.Text = "Confirm";
            this.btn_set_mounters.UseVisualStyleBackColor = true;
            this.btn_set_mounters.Click += new System.EventHandler(this.btn_set_mounters_Click);
            // 
            // production_planning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_set_mounters);
            this.Controls.Add(this.pnl_week_orders);
            this.Controls.Add(this.pnl_titles_week_orders);
            this.Controls.Add(this.btn_get_orders);
            this.Controls.Add(this.title_production_planning);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "production_planning";
            this.Size = new System.Drawing.Size(1218, 671);
            this.pnl_titles_week_orders.ResumeLayout(false);
            this.pnl_titles_week_orders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_production_planning;
        private System.Windows.Forms.Button btn_get_orders;
        public System.Windows.Forms.Panel pnl_titles_week_orders;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnl_week_orders;
        private System.Windows.Forms.Button btn_set_mounters;
    }
}
