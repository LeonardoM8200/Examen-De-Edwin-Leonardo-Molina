using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1_EdwinLeonardoMolinaFlores.Formularios
{
    public partial class frmsalarioneto : Form
    {
        Clases.Pagos_y_Cobros PYC = new Clases.Pagos_y_Cobros();
        public frmsalarioneto()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
           
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horas, salariobase, pagos, cooperativa, rap, pagosporhoras, coopetativa1, segurosocialxx, rap1, prestamo, cantidad1;
            salariobase = Convert.ToDouble(txtsalariobase.Text);
            horas = Convert.ToDouble(txthorasextras.Text);
            cooperativa = 0.05;
            rap = 1.5;
           

            
            if (horas < 20)
            {
                txtpagoxhorasnm.Text = ("40");
            }
            if (horas >=20)
            {
                txtpagoxhorasnm.Text = ("50");
            }
            pagos = Convert.ToDouble(txtpagoxhorasnm.Text);
            txtpagoporhoraextra.Text = PYC.pagosdoble(horas, pagos).ToString();
            pagosporhoras = Convert.ToDouble(txtpagoporhoraextra.Text);
           
            txtcooperativa.Text = PYC.cooperativa(salariobase, cooperativa).ToString();
            coopetativa1 = Convert.ToDouble(txtcooperativa.Text);
            

            if (salariobase>= 8722)
            {
                txtsegurosocial.Text = ("225");
            }
            if (salariobase< 8722)
            {
                txtsegurosocial.Text = (salariobase * 2.5 / 100).ToString();
            }
            segurosocialxx = Convert.ToDouble(txtsegurosocial.Text);
            txtrap.Text = PYC.RAP(salariobase, rap).ToString();

            rap1 = Convert.ToDouble(txtrap.Text);

           

            prestamo = Convert.ToDouble(txtprestamo.Text);
            txtcantidadmensual.Text = (prestamo * 10.0 / 100).ToString();
            cantidad1 = Convert.ToDouble(txtcantidadmensual.Text);
            txttotaldeduccion.Text = (coopetativa1 + segurosocialxx + rap1).ToString();
            txtpagototal.Text = (salariobase + pagosporhoras - coopetativa1 - segurosocialxx - rap1 - cantidad1).ToString();
           
            
            


            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre;
            double salario, horas, pagoporhoras, cooperativa, segurosocial, rap, total, prestamo, deduccion;
            nombre = txtnombre.Text;
            salario = Convert.ToDouble(txtsalariobase.Text);
            horas = Convert.ToDouble(txthorasextras.Text);
            pagoporhoras = Convert.ToDouble(txtpagoporhoraextra.Text);
            cooperativa = Convert.ToDouble(txtcooperativa.Text);
            segurosocial = Convert.ToDouble(txtsegurosocial.Text);
            rap = Convert.ToDouble(txtrap.Text);
            total = Convert.ToDouble(txtpagototal.Text);
            prestamo = Convert.ToDouble(txtcantidadmensual.Text);
            deduccion = Convert.ToDouble(txttotaldeduccion.Text);
            dataGridView1.Rows.Add(nombre, pagoporhoras, cooperativa, segurosocial, rap, prestamo, deduccion, total);

            txtnombre.Clear();
            txthorasextras.Clear();
            txtcooperativa.Clear();
            txtpagoporhoraextra.Clear();
            txtpagototal.Clear();
            txtrap.Clear();
            txtsalariobase.Clear();
            txtsegurosocial.Clear();
            txtpagoxhorasnm.Clear();
            txtprestamo.Clear();
            txtcantidadmensual.Clear();
            txttotaldeduccion.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Column6"].Value);


                txttotal.Text = Convert.ToString(total);

            }
            double total2 = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total2 += Convert.ToDouble(row.Cells["Column7"].Value);

                txtbox1.Text = Convert.ToString(total2);


            }


        }
    }
}
