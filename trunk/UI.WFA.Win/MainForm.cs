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
    public partial class MainForm : Form
    {
        #region Constructors

        public MainForm()
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
            this.IsLoadVisible(true);
            this.IsButtonBackVisible(false);
        }

        private void Avancar()
        {
            this.IsButtonBackVisible(true);
            this.IsButtonNextFinish(true);
        }

        private void Voltar()
        {
            this.IsButtonBackVisible(false);
            this.IsButtonNextFinish(false);
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

        public void IsLoadVisible(Boolean visible)
        {
            this.progressBarLoad.Visible =
                this.labelLoad.Visible = visible;

            this.progressBarLoad.Value = visible ? 50 : 0;
        }

        public void IsButtonBackVisible(bool visible)
        {
            this.buttonBack.Visible = visible;
            this.progressBarLoad.Size =
                this.labelLoad.Size =
                    visible ?
                        new Size(528, 10) :
                        new Size(528 + this.buttonBack.Size.Width, 10);
        }

        public void IsButtonNextFinish(Boolean finish)
        {
            this.buttonNext.Text = finish ? "Concluir" : "Avançar";
        }

        #endregion
    }
}
