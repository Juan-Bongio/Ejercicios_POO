using System;

namespace MarketCraft
{
    internal class MineralRaro : ItemMercado
    {
        private decimal _factorEscasez;

        public decimal FactorEscasez
        {
            get { return _factorEscasez; }
            set
            {
                if (value > 0)
                {
                    _factorEscasez = value;
                }
            }
        }

        public override string CotizarVenta(int cantidad)
        {
            decimal precioFinal = PrecioBase;

            if (Stock < 5)
            {
                precioFinal *= FactorEscasez;

                decimal totalEscasez = precioFinal * cantidad;

                return $"[Mineral Raro] ¡Precio inflado por alta demanda! {cantidad} unidades de {Nombre}. Total: ${totalEscasez}";
            }

            decimal total = precioFinal * cantidad;

            return $"[Mineral Raro] {cantidad} unidades de {Nombre}. Total: ${total}";
        }
    }
}