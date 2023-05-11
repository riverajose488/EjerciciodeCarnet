using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AplicacioneEstudiantes
{
    public partial class lblErrorCarnet : Form
    {
        Estudiante[] estudiante = new Estudiante[5];
        int contador = 0;
        public lblErrorCarnet()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
            ListViewItem lista = new ListViewItem(txtCarnet.Text);
            lista.SubItems.Add(txtNombre.Text);
            listView1.Items.Add(lista);
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                Boolean verificado = true;
                if (txtCarnet.Text == "")
                {
                    lblCarnetError.Text = "El carnet no pueder ser vacio";
                    lblCarnetError.Visible = true;
                    verificado = false;
                }

                if (txtNombre.Text == "")
                {
                    lblErrorNombre.Text = "El carnet no pueder ser vacio";
                    lblErrorNombre.Visible = true;
                    verificado = false;
                }

                if (verificado)
                {
                    estudiante[contador] = new Estudiante(txtCarnet.Text, txtNombre.Text);
                    contador++;

                    txtCarnet.Text = "";
                    txtNombre.Text = "";
                    lblCarnetError.Visible = false;
                    lblErrorNombre.Visible = false;

                }
            }
            else
            {
                lblError.Text = "No es posible almacenar mas estudiantes";
                lblError.Visible = true;
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblCarnetError_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorCarnet_Load(object sender, EventArgs e)
        {

        }

        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (contador < 5)
                {
                    Boolean verificado = true;
                    if (txtCarnet.Text == "")
                    {
                        lblCarnetError.Text = "El carnet no pueder ser vacio";
                        lblCarnetError.Visible = true;
                        verificado = false;
                    }

                    if (txtNombre.Text == "")
                    {
                        lblErrorNombre.Text = "El carnet no pueder ser vacio";
                        lblErrorNombre.Visible = true;
                        verificado = false;
                    }

                    if (verificado)
                    {
                        estudiante[contador] = new Estudiante(txtCarnet.Text, txtNombre.Text);
                        contador++;

                        txtCarnet.Text = "";
                        txtNombre.Text = "";
                        lblCarnetError.Visible = false;
                        lblErrorNombre.Visible = false;

                    }
                }
                else
                {
                    lblError.Text = "No es posible almacenar mas estudiantes";
                    lblError.Visible = true;
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (contador < 5)
                    {
                        Boolean verificado = true;
                        if (txtCarnet.Text == "")
                        {
                            lblCarnetError.Text = "El carnet no pueder ser vacio";
                            lblCarnetError.Visible = true;
                            verificado = false;
                        }

                        if (txtNombre.Text == "")
                        {
                            lblErrorNombre.Text = "El carnet no pueder ser vacio";
                            lblErrorNombre.Visible = true;
                            verificado = false;
                        }

                        if (verificado)
                        {
                            estudiante[contador] = new Estudiante(txtCarnet.Text, txtNombre.Text);
                            contador++;

                            txtCarnet.Text = "";
                            txtNombre.Text = "";
                            lblCarnetError.Visible = false;
                            lblErrorNombre.Visible = false;

                        }
                    }
                    else
                    {
                        lblError.Text = "No es posible almacenar mas estudiantes";
                        lblError.Visible = true;
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
