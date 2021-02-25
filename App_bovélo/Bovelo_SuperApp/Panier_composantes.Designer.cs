
namespace Bovelo_SuperApp
{
    partial class Panier_composantes
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
            this.Vélo_Image = new System.Windows.Forms.PictureBox();
            this.model_name = new System.Windows.Forms.Label();
            this.colour_text = new System.Windows.Forms.Label();
            this.size_text = new System.Windows.Forms.Label();
            this.qtt_number = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.Remove_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vélo_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Vélo_Image
            // 
            this.Vélo_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vélo_Image.Location = new System.Drawing.Point(0, 0);
            this.Vélo_Image.Name = "Vélo_Image";
            this.Vélo_Image.Size = new System.Drawing.Size(107, 107);
            this.Vélo_Image.TabIndex = 0;
            this.Vélo_Image.TabStop = false;
            // 
            // model_name
            // 
            this.model_name.AutoSize = true;
            this.model_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_name.Location = new System.Drawing.Point(113, 35);
            this.model_name.Name = "model_name";
            this.model_name.Size = new System.Drawing.Size(87, 31);
            this.model_name.TabIndex = 1;
            this.model_name.Text = "Model";
            // 
            // colour_text
            // 
            this.colour_text.AutoSize = true;
            this.colour_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colour_text.Location = new System.Drawing.Point(229, 35);
            this.colour_text.Name = "colour_text";
            this.colour_text.Size = new System.Drawing.Size(88, 31);
            this.colour_text.TabIndex = 2;
            this.colour_text.Text = "colour";
            // 
            // size_text
            // 
            this.size_text.AutoSize = true;
            this.size_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size_text.Location = new System.Drawing.Point(345, 35);
            this.size_text.Name = "size_text";
            this.size_text.Size = new System.Drawing.Size(63, 31);
            this.size_text.TabIndex = 3;
            this.size_text.Text = "size";
            // 
            // qtt_number
            // 
            this.qtt_number.AutoSize = true;
            this.qtt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtt_number.Location = new System.Drawing.Point(456, 35);
            this.qtt_number.Name = "qtt_number";
            this.qtt_number.Size = new System.Drawing.Size(45, 31);
            this.qtt_number.TabIndex = 4;
            this.qtt_number.Text = "qtt";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(535, 35);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(73, 31);
            this.Price_label.TabIndex = 5;
            this.Price_label.Text = "price";
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(677, 43);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(24, 23);
            this.Remove_button.TabIndex = 6;
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // Panier_composantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.qtt_number);
            this.Controls.Add(this.size_text);
            this.Controls.Add(this.colour_text);
            this.Controls.Add(this.model_name);
            this.Controls.Add(this.Vélo_Image);
            this.Name = "Panier_composantes";
            this.Size = new System.Drawing.Size(734, 107);
            this.Load += new System.EventHandler(this.Panier_composantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vélo_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Vélo_Image;
        public System.Windows.Forms.Label model_name;
        public System.Windows.Forms.Label colour_text;
        public System.Windows.Forms.Label size_text;
        public System.Windows.Forms.Label qtt_number;
        public System.Windows.Forms.Label Price_label;
        public System.Windows.Forms.Button Remove_button;
    }
}
