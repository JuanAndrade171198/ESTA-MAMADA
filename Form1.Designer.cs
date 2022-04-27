
namespace Aplicacion_de_prueba_serial
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
            this.components = new System.ComponentModel.Container();
            this.Diseñopuerto = new System.Windows.Forms.Label();
            this.BotonConectar = new System.Windows.Forms.Button();
            this.BotonDesconectar = new System.Windows.Forms.Button();
            this.CmBoxLista = new System.Windows.Forms.ComboBox();
            this.BotonRefrescar = new System.Windows.Forms.Button();
            this.TxBxDatoRecibido = new System.Windows.Forms.TextBox();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // Diseñopuerto
            // 
            this.Diseñopuerto.AutoSize = true;
            this.Diseñopuerto.Location = new System.Drawing.Point(12, 9);
            this.Diseñopuerto.Name = "Diseñopuerto";
            this.Diseñopuerto.Size = new System.Drawing.Size(0, 13);
            this.Diseñopuerto.TabIndex = 0;
            // 
            // BotonConectar
            // 
            this.BotonConectar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BotonConectar.Location = new System.Drawing.Point(35, 61);
            this.BotonConectar.Name = "BotonConectar";
            this.BotonConectar.Size = new System.Drawing.Size(103, 23);
            this.BotonConectar.TabIndex = 1;
            this.BotonConectar.Text = "Conectar";
            this.BotonConectar.UseVisualStyleBackColor = false;
            this.BotonConectar.Click += new System.EventHandler(this.BotonConectar_Click);
            // 
            // BotonDesconectar
            // 
            this.BotonDesconectar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BotonDesconectar.Location = new System.Drawing.Point(166, 61);
            this.BotonDesconectar.Name = "BotonDesconectar";
            this.BotonDesconectar.Size = new System.Drawing.Size(105, 23);
            this.BotonDesconectar.TabIndex = 2;
            this.BotonDesconectar.Text = "Desconectar";
            this.BotonDesconectar.UseVisualStyleBackColor = false;
            this.BotonDesconectar.Click += new System.EventHandler(this.BotonDesconectar_Click);
            // 
            // CmBoxLista
            // 
            this.CmBoxLista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CmBoxLista.FormattingEnabled = true;
            this.CmBoxLista.Location = new System.Drawing.Point(3, 25);
            this.CmBoxLista.Name = "CmBoxLista";
            this.CmBoxLista.Size = new System.Drawing.Size(165, 21);
            this.CmBoxLista.TabIndex = 4;
            // 
            // BotonRefrescar
            // 
            this.BotonRefrescar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BotonRefrescar.Location = new System.Drawing.Point(186, 25);
            this.BotonRefrescar.Name = "BotonRefrescar";
            this.BotonRefrescar.Size = new System.Drawing.Size(105, 23);
            this.BotonRefrescar.TabIndex = 5;
            this.BotonRefrescar.Text = "Refrescar";
            this.BotonRefrescar.UseVisualStyleBackColor = false;
            this.BotonRefrescar.Click += new System.EventHandler(this.BotonRefrescar_Click);
            // 
            // TxBxDatoRecibido
            // 
            this.TxBxDatoRecibido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxBxDatoRecibido.Location = new System.Drawing.Point(3, 102);
            this.TxBxDatoRecibido.Multiline = true;
            this.TxBxDatoRecibido.Name = "TxBxDatoRecibido";
            this.TxBxDatoRecibido.Size = new System.Drawing.Size(301, 101);
            this.TxBxDatoRecibido.TabIndex = 6;
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(316, 215);
            this.Controls.Add(this.TxBxDatoRecibido);
            this.Controls.Add(this.BotonRefrescar);
            this.Controls.Add(this.CmBoxLista);
            this.Controls.Add(this.BotonDesconectar);
            this.Controls.Add(this.BotonConectar);
            this.Controls.Add(this.Diseñopuerto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Diseñopuerto;
        private System.Windows.Forms.Button BotonConectar;
        private System.Windows.Forms.Button BotonDesconectar;
        private System.Windows.Forms.ComboBox CmBoxLista;
        private System.Windows.Forms.Button BotonRefrescar;
        private System.Windows.Forms.TextBox TxBxDatoRecibido;
        private System.IO.Ports.SerialPort PuertoSerie;
    }
}

