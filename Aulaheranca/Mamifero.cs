﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulaheranca
{
    public class Mamifero : Animal
    {
        public Mamifero(string nome, string especie)
        {
            Nome= nome;
            Especie= especie;
        }

        public void Mamar()
        {
            Respirar();

            Console.WriteLine($"Animal {Nome} da espécie {Especie} está mamando");
        }
    }
}
