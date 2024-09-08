using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bono_Guia3
{
    /// <summary>
    /// Este programa consiste en calcular un bono de un x empleado
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            string puesto, nombre;
            double sueldo = 0, bono = 0, salarioTotal = 0;
            int categoria;
            try
            {


                //Capturando datos

                nombre = txtNombre.Text;
                // validando que los campos no esten vacios
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Debe completar el nombre del empleado");
                    return;
                }
                sueldo = Convert.ToDouble(txtSueldo.Text);

                if (sueldo <= 0)
                {
                    MessageBox.Show("El salario debe ser mayor a cero");
                    return;
                }
                if (combotxt.SelectedIndex == -1)
                {
                    MessageBox.Show("No a selecciona ninguna categoria");
                    return;
                }
                else
                {
                    puesto = Convert.ToString(combotxt.SelectedIndex);
                    categoria = combotxt.SelectedIndex + 1;
                }
                switch (categoria)
                {
                    case 1:
                        bono = 500;
                        break;
                    case 2:
                        bono = 300;
                        break;
                    case 3:
                        bono = 200;
                        break;
                    case 4:
                        bono = 100;
                        break;
                    default:
                        bono = 0;
                        break;
                }
                salarioTotal = bono + sueldo;

                MessageBox.Show(string.Format("El nombre es: {0}", nombre));
                MessageBox.Show(string.Format("El sueldo es: {0}", sueldo));
                MessageBox.Show(string.Format("El puesto es: {0}", puesto));
                MessageBox.Show(string.Format("El bono es: {0}", bono));
                MessageBox.Show(string.Format("El salario Total es: {0}", salarioTotal));

            }
            catch (Exception error)
            {
                MessageBox.Show(string.Format("Mensaje: {0}", error.Message));
            }

        }
    }
}
