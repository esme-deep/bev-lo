
namespace Bovelo_SuperApp
{
    partial class Productcs
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
            this.label5 = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxSize = new System.Windows.Forms.ComboBox();
            this.boxColor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
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
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(416, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 324);
            this.label5.TabIndex = 16;
            this.label5.Text = "Description";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(26, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 374);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Image";
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
            this.BoxSize.Items.AddRange(new object[] {
            "M",
            "L"});
            this.BoxSize.Location = new System.Drawing.Point(663, 283);
            this.BoxSize.Name = "BoxSize";
            this.BoxSize.Size = new System.Drawing.Size(89, 21);
            this.BoxSize.TabIndex = 21;
            this.BoxSize.SelectedIndexChanged += new System.EventHandler(this.BoxSize_SelectedIndexChanged);
            // 
            // boxColor
            // 
            this.boxColor.FormattingEnabled = true;
            this.boxColor.Items.AddRange(new object[] {
            "Rouge",
            "Vert",
            "Noir"});
            this.boxColor.Location = new System.Drawing.Point(663, 200);
            this.boxColor.Name = "boxColor";
            this.boxColor.Size = new System.Drawing.Size(89, 21);
            this.boxColor.TabIndex = 20;
            // 
            // Productcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxSize);
            this.Controls.Add(this.boxColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add_to_Cart);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Productcs";
            this.Size = new System.Drawing.Size(812, 436);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Add_to_Cart;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxSize;
        private System.Windows.Forms.ComboBox boxColor;
        
    }
}
