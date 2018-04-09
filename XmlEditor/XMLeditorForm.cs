using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XmlEditor
{
    public partial class XMLeditorForm : Form
    {
        private XElement rootElem;
        private IEnumerable<XElement> elements;
        private int idActual;
        private int offset;
        private int idInitial;

        public XMLeditorForm()
        {
            InitializeComponent();
        }

        private void btnSelectXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            //OpenFileDialog
            fileDialog.Multiselect = false;
            fileDialog.Title = "Selecionar XML";

            //filtra para exibir somente arquivos XML
            fileDialog.Filter = "Images (*.XML)|*.XML|" + "Images (*.MPDGR)|*.MPDGR|" + "All files (*.*)|*.*";
            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            fileDialog.ReadOnlyChecked = false;
            fileDialog.ShowReadOnly = false;

            DialogResult result = fileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtSelectXML.Text = "";
                foreach (String arquivo in fileDialog.FileNames)
                {
                    txtSelectXML.Text += arquivo;
                }
            }
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            try
            {
                rootElem = XElement.Load(txtSelectXML.Text);
                txtLoadXML.Text = rootElem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar arquivo : " + ex.Message);
            }
        }

        private void btnSelectElements_Click(object sender, EventArgs e)
        {
            try
            {
                txtLoadXML.Text = "";
                elements = rootElem.Element("blocos").Elements();

                foreach (XElement elemento in elements)
                {
                    txtLoadXML.Text += "\n" + elemento.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro  : " + ex.Message);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                txtLoadXML.Text = "";
                elements = rootElem.Element("blocos").Elements();

                foreach (XElement elemento in elements)
                {
                    var childOne = elemento.Elements();
                    foreach (var item in childOne)
                    {
                        var childTwo = item.Elements();
                        foreach (var child in childTwo)
                        {
                            var childThree = child.Elements();
                            foreach (var chld in childThree)
                            {
                                Int32.TryParse(chld.Attribute("valor").Value, out idActual);
                                if (chld.Attribute("nome").Value.Equals("address"))
                                {
                                    chld.SetAttributeValue("valor", idActual + 100);
                                }
                            }
                        }
                    }
                }
                this.btnSelectElements_Click(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro  : " + ex.Message);
            }
        }
    }
}
