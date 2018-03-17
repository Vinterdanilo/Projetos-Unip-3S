using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeiraAula.Modelo;

namespace PrimeiraAula.Modelo
{
   public class validacao
    {
       public String num1;
       public String num2;
       public Double n1;
       public Double n2;
       public String op;
       public String mensagem;

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

           
           if (this.op.Equals("/") && this.num2.Equals("0"))
           {
               this.mensagem += "Não é possível divisão por zero";
           }
       }
   }
}
