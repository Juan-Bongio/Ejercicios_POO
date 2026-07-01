using System;

namespace MarketCraft
{
    internal class ItemMercado
    {
        private string _nombre;
        private decimal _precioBase;
        private int _stock;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
            }
        }

        public decimal PrecioBase
        {
            get { return _precioBase; }
            set
            {
                if (value > 0)
                {
                    _precioBase = value;
                }
            }
        }

        public int Stock
        {
            get { return _stock; }
            set
            {
                if (value >= 0)
                {
                    _stock = value;
                }
            }
        }

        public virtual string CotizarVenta(int cantidad)
        {
            decimal total = PrecioBase * cantidad;

            return $"{cantidad} unidades de {Nombre}. Total: ${total}";
        }
    }
}