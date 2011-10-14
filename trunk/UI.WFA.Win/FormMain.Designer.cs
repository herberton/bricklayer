namespace UI.WFA.Win
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonAvancar = new System.Windows.Forms.Button();
            this.ucPasso11 = new UI.WFA.Win.UC.UCPasso1();
            this.panelFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ForeColor = System.Drawing.Color.DimGray;
            this.progressBar.Location = new System.Drawing.Point(0, 1);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(609, 10);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 50;
            // 
            // panelFoot
            // 
            this.panelFoot.BackColor = System.Drawing.Color.DimGray;
            this.panelFoot.Controls.Add(this.progressBar);
            this.panelFoot.Controls.Add(this.labelProgressBar);
            this.panelFoot.Controls.Add(this.buttonVoltar);
            this.panelFoot.Controls.Add(this.buttonAvancar);
            this.panelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoot.Location = new System.Drawing.Point(0, 377);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(763, 23);
            this.panelFoot.TabIndex = 4;
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.labelProgressBar.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelProgressBar.Location = new System.Drawing.Point(0, 13);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(609, 10);
            this.labelProgressBar.TabIndex = 4;
            this.labelProgressBar.Text = "Carregando...";
            this.labelProgressBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVoltar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVoltar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.ForeColor = System.Drawing.Color.DimGray;
            this.buttonVoltar.Location = new System.Drawing.Point(611, -1);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(78, 23);
            this.buttonVoltar.TabIndex = 7;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAvancar
            // 
            this.buttonAvancar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAvancar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAvancar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonAvancar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonAvancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvancar.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAvancar.Location = new System.Drawing.Point(689, -1);
            this.buttonAvancar.Name = "buttonAvancar";
            this.buttonAvancar.Size = new System.Drawing.Size(75, 23);
            this.buttonAvancar.TabIndex = 6;
            this.buttonAvancar.Text = "Avançar";
            this.buttonAvancar.UseVisualStyleBackColor = false;
            this.buttonAvancar.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // ucPasso11
            // 
            this.ucPasso11.BackColor = System.Drawing.Color.Transparent;
            this.ucPasso11.Cursor = System.Windows.Forms.Cursors.Default;
            this.ucPasso11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPasso11.Location = new System.Drawing.Point(0, 0);
            this.ucPasso11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucPasso11.Name = "ucPasso11";
            this.ucPasso11.Size = new System.Drawing.Size(763, 377);
            this.ucPasso11.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(763, 400);
            this.Controls.Add(this.ucPasso11);
            this.Controls.Add(this.panelFoot);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progressus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelFoot.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.Button buttonAvancar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelProgressBar;
        private UI.WFA.Win.UC.UCPasso1 ucPasso11;
    }
}