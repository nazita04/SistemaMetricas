﻿using SistemaMetricas.Handlers;
using SistemaMetricas.Models;
using SistemaMetricas.Models.DTO;
using SistemaMetricas.Services.Handlers;
using SistemaMetricas.Services.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaMetricas
{
    public partial class frmLogin : Form
    {

        LoginService loginService = new LoginService();
        AreaService areaService = new AreaService(); 

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Text == "")
            {
                btnAlert.Visible = true;
                btnAlert.Text = "Los datos son obligatorios";
                btnAlert.BackColor = Color.Crimson;
                return;
            }

            LoginDTO loginDTO = new LoginDTO();
            loginDTO.Usuario = txtLogin.Text;
            loginDTO.Clave = EncriptHandler.Base64Encode(txtPassword.Text);

            bool result = loginService.Login(loginDTO);

            if (result)
            {
                DatosGlobales datosGlobales = new DatosGlobales();
                string usuario = txtLogin.Text;
                string area = areaService.GetAreaByLogin(txtLogin.Text);
                
                datosGlobales.SetRedis(usuario, area);

                DatosGlobales.AreaUsuario = areaService.GetAreaByLogin(txtLogin.Text);
             

                DatosGlobales.UsuarioLogeado = txtLogin.Text;
                frmHome home = new frmHome();
                home.Shown += (s, args) => this.Hide();
                home.FormClosed += (s, args) => this.Close();
                home.ShowDialog();
            }
            else
            {
                btnAlert.Visible = true;
                btnAlert.Text = "Las credenciales no son validas";
                btnAlert.BackColor = Color.Crimson;
            }
        }

        private void lblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPanel.Visible = true;
        }

        private void cmdCrearUsuario_Click(object sender, EventArgs e)
        {

            Login login = new Login();
            login.Usuario = txtUsuario.Text;
            login.Clave = txtClave.Text;
            login.Nombre = txtNombre.Text;
            login.Apellido = txtApellido.Text;
            login.Email = txtEmail.Text;
            login.Dni = txtDni.Text;
            login.Area = cmbAreas.Text;



            bool respuesta = loginService.CrearUsuario(login);

            if (respuesta)
            {
                btnAlert.Text = "Usuario creado correctamente.";
                btnAlert.BackColor = Color.ForestGreen;
            }
            else
            {
                btnAlert.Text = "Ocurrio un problema al crear el usuario.";
                btnAlert.BackColor = Color.Crimson;
            }

            pnlPanel.Visible = false;
            txtLogin.Text = txtUsuario.Text;
            btnAlert.Visible = true;
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            btnAlert.Visible = false;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            pnlPanel.Visible = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pnlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPanel_Click(object sender, EventArgs e)
        {

        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
