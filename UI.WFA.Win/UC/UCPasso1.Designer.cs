namespace UI.WFA.Win.UC
{
    partial class UCPasso1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNomeProjeto = new System.Windows.Forms.Label();
            this.textBoxNomeProjeto = new System.Windows.Forms.TextBox();
            this.groupBoxProjeto = new System.Windows.Forms.GroupBox();
            this.groupBoxProjeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNomeProjeto
            // 
            this.labelNomeProjeto.AutoSize = true;
            this.labelNomeProjeto.Location = new System.Drawing.Point(6, 16);
            this.labelNomeProjeto.Name = "labelNomeProjeto";
            this.labelNomeProjeto.Size = new System.Drawing.Size(35, 13);
            this.labelNomeProjeto.TabIndex = 0;
            this.labelNomeProjeto.Text = "Nome";
            // 
            // textBoxNomeProjeto
            // 
            this.textBoxNomeProjeto.Location = new System.Drawing.Point(43, 13);
            this.textBoxNomeProjeto.Name = "textBoxNomeProjeto";
            this.textBoxNomeProjeto.Size = new System.Drawing.Size(282, 20);
            this.textBoxNomeProjeto.TabIndex = 1;
            // 
            // groupBoxProjeto
            // 
            this.groupBoxProjeto.Controls.Add(this.textBoxNomeProjeto);
            this.groupBoxProjeto.Controls.Add(this.labelNomeProjeto);
            this.groupBoxProjeto.Location = new System.Drawing.Point(3, 0);
            this.groupBoxProjeto.Name = "groupBoxProjeto";
            this.groupBoxProjeto.Size = new System.Drawing.Size(331, 44);
            this.groupBoxProjeto.TabIndex = 6;
            this.groupBoxProjeto.TabStop = false;
            this.groupBoxProjeto.Text = "Projeto";
            // 
            // UCPasso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxProjeto);
            this.Name = "UCPasso1";
            this.Size = new System.Drawing.Size(338, 50);
            this.groupBoxProjeto.ResumeLayout(false);
            this.groupBoxProjeto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNomeProjeto;
        private System.Windows.Forms.TextBox textBoxNomeProjeto;
        private System.Windows.Forms.GroupBox groupBoxProjeto;

    }
}
