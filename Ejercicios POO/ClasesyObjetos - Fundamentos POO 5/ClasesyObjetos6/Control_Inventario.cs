namespace Control_Inventario
{
    public class Producto
    {
        private string codigo;
        private string nombre;
        private double precio;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Producto(string codigo, string nombre, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
        }

        public void AplicarDescuento(double porcentaje)
        {
            double descuento = precio * porcentaje / 100;
            double precioFinal = precio - descuento;

            Console.WriteLine($"{nombre} tenia un precio de ${precio}");
            Console.WriteLine($"Descuento aplicado: {porcentaje}%");
            Console.WriteLine($"Precio final: ${precioFinal}");
        }
    }
}