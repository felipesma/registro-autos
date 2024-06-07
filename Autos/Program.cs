// See https://aka.ms/new-console-template for more information

using Autos.Dialogos;

void AppConcesionario()
{
    try
    {
        while (true)
        {
            Presentacion();
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    DialogosConsola.CargarDialogoCreate();
                    Reiniciar();
                    break;

                case 2:
                    DialogosConsola.CargarDialogoRead();
                    Reiniciar();
                    break;

                case 3:
                    DialogosConsola.CargarDialogoUpdate();
                    Reiniciar();
                    break;

                case 4:
                    DialogosConsola.CargarDialogoDelete();
                    Reiniciar();
                    break;

                case 5:
                    DialogosConsola.CargarDialogoReadAll();
                    Reiniciar();
                    break;

                case 6:
                    DialogosConsola.CargarDialogoSearch();
                    Reiniciar();
                    break;

                case 0:
                    Despedida();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opción inválida");
                    Reiniciar();
                    break;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Opción inválida");
        Reiniciar();
    }
}

void Presentacion()
{
    Console.WriteLine("BIENVENIDO!!!");
    Console.WriteLine("Elige una de las siguientes opciones para empezar:");
    Console.WriteLine("1. Agregar nuevo vehículo");
    Console.WriteLine("2. Buscar vehículo por id");
    Console.WriteLine("3. Actualizar vehículo");
    Console.WriteLine("4. Eliminar vehículo");
    Console.WriteLine("5. Listar todos los registros");
    Console.WriteLine("6. Búsqueda personalizada");
    Console.WriteLine("0. Salir\n");

    Console.WriteLine("Ingrese opción:");
}

void Reiniciar()
{
    Console.WriteLine("Presione una tecla para volver al menú");
    Console.ReadLine();
    Console.Clear();
    AppConcesionario();
}

void Despedida()
{
    Console.Clear();
    Console.WriteLine("HASTA PRONTO!!");
    Console.WriteLine("Presiona cualquier tecla para salir");
    Console.ReadLine();
    Environment.Exit(1);
}

AppConcesionario();