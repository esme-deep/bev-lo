﻿
namespace Bovelo_SuperApp
{
    partial class Index_Hautcs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Connection_User = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Connection_User);
            this.panel1.Location = new System.Drawing.Point(782, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 125);
            this.panel1.TabIndex = 3;
            // 
            // Connection_User
            // 
            this.Connection_User.AutoSize = true;
            this.Connection_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Connection_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_User.Location = new System.Drawing.Point(47, 19);
            this.Connection_User.Name = "Connection_User";
            this.Connection_User.Size = new System.Drawing.Size(223, 38);
            this.Connection_User.TabIndex = 0;
            this.Connection_User.Text = "Not connected";
            this.Connection_User.Click += new System.EventHandler(this.Connection_User_Click);
            // 
            // Index_Hautcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Index_Hautcs";
            this.Size = new System.Drawing.Size(1238, 175);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label Connection_User;
    }
}
