using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;
using TiamitDAO;
using Modelo;

namespace Vista
{
    ///////////////////////////////////////////////////////////
    //  Original author: sebastian
    ///////////////////////////////////////////////////////////
    public partial class validUserForm : Form
    {
        public string usuario = null;
        public string contraseña = null;
        string connectionString;
        public Usuario user;

        public validUserForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Content/Background1.PNG");
            pwd.PasswordChar = '*';

            //this.label3.Parent = pictureBox1;
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            validUserForm.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = usu.Text;
            contraseña = pwd.Text;
            
            if (usuario == "") {
                MessageBox.Show("Escria porfavor un usuario");
                return;
            }
            if (contraseña == "") {
                MessageBox.Show("escriba una contraseña valida");
                return;
            }

            UsuarioDao usurDao = new UsuarioDao(usuario,contraseña);
            bool band = usurDao.userValidation();
            if (band)
            {
                user = usurDao.crearUsuario();
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("usuario o contraseña no valido");

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }
    }
}

// SELECT condicion from tabla 