using System;

namespace BioTech
{
    internal class Cactus : Planta
    {
        public override string AplicarClima(string clima)
        {
            if (clima == "Lluvioso")
            {
                Salud -= 10;

                if (Salud < 0)
                {
                    Salud = 0;
                }

                return $"Cactus afectado por exceso de agua. Salud: {Salud}";
            }

            if (clima == "Desértico")
            {
                Salud += 10;

                if (Salud > 100)
                {
                    Salud = 100;
                }

                return $"Cactus en su hábitat óptimo. Salud: {Salud}";
            }

            return $"Cactus sin cambios. Salud: {Salud}";
        }
    }
}