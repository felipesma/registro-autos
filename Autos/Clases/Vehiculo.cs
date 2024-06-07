using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Clases
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Anho { get; set; }
        public string? VIN { get; set; }
        public bool EsElectrico { get; set; }
        private DateTime? _createdAt = DateTime.Now;

        public string InfoVehiculo()
        {
            return $"Id: {Id}\nMarca: {Marca}\nModelo: {Modelo}\nAño: {Anho}\nVIN: {VIN}\nMotor: {TipoMotor()}\nRegistro creado el: {_createdAt.ToString()}";
        }

        private string TipoMotor()
        {
            return EsElectrico ? "Eléctrico" : "Gasolina";
        }
    }
}
