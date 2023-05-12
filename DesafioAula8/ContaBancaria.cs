﻿namespace DesafioAula8
{
    public class ContaBancaria
    {
        public string? Tipo { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set;}
        public double Saldo { get; set; }

        public ContaBancaria(string? tipo, int numero, int agencia, double saldo)
        {
            Tipo = tipo;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public string ExibirDadosConta() 
        {
            return $"A conta bancária pesquisada é do tipo {Tipo} com a agencia {Agencia} e inscrita no número de conta {Numero} com o saldo {Saldo}";

        }

    }
}
