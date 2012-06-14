using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace XMLNator
{
    class ConvertirXmlEnTexo
    {
       public static void ValidarXml(string pathXml)
        {
            string DirectorioActual = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
            string PathFicheroXds = DirectorioActual + "\\esquema.XSD";
            var documents = new XmlDocument();
            MessageBox.Show(pathXml, @"Validacion de XML",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add(String.Empty,
                    XmlReader.Create(new StreamReader(PathFicheroXds)));

                XmlReaderSettings settings = new XmlReaderSettings
                                                 {Schemas = schemaSet, ValidationType = ValidationType.Schema};

                XmlReader reader = XmlReader.Create(
                    new StringReader(pathXml), settings);

                while (reader.Read()) { }
                MessageBox.Show(@"Document XML Valido :o)" +
                DateTime.Now.ToLongDateString(), @"Validacion de XML",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (XmlSchemaException schemaEx)
            {
                MessageBox.Show(@"Documento XML Invalido:" +
                    Environment.NewLine + schemaEx.Message, @"Validacion de XML",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), @"Validacion de XML",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
