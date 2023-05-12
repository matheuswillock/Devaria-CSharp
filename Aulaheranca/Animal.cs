using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulaheranca
{
    public class Animal
    {
        protected string Nome { get; set; }
        protected string Especie { get; set; }

        protected void Respirar() 
        {
            Console.WriteLine($"Animal {Nome} da espécie {Especie} está respirando");    
        }


    }
}
