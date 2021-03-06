using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutorizadorSuccess.Libreria;
using MetroFramework.Forms;

namespace AutorizadorSuccess
{
    public partial class Form1 : MetroForm
    {
        private bool _activo = false;
        private string url = string.Empty;

        private Autorizacion _autorizacion = new Autorizacion();
        private Resumen _resumen = new Resumen();

        private List<Autorizacion> listEnviado = new List<Autorizacion>();
        private List<Autorizacion> listRecibido = new List<Autorizacion>();
        private List<Autorizacion> listCorreo = new List<Autorizacion>();

        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Text = "Mile Autorizador";

            Enviar();
            Recibir();
            Resumen();
            Correos();
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

        #region Enviar

        async Task Enviar()
        {
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
                            listEnviado = await _autorizacion.Enviar_Async(url, listEnviado);

                            // string
                            StringBuilder stringBuilder = new StringBuilder();

                            // Recorremos
                            foreach (Autorizacion row in listEnviado)
                            {
                                stringBuilder.AppendLine($"{row.DateAt}: {row.Descripcion}");
                            }

                            // Set
                            txtEnviado.Text = stringBuilder.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        Thread.Sleep(333);
                    }
                }
            });
        }

        async Task Recibir()
        {
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
                            listRecibido = await _autorizacion.Recibir_Async(url, listRecibido);

                            // string
                            StringBuilder stringBuilder = new StringBuilder();

                            // Recorremos
                            foreach (Autorizacion row in listRecibido)
                            {
                                stringBuilder.AppendLine($"{row.DateAt}: {row.Descripcion}");
                            }

                            // Set
                            txtRecibir.Text = stringBuilder.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        Thread.Sleep(333);
                    }
                }
            });
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
                        Thread.Sleep(5000);
                    }
                }
            });
        }

        #endregion

        #region Correos

        async Task Correos()
        {
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
                            listCorreo = await _autorizacion.Correos_Async(url, listCorreo);

                            // string
                            StringBuilder stringBuilder = new StringBuilder();

                            // Recorremos
                            foreach (Autorizacion row in listCorreo)
                            {
                                stringBuilder.AppendLine($"{row.DateAt}: {row.Descripcion}");
                            }

                            // Set
                            txtCorreos.Text = stringBuilder.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        Thread.Sleep(333);
                    }
                }
            });
        }

        #endregion
    }
}
