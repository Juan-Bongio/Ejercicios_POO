using System;

namespace MarketCraft
{
    internal class Pocion : ItemMercado
    {
        public override string CotizarVenta(int cantidad)
        {
            if (cantidad > Stock)
            {
                decimal totalDisponible = PrecioBase * Stock;

                return $"[Poción] Solo hay {Stock} unidades disponibles de {Nombre}. Total: ${totalDisponible}";
            }

            decimal total = PrecioBase * cantidad;

            return $"[Poción] {cantidad} unidades de {Nombre}. Total: ${total}";
        }
    }
}