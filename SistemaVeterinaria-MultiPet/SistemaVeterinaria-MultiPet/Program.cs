using System;

namespace HerenciaPolimorfismoApp
{
    internal class Mascota
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }
            }
        }

        public virtual void RealizarExamen()
        {
            Console.WriteLine($"Realizando Chequeo General a {Nombre}");
        }

        public class Perro : Mascota
        {
            public bool EsEntrenado { get; set; }

            public override void RealizarExamen()
            {
                Console.WriteLine($"[Canino] Revisando articulaciones y vacunas de {Nombre}");
            }
        }

        public class Gato : Mascota
        {
            public override void RealizarExamen()
            {
                Console.WriteLine($"[Felino] Revisando reflejos y pelaje de {Nombre}");
            }
        }

        class Program
        {
            private static void Main(string[] args)
            {
                List<Mascota> pacientes = new List<Mascota>();

                pacientes.Add(new Perro { Nombre = "Rex", EsEntrenado = true });
                pacientes.Add(new Gato { Nombre = "Michi" });

                Console.WriteLine("--- Turnos del dia ---");

                foreach (var paciente in pacientes)
                {
                    paciente.RealizarExamen();
                }

                Console.ReadLine();
            }
        }
    }
}