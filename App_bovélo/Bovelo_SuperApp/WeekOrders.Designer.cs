
namespace Bovelo_SuperApp
{
    partial class WeekOrders
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
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_business_name = new System.Windows.Forms.Label();
            this.lbl_client_name = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.OrderOfProduction = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(3, 18);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(126, 46);
            this.lbl_model.TabIndex = 2;
            this.lbl_model.Text = "Model";
            // 
            // lbl_business_name
            // 
            this.lbl_business_name.AutoSize = true;
            this.lbl_business_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_business_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_business_name.Location = new System.Drawing.Point(535, 18);
            this.lbl_business_name.Name = "lbl_business_name";
            this.lbl_business_name.Size = new System.Drawing.Size(176, 46);
            this.lbl_business_name.TabIndex = 12;
            this.lbl_business_name.Text = "Business";
            this.lbl_business_name.Click += new System.EventHandler(this.lbl_business_name_Click);
            // 
            // lbl_client_name
            // 
            this.lbl_client_name.AutoSize = true;
            this.lbl_client_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client_name.Location = new System.Drawing.Point(320, 18);
            this.lbl_client_name.Name = "lbl_client_name";
            this.lbl_client_name.Size = new System.Drawing.Size(130, 46);
            this.lbl_client_name.TabIndex = 11;
            this.lbl_client_name.Text = "Client ";
            this.lbl_client_name.Click += new System.EventHandler(this.lbl_client_name_Click);
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(214, 18);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(96, 46);
            this.lbl_size.TabIndex = 9;
            this.lbl_size.Text = "Size";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(772, 18);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(96, 46);
            this.lbl_time.TabIndex = 7;
            this.lbl_time.Text = "time";
            this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click_1);
            // 
            // OrderOfProduction
            // 
            this.OrderOfProduction.AccessibleName = "OrderOfProduction";
            this.OrderOfProduction.Items.Add("1");
            this.OrderOfProduction.Items.Add("2");
            this.OrderOfProduction.Items.Add("3");
            this.OrderOfProduction.Items.Add("4");
            this.OrderOfProduction.Items.Add("5");
            this.OrderOfProduction.Items.Add("6");
            this.OrderOfProduction.Items.Add("7");
            this.OrderOfProduction.Items.Add("8");
            this.OrderOfProduction.Items.Add("9");
            this.OrderOfProduction.Items.Add("10");
            this.OrderOfProduction.Items.Add("11");
            this.OrderOfProduction.Items.Add("12");
            this.OrderOfProduction.Items.Add("13");
            this.OrderOfProduction.Items.Add("14");
            this.OrderOfProduction.Items.Add("15");
            this.OrderOfProduction.Items.Add("16");
            this.OrderOfProduction.Items.Add("17");
            this.OrderOfProduction.Items.Add("18");
            this.OrderOfProduction.Items.Add("19");
            this.OrderOfProduction.Items.Add("20");
            this.OrderOfProduction.Location = new System.Drawing.Point(1015, 36);
            this.OrderOfProduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderOfProduction.Name = "OrderOfProduction";
            this.OrderOfProduction.Size = new System.Drawing.Size(119, 26);
            this.OrderOfProduction.TabIndex = 14;
            this.OrderOfProduction.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged_2);
            // 
            // WeekOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderOfProduction);
            this.Controls.Add(this.lbl_business_name);
            this.Controls.Add(this.lbl_client_name);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_model);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WeekOrders";
            this.Size = new System.Drawing.Size(1496, 80);
            this.Load += new System.EventHandler(this.WeekOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_model;
        public System.Windows.Forms.Label lbl_business_name;
        public System.Windows.Forms.Label lbl_client_name;
        public System.Windows.Forms.Label lbl_size;
        public System.Windows.Forms.Label lbl_time;
        public System.Windows.Forms.DomainUpDown OrderOfProduction;
    }
}
