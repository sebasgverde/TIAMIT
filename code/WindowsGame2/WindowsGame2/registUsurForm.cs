using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TiamitDAO;
using Modelo;


namespace Vista
{
    ///////////////////////////////////////////////////////////
    //  Original author: sebastian
    ///////////////////////////////////////////////////////////
    public partial class registUsurForm : Form
    {
        public string usuario = null;
        public string contraseña = null;
        public int pais;
        public Usuario user;

        public registUsurForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Content/Background3.PNG");
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
            InterpretacionDao interDao = new InterpretacionDao();
            List<String> lis = interDao.listarPais();
            for (int i = 0; i < lis.Count; i++)
                comboBox1.Items.Add(lis[i]);

            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.label6.BackColor = Color.Transparent;
            this.label7.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario = textBox1.Text;
            contraseña = textBox4.Text;
            pais = comboBox1.SelectedIndex + 1;

            if(usuario == "" || usuario == null ){ //poner mensaje de error usuario vacio y parar la ejecucion 
                MessageBox.Show("Wrong user name, try again");
                return;
            }
            if (contraseña == "" || contraseña == null) { // Poner menjase de error contraseña vacia y para ejecucion 
                MessageBox.Show("Wrong password, try again");
                return;
            }
            if (contraseña != textBox3.Text) { // Poner mensaje de error "las contraseñas no coinciden" 
                MessageBox.Show("Passwords don't match, try again");
                return;
            }
            if (pais < 1) { // Poner mensaje de error falta escoger pais y parar ejecucion
                MessageBox.Show("Please choose a country");
                return;
            }

            UsuarioDao usudao = new UsuarioDao(usuario, contraseña);
            bool band = usudao.existingUserValidation();
            if (!band)
            {
                usudao.insertNewUser(pais);
                user = usudao.crearUsuario();
                MessageBox.Show("User created");
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Choose other name");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            validUserForm valid = new validUserForm();
            valid.ShowDialog();
        }
    }
}
