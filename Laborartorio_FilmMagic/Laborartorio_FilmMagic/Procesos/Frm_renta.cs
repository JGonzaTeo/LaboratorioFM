﻿using Laborartorio_FilmMagic.Consulta;
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
    public partial class Frm_renta : Form
    {
        public Frm_renta()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_membresia_Click(object sender, EventArgs e)
        {
            Frm_consultaMembresia concep = new Frm_consultaMembresia();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_membresia.Text = concep.Dgv_consulta.Rows[concep.Dgv_consulta.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Btn_sucursal_Click(object sender, EventArgs e)
        {
            Frm_consultasucursal concep = new Frm_consultasucursal();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_sucursal.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }
    }
}
