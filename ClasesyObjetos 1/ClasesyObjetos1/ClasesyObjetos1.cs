namespace ClasesyObjetos1
{
    public class Perro
    {
        private string nombre;
        private string raza;
        private string altura;

        public string Nombre
        { 
            get {return nombre;} 
            set {nombre = value;}
        }

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        public string Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Perro() { }

        public Perro(string nombre, string raza, string altura)
        { 
            this.nombre = nombre;
            this.raza = raza;  
            this.altura = altura;
        }

        public void Dormir()
        {
            Console.WriteLine($"{nombre} esta durmiendo... Zzz");
        }

        public void Ladrar()
        {
            Console.WriteLine($"{nombre} dice: ¡Guau! ¡Guau!");
        }

        public string Comer(string carne)
        {
            return $"{nombre} mide {altura} y comera: {carne}";
        }
    }
}