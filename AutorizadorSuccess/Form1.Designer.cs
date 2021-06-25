
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
            this.btnProduccion = new MetroFramework.Controls.MetroButton();
            this.btnPrueba = new MetroFramework.Controls.MetroButton();
            this.btnLocal = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(337, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(650, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 339);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnProduccion
            // 
            this.btnProduccion.Location = new System.Drawing.Point(887, 35);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(75, 23);
            this.btnProduccion.TabIndex = 2;
            this.btnProduccion.Text = "Producción";
            this.btnProduccion.UseSelectable = true;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(806, 35);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 3;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseSelectable = true;
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(725, 35);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 4;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseSelectable = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnProduccion;
        private MetroFramework.Controls.MetroButton btnPrueba;
        private MetroFramework.Controls.MetroButton btnLocal;
    }
}

