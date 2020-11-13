using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : WSAlumnos
    {
        public Alumno ObtenerAlumno(string identificacion)
        {
            if(identificacion == "1")
            {
                return new Alumno() { Nombre = "Juan", Apellido_Paterno = "Perez", Apellido_Materno = "Durán", Carrera = "Contaduría", NumCtrl = "10BA3467" };
            }
            else if(identificacion == "2")
            {
                return new Alumno() { Nombre = "Pedro", Apellido_Paterno = "Juarez", Apellido_Materno = "Reyes", Carrera = "Agronomía", NumCtrl = "10AS3409" };
            }
            else
            {
                return new Alumno() { Error = "Alumno No Encontrado" };
            }
        }
    }
}

