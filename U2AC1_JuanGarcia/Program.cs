using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AC1_JuanGarcia
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion variables
            string nombreAlumno, Materia;
            byte calificacion = 0, matricula;

            //clasificacion de las variables
            Console.WriteLine("por favor escriba su nombre completo");
            nombreAlumno = Console.ReadLine();
            
            Console.WriteLine("por favor escriba su matricula");
            matricula = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("por favor escriba la materia que desea ver la calificacion");
            Materia = Console.ReadLine();


            //if
            if (calificacion >= 70)
            {
                Console.WriteLine("si acreditaste la materia ");

            }
            else
            {
                Console.WriteLine("no acreditaste el curso deberas de acreditar la materia nuevamente");
            }
        } 
    }
}
