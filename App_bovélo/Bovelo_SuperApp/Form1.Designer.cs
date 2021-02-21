
namespace Bovelo_SuperApp
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.index_Hautcs1 = new Bovelo_SuperApp.Index_Hautcs();
            this.index_Gauche1 = new Bovelo_SuperApp.Index_Gauche();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelContainer.Location = new System.Drawing.Point(180, 137);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1082, 536);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // index_Hautcs1
            // 
            this.index_Hautcs1.BackColor = System.Drawing.SystemColors.Highlight;
            this.index_Hautcs1.Location = new System.Drawing.Point(180, 0);
            this.index_Hautcs1.Name = "index_Hautcs1";
            this.index_Hautcs1.Size = new System.Drawing.Size(1106, 142);
            this.index_Hautcs1.TabIndex = 1;
            // 
            // index_Gauche1
            // 
            this.index_Gauche1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.index_Gauche1.Location = new System.Drawing.Point(0, 0);
            this.index_Gauche1.Name = "index_Gauche1";
            this.index_Gauche1.Size = new System.Drawing.Size(180, 720);
            this.index_Gauche1.TabIndex = 0;
            this.index_Gauche1.Load += new System.EventHandler(this.index_Gauche1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.index_Hautcs1);
            this.Controls.Add(this.index_Gauche1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Index_Gauche index_Gauche1;
        private Index_Hautcs index_Hautcs1;
        private System.Windows.Forms.Panel panelContainer;
    }
}

