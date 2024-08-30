using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class EvaluadorLineal : Evaluador
    {
        public EvaluadorLineal(int añoACalcular, Moto vehiculo, int vidautil) : base(añoACalcular, vehiculo)
        {
            VidaUtil = vidautil;
        }

        public int VidaUtil { get; set; }

        public override double CalcularDepreciacion()
        {
            int añodeuso = añoACalcular - Vehiculo.Modelo;
            double valoractualizado;
            return valoractualizado = Vehiculo.ValorFabricacion - (Vehiculo.ValorFabricacion * añodeuso / VidaUtil);

        }

        public override string VerDescripcion()
        {
            return "Vehiculo: " + Vehiculo.Marca + ", Modelo: " + Vehiculo.Modelo + ", Valor de fabricacion: " + Vehiculo.ValorFabricacion + "$, Depreciacion lineal: " + CalcularDepreciacion();
        }
    }
}
