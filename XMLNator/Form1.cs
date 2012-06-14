using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Xml.Schema;

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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnAbrirXml_Click(object sender, EventArgs e)
        {
            abrirXML.InitialDirectory = Directory.GetCurrentDirectory();
            abrirXML.Title = "Seleccione un archivo";
            if (abrirXML.ShowDialog() == DialogResult.OK)
            {
                var strFileName = abrirXML.FileName;
                txtRutaXML.Text = strFileName;
                ConvertirXmlEnTexo.ValidarXml(strFileName);
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            DialogResult show = MessageBox.Show("XmlNator v 1.0\r\nProyecto Final del curso Compiladores\r\nConvierte Texto Plano a XML y Viceversa\r\nEnjoy it ;)"
                                            , caption: "XmlNator", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            DialogResult show = MessageBox.Show("XmlNator v 1.0\r\nDesarrollado por:\r\nGenerar documentos de texto: Pedro Alonso\r\nValidar documentos txt            : Roger Olavarrueth\r\nConversion txt a xml                 : Roger Olavarrueth\r\nValidar archivos xml                  : Jose Sosa\r\nConvertir xml a txt                     : Jose Sosa\r\nRevision                                      : Jose Sosa\r\n" 
                                            , caption: "Acerca de", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}