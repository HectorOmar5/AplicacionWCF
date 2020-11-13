using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWSMusica" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWSMusica
    {
        [OperationContract]
        Musica ObtenerMusica(string NombreMusica);
    }

    [DataContract]
    public class Musica:Erroress
    {

        [DataMember]
        public string Autor { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Genero { get; set; }
        [DataMember]
        public string Duracion { get; set; }
    }

    [DataContract]
    public class Erroress
    {
        [DataMember]
        public string Error { get; set; }
    }

}
