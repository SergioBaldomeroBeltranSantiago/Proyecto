using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;

namespace ImagenesPiezas
{
    public partial class VentanaPrincipal : Form
    {

        string path;
        string[] filepaths;
        ArrayList filenames = new ArrayList();
        Image imagen_display;
        Bitmap bm;
        Graphics gpu;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            ZoomTool.Minimum = ZoomTool.SmallChange = ZoomTool.LargeChange = 1;
            ZoomTool.Maximum = 6;
            ZoomTool.UseWaitCursor = false;
            this.DoubleBuffered = true;
        }

        private void Btn_OpenFolder_Click(object sender, EventArgs e)
        {
            FolderOpener.ShowDialog();
            if (FolderOpener.SelectedPath.Length > 0)
            {
                path = FolderOpener.SelectedPath;
                filepaths = Directory.GetFiles(path) ;
                if (filepaths.Length > 0)
                {
                    foreach (string file in filepaths)
                    {
                        filenames.Add(Path.GetFileName(file));
                    }
                    filepaths = new string[0];
                    ButtonSwitch(true);
                    FolderOpener.Dispose();
                    CreateImage(path + "\\" + (string)filenames[0]);
                }
            }
        }

        private void Btn_RotateRight_Click(object sender, EventArgs e)
        {
            RotateImageRight();
        }

        private void Btn_Voltear_Imagen_Click(object sender, EventArgs e)
        {
            RotateImageHalfCircle();
        }

        private void Btn_Imagen_Aprobada_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta a punto de aprobar una imagen\n¿Esta seguro de esto? ", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Visualizer.Image = null;
                imagen_display.Dispose();
                if (!File.Exists(path + "\\Imagenes Aprobadas"))
                {
                    Directory.CreateDirectory(path + "\\Imagenes Aprobadas");
                }
                if (!File.Exists(path + "\\Imagenes Aprobadas\\" + filenames[0]))
                {
                    File.Move(path + "\\" + (string)filenames[0], path + "\\Imagenes Aprobadas\\" + (string)filenames[0]);
                }
                else
                {
                    File.Delete(path + "\\" + (string)filenames[0]);
                }
                ImageChanger();
            }
        }

        private void Btn_Imagen_No_Aprobada_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta a punto de desaprobar una imagen\n¿Esta seguro de esto? ", "Confirmacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                Visualizer.Image = null;
                imagen_display.Dispose();
                bm.Dispose();
                gpu.Dispose();
                if (!File.Exists(path + "\\Imagenes No Aprobadas"))
                {
                    Directory.CreateDirectory(path + "\\Imagenes No Aprobadas");
                }
                if (!File.Exists(path + "\\Imagenes No Aprobadas\\" + filenames[0]))
                {
                    File.Move(path + "\\" + (string)filenames[0], path + "\\Imagenes No Aprobadas\\" + (string)filenames[0]);
                }
                else {
                    File.Delete(path + "\\" + (string)filenames[0]);
                }
                ImageChanger();
            }
        }

        private void Btn_Reiniciar_Click(object sender, EventArgs e)
        {
            Btn_OpenFolder_Click(sender, e);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void RotateImageHalfCircle()
        {
            imagen_display.RotateFlip(RotateFlipType.Rotate180FlipNone);
            Visualizer.Image = imagen_display;
        }

        public void RotateImageRight()
        {
            imagen_display.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Visualizer.Image = imagen_display;
        }


        public void ImageChanger()
        {
            if (filenames.Count > 1)
            {
                filenames.RemoveAt(0);
                CreateImage(path + "\\" + (string)filenames[0]);
            }
            else {
                ButtonSwitch(false);
                MessageBox.Show("Se han agotado las imagenes dentro de la carpeta","Aviso",MessageBoxButtons.OK);
            }
        }
        public void CreateImage(string imagepath)
        {
            Visualizer.Image = imagen_display = Image.FromFile(imagepath);
            ZoomTool.Value = ZoomTool.Minimum;
        }

        public Image ZoomImage(Image imagen_modificar, Size tamaño_deseado) {
            bm = new Bitmap(imagen_modificar, Convert.ToInt32(imagen_modificar.Width * tamaño_deseado.Width), Convert.ToInt32(imagen_modificar.Height * tamaño_deseado.Height));
            gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        public void ButtonSwitch(bool state) {
            Btn_OpenFolder.Enabled = !state;
            Btn_Imagen_Aprobada.Enabled = Btn_Imagen_Aprobada.Visible = state;
            Btn_Imagen_No_Aprobada.Enabled = Btn_Imagen_No_Aprobada.Visible = state;
            Btn_Rotate.Enabled = Btn_Rotate.Visible = state;
            Btn_Voltear_Imagen.Enabled = Btn_Voltear_Imagen.Visible = state;
            Btn_Reiniciar.Enabled = Btn_Reiniciar.Visible = state;
            ZoomTool.Enabled = ZoomTool.Visible = state;
        }

        private void ZoomTool_Scroll(object sender, EventArgs e)
        {
            if (ZoomTool.Value != 0) {
                Visualizer.Image = null;
                Visualizer.Image = ZoomImage(imagen_display,new Size(ZoomTool.Value,ZoomTool.Value));
            }
        }
    }
}
