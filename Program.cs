using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Name
{  
    class Album
    {
        public string Nombre { get; set; }
        public string Artista {get; set;}
        public int Anio { get; set; }
        public string Genero { get; set; }

        public Album(string nombre, string artista, int anio, string genero)
        {
            Nombre = nombre;
            Artista = artista;
            Anio = anio;
            Genero = genero;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Album> discos = new List<Album>();

            Console.WriteLine();
            discos.Add(new Album("Formula, Vol.2           |", "Romeo Santos |",2014, "Bachata, Pop latino, Pop, R&B contemporáneo        |"));
            discos.Add(new Album("Un verano sin ti         |", "Bad Bunny    |",2022, "Urbano Latino, Musica Tropical                     |"));
            discos.Add(new Album("The Most Powerful Rookie |", "Farruko      |",2012, "Urbano latino, Música tropical, Pop, Bachata       |"));
            discos.Add(new Album("Sincero                  |", "Chayanne     |",2003, "Pop latino, Balada romántica, Soft rock, Dance pop |"));
            discos.Add(new Album("Brothas Doobie           |", "Funkdoobiest |",1995, "Hip hop, West Coast rap, Rap alternativo           |"));
            discos.Add(new Album("Escucha                  |", "Laura Pausini|",2004, "Pop, Romanticas                                    |"));
            discos.Add(new Album("Los grandes éxitos Españ |", "Cypress Hill |",1999, "Hip hop, Gangsta rap, Hip hop latino, hardcore     |"));

            foreach (Album disco in discos)
            {
                Console.WriteLine($"| Nombre: {disco.Nombre}, | Artista: {disco.Artista}, | Año de lanzamiento: {disco.Anio}, | Género: {disco.Genero}");
            }
            Console.WriteLine();
        }
    }
}
