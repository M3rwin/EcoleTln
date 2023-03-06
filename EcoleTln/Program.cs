using System;
using Classes.ClassesEcole;

namespace EcoleTln
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Init();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static void Init()
        {
            Ecole ecoleTln = new Ecole("Bonaparte", 1939);
            Etudiant test2 = new Etudiant(2, "jade", 2013, "matter des seins");
            Console.WriteLine(test2.ToString());
        }

    }
}
