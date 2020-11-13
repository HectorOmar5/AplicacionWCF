using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSMusica" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSMusica.svc o WSMusica.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSMusica : IWSMusica
    {
        public Musica ObtenerMusica (string NombreMusica)
        {
            if(NombreMusica == "1")
            {
                return new Musica { Autor = "Los Cadetes De Linares", Nombre = "Las Tres Tumbas", Genero = "Corridos", Duracion = "2:26 min." };
            }
            else if (NombreMusica == "2")
            {
                return new Musica { Autor = "Antonio Aguilar", Nombre = "Lamberto Quintero", Genero = "Corridos", Duracion = "3:02 min." };
            }
            if (NombreMusica == "3")
            {
                return new Musica { Autor = "Carlos y Jose", Nombre = "Arboles De La Barranca", Genero = "Corridos", Duracion = "2:21 min." };
            }
            else
            {
                return new Musica { Error = "Canción No Encontrada" };
            }
        }
    }
}
