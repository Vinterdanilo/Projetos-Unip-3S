using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeiraAula.Modelo;

namespace PrimeiraAula.Modelo
{
    public class Calculos : absPropriedades
    {
        public Calculos(Double n1, Double n2, String op) :base(n1, n2, op)
        {
            Calcular();
        }

        public void Calcular()
        {
            if (this.op.Equals("+"))
            {
                this.resposta = (this.n1 + this.n2).ToString();
            }
            if (this.op.Equals("-"))
            {
                this.resposta = (this.n1 - this.n2).ToString();
            }
            if (this.op.Equals("*"))
            {
                this.resposta = (this.n1 * this.n2).ToString();
            }
            if (this.op.Equals("/"))
            {
                this.resposta = (this.n1 / this.n2).ToString();
            }
        }
    }
}
