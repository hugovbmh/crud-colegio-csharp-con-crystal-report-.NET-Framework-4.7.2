using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Vista
{
    public partial class Form1 : Form
    {
        CNalumnos obj = new CNalumnos();
        private string idAlumno = null;
        private bool Editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        private void MostrarAlumnos()
        {
            CNalumnos objeto2 = new CNalumnos();//segunda instancia para mostrar y actualizar el datagridview
            dataGridView1.DataSource = objeto2.MostrarAlumnos();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //INSERTAR NUEVOS REGISTROS
            if (Editar == false)
            {
                try
                {
                    obj.InsertarAlumno(txtpnom.Text, txtsnom.Text, txtpape.Text, txtsape.Text, txttele.Text, txtcelu.Text, txtdir.Text, txtemail.Text, txtfecha.Text, txtobs.Text);
                    MessageBox.Show("Se insertó correctamente");
                    MostrarAlumnos();//actualizar datagridview
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                }
            }

            //EDITAR REGISTROS
            if(Editar == true)
            {
                try
                {
                    obj.EditarAlumno(txtpnom.Text, txtsnom.Text, txtpape.Text, txtsape.Text, txttele.Text, txtcelu.Text, txtdir.Text, txtemail.Text, txtfecha.Text, txtobs.Text,idAlumno);
                    MessageBox.Show("Se editó correctamente");
                    MostrarAlumnos();//actualizar datagridview
                    LimpiarForm();
                    Editar = false;
                    btnguardar.Text = "Guardar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtpnom.Text = dataGridView1.CurrentRow.Cells["p_nombre"].Value.ToString();
                txtsnom.Text = dataGridView1.CurrentRow.Cells["s_nombre"].Value.ToString();
                txtpape.Text = dataGridView1.CurrentRow.Cells["p_apellido"].Value.ToString();
                txtsape.Text = dataGridView1.CurrentRow.Cells["s_apellido"].Value.ToString();
                txttele.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
                txtcelu.Text = dataGridView1.CurrentRow.Cells["celular"].Value.ToString();
                txtdir.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                txtemail.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                txtfecha.Text = dataGridView1.CurrentRow.Cells["fec_nac"].Value.ToString();
                txtobs.Text = dataGridView1.CurrentRow.Cells["observ"].Value.ToString();
                idAlumno = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                btnguardar.Text = "Actualizar";
            }
            else MessageBox.Show("Selecciona una fila");

        }
        private void LimpiarForm()
        {
            txtpnom.Clear();
            txtsnom.Text = "";
            txtpape.Clear();
            txtsape.Text = "";
            txttele.Clear();
            txtcelu.Text = "";
            txtdir.Clear();
            txtemail.Text = "";
            txtfecha.Clear();
            txtobs.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idAlumno = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                obj.EliminarAlumno(idAlumno);
                MessageBox.Show("Eliminado correctamente");
                MostrarAlumnos();
            }
            else MessageBox.Show("Selecciona una fila");
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            FrmReporteCliente frm = new FrmReporteCliente();
            frm.ShowDialog();
        }
    }
}
