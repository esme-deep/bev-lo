
namespace Bovelo_SuperApp
{
    partial class Index_Gauche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index_Gauche));
            this.Catalog_Button = new System.Windows.Forms.Button();
            this.Cart_Button = new System.Windows.Forms.Button();
            this.Client_info = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Log_in_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Catalog_Button
            // 
            this.Catalog_Button.Enabled = false;
            this.Catalog_Button.Location = new System.Drawing.Point(0, 121);
            this.Catalog_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Catalog_Button.Name = "Catalog_Button";
            this.Catalog_Button.Size = new System.Drawing.Size(135, 81);
            this.Catalog_Button.TabIndex = 0;
            this.Catalog_Button.Text = "Catalog";
            this.Catalog_Button.UseVisualStyleBackColor = true;
            this.Catalog_Button.Visible = false;
            this.Catalog_Button.Click += new System.EventHandler(this.Catalog_Button_Click);
            // 
            // Cart_Button
            // 
            this.Cart_Button.Enabled = false;
            this.Cart_Button.Location = new System.Drawing.Point(0, 207);
            this.Cart_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cart_Button.Name = "Cart_Button";
            this.Cart_Button.Size = new System.Drawing.Size(135, 81);
            this.Cart_Button.TabIndex = 1;
            this.Cart_Button.Text = "Cart";
            this.Cart_Button.UseVisualStyleBackColor = true;
            this.Cart_Button.Visible = false;
            this.Cart_Button.Click += new System.EventHandler(this.Cart_Button_Click);
            // 
            // Client_info
            // 
            this.Client_info.Enabled = false;
            this.Client_info.Location = new System.Drawing.Point(0, 293);
            this.Client_info.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Client_info.Name = "Client_info";
            this.Client_info.Size = new System.Drawing.Size(135, 81);
            this.Client_info.TabIndex = 2;
            this.Client_info.Text = "Client information";
            this.Client_info.UseVisualStyleBackColor = true;
            this.Client_info.Visible = false;
            this.Client_info.Click += new System.EventHandler(this.Client_info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 114);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Log_in_Button
            // 
            this.Log_in_Button.Location = new System.Drawing.Point(0, 380);
            this.Log_in_Button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Log_in_Button.Name = "Log_in_Button";
            this.Log_in_Button.Size = new System.Drawing.Size(135, 81);
            this.Log_in_Button.TabIndex = 4;
            this.Log_in_Button.Text = "Sign in";
            this.Log_in_Button.UseVisualStyleBackColor = true;
            this.Log_in_Button.Click += new System.EventHandler(this.Log_In_Button_Click);
            // 
            // Index_Gauche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.Log_in_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Client_info);
            this.Controls.Add(this.Cart_Button);
            this.Controls.Add(this.Catalog_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Index_Gauche";
            this.Size = new System.Drawing.Size(135, 585);
            this.Load += new System.EventHandler(this.Index_Gauche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Catalog_Button;
        public System.Windows.Forms.Button Cart_Button;
        public System.Windows.Forms.Button Client_info;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Log_in_Button;
    }
}
