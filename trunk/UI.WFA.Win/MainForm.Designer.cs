namespace UI.WFA.Win
{
    partial class MainForm
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
            this.progressBarLoad = new System.Windows.Forms.ProgressBar();
            this.panelFoot = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelLoad = new System.Windows.Forms.Label();
            this.panelStep = new System.Windows.Forms.Panel();
            this.splitContainerStep = new System.Windows.Forms.SplitContainer();
            this.splitContainerStep2 = new System.Windows.Forms.SplitContainer();
            this.splitContainerStep1 = new System.Windows.Forms.SplitContainer();
            this.panelFoot.SuspendLayout();
            this.panelStep.SuspendLayout();
            this.splitContainerStep.Panel1.SuspendLayout();
            this.splitContainerStep.Panel2.SuspendLayout();
            this.splitContainerStep.SuspendLayout();
            this.splitContainerStep2.SuspendLayout();
            this.splitContainerStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarLoad
            // 
            this.progressBarLoad.ForeColor = System.Drawing.Color.DimGray;
            this.progressBarLoad.Location = new System.Drawing.Point(0, 0);
            this.progressBarLoad.Name = "progressBarLoad";
            this.progressBarLoad.Size = new System.Drawing.Size(528, 10);
            this.progressBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarLoad.TabIndex = 1;
            this.progressBarLoad.Value = 50;
            // 
            // panelFoot
            // 
            this.panelFoot.BackColor = System.Drawing.Color.DimGray;
            this.panelFoot.Controls.Add(this.progressBarLoad);
            this.panelFoot.Controls.Add(this.labelLoad);
            this.panelFoot.Controls.Add(this.buttonBack);
            this.panelFoot.Controls.Add(this.buttonNext);
            this.panelFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFoot.Location = new System.Drawing.Point(0, 530);
            this.panelFoot.Name = "panelFoot";
            this.panelFoot.Size = new System.Drawing.Size(682, 23);
            this.panelFoot.TabIndex = 4;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.ForeColor = System.Drawing.Color.DimGray;
            this.buttonNext.Location = new System.Drawing.Point(607, 0);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Avançar";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.DimGray;
            this.buttonBack.Location = new System.Drawing.Point(529, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(78, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Voltar";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelLoad
            // 
            this.labelLoad.BackColor = System.Drawing.Color.Transparent;
            this.labelLoad.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelLoad.Location = new System.Drawing.Point(0, 13);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(528, 10);
            this.labelLoad.TabIndex = 4;
            this.labelLoad.Text = "Carregando...";
            this.labelLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStep
            // 
            this.panelStep.Controls.Add(this.splitContainerStep);
            this.panelStep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStep.Location = new System.Drawing.Point(0, 454);
            this.panelStep.Name = "panelStep";
            this.panelStep.Size = new System.Drawing.Size(682, 76);
            this.panelStep.TabIndex = 5;
            // 
            // splitContainerStep
            // 
            this.splitContainerStep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainerStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerStep.IsSplitterFixed = true;
            this.splitContainerStep.Location = new System.Drawing.Point(0, 0);
            this.splitContainerStep.Name = "splitContainerStep";
            // 
            // splitContainerStep.Panel1
            // 
            this.splitContainerStep.Panel1.Controls.Add(this.splitContainerStep1);
            // 
            // splitContainerStep.Panel2
            // 
            this.splitContainerStep.Panel2.Controls.Add(this.splitContainerStep2);
            this.splitContainerStep.Size = new System.Drawing.Size(682, 76);
            this.splitContainerStep.SplitterDistance = 341;
            this.splitContainerStep.TabIndex = 0;
            // 
            // splitContainerStep2
            // 
            this.splitContainerStep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerStep2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerStep2.IsSplitterFixed = true;
            this.splitContainerStep2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerStep2.Name = "splitContainerStep2";
            // 
            // splitContainerStep2.Panel1
            // 
            this.splitContainerStep2.Panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            // 
            // splitContainerStep2.Panel2
            // 
            this.splitContainerStep2.Panel2.BackColor = System.Drawing.Color.LightCoral;
            this.splitContainerStep2.Size = new System.Drawing.Size(337, 76);
            this.splitContainerStep2.SplitterDistance = 170;
            this.splitContainerStep2.TabIndex = 0;
            // 
            // splitContainerStep1
            // 
            this.splitContainerStep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerStep1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerStep1.IsSplitterFixed = true;
            this.splitContainerStep1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerStep1.Name = "splitContainerStep1";
            // 
            // splitContainerStep1.Panel1
            // 
            this.splitContainerStep1.Panel1.BackColor = System.Drawing.Color.LightGreen;
            // 
            // splitContainerStep1.Panel2
            // 
            this.splitContainerStep1.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainerStep1.Size = new System.Drawing.Size(341, 76);
            this.splitContainerStep1.SplitterDistance = 170;
            this.splitContainerStep1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.panelStep);
            this.Controls.Add(this.panelFoot);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progressus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelFoot.ResumeLayout(false);
            this.panelStep.ResumeLayout(false);
            this.splitContainerStep.Panel1.ResumeLayout(false);
            this.splitContainerStep.Panel2.ResumeLayout(false);
            this.splitContainerStep.ResumeLayout(false);
            this.splitContainerStep2.ResumeLayout(false);
            this.splitContainerStep1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarLoad;
        private System.Windows.Forms.Panel panelFoot;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Panel panelStep;
        private System.Windows.Forms.SplitContainer splitContainerStep;
        private System.Windows.Forms.SplitContainer splitContainerStep1;
        private System.Windows.Forms.SplitContainer splitContainerStep2;
    }
}