using SistemaMetricas.Models;
using SistemaMetricas.Services.Handlers;
using SistemaMetricas.Services.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmUsuarios : Form
    {
        AreaService areaService = new AreaService();
        LoginService LoginService = new LoginService();
        SecurityService rolService = new SecurityService();
        string idUpdate = string.Empty;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void GetUsuarios()
        {
            grdDatos.DataSource = LoginService.TraerUsuarios();
        }

        private void GetAreas()
        {
            cmbAreas.DataSource = areaService.GetAreas();
            cmbAreas.DisplayMember = "Area";
            cmbAreas.ValueMember = "Area";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdDatos.Rows[e.RowIndex];

             string id  = row.Cells["Id"].Value.ToString();
            idUpdate = id;
            
            if(e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                //MessageBox.Show("ID seleccionado: " + id.ToString());
                txtUsuario.Text = row.Cells["Usuario"].Value.ToString();
                txtClave.Text = row.Cells["Clave"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDni.Text = row.Cells["Dni"].Value.ToString();
                cmbAreas.Text = row.Cells["Area"].Value.ToString();
                cmbEstado.Text = row.Cells["Estado"].Value.ToString();

                Login login = new Login();
                login.Id = Convert.ToInt32(id);
                login.Usuario = txtUsuario.Text;
                login.Clave = EncriptHandler.Base64Decode(txtClave.Text);
                login.Nombre = txtNombre.Text;
                login.Apellido = txtApellido.Text;
                login.Dni = txtDni.Text;
                login.Email = txtEmail.Text;
                login.Area = cmbAreas.Text;
                login.Estado = cmbEstado.Text;

                btnEditar.Visible = true;
                btnNuevoUsuario.Visible = false;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DialogResult dialogo = MessageBox.Show("Continuar con la eliminacion","Atencion",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                if(dialogo == DialogResult.OK)
                {
                    if (LoginService.DeleteUsuario(id))
                    {
                        btnAlert.Text = "Usuario eliminado correctamente";
                        btnAlert.BackColor = Color.ForestGreen;
                    }
                    else
                    {
                        btnAlert.Text = "Ocurrio un problema";
                        btnAlert.BackColor = Color.Crimson;
                    }
                    GetUsuarios();
                }
            }
        }

        private void frmUsuarios_Load(object sender, System.EventArgs e)
        {

            GetAreas();
            GetUsuarios();
            btnEditar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Id = Convert.ToInt32(idUpdate);
            login.Usuario = txtUsuario.Text;
            login.Clave = EncriptHandler.Base64Encode(txtClave.Text);
            login.Nombre = txtNombre.Text;
            login.Apellido = txtApellido.Text;
            login.Dni = txtDni.Text;
            login.Email = txtEmail.Text;
            login.Area = cmbAreas.Text;
            login.Estado = cmbEstado.Text;


            if (LoginService.EditarUsuario(login))
            {
                btnAlert.Text = "Usuario Editado correctamente.";
                btnAlert.BackColor = Color.ForestGreen;
            }
            else
            {
                btnAlert.Text = "Ocurrio un Error";
                btnAlert.BackColor = Color.Crimson;
            }
            btnEditar.Visible = false;
            btnNuevoUsuario.Visible = true;
            GetUsuarios();

        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Usuario = txtUsuario.Text;
            login.Clave = txtClave.Text;
            login.Nombre = txtNombre.Text;
            login.Apellido = txtApellido.Text;
            login.Email = txtEmail.Text;
            login.Dni = txtDni.Text;    
            login.Area = cmbAreas.Text;


            bool respuesta = LoginService.CrearUsuario(login);

            if (respuesta)
            {
                btnAlert.Text = "Usuario creado correctamente.";
                btnAlert.BackColor = Color.ForestGreen;
            }
            else
            {
                btnAlert.Text = "Ocurrio un Error";
                btnAlert.BackColor = Color.Crimson;
            }

            btnAlert.Visible = true;
            GetUsuarios();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            btnAlert.Visible = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlert_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
