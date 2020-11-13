using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSALibros" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSALibros
    {
        [OperationContract]
        Libro ObtenerLibro(string NombreLibros);
    }

    [DataContract]
    public class Libro:Errores
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Autor { get; set; }
        [DataMember]
        public string Editorial { get; set; }
        public string Secreto { get; set; }
    }

    [DataContract]
    public class Errores
    {
        [DataMember]
        public string Error { get; set; }
    }
}

