﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionForms
{
    public partial class AltaItemsForm : Form
    {
        private Articulo articulo = null;
        // para pedirle al usuario q abra un archivo local ---> 'Agregar Imagen manualmente'
        private OpenFileDialog archivo = null;
        public AltaItemsForm()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoria.DataSource = categoriaNegocio.Listar();
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
