
namespace ImagenesPiezas
{
    partial class VentanaPrincipal
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
            this.ControlBox = new System.Windows.Forms.GroupBox();
            this.Btn_OpenFolder = new System.Windows.Forms.Button();
            this.Btn_Voltear_Imagen = new System.Windows.Forms.Button();
            this.Btn_Rotate = new System.Windows.Forms.Button();
            this.Btn_Imagen_No_Aprobada = new System.Windows.Forms.Button();
            this.Btn_Imagen_Aprobada = new System.Windows.Forms.Button();
            this.FolderOpener = new System.Windows.Forms.FolderBrowserDialog();
            this.Visualizer = new System.Windows.Forms.PictureBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.ControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visualizer)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.Controls.Add(this.Btn_Reiniciar);
            this.ControlBox.Controls.Add(this.Btn_Salir);
            this.ControlBox.Controls.Add(this.Btn_OpenFolder);
            this.ControlBox.Controls.Add(this.Btn_Voltear_Imagen);
            this.ControlBox.Controls.Add(this.Btn_Rotate);
            this.ControlBox.Controls.Add(this.Btn_Imagen_No_Aprobada);
            this.ControlBox.Controls.Add(this.Btn_Imagen_Aprobada);
            this.ControlBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlBox.Location = new System.Drawing.Point(13, 13);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(238, 657);
            this.ControlBox.TabIndex = 0;
            this.ControlBox.TabStop = false;
            this.ControlBox.Text = "Controles";
            // 
            // Btn_OpenFolder
            // 
            this.Btn_OpenFolder.Location = new System.Drawing.Point(6, 45);
            this.Btn_OpenFolder.Name = "Btn_OpenFolder";
            this.Btn_OpenFolder.Size = new System.Drawing.Size(226, 37);
            this.Btn_OpenFolder.TabIndex = 1;
            this.Btn_OpenFolder.Text = "Seleccionar carpeta";
            this.Btn_OpenFolder.UseVisualStyleBackColor = true;
            this.Btn_OpenFolder.Click += new System.EventHandler(this.Btn_OpenFolder_Click);
            // 
            // Btn_Voltear_Imagen
            // 
            this.Btn_Voltear_Imagen.Location = new System.Drawing.Point(6, 208);
            this.Btn_Voltear_Imagen.Name = "Btn_Voltear_Imagen";
            this.Btn_Voltear_Imagen.Size = new System.Drawing.Size(226, 35);
            this.Btn_Voltear_Imagen.TabIndex = 6;
            this.Btn_Voltear_Imagen.TabStop = false;
            this.Btn_Voltear_Imagen.Text = "Voltear";
            this.Btn_Voltear_Imagen.UseVisualStyleBackColor = true;
            this.Btn_Voltear_Imagen.Visible = false;
            this.Btn_Voltear_Imagen.Click += new System.EventHandler(this.Btn_Voltear_Imagen_Click);
            // 
            // Btn_Rotate
            // 
            this.Btn_Rotate.Enabled = false;
            this.Btn_Rotate.Location = new System.Drawing.Point(6, 160);
            this.Btn_Rotate.Name = "Btn_Rotate";
            this.Btn_Rotate.Size = new System.Drawing.Size(226, 33);
            this.Btn_Rotate.TabIndex = 3;
            this.Btn_Rotate.Text = "Rotar";
            this.Btn_Rotate.UseVisualStyleBackColor = true;
            this.Btn_Rotate.Visible = false;
            this.Btn_Rotate.Click += new System.EventHandler(this.Btn_RotateRight_Click);
            // 
            // Btn_Imagen_No_Aprobada
            // 
            this.Btn_Imagen_No_Aprobada.Enabled = false;
            this.Btn_Imagen_No_Aprobada.Location = new System.Drawing.Point(6, 336);
            this.Btn_Imagen_No_Aprobada.Name = "Btn_Imagen_No_Aprobada";
            this.Btn_Imagen_No_Aprobada.Size = new System.Drawing.Size(226, 36);
            this.Btn_Imagen_No_Aprobada.TabIndex = 5;
            this.Btn_Imagen_No_Aprobada.Text = "No Aprobada";
            this.Btn_Imagen_No_Aprobada.UseVisualStyleBackColor = true;
            this.Btn_Imagen_No_Aprobada.Visible = false;
            this.Btn_Imagen_No_Aprobada.Click += new System.EventHandler(this.Btn_Imagen_No_Aprobada_Click);
            // 
            // Btn_Imagen_Aprobada
            // 
            this.Btn_Imagen_Aprobada.Enabled = false;
            this.Btn_Imagen_Aprobada.Location = new System.Drawing.Point(6, 283);
            this.Btn_Imagen_Aprobada.Name = "Btn_Imagen_Aprobada";
            this.Btn_Imagen_Aprobada.Size = new System.Drawing.Size(226, 38);
            this.Btn_Imagen_Aprobada.TabIndex = 4;
            this.Btn_Imagen_Aprobada.Text = "Aprobada";
            this.Btn_Imagen_Aprobada.UseVisualStyleBackColor = true;
            this.Btn_Imagen_Aprobada.Visible = false;
            this.Btn_Imagen_Aprobada.Click += new System.EventHandler(this.Btn_Imagen_Aprobada_Click);
            // 
            // FolderOpener
            // 
            this.FolderOpener.Description = "Seleccione la carpeta";
            this.FolderOpener.ShowNewFolderButton = false;
            // 
            // Visualizer
            // 
            this.Visualizer.Location = new System.Drawing.Point(257, 13);
            this.Visualizer.Name = "Visualizer";
            this.Visualizer.Size = new System.Drawing.Size(995, 657);
            this.Visualizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Visualizer.TabIndex = 1;
            this.Visualizer.TabStop = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(6, 615);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(226, 36);
            this.Btn_Salir.TabIndex = 7;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.Enabled = false;
            this.Btn_Reiniciar.Location = new System.Drawing.Point(6, 97);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(226, 36);
            this.Btn_Reiniciar.TabIndex = 8;
            this.Btn_Reiniciar.Text = "Cambiar Carpeta";
            this.Btn_Reiniciar.UseVisualStyleBackColor = true;
            this.Btn_Reiniciar.Visible = false;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.Btn_Reiniciar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.Visualizer);
            this.Controls.Add(this.ControlBox);
            this.Name = "VentanaPrincipal";
            this.Text = "Imagen";
            this.ControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Visualizer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ControlBox;
        private System.Windows.Forms.Button Btn_OpenFolder;
        private System.Windows.Forms.FolderBrowserDialog FolderOpener;
        private System.Windows.Forms.PictureBox Visualizer;
        private System.Windows.Forms.Button Btn_Rotate;
        private System.Windows.Forms.Button Btn_Imagen_Aprobada;
        private System.Windows.Forms.Button Btn_Imagen_No_Aprobada;
        private System.Windows.Forms.Button Btn_Voltear_Imagen;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.Button Btn_Salir;
    }
}

