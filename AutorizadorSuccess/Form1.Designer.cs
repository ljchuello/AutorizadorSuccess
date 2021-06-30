
namespace AutorizadorSuccess
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResumen = new MetroFramework.Controls.MetroLabel();
            this.btnProduccion = new MetroFramework.Controls.MetroButton();
            this.btnPrueba = new MetroFramework.Controls.MetroButton();
            this.btnLocal = new MetroFramework.Controls.MetroButton();
            this.txtEnviado = new MetroFramework.Controls.MetroTextBox();
            this.txtRecibir = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEnviado);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecibir);
            this.groupBox2.Location = new System.Drawing.Point(337, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recibir";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResumen);
            this.groupBox3.Location = new System.Drawing.Point(650, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 339);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(7, 20);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(76, 19);
            this.lblResumen.TabIndex = 0;
            this.lblResumen.Text = "lblResumen";
            // 
            // btnProduccion
            // 
            this.btnProduccion.Location = new System.Drawing.Point(887, 35);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(75, 23);
            this.btnProduccion.TabIndex = 2;
            this.btnProduccion.Text = "Producción";
            this.btnProduccion.UseSelectable = true;
            this.btnProduccion.Click += new System.EventHandler(this.btnProduccion_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(806, 35);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 3;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseSelectable = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(725, 35);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 4;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseSelectable = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // txtEnviado
            // 
            // 
            // 
            // 
            this.txtEnviado.CustomButton.Image = null;
            this.txtEnviado.CustomButton.Location = new System.Drawing.Point(-18, 1);
            this.txtEnviado.CustomButton.Name = "";
            this.txtEnviado.CustomButton.Size = new System.Drawing.Size(311, 311);
            this.txtEnviado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnviado.CustomButton.TabIndex = 1;
            this.txtEnviado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnviado.CustomButton.UseSelectable = true;
            this.txtEnviado.CustomButton.Visible = false;
            this.txtEnviado.Enabled = false;
            this.txtEnviado.Lines = new string[0];
            this.txtEnviado.Location = new System.Drawing.Point(7, 20);
            this.txtEnviado.MaxLength = 32767;
            this.txtEnviado.Multiline = true;
            this.txtEnviado.Name = "txtEnviado";
            this.txtEnviado.PasswordChar = '\0';
            this.txtEnviado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnviado.SelectedText = "";
            this.txtEnviado.SelectionLength = 0;
            this.txtEnviado.SelectionStart = 0;
            this.txtEnviado.ShortcutsEnabled = true;
            this.txtEnviado.Size = new System.Drawing.Size(294, 313);
            this.txtEnviado.TabIndex = 0;
            this.txtEnviado.UseSelectable = true;
            this.txtEnviado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnviado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRecibir
            // 
            // 
            // 
            // 
            this.txtRecibir.CustomButton.Image = null;
            this.txtRecibir.CustomButton.Location = new System.Drawing.Point(-18, 1);
            this.txtRecibir.CustomButton.Name = "";
            this.txtRecibir.CustomButton.Size = new System.Drawing.Size(311, 311);
            this.txtRecibir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRecibir.CustomButton.TabIndex = 1;
            this.txtRecibir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecibir.CustomButton.UseSelectable = true;
            this.txtRecibir.CustomButton.Visible = false;
            this.txtRecibir.Enabled = false;
            this.txtRecibir.Lines = new string[0];
            this.txtRecibir.Location = new System.Drawing.Point(6, 20);
            this.txtRecibir.MaxLength = 32767;
            this.txtRecibir.Multiline = true;
            this.txtRecibir.Name = "txtRecibir";
            this.txtRecibir.PasswordChar = '\0';
            this.txtRecibir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecibir.SelectedText = "";
            this.txtRecibir.SelectionLength = 0;
            this.txtRecibir.SelectionStart = 0;
            this.txtRecibir.ShortcutsEnabled = true;
            this.txtRecibir.Size = new System.Drawing.Size(294, 313);
            this.txtRecibir.TabIndex = 1;
            this.txtRecibir.UseSelectable = true;
            this.txtRecibir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRecibir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 426);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnProduccion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnProduccion;
        private MetroFramework.Controls.MetroButton btnPrueba;
        private MetroFramework.Controls.MetroButton btnLocal;
        private MetroFramework.Controls.MetroLabel lblResumen;
        private MetroFramework.Controls.MetroTextBox txtEnviado;
        private MetroFramework.Controls.MetroTextBox txtRecibir;
    }
}

