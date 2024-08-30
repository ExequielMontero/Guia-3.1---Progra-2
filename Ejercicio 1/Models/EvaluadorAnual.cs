using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class EvaluadorAnual:Evaluador
    {
        public EvaluadorAnual(int añoACalcular, Moto vehiculo, double tasadepreciacion) : base(añoACalcular, vehiculo)
        {
            TasaDepreciacion = tasadepreciacion;
        }

        public double TasaDepreciacion { get; set; }

        public override double CalcularDepreciacion()
        {
            double valoractualizado = Vehiculo.ValorFabricacion * (1 - TasaDepreciacion);
            return valoractualizado;
        }

        public override string VerDescripcion()
        {
            return "Vehiculo: " + Vehiculo.Marca + ", Modelo: " + Vehiculo.Modelo + ", Valor de fabricacion: " + Vehiculo.ValorFabricacion + "$, Depreciacion Anual: " + CalcularDepreciacion();
        }

    }
}
