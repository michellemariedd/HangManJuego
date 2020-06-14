using System;
using System.Windows.Forms;

namespace HangManGame
{
    partial class HangManGame
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
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.flFichas = new System.Windows.Forms.FlowLayoutPanel();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.intento = new System.Windows.Forms.PictureBox();
            this.btnIniciarJuego = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intento)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxCategorias.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(24, 102);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(259, 51);
            this.cbxCategorias.TabIndex = 1;
            this.cbxCategorias.Text = "Categorias";
            this.cbxCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxCategorias_SelectedIndexChanged);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(553, 38);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(203, 43);
            this.lbMensaje.TabIndex = 2;
            this.lbMensaje.Text = "!Tú lo mataste!";
            // 
            // flFichas
            // 
            this.flFichas.Location = new System.Drawing.Point(21, 173);
            this.flFichas.Name = "flFichas";
            this.flFichas.Size = new System.Drawing.Size(477, 218);
            this.flFichas.TabIndex = 4;
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(24, 406);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(474, 83);
            this.flPalabra.TabIndex = 5;
            this.flPalabra.Paint += new System.Windows.Forms.PaintEventHandler(this.flPalabra_Paint);
            // 
            // intento
            // 
            this.intento.Image = global::HangManGame.Properties.Resources.Intento;
            this.intento.Location = new System.Drawing.Point(536, 102);
            this.intento.Name = "intento";
            this.intento.Size = new System.Drawing.Size(252, 423);
            this.intento.TabIndex = 3;
            this.intento.TabStop = false;
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarJuego.Image = global::HangManGame.Properties.Resources.Jugando;
            this.btnIniciarJuego.Location = new System.Drawing.Point(12, 12);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(344, 69);
            this.btnIniciarJuego.TabIndex = 0;
            this.btnIniciarJuego.UseVisualStyleBackColor = true;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click_1);
            // 
            // HangManGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.flFichas);
            this.Controls.Add(this.intento);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.btnIniciarJuego);
            this.Name = "HangManGame";
            this.Text = "HangMan";
            this.Load += new System.EventHandler(this.HangManGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }







        #endregion

        private System.Windows.Forms.Button btnIniciarJuego;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.PictureBox intento;
        private System.Windows.Forms.FlowLayoutPanel flFichas;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
    }
}

