using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Pantalla_de_Inscripciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            if (chkTodas.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("¡Por favor, seleccione al menos una materia!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                cmbAlumno.Focus();
                return;
            }
            else
            {
                if (radioButton1.Checked)
                {
                    mensaje = cmbAlumno.Text  + " Ud se inscribio en 2do 1ra. \n en las siguientes materias:\n" +
                        " \n";

                }

                else if (radioButton2.Checked)
                {
                    mensaje = cmbAlumno.Text  + " Ud se inscribio en 2do 2da. \n en las siguientes materias:\n" +
                        " \n";
                }

                if (checkBox1.Checked == true)
                { mensaje = mensaje + " Sistemas de Informacion.\n"; }
                if (checkBox2.Checked == true)
                { mensaje = mensaje + " Base de Datos.\n"; }
                if (checkBox3.Checked == true)
                { mensaje = mensaje + " EDI II.\n"; }
                if (checkBox4.Checked == true)
                { mensaje = mensaje + " Probablilidad y Estaditica.\n"; }
                if (checkBox5.Checked == true)
                { mensaje = mensaje + " Analisis Matematico II.\n" ; }
                if (checkBox6.Checked == true)
                { mensaje = mensaje + " Sistemas Operativos.\n"; }
                if (checkBox7.Checked == true)
                { mensaje = mensaje + " Programacion II.\n"; }
                if (checkBox8.Checked == true)
                { mensaje = mensaje + " Ingles Tecnico II.\n"; }

                MessageBox.Show(mensaje,"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAlumno.Items.Add("Marcos");
            cmbAlumno.Items.Add("Lucas");
            cmbAlumno.Items.Add("Denis");
            cmbAlumno.Items.Add("Alan");
            cmbAlumno.Items.Add("Johana");
            cmbAlumno.Items.Add("Micaela");
            cmbAlumno.SelectedIndex= 0;

        }

        private void chkTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodas.CheckState == CheckState.Checked)
            {
                foreach (Control G in grpMaterias.Controls)
                {
                    if ((G is CheckBox))
                    {
                        ((CheckBox)G).Checked = true;

                    }
                }
            }

            if (chkTodas.CheckState == CheckState.Unchecked)
            {
                foreach (Control G in grpMaterias.Controls)
                {
                    if ((G is CheckBox))
                    {
                        ((CheckBox)G).Checked = false;

                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Validad_chk V = new Validad_chk();
            V.Valid(grpMaterias, chkTodas);
        }
    }
}
