using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_salário.Modelo
{
   public class Validacao: absPropriedades
    {
        public Validacao(String salarioBruto, String imposto): base(salarioBruto, imposto)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.numeroSalarioBruto = Convert.ToDouble(this.salarioBruto);
                this.numeroImposto = Convert.ToDouble(this.imposto);
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro de conversão";                
            }
        }
    }
}
