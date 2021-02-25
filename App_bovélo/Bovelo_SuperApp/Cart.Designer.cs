
namespace Bovelo_SuperApp
{
    partial class Cart
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
            this.FLPanel_Cart = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_cart_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Price_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FLPanel_Cart
            // 
            this.FLPanel_Cart.AutoScroll = true;
            this.FLPanel_Cart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLPanel_Cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLPanel_Cart.Location = new System.Drawing.Point(234, 92);
            this.FLPanel_Cart.Name = "FLPanel_Cart";
            this.FLPanel_Cart.Size = new System.Drawing.Size(720, 428);
            this.FLPanel_Cart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cart";
            // 
            // confirm_cart_button
            // 
            this.confirm_cart_button.Location = new System.Drawing.Point(987, 440);
            this.confirm_cart_button.Name = "confirm_cart_button";
            this.confirm_cart_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_cart_button.TabIndex = 2;
            this.confirm_cart_button.Text = "Confirm cart";
            this.confirm_cart_button.UseVisualStyleBackColor = true;
            this.confirm_cart_button.Click += new System.EventHandler(this.confirm_cart_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Price_Label);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(234, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 40);
            this.panel1.TabIndex = 0;
            // 
            // Price_Label
            // 
            this.Price_Label.AutoSize = true;
            this.Price_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Label.Location = new System.Drawing.Point(536, 0);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(74, 32);
            this.Price_Label.TabIndex = 5;
            this.Price_Label.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Colour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Image";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirm_cart_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FLPanel_Cart);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(1082, 536);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel FLPanel_Cart;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button confirm_cart_button;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label Price_Label;
    }
}
