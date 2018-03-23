using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeiraAula.Modelo;


namespace PrimeiraAula.Modelo
{
   public abstract class absPropriedades
    {
       public absPropriedades(String num1, String num2, String op)
       {/*pegando os parametros e colocando nos atributos interno*/
           this.num1 = num1;
           this.num2 = num2;
           this.op = op;
       }
       /*sobrecarga de metodos, + de 1 construtor porem tem que ser um parametro ter que ser diferente do outro*/
       public absPropriedades(Double n1, Double n2, String op)
       {
           this.n1 = n1;
           this.n2 = n2;
           this.op = op;
       }

        public Double n1;
        public Double n2;
        public String op;
        public String resposta;
        public String num1;
        public String num2;
        public String mensagem;

        public void teste()
        {
 
        }
      
    }
}
