using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeiraAula.Modelo;


namespace PrimeiraAula.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle(String num1, String num2, String op) /*jogando os atributos para a classe pai "base"*/  :base (num1, num2, op)
        {       
            this.Executar();
        }
        /*atributos*/
       

        /*classe Executar*/
        public void Executar()
        {
            this.mensagem = "";

            /*isntanciar a classe*/
            validacao validacao = new validacao(this.num1, this.num2, this.op);

            if (validacao.mensagem.Equals(""))
            {
                /*isntanciar a classe*/

                Calculos calculos = new Calculos(validacao.n2,validacao.n1, this.op);
                this.resposta = calculos.resposta;
                
            }
            else
            {
                /*log de erro*/
                this.mensagem = validacao.mensagem;
            }

        }
    }
}