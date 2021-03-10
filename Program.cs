using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    class persona
    {
        private string _nombre;
        private string _apellido;

     

        public string Nombre
        {

            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }


        public string getNombre()
        {
            return _nombre;
        }

        //public string getNombre => _nombre;
        //public string Nombre => _nombre;

      
    }
    class Program
    {
        static void Main(string[] args)
        {
            persona ana = new persona();
            //ana.setNombre("Ana");
            ana.Nombre = "Ana";
            //Console.WriteLine($" Nombre: {ana.getNombre()}");
            Console.WriteLine($" Nombre: {ana.Nombre}");

            Console.ReadKey();
        }
    }
}
