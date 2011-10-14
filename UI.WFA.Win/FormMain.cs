using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.WFA.Win
{
    public partial class FormMain : Form
    {
        #region Properties

        public int CarregarWidth { get; set; }

        #endregion

        #region Constructors

        public FormMain()
        {
            InitializeComponent();
            this.Carregar();
        }

        #endregion

        #region Events

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Fechar(e);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Avancar();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Voltar();
        }

        #endregion

        #region Methods

        private void Carregar()
        {
            this.CarregarWidth = this.progressBar.Size.Width;
            this.IsCarregarVisible(true);
            this.IsButtonVoltarVisible(false);
        }

        private void Avancar()
        {
            this.IsButtonVoltarVisible(true);
            this.IsButtonFinalizar(true);
        }

        private void Voltar()
        {
            this.IsButtonVoltarVisible(false);
            this.IsButtonFinalizar(false);
        }

        private void Fechar(FormClosingEventArgs e)
        {
            DialogResult dialogResult =
                MessageBox
                    .Show(
                        "Deseja realmente sair?",
                        "Atenção!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2
                    );

            e.Cancel =
                dialogResult.Equals(DialogResult.Abort) ||
                dialogResult.Equals(DialogResult.Cancel) ||
                dialogResult.Equals(DialogResult.Ignore) ||
                dialogResult.Equals(DialogResult.No) ||
                dialogResult.Equals(DialogResult.None);
        }

        public void IsCarregarVisible(Boolean isVisible)
        {
            this.progressBar.Visible =
                this.labelProgressBar.Visible = isVisible;

            this.progressBar.Value = isVisible ? 50 : 0;
        }

        public void IsButtonVoltarVisible(bool isVisible)
        {
            this.buttonVoltar.Visible = isVisible;
            this.progressBar.Size =
                this.labelProgressBar.Size =
                    isVisible ?
                        new Size(this.CarregarWidth, 10) :
                        new Size(this.CarregarWidth + this.buttonVoltar.Size.Width, 10);
        }

        public void IsButtonFinalizar(Boolean isFinish)
        {
            this.buttonAvancar.Text = isFinish ? "Concluir" : "Avançar";
        }

        #endregion
    }
}
