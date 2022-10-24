using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abastecimento_de_Combustível
{
    class Abastecimento
    {
        private double ValorLitro;
        private double ValorPago;
        private double ValorKmrodado;

        public void SetValorLitro(double ValorLitro)
        {
            if (ValorLitro > 0) this.ValorLitro = ValorLitro;
        }
        public void SetValorPago(double ValorPago)
        {
            if (ValorPago > 0) this.ValorPago = ValorPago;
        }
        public void SetValorKmrodado(double ValorKmrodado)
        {
            if (ValorKmrodado > 0) this.ValorKmrodado = ValorKmrodado;
        }
        public double MediaKmlitro()
        {
            double numLitro = ValorPago / ValorLitro;
            return ValorKmrodado / numLitro;
        }
        public double MediaReaiskm()
        {
            return ValorPago / ValorKmrodado;
        }
    }
}
