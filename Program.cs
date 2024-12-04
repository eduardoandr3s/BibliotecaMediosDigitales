using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace BibliotecaMediosDigitales
{

    abstract class MedioDigital
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }


        public MedioDigital(string titulo, string autor, int ano)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Ano = ano;
        }
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"\nTítulo: {Titulo}, Autor: {Autor}, Año: {Ano}");
        }
    }

    class Libro : MedioDigital
    {
        public int NumeroPaginas { get; set; }

        public Libro(string titulo, string autor, int ano, int numeroPaginas) : base(titulo, autor, ano)
        {

            this.NumeroPaginas = numeroPaginas;

        }
        public override void MostrarDetalles()
        {
            Console.Write("Libro: ");
            base.MostrarDetalles();
            Console.WriteLine($"Páginas: {NumeroPaginas}\n");


        }

    }

    class Pelicula : MedioDigital
    {

        public int DuracionMinutos { get; set; }

        public Pelicula(string titulo, string autor, int ano, int duracion) : base(titulo, autor, ano)
        {

            this.DuracionMinutos = duracion;

        }

        public override void MostrarDetalles()
        {
            Console.Write("Película: ");
            base.MostrarDetalles();
            Console.WriteLine($"Duración: {DuracionMinutos}\n");


        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MedioDigital libro1 = new Libro("Harry Potter 1", "J.K. Rowling", 1997, 223);
            MedioDigital pelicula1 = new Pelicula("Harry Potter 1", "Chris Columbus", 2001, 152);

            libro1.MostrarDetalles();
            pelicula1.MostrarDetalles();

        }
    }
}
