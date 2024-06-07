using Autos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Colecciones
{
    internal class VehiculoCollection
    {
        private static List<Vehiculo> _listadoVehiculos = new List<Vehiculo>();

        public static string Create(Vehiculo v)
        {
            var res = _listadoVehiculos.Find(x => x.Modelo == v.Modelo);

            if (res != null)
                return "Vehículo existente";

            v.Id = _listadoVehiculos.Count + 1;

            _listadoVehiculos.Add(v);

            return $"Vehículo agregado con éxito =)\n{v.InfoVehiculo()}\n";
        }

        public static string Read(int id)
        {
            var res = _listadoVehiculos.Find(x => x.Id == id);

            if (res == null)
                return $"Vehículo con Id: {id} no encontrado";

            return res.InfoVehiculo();
        }

        public static string Update(int id, string marca, string modelo)
        {
            var res = _listadoVehiculos.Find(x => x.Id == id);

            if (res == null)
                return $"Vehículo con Id: {id} no encontrado";

            res.Marca = marca;
            res.Modelo = modelo;

            return $"Vehículo actualizado \n{res.InfoVehiculo()}";
        }

        public static string Delete(int id)
        {
            var res = _listadoVehiculos.Find(x => x.Id == id);

            if (res == null)
                return $"Vehículo con Id: {id} no encontrado";

            _listadoVehiculos.Remove(res);

            return "Vehículo eliminado con éxito";
        }

        public static List<Vehiculo> ReadAll()
        { 
            return _listadoVehiculos;
        }

        public static List<Vehiculo> Search(string filter)
        {
            return _listadoVehiculos.Where(
                x => x.Modelo.Contains(filter) || x.Marca.Contains(filter)
                )
                .ToList();
        }
    }
}
