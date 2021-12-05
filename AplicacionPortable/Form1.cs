using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AplicacionPortable
{

    public partial class Form1 : Form
    {

        String ruta= Path.GetDirectoryName(Process.GetProcessesByName("Mecanismo")[0].MainModule.FileName)+@"\publicKey.bin";
       
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            
            var CurrentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);


            try
            {
                String dir = Path.GetDirectoryName(CurrentDirectory) + @"\llaves";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                if (rbAutor.Checked)
                {
                    File.Copy(ruta, dir + @"\autorLlave.bin", true);
                    logMensajes.Text = "Se ha extraido la llave del autor correctamente.";
                }
                else
                {
                    File.Copy(ruta, dir + @"\receptorLlave.bin", true);
                    logMensajes.Text = "Se ha extraido la llave del receptor correctamente.";
                }
            }
            catch 
            {
                logMensajes.Text = "Ha ocurrido un error, es posible que el archivo no exista."; 
            }
            
        }

        private void rbAutor_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rbReceptor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
