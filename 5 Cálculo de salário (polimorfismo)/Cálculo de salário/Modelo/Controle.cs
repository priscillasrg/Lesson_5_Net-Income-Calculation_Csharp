using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_salário.Modelo
{
    public class Controle: absPropriedades
    {
        public Controle(String salarioBruto, String imposto): base(salarioBruto, imposto)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            absPropriedades validacao = new Validacao(this.salarioBruto, this.imposto);

            if(validacao.mensagem.Equals(""))
            {
                absPropriedades calculo = new Calculo(validacao.numeroSalarioBruto, validacao.numeroImposto);
                this.resposta = calculo.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
