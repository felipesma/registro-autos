using System;
using Autos.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autos.Colecciones;

namespace Autos.Dialogos
{
    internal class DialogosConsola
    {
        public static void CargarDialogoCreate()
        {
            Console.Clear();
            Console.WriteLine("AGREGAR NUEVO REGISTRO");
            Console.WriteLine("*********************************************\n");

            Console.WriteLine("Ingrese la marca del vehículo");
            string? marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo del vehiculo");
            string? modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año de fabricación");
            int anho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese número del chasis (VIN)");
            string? VIN = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de motor");
            Console.WriteLine("1. Eléctrico");
            Console.WriteLine("2. Gasolina");
            int motor = Convert.ToInt32(Console.ReadLine());

            bool tipoMotor;

            if (motor == 0)
                tipoMotor = true;
            if (motor == 2)
                tipoMotor = false;
            if (motor != 1 && motor != 2)
                Console.WriteLine("Opción inválida. Por defecto ase agregara como gasolina.");
                tipoMotor = false;

            Auto auto = new Auto()
            {
                Marca = marca,
                Modelo = modelo,
                Anho = anho,
                VIN = VIN,
                EsElectrico = tipoMotor
            };

            Console.WriteLine(VehiculoCollection.Create(auto));
        }

        public static void CargarDialogoRead()
        {
            Console.Clear();
            Console.WriteLine("OBTENER VEHÍCULO POR ID\n**********************************\n\n");
            Console.WriteLine("Ingrese el id del vehículo");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(VehiculoCollection.Read(id));
        }

        public static void CargarDialogoUpdate()
        {
            Console.Clear();
            Console.WriteLine("ACTUALIZAR VEHÍCULO");
            Console.WriteLine("***********************************\n");

            Console.WriteLine("Ingrese el id del vehículo a actualizar");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la nueva marca del vehículo");
            string? marca = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo modelo del vehículo");
            string? modelo = Console.ReadLine();

            Console.WriteLine(VehiculoCollection.Update(id, marca, modelo));
        }


        public static void CargarDialogoDelete()
        {
            Console.Clear();
            Console.WriteLine("ELIMINAR VEHÍCULO");
            Console.WriteLine("***********************************\n");

            Console.WriteLine("Ingrese el id del vehículo a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(VehiculoCollection.Delete(id));
        }

        public static void CargarDialogoReadAll()
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE VEHÍCULOS");
            Console.WriteLine("***********************************\n");

            var res = VehiculoCollection.ReadAll();

            if (res.Count == 0) Console.WriteLine("No existen registros :c");
            else
            {
                res.ForEach(x =>
                {
                    Console.WriteLine(x.InfoVehiculo() + "\n");
                });
            }
        }

        public static void CargarDialogoSearch()
        {
            Console.Clear();
            Console.WriteLine("Búsqueda avanzada");
            Console.WriteLine("***********************************\n");

            Console.WriteLine("Ingrese el parámetro de búsqueda");
            string? filtro = Console.ReadLine();

            var res = VehiculoCollection.Search(filtro);

            if (res.Count == 0) Console.WriteLine("No existen registros =(");
            else
            {
                Console.WriteLine("Coincidencias encontradas: " + res.Count);
                res.ForEach(x =>
                {
                    Console.WriteLine(x.InfoVehiculo() + "\n");
                });
            }
        }
    }
}