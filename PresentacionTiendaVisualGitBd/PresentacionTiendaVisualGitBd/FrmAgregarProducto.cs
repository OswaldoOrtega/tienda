﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadoresTienda;
using Entidades;
namespace PresentacionTiendaVisualGitBd
{
    public partial class FrmAgregarProducto : Form
    {
        ManejdaroTienda mt;
        public FrmAgregarProducto()
        {
            InitializeComponent();
            mt = new ManejdaroTienda();
            if(FrmTienda.tien.Idproducto>0)
            {
                txtNombre.Text = FrmTienda.tien.Nombre;
                txtDescripcion.Text = FrmTienda.tien.Descripcion;
                txtPrecio.Text = FrmTienda.tien.Precio.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mt.Guardar(new Tienda(FrmTienda.tien.Idproducto, txtNombre.Text, txtDescripcion.Text,
                double.Parse(txtPrecio.Text)));
        }
    }
}
