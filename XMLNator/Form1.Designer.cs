using System.Windows.Forms;

namespace XMLNator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.guardarXmlTexto = new System.Windows.Forms.SaveFileDialog();
            this.abrirXML = new System.Windows.Forms.OpenFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnGenerarTxt = new System.Windows.Forms.Button();
            this.btnAbrirXml = new System.Windows.Forms.Button();
            this.txtRutaTXT = new System.Windows.Forms.TextBox();
            this.txtRutaXML = new System.Windows.Forms.TextBox();
            this.lblEstadoArchivo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGuardarTextoBase = new System.Windows.Forms.Button();
            this.txtCobertura3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCobertura2 = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtNombreCertificado = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCobertura1 = new System.Windows.Forms.TextBox();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtSumaAsegurada = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAsuguradoNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoAsegurado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccionCobro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContratanteDireccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContratanteNit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContratanteNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVigenciaFinal = new System.Windows.Forms.TextBox();
            this.txtCodigoPoliza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVigenciaInicial = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumeroPoliza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.AccessibleDescription = "Sale del Programa";
            this.btnCerrar.AccessibleName = "Salir";
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(730, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(31, 31);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "XmlNator";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(502, 406);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(235, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Derechos Reservados 2do. Grupo Compiladores";
            // 
            // guardarXmlTexto
            // 
            this.guardarXmlTexto.Filter = "\"Archivos de Texto|*.txt\"";
            // 
            // abrirXML
            // 
            this.abrirXML.Filter = "Archivos XML (*.xml) | *.XML| todos los archivos (*.*)|*.*";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGenerarTxt);
            this.tabPage3.Controls.Add(this.btnAbrirXml);
            this.tabPage3.Controls.Add(this.txtRutaTXT);
            this.tabPage3.Controls.Add(this.txtRutaXML);
            this.tabPage3.Controls.Add(this.lblEstadoArchivo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(714, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xml a Texto";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnGenerarTxt
            // 
            this.btnGenerarTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGenerarTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarTxt.ForeColor = System.Drawing.Color.White;
            this.btnGenerarTxt.Location = new System.Drawing.Point(241, 257);
            this.btnGenerarTxt.Name = "btnGenerarTxt";
            this.btnGenerarTxt.Size = new System.Drawing.Size(232, 53);
            this.btnGenerarTxt.TabIndex = 4;
            this.btnGenerarTxt.Text = "Generar Archivo TXT";
            this.btnGenerarTxt.UseVisualStyleBackColor = false;
            // 
            // btnAbrirXml
            // 
            this.btnAbrirXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAbrirXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirXml.ForeColor = System.Drawing.Color.White;
            this.btnAbrirXml.Location = new System.Drawing.Point(241, 142);
            this.btnAbrirXml.Name = "btnAbrirXml";
            this.btnAbrirXml.Size = new System.Drawing.Size(232, 53);
            this.btnAbrirXml.TabIndex = 3;
            this.btnAbrirXml.Text = "Abrir Archivo XML";
            this.btnAbrirXml.UseVisualStyleBackColor = false;
            this.btnAbrirXml.Click += new System.EventHandler(this.btnAbrirXml_Click);
            // 
            // txtRutaTXT
            // 
            this.txtRutaTXT.Location = new System.Drawing.Point(44, 220);
            this.txtRutaTXT.Name = "txtRutaTXT";
            this.txtRutaTXT.Size = new System.Drawing.Size(627, 20);
            this.txtRutaTXT.TabIndex = 2;
            // 
            // txtRutaXML
            // 
            this.txtRutaXML.Location = new System.Drawing.Point(44, 116);
            this.txtRutaXML.Name = "txtRutaXML";
            this.txtRutaXML.Size = new System.Drawing.Size(627, 20);
            this.txtRutaXML.TabIndex = 1;
            // 
            // lblEstadoArchivo
            // 
            this.lblEstadoArchivo.AutoSize = true;
            this.lblEstadoArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEstadoArchivo.Location = new System.Drawing.Point(176, 27);
            this.lblEstadoArchivo.Name = "lblEstadoArchivo";
            this.lblEstadoArchivo.Size = new System.Drawing.Size(362, 42);
            this.lblEstadoArchivo.TabIndex = 0;
            this.lblEstadoArchivo.Text = "Elija un Archivo XML";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Texto a Xml";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Txt Base";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGuardarTextoBase);
            this.groupBox4.Controls.Add(this.txtCobertura3);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtCobertura2);
            this.groupBox4.Controls.Add(this.txtPlacas);
            this.groupBox4.Controls.Add(this.txtLinea);
            this.groupBox4.Controls.Add(this.txtMarca);
            this.groupBox4.Controls.Add(this.txtNombreCertificado);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtCobertura1);
            this.groupBox4.Controls.Add(this.txtChasis);
            this.groupBox4.Controls.Add(this.txtModelo);
            this.groupBox4.Controls.Add(this.txtSumaAsegurada);
            this.groupBox4.Controls.Add(this.txtNumero);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 148);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles del Certificado";
            // 
            // btnGuardarTextoBase
            // 
            this.btnGuardarTextoBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTextoBase.ForeColor = System.Drawing.Color.Red;
            this.btnGuardarTextoBase.Location = new System.Drawing.Point(459, 107);
            this.btnGuardarTextoBase.Name = "btnGuardarTextoBase";
            this.btnGuardarTextoBase.Size = new System.Drawing.Size(202, 23);
            this.btnGuardarTextoBase.TabIndex = 32;
            this.btnGuardarTextoBase.Text = "Guardar Texto Base";
            this.btnGuardarTextoBase.UseVisualStyleBackColor = true;
            // 
            // txtCobertura3
            // 
            this.txtCobertura3.Location = new System.Drawing.Point(329, 104);
            this.txtCobertura3.MaxLength = 100;
            this.txtCobertura3.Name = "txtCobertura3";
            this.txtCobertura3.Size = new System.Drawing.Size(100, 20);
            this.txtCobertura3.TabIndex = 23;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(234, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 13);
            this.label24.TabIndex = 31;
            this.label24.Text = "Cobertura 3:";
            // 
            // txtCobertura2
            // 
            this.txtCobertura2.Location = new System.Drawing.Point(124, 104);
            this.txtCobertura2.MaxLength = 100;
            this.txtCobertura2.Name = "txtCobertura2";
            this.txtCobertura2.Size = new System.Drawing.Size(100, 20);
            this.txtCobertura2.TabIndex = 22;
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(329, 76);
            this.txtPlacas.MaxLength = 100;
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(100, 20);
            this.txtPlacas.TabIndex = 20;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(563, 50);
            this.txtLinea.MaxLength = 100;
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(100, 20);
            this.txtLinea.TabIndex = 18;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(124, 50);
            this.txtMarca.MaxLength = 100;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 16;
            // 
            // txtNombreCertificado
            // 
            this.txtNombreCertificado.Location = new System.Drawing.Point(329, 24);
            this.txtNombreCertificado.MaxLength = 100;
            this.txtNombreCertificado.Multiline = true;
            this.txtNombreCertificado.Name = "txtNombreCertificado";
            this.txtNombreCertificado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCertificado.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Cobertura 2:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(234, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Placas:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(458, 53);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Linea:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Marca:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(230, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "Nombre Certificado:";
            // 
            // txtCobertura1
            // 
            this.txtCobertura1.Location = new System.Drawing.Point(563, 76);
            this.txtCobertura1.MaxLength = 100;
            this.txtCobertura1.Name = "txtCobertura1";
            this.txtCobertura1.Size = new System.Drawing.Size(100, 20);
            this.txtCobertura1.TabIndex = 21;
            // 
            // txtChasis
            // 
            this.txtChasis.Location = new System.Drawing.Point(124, 76);
            this.txtChasis.MaxLength = 100;
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(100, 20);
            this.txtChasis.TabIndex = 19;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(329, 50);
            this.txtModelo.MaxLength = 12;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 17;
            // 
            // txtSumaAsegurada
            // 
            this.txtSumaAsegurada.Location = new System.Drawing.Point(563, 24);
            this.txtSumaAsegurada.MaxLength = 12;
            this.txtSumaAsegurada.Name = "txtSumaAsegurada";
            this.txtSumaAsegurada.Size = new System.Drawing.Size(100, 20);
            this.txtSumaAsegurada.TabIndex = 15;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(124, 24);
            this.txtNumero.MaxLength = 12;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(458, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Cobertura 1:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Chasis:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(234, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "Modelo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(458, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Suma Asegurada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Numero:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAsuguradoNombre);
            this.groupBox2.Controls.Add(this.txtApellidoAsegurado);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDireccionCobro);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtContratanteDireccion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtContratanteNit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtContratanteNombre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles Contratante | Asegurado";
            // 
            // txtAsuguradoNombre
            // 
            this.txtAsuguradoNombre.Location = new System.Drawing.Point(329, 46);
            this.txtAsuguradoNombre.Name = "txtAsuguradoNombre";
            this.txtAsuguradoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtAsuguradoNombre.TabIndex = 11;
            // 
            // txtApellidoAsegurado
            // 
            this.txtApellidoAsegurado.Location = new System.Drawing.Point(563, 46);
            this.txtApellidoAsegurado.Name = "txtApellidoAsegurado";
            this.txtApellidoAsegurado.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoAsegurado.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Asegurado Nombre:";
            // 
            // txtDireccionCobro
            // 
            this.txtDireccionCobro.Location = new System.Drawing.Point(124, 43);
            this.txtDireccionCobro.Name = "txtDireccionCobro";
            this.txtDireccionCobro.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionCobro.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Asegurado Apellido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Direccion de Cobro:";
            // 
            // txtContratanteDireccion
            // 
            this.txtContratanteDireccion.Location = new System.Drawing.Point(563, 17);
            this.txtContratanteDireccion.Name = "txtContratanteDireccion";
            this.txtContratanteDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtContratanteDireccion.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Contratante Direccion:";
            // 
            // txtContratanteNit
            // 
            this.txtContratanteNit.Location = new System.Drawing.Point(329, 17);
            this.txtContratanteNit.Name = "txtContratanteNit";
            this.txtContratanteNit.Size = new System.Drawing.Size(100, 20);
            this.txtContratanteNit.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Contratante Nit:";
            // 
            // txtContratanteNombre
            // 
            this.txtContratanteNombre.Location = new System.Drawing.Point(124, 17);
            this.txtContratanteNombre.Name = "txtContratanteNombre";
            this.txtContratanteNombre.Size = new System.Drawing.Size(100, 20);
            this.txtContratanteNombre.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contratante Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVigenciaFinal);
            this.groupBox1.Controls.Add(this.txtCodigoPoliza);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVigenciaInicial);
            this.groupBox1.Controls.Add(this.txtCodigoProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNumeroPoliza);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 82);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // txtVigenciaFinal
            // 
            this.txtVigenciaFinal.Location = new System.Drawing.Point(563, 54);
            this.txtVigenciaFinal.Name = "txtVigenciaFinal";
            this.txtVigenciaFinal.Size = new System.Drawing.Size(100, 20);
            this.txtVigenciaFinal.TabIndex = 6;
            // 
            // txtCodigoPoliza
            // 
            this.txtCodigoPoliza.Location = new System.Drawing.Point(563, 25);
            this.txtCodigoPoliza.Name = "txtCodigoPoliza";
            this.txtCodigoPoliza.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPoliza.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vigencia Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Producto:";
            // 
            // txtVigenciaInicial
            // 
            this.txtVigenciaInicial.Location = new System.Drawing.Point(329, 51);
            this.txtVigenciaInicial.Name = "txtVigenciaInicial";
            this.txtVigenciaInicial.Size = new System.Drawing.Size(100, 20);
            this.txtVigenciaInicial.TabIndex = 5;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(124, 25);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProducto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vigencia Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Producto:";
            // 
            // txtNumeroPoliza
            // 
            this.txtNumeroPoliza.Location = new System.Drawing.Point(124, 51);
            this.txtNumeroPoliza.Name = "txtNumeroPoliza";
            this.txtNumeroPoliza.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPoliza.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo Poliza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Numero Poliza:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(329, 25);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(19, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 376);
            this.tabControl1.TabIndex = 30;
            this.tabControl1.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.AccessibleDescription = "Muestra la ayuda del Programa";
            this.btnAyuda.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.White;
            this.btnAyuda.Location = new System.Drawing.Point(668, 0);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(31, 31);
            this.btnAyuda.TabIndex = 31;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.AccessibleDescription = "Muestra la ayuda del Programa";
            this.btnAcercaDe.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.btnAcercaDe.Location = new System.Drawing.Point(637, 0);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(31, 31);
            this.btnAcercaDe.TabIndex = 32;
            this.btnAcercaDe.Text = "!";
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "Muestra la ayuda del Programa";
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(699, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 33;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "<name>XmlNator</name>";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCerrar;
        private Label label1;
        private Label label25;
        private SaveFileDialog guardarXmlTexto;
        private OpenFileDialog abrirXML;
        private TabPage tabPage3;
        private Button btnGenerarTxt;
        private Button btnAbrirXml;
        private TextBox txtRutaTXT;
        private TextBox txtRutaXML;
        public Label lblEstadoArchivo;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private GroupBox groupBox4;
        private Button btnGuardarTextoBase;
        private TextBox txtCobertura3;
        private Label label24;
        private TextBox txtCobertura2;
        private TextBox txtPlacas;
        private TextBox txtLinea;
        private TextBox txtMarca;
        private TextBox txtNombreCertificado;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox txtCobertura1;
        private TextBox txtChasis;
        private TextBox txtModelo;
        private TextBox txtSumaAsegurada;
        private TextBox txtNumero;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private GroupBox groupBox2;
        private TextBox txtAsuguradoNombre;
        private TextBox txtApellidoAsegurado;
        private Label label12;
        private TextBox txtDireccionCobro;
        private Label label13;
        private Label label11;
        private TextBox txtContratanteDireccion;
        private Label label10;
        private TextBox txtContratanteNit;
        private Label label9;
        private TextBox txtContratanteNombre;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox txtVigenciaFinal;
        private TextBox txtCodigoPoliza;
        private Label label7;
        private Label label2;
        private TextBox txtVigenciaInicial;
        private TextBox txtCodigoProducto;
        private Label label6;
        private Label label3;
        private TextBox txtNumeroPoliza;
        private Label label4;
        private Label label5;
        private TextBox txtNombreProducto;
        private TabControl tabControl1;
        private Button btnAyuda;
        private Button btnAcercaDe;
        private Button button1;

    }
}

