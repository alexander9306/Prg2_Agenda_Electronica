using System;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class Form1 : Form
    {

        private readonly Aplicacion app = new Aplicacion();

        public Form1()
        {
            InitializeComponent();
        }


        private void MostrarData()
        {
            var fila = new DataGridViewRow();
            fila.CreateCells(dgv);

            for (var i = 0; i < app.GetArrayCount(); i++)
            {
                fila.Cells[0].Value = app.GetPersona(i).nombre;
                fila.Cells[1].Value = app.GetPersona(i).apellido;
                fila.Cells[2].Value = app.GetPersona(i).edad;
                fila.Cells[3].Value = app.GetPersona(i).fechaNac.Date.ToString();
                fila.Cells[4].Value = app.GetPersona(i).direccion;
                fila.Cells[5].Value = app.GetPersona(i).provincia;
                fila.Cells[6].Value = app.GetPersona(i).pais;
                fila.Cells[7].Value = app.GetPersona(i).telefono;
                fila.Cells[8].Value = app.GetPersona(i).celular;
            }

            dgv.Rows.Add(fila);
        }

        private void LimpiarTextos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            dtpFechaNac.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            txtPais.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
        }


        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            app.CrearPersona(txtNombre.Text,
                txtApellido.Text,
                txtEdad.Text,
                dtpFechaNac.Value.Date,
                txtDireccion.Text,
                txtProvincia.Text,
                txtPais.Text,
                txtTelefono.Text,
                txtCelular.Text
            );
            LimpiarTextos();
            MostrarData();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            app.EliminarPersona(dgv.CurrentRow.Index);
            dgv.Rows.Remove(dgv.CurrentRow);
        }
    }
}

