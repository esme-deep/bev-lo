
namespace Bovelo_SuperApp
{
    partial class Product
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Add_to_Cart = new System.Windows.Forms.Button();
            this.price_lbl = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxSize = new System.Windows.Forms.ComboBox();
            this.boxColor = new System.Windows.Forms.ComboBox();
            this.quatity_lbl = new System.Windows.Forms.Label();
            this.quantity_input = new System.Windows.Forms.DomainUpDown();
            this.pic_bike = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bike)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(681, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Size";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(615, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Colour";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_to_Cart
            // 
            this.Add_to_Cart.Location = new System.Drawing.Point(616, 98);
            this.Add_to_Cart.Name = "Add_to_Cart";
            this.Add_to_Cart.Size = new System.Drawing.Size(171, 41);
            this.Add_to_Cart.TabIndex = 18;
            this.Add_to_Cart.Text = "Add to cart";
            this.Add_to_Cart.UseVisualStyleBackColor = true;
            this.Add_to_Cart.Click += new System.EventHandler(this.Add_to_Cart_Click);
            // 
            // price_lbl
            // 
            this.price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.price_lbl.Location = new System.Drawing.Point(639, 49);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(113, 31);
            this.price_lbl.TabIndex = 17;
            this.price_lbl.Text = "Price";
            // 
            // label_desc
            // 
            this.label_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_desc.Location = new System.Drawing.Point(416, 98);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(194, 324);
            this.label_desc.TabIndex = 16;
            this.label_desc.Text = "Description";
            // 
            // label_model
            // 
            this.label_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_model.Location = new System.Drawing.Point(416, 49);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(194, 31);
            this.label_model.TabIndex = 15;
            this.label_model.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product";
            // 
            // BoxSize
            // 
            this.BoxSize.FormattingEnabled = true;
            this.BoxSize.Location = new System.Drawing.Point(663, 283);
            this.BoxSize.Name = "BoxSize";
            this.BoxSize.Size = new System.Drawing.Size(89, 21);
            this.BoxSize.TabIndex = 21;
            // 
            // boxColor
            // 
            this.boxColor.FormattingEnabled = true;
            this.boxColor.Location = new System.Drawing.Point(663, 200);
            this.boxColor.Name = "boxColor";
            this.boxColor.Size = new System.Drawing.Size(89, 21);
            this.boxColor.TabIndex = 20;
            this.boxColor.SelectedIndexChanged += new System.EventHandler(this.boxColor_SelectedIndexChanged);
            // 
            // quatity_lbl
            // 
            this.quatity_lbl.AutoSize = true;
            this.quatity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.quatity_lbl.Location = new System.Drawing.Point(674, 333);
            this.quatity_lbl.Name = "quatity_lbl";
            this.quatity_lbl.Size = new System.Drawing.Size(79, 20);
            this.quatity_lbl.TabIndex = 23;
            this.quatity_lbl.Text = "Quantity";
            // 
            // quantity_input
            // 
            this.quantity_input.Location = new System.Drawing.Point(672, 370);
            this.quantity_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantity_input.Name = "quantity_input";
            this.quantity_input.Size = new System.Drawing.Size(80, 20);
            this.quantity_input.TabIndex = 24;
            this.quantity_input.Text = "1";
            // 
            // pic_bike
            // 
            this.pic_bike.Location = new System.Drawing.Point(35, 85);
            this.pic_bike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_bike.Name = "pic_bike";
            this.pic_bike.Size = new System.Drawing.Size(330, 281);
            this.pic_bike.TabIndex = 25;
            this.pic_bike.TabStop = false;
            this.pic_bike.Click += new System.EventHandler(this.pic_bike_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_bike);
            this.Controls.Add(this.quantity_input);
            this.Controls.Add(this.quatity_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxSize);
            this.Controls.Add(this.boxColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add_to_Cart);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(812, 436);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_bike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button Add_to_Cart;
        public System.Windows.Forms.Label price_lbl;
        public System.Windows.Forms.Label label_desc;
        public System.Windows.Forms.Label label_model;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox BoxSize;
        public System.Windows.Forms.ComboBox boxColor;
        public System.Windows.Forms.Label quatity_lbl;
        public System.Windows.Forms.DomainUpDown quantity_input;
        public System.Windows.Forms.PictureBox pic_bike;
    }
}
