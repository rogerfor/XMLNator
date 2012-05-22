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
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Nombre para el archivo";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                DateTime fecha = DateTime.Now;
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(fecha + "\r\nBuscar Caracter: \r\n" + "El caracter a buscar: " + Convert.ToString('"') + Convert.ToString(txtCodigoPoliza.Text + "\n") + Convert.ToString('"'));
                sw.WriteLine("Resultado: \r\n" + Convert.ToString(txtCodigoProducto.Text));
                sw.WriteLine("Buscador de delimitadores y tokens\n");
                sw.WriteLine("Resultado: \r\n" + Convert.ToString(txtNombreProducto.Text));
                sw.WriteLine("------------------------------------------------");
                sw.Close();
            }

        }

        
    }
}