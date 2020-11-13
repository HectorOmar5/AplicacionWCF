using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSCliente
{
    public partial class btnBuscar : Form
    {
        public btnBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var identificacion = textBox1.Text;

            using (WSAlumnos.WSAlumnosClient client = new WSAlumnos.WSAlumnosClient())
            {
                var alumno = client.ObtenerAlumno(identificacion);

                var nombre = alumno.Nombre;
            }
        }
    }
}
