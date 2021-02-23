
namespace Bovelo_SuperApp
{
    partial class Product_catalog
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_price);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel);
            this.panel2.Controls.Add(this.label_Model);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 156);
            this.panel2.TabIndex = 2;
            // 
            // label_price
            // 
            this.label_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_price.Location = new System.Drawing.Point(149, 132);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(125, 22);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "From 399.99 $";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.label4);
            this.panel.Location = new System.Drawing.Point(4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(270, 100);
            this.panel.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Image1";
            // 
            // label_Model
            // 
            this.label_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Model.Location = new System.Drawing.Point(4, 108);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(268, 21);
            this.label_Model.TabIndex = 1;
            this.label_Model.Text = "City";
            this.label_Model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product_catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Product_catalog";
            this.Size = new System.Drawing.Size(300, 180);
            this.panel2.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label_price;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Label label_Model;
        public System.Windows.Forms.Label label4;
    }
}
