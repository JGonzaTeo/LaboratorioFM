using Laborartorio_FilmMagic.Mantenimiento;
using Laborartorio_FilmMagic.Mantenimientos;
using Laborartorio_FilmMagic.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborartorio_FilmMagic
{
    public partial class Menu_Principal : Form
    {
        private int childFormNumber = 0;
        string susuario="jose";
        public Menu_Principal()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        bool ventanaConceptos = false;
       // Frm_MantPercepciones conceptos = new Frm_MantPercepciones("");

        private void PruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantPercepciones);
            //if (ventanaConceptos == false || frmC == null)
            //{
            //    if (frmC == null)
            //    {
            //        conceptos = new Frm_MantPercepciones(susuario);
            //    }

            //    conceptos.MdiParent = this;
            //    conceptos.Show();
            //    Application.DoEvents();
            //    ventanaConceptos = true;

            //}
            //else
            //{
            //    conceptos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            //}
        }
        bool ventanaproveedores = false;
        Frm_Proveedores proveedores = new Frm_Proveedores();

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Proveedores);
            if (ventanaproveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    proveedores = new Frm_Proveedores();
                }

                proveedores.MdiParent = this;
                proveedores.Show();
                Application.DoEvents();
                ventanaproveedores = true;

            }
            else
            {
                proveedores.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanasucursal = false;
        Frm_sucursal sucursal = new Frm_sucursal();
        private void SucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_sucursal);
            if (ventanasucursal == false || frmC == null)
            {
                if (frmC == null)
                {
                    sucursal = new Frm_sucursal();
                }

                sucursal.MdiParent = this;
                sucursal.Show();
                Application.DoEvents();
                ventanasucursal = true;

            }
            else
            {
                sucursal.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaprodcuto = false;
        Frm_productos producto = new Frm_productos();
        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_productos);
            if (ventanaprodcuto == false || frmC == null)
            {
                if (frmC == null)
                {
                    producto = new Frm_productos();
                }

                producto.MdiParent = this;
                producto.Show();
                Application.DoEvents();
                ventanaprodcuto = true;

            }
            else
            {
                producto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanaautor= false;
        Frm_MantAutor autor = new Frm_MantAutor();
        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantAutor);
            if (ventanaautor == false || frmC == null)
            {
                if (frmC == null)
                {
                    autor = new Frm_MantAutor();
                }

                autor.MdiParent = this;
                autor.Show();
                Application.DoEvents();
                ventanaautor = true;

            }
            else
            {
                autor.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanacategoria = false;
        Frm_MantCategoria categoria = new Frm_MantCategoria();
        private void CategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantCategoria);
            if (ventanacategoria == false || frmC == null)
            {
                if (frmC == null)
                {
                    categoria = new Frm_MantCategoria();
                }

                categoria.MdiParent = this;
                categoria.Show();
                Application.DoEvents();
                ventanacategoria = true;

            }
            else
            {
                categoria.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanacliente = false;
        Frm_MantCliente cliente = new Frm_MantCliente();
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantCliente);
            if (ventanacliente == false || frmC == null)
            {
                if (frmC == null)
                {
                    cliente = new Frm_MantCliente();
                }

                cliente.MdiParent = this;
                cliente.Show();
                Application.DoEvents();
                ventanacliente = true;

            }
            else
            {
                cliente.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaconcepto= false;
        Mnt_Concepto concepto = new Mnt_Concepto();
        private void ConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Mnt_Concepto);
            if (ventanaconcepto == false || frmC == null)
            {
                if (frmC == null)
                {
                    concepto = new Mnt_Concepto();
                }

                concepto.MdiParent = this;
                concepto.Show();
                Application.DoEvents();
                ventanaconcepto = true;

            }
            else
            {
                concepto.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanamembresia = false;
        Frm_MantMembresia membresia = new Frm_MantMembresia();
        private void MembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantMembresia);
            if (ventanamembresia == false || frmC == null)
            {
                if (frmC == null)
                {
                    membresia = new Frm_MantMembresia();
                }

                membresia.MdiParent = this;
                membresia.Show();
                Application.DoEvents();
                ventanamembresia = true;

            }
            else
            {
                membresia.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanatipoprod = false;
        Frm_MantTipoProducto tipoprod = new Frm_MantTipoProducto();
        private void TipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantTipoProducto);
            if (ventanatipoprod == false || frmC == null)
            {
                if (frmC == null)
                {
                    tipoprod = new Frm_MantTipoProducto();
                }

                tipoprod.MdiParent = this;
                tipoprod.Show();
                Application.DoEvents();
                ventanatipoprod = true;

            }
            else
            {
                membresia.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanarenta = false;
        Frm_renta renta = new Frm_renta();
        private void RentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_renta);
            if (ventanarenta == false || frmC == null)
            {
                if (frmC == null)
                {
                    renta = new Frm_renta();
                }

                renta.MdiParent = this;
                renta.Show();
                Application.DoEvents();
                ventanarenta = true;

            }
            else
            {
                renta.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanabonos = false;
        Frm_Conceptos bono = new Frm_Conceptos();
        private void BonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Conceptos);
            if (ventanabonos == false || frmC == null)
            {
                if (frmC == null)
                {
                    bono = new Frm_Conceptos();
                }

                bono.MdiParent = this;
                bono.Show();
                Application.DoEvents();
                ventanabonos = true;

            }
            else
            {
                bono.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
    }

