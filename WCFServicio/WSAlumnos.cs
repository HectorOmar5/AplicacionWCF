using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface WSAlumnos
    {

        [OperationContract]
        Alumno ObtenerAlumno(string identificacion);

    }

    [DataContract]
    public class Alumno:Respuesta
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Apellido_Paterno { get; set; }
        [DataMember]
        public string Apellido_Materno { get; set; }
        [DataMember]
        public string NumCtrl { get; set; }
        [DataMember]
        public string Carrera { get; set; }
        public string Secreto { get; set; }
    }
    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public string Mensaje { get; set; }
        [DataMember]
        public string Error { get; set; }
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
        
    }
}
