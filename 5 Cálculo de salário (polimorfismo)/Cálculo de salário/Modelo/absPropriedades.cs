using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_salário.Modelo
{
    public abstract class absPropriedades: intMetodos
    {
        public String mensagem;
        public String resposta;
        protected String salarioBruto;
        protected String imposto;
        public Double numeroSalarioBruto;
        public Double numeroImposto;

        public absPropriedades(String salarioBruto, String imposto)
        {
            this.salarioBruto = salarioBruto;
            this.imposto = imposto;
        }

        public absPropriedades(Double numeroSalarioBruto, Double numeroImposto)
        {
            this.numeroSalarioBruto = numeroSalarioBruto;
            this.numeroImposto = numeroImposto;
        }

        public virtual void Executar()
        {
        }

        public override string ToString()
        {
            return this.resposta;
        }
    }
}
