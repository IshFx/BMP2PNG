namespace BMP2PNG
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Main_progressBar = new System.Windows.Forms.ProgressBar();
            this.Main_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop BMP images here ...";
            // 
            // Main_progressBar
            // 
            this.Main_progressBar.Location = new System.Drawing.Point(12, 81);
            this.Main_progressBar.Name = "Main_progressBar";
            this.Main_progressBar.Size = new System.Drawing.Size(213, 23);
            this.Main_progressBar.TabIndex = 1;
            // 
            // Main_checkbox
            // 
            this.Main_checkbox.AutoSize = true;
            this.Main_checkbox.Location = new System.Drawing.Point(12, 58);
            this.Main_checkbox.Name = "Main_checkbox";
            this.Main_checkbox.Size = new System.Drawing.Size(156, 17);
            this.Main_checkbox.TabIndex = 2;
            this.Main_checkbox.Text = "Delete BMP files afterwards";
            this.Main_checkbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 115);
            this.Controls.Add(this.Main_checkbox);
            this.Controls.Add(this.Main_progressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMP2PNG";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar Main_progressBar;
        private System.Windows.Forms.CheckBox Main_checkbox;
    }
}

