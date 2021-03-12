
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
            this.pic_bike = new System.Windows.Forms.PictureBox();
            this.label_price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Model = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bike)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pic_bike);
            this.panel2.Controls.Add(this.label_price);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label_Model);
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 239);
            this.panel2.TabIndex = 2;
            // 
            // pic_bike
            // 
            this.pic_bike.Location = new System.Drawing.Point(52, 3);
            this.pic_bike.Name = "pic_bike";
            this.pic_bike.Size = new System.Drawing.Size(300, 163);
            this.pic_bike.TabIndex = 5;
            this.pic_bike.TabStop = false;
            this.pic_bike.Click += new System.EventHandler(this.pic_bike_Click);
            // 
            // label_price
            // 
            this.label_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_price.Location = new System.Drawing.Point(224, 203);
            this.label_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(186, 33);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "From 399.99 $";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Model
            // 
            this.label_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_Model.Location = new System.Drawing.Point(6, 166);
            this.label_Model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(401, 31);
            this.label_Model.TabIndex = 1;
            this.label_Model.Text = "City";
            this.label_Model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product_catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Product_catalog";
            this.Size = new System.Drawing.Size(450, 277);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_bike)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label_price;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label_Model;
        public System.Windows.Forms.PictureBox pic_bike;
    }
}
