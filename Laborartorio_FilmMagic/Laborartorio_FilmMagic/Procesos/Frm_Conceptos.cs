using Laborartorio_FilmMagic.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborartorio_FilmMagic.Procesos
{
    public partial class Frm_Conceptos : Form
    {
        public Frm_Conceptos()
        {
            InitializeComponent();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_buscarmembresia_Click(object sender, EventArgs e)
        {
            Frm_consultaMembresia concep = new Frm_consultaMembresia();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_membresia.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Frm_consultaConcepto concep = new Frm_consultaConcepto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_concepto.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }
    }
}
