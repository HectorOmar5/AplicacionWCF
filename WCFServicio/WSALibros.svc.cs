using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WSALibros" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WSALibros.svc o WSALibros.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSALibros : IWSALibros
    {
        public Libro ObtenerLibro(string NombreLibro)
        {
            if(NombreLibro == "1")
            {
                return new Libro() { Nombre = "El Niño Con El Pijama De Rayas", Autor = "John Boyne", Editorial = "Salamandra" };
            }
            else if(NombreLibro == "2")
            {
                return new Libro() { Nombre = "Bajo La Misma Estrella", Autor = "John Green", Editorial = "Nube De Tinta" };
            }
            else if(NombreLibro == "3")
            {
                return new Libro() { Nombre = "La Chica Del Tren", Autor = "Paula Hawkins", Editorial = "Planeta" };
            }
            else
            {
                return new Libro() { Error = "Libro No Encontrado" };
            }
        }
    }
}
