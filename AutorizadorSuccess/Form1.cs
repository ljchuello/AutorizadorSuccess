using System;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace AutorizadorSuccess
{
    public partial class Form1 : MetroForm
    {
        private bool _activo = false;
        private string url = string.Empty;

        public Form1()
        {
            InitializeComponent();
            Text = "Mile Autorizador 🤣";
        }

        #region Botonera

        private void btnLocal_Click(object sender, EventArgs e)
        {
            _activo = true;
            url = "http://localhost:52659/";
            DisableBotones();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            _activo = true;
            url = "https://pruebas.mileniumweb.com/";
            DisableBotones();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            _activo = true;
            url = "https://mileniumweb.com/";
            DisableBotones();
        }

        void DisableBotones()
        {
            btnLocal.Enabled = false;
            btnPrueba.Enabled = false;
            btnProduccion.Enabled = false;
        }

        #endregion
    }
}
