using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeiraAula.Modelo;

namespace PrimeiraAula.Modelo
{
   public class validacao : absPropriedades
    {
       public validacao(String num1, String num2, String op) :base (num1, num2, op)
       {
           Validar();
       }
       /*metodo para se comunicar com os atributos*/
       public void Validar()
       {
           this.mensagem = "";
           try
           {
               this.n1 = Convert.ToDouble(this.num1);
           }
           catch (FormatException e)
           {
               this.mensagem = "Erro de converção 1 campo \n";
           }

           try
           {
               this.n2 = Convert.ToDouble(this.num2);
           }
           catch (FormatException e)
           {
               this.mensagem += "Erro de converção 2 campo";
           }

           
           if (this.op.Equals("/") && this.num2
               .Equals("0"))
           {
               this.mensagem += "Não é possível divisão por zero";
           }
       }
   }
}
