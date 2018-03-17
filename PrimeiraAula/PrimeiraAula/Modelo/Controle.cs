using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeiraAula.Modelo;


namespace PrimeiraAula.Modelo
{
    public class Controle
    {
        /*atributos*/
        public String num1;
        public String num2;
        public String op;
        public String resposta;
        public String mensagem;

        /*classe Executar*/
        public void Executar()
        {
            this.mensagem = "";

            /*isntanciar a classe*/
            validacao validacao = new validacao();
            validacao.num1 = this.num1;
            validacao.num2 = this.num2;
            validacao.op = this.op;
            validacao.Validar();
            

            if (validacao.mensagem.Equals(""))
            {
                /*isntanciar a classe*/
                Calculos calculos = new Calculos();
                calculos.n2 = validacao.n2;
                calculos.n1 = validacao.n1;
                calculos.op = this.op;
                calculos.Calcular();
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