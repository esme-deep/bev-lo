﻿
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
            this.label8.Location = new System.Drawing.Point(1022, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Size";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(922, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "Colour";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_to_Cart
            // 
            this.Add_to_Cart.Location = new System.Drawing.Point(924, 151);
            this.Add_to_Cart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_to_Cart.Name = "Add_to_Cart";
            this.Add_to_Cart.Size = new System.Drawing.Size(256, 63);
            this.Add_to_Cart.TabIndex = 18;
            this.Add_to_Cart.Text = "Add to cart";
            this.Add_to_Cart.UseVisualStyleBackColor = true;
            this.Add_to_Cart.Click += new System.EventHandler(this.Add_to_Cart_Click);
            // 
            // price_lbl
            // 
            this.price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.price_lbl.Location = new System.Drawing.Point(958, 75);
            this.price_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(170, 48);
            this.price_lbl.TabIndex = 17;
            this.price_lbl.Text = "Price";
            // 
            // label_desc
            // 
            this.label_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_desc.Location = new System.Drawing.Point(624, 151);
            this.label_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(290, 497);
            this.label_desc.TabIndex = 16;
            this.label_desc.Text = "Description";
            // 
            // label_model
            // 
            this.label_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label_model.Location = new System.Drawing.Point(624, 75);
            this.label_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(290, 47);
            this.label_model.TabIndex = 15;
            this.label_model.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product View";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Product";
            // 
            // BoxSize
            // 
            this.BoxSize.FormattingEnabled = true;
            this.BoxSize.Location = new System.Drawing.Point(994, 435);
            this.BoxSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxSize.Name = "BoxSize";
            this.BoxSize.Size = new System.Drawing.Size(132, 28);
            this.BoxSize.TabIndex = 21;
            // 
            // boxColor
            // 
            this.boxColor.FormattingEnabled = true;
            this.boxColor.Location = new System.Drawing.Point(994, 308);
            this.boxColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boxColor.Name = "boxColor";
            this.boxColor.Size = new System.Drawing.Size(132, 28);
            this.boxColor.TabIndex = 20;
            // 
            // quatity_lbl
            // 
            this.quatity_lbl.AutoSize = true;
            this.quatity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.quatity_lbl.Location = new System.Drawing.Point(1011, 513);
            this.quatity_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quatity_lbl.Name = "quatity_lbl";
            this.quatity_lbl.Size = new System.Drawing.Size(115, 29);
            this.quatity_lbl.TabIndex = 23;
            this.quatity_lbl.Text = "Quantity";
            // 
            // quantity_input
            // 
            this.quantity_input.Location = new System.Drawing.Point(1008, 569);
            this.quantity_input.Name = "quantity_input";
            this.quantity_input.Size = new System.Drawing.Size(120, 26);
            this.quantity_input.TabIndex = 24;
            this.quantity_input.Text = "1";
            // 
            // pic_bike
            // 
            this.pic_bike.Location = new System.Drawing.Point(53, 131);
            this.pic_bike.Name = "pic_bike";
            this.pic_bike.Size = new System.Drawing.Size(495, 433);
            this.pic_bike.TabIndex = 25;
            this.pic_bike.TabStop = false;
            this.pic_bike.Click += new System.EventHandler(this.pic_bike_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
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
            this.Name = "Product";
            this.Size = new System.Drawing.Size(1218, 671);
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
