using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace XMLNator
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
            MouseMove += Form1MouseMove;
        }



        #region Funciones necesarias para mover la ventana sin barra de titulo

        //
        // Declaraciones del API de Windows (y constantes usadas para mover el form)
        //
        private const int WM_SYSCOMMAND = 0x112;
        private const int MOUSE_MOVE = 0xF012;
        //
        // Declaraciones del API
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        //
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // función privada usada para mover el formulario actual
        private void MoverForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }


        private void Form1MouseMove(object sender, MouseEventArgs e)
        {
            MoverForm();
        }

        private void BtnCerrarClick1(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void btnGuardarTextoBase_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog1.Title = "Guardar Archivo";
            saveFileDialog1.ShowDialog();

            if(saveFileDialog1.FileName != "")
   {
      
      StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile());
                sw.WriteLine("General: " + "\n");
                sw.WriteLine("Código Producto: " + txtCodigoProducto.Text + "     Nombre Producto: " +
                             txtNombreProducto.Text + "     Código Poliza: " + txtCodigoPoliza.Text);
                sw.WriteLine("Número Poliza: " + txtNumeroPoliza.Text + "     Vigencia Inicial: " +
                             txtVigenciaInicial.Text + "     VigenciaFinal: " + txtVigenciaFinal.Text);
                sw.WriteLine("\n\n");
                sw.WriteLine("Detalles Contratante/Asegurado:");
                sw.Close();
   }
}


          

        }

        
    }
