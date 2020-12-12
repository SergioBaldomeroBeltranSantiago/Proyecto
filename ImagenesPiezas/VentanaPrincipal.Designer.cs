
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
            this.SuspendLayout();
            // 
            // ControlBox
            // 
            this.ControlBox.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlBox.Location = new System.Drawing.Point(13, 13);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(213, 474);
            this.ControlBox.TabIndex = 0;
            this.ControlBox.TabStop = false;
            this.ControlBox.Text = "Controles";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 499);
            this.Controls.Add(this.ControlBox);
            this.Name = "VentanaPrincipal";
            this.Text = "Imagen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ControlBox;
    }
}

