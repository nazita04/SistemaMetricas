using SistemaMetricas.Models;
using SistemaMetricas.Models.DTO;
using SistemaMetricas.Services.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmAreas : Form
    {
        AreaService areaService = new AreaService();
        bool editMode = false;
        string idUpdate = string.Empty;
        public frmAreas()
        {
            InitializeComponent();
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            GetAreas();
        }

        private void GetAreas()
        {
            grdAreas.DataSource = areaService.GetAreas();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            txtArea.Text = "";
            txtDescripcion.Text = "";


            if (pnlPanel.Visible)
            {
                pnlPanel.Visible = false;
            }
            else
            {
                editMode = true;
                cmdCrearArea.Text = "Crear Area";
                pnlPanel.Visible = true;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            pnlPanel.Visible = false;
            lblEstado.Visible = false;
            cmbEstado.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPanel.Visible = false;
        }

        private void cmdCrearArea_Click(object sender, EventArgs e)
        {
            bool respuesta = false;
            if (editMode)
            {
                if (txtArea.Text == "" || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Los Campos Son obligatorios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                AreaDTO areaDTO = new AreaDTO();
                areaDTO.Area = txtArea.Text;
                areaDTO.Descripcion = txtDescripcion.Text;
                respuesta = areaService.CreateArea(areaDTO);
            }
            else
            {
                Areas areaUpdate = new Areas();
                areaUpdate.Id = Convert.ToInt32(idUpdate);
                areaUpdate.Area = txtArea.Text;
                areaUpdate.Descripcion = txtDescripcion.Text;
                areaUpdate.Estado = cmbEstado.Text;
                respuesta = areaService.EditarArea(areaUpdate);
            }

            if (respuesta)
            {
                GetAreas();
                pnlPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("Ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            editMode = false;
            cmdCrearArea.Text = "Crear Area";
        }

        private void grdAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdAreas.Rows[e.RowIndex];
            string id = row.Cells["Id"].Value.ToString();
            idUpdate = id;
            string area = row.Cells["Area"].Value.ToString();
            string descripcion = row.Cells["Descripcion"].Value.ToString();
            string estado = row.Cells["Estado"].Value.ToString();

            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                pnlPanel.Visible = true;
                txtArea.Text = area;
                txtDescripcion.Text = descripcion;
                lblEstado.Visible = true;
                cmbEstado.Visible = true;
                editMode = false;
                cmdCrearArea.Text = "Actualizar Area";
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                DialogResult dialogo = MessageBox.Show("esta seguro de eliminar a " + area + "?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialogo == DialogResult.OK)
                {
                    areaService.DeleteArea(id);
                }
                GetAreas();
            }

        }

        private void pnlPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
