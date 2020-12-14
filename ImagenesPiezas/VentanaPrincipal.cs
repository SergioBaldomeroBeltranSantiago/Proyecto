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

        string folderpath;
        string[] filepaths;
        ArrayList filepathss = new ArrayList();
        Image ori_imagen, mod_imagen;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_OpenFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderOpener.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderpath = FolderOpener.SelectedPath;
                filepaths = Directory.GetFiles(folderpath);
                if (filepaths.Length > 0)
                {
                    for (int i = 0; i < filepaths.Length; i++)
                    {
                        filepathss.Add(filepaths[i]);
                    }
                    Btn_OpenFolder.Enabled = false;
                }
                CreateImage((string)filepathss[0]);
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
            DialogResult resulttwo = MessageBox.Show("Esta a punto de aprobar una imagen\n¿Esta seguro de esto? ", "Confirmacion", MessageBoxButtons.YesNo);
            if (resulttwo == DialogResult.Yes)
            {
                if (!File.Exists(folderpath + "\\Imagenes Aprobadas"))
                {
                    Directory.CreateDirectory(folderpath + "\\Imagenes Aprobadas");
                }
                Visualizer.Image = null;
                string ori_directory = (string)filepathss[0];
                string new_directory = folderpath + "\\Imagenes Aprobadas\\" + Path.GetFileName((string)filepathss[0]);
                File.Move(ori_directory, new_directory);
                ImageRotator();
            }
        }

        private void Btn_Imagen_No_Aprobada_Click(object sender, EventArgs e)
        {
            DialogResult resultthree = MessageBox.Show("Esta a punto de desaprobar una imagen\n¿Esta seguro de esto? ", "Confirmacion", MessageBoxButtons.YesNo);
            if (resultthree == DialogResult.Yes)
            {
                if (!File.Exists(folderpath + "\\Imagenes No Aprobadas"))
                {
                    Directory.CreateDirectory(folderpath + "\\Imagenes No Aprobadas");
                }
                Visualizer.Image = null;
                string ori_directory = (string)filepathss[0];
                string new_directory = folderpath + "\\Imagenes No Aprobadas\\" + Path.GetFileName((string)filepathss[0]);
                File.Move(ori_directory, new_directory);
                ImageRotator();
            }
        }


        public void RotateImageHalfCircle()
        {
            mod_imagen.RotateFlip(RotateFlipType.Rotate180FlipNone);
            Visualizer.Image = mod_imagen;
        }


        public void ImageRotator()
        {
            filepathss.RemoveAt(0);
            CreateImage((string)filepathss[0]);
        }
        public void CreateImage(string path)
        {
            ori_imagen = Image.FromFile(path);
            Visualizer.Image = ori_imagen;
            mod_imagen = ori_imagen;
        }

        public void RotateImageRight()
        {
            mod_imagen.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Visualizer.Image = mod_imagen;
        }
    }
}
