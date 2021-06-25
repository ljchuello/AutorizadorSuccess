using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutorizadorSuccess.Libreria;
using MetroFramework.Forms;

namespace AutorizadorSuccess
{
    public partial class Form1 : MetroForm
    {
        private bool _activo = false;
        private string url = string.Empty;

        private Resumen _resumen = new Resumen();

        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Text = "Mile Autorizador 🤣";

            Resumen();
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

        #region Resumen

        async Task Resumen()
        {
            lblResumen.Text = string.Empty;
            await Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        // Validamos
                        if (_activo)
                        {
                            // Obtenemos
                            List<Resumen> listResumen = await _resumen.Get_Async(url);

                            // string
                            StringBuilder stringBuilder = new StringBuilder();

                            // Recorremos
                            foreach (Resumen row in listResumen)
                            {
                                stringBuilder.AppendLine($"{row.Clave} => {row.Valor}");
                            }

                            // Seteamos
                            lblResumen.Text = stringBuilder.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        Thread.Sleep(2500);
                    }
                }
            });
        }

        #endregion
    }
}
