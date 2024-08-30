using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal abstract class Evaluador
    {
        public Evaluador(int añoACalcular, Moto vehiculo)
        {
            this.añoACalcular = añoACalcular;
            Vehiculo = vehiculo;
        }

        public int añoACalcular { get; protected set; }
        public int AñoACalcular { get; private set; }

        public Moto Vehiculo { get; set; }


        abstract public double CalcularDepreciacion();

        public virtual string VerDescripcion()
        {
            return "Año a calcular: " + añoACalcular +", Vehiculo: " + Vehiculo.Marca + ", Modelo: " + Vehiculo.Modelo + ", Valor de fabricacion: " + Vehiculo.ValorFabricacion + "$";
        }

    }
}
