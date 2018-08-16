using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_salário.Modelo
{
    public class Calculo: absPropriedades
    {
        public Calculo(Double numeroSalarioBruto, Double numeroImposto): base(numeroSalarioBruto, numeroImposto)
        {
            Executar();
        }

        public override void Executar()
        {
            this.resposta = "O valor do salário líquido é de:  \n" + "R$" + ((numeroSalarioBruto) - (numeroSalarioBruto * (numeroImposto / 100))).ToString("0.##") +
                "\n\nO valor pago de impostos foi de:  \n" + "R$ " + ((numeroSalarioBruto * (numeroImposto / 100)).ToString("0.##"));
        }
    }
}
