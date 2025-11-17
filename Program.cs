using System;

namespace BarrioShopManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string usuarioDefecto = "administrador";
            const string claveDefecto = "123";

            while (true) 
            {
            Console.WriteLine("---- AUTENTICACIÓN ----");
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string clave = Console.ReadLine();

                if (usuario == usuarioDefecto && clave == claveDefecto)
                {
                    Console.WriteLine("¡Bienvenido al sistema!");
                    break;  
                }
                else
                {
                    Console.WriteLine("Error de autenticación. Intente de nuevo.");
                }
            }
            Console.WriteLine("------------------MENÚ------------------");
            Console.WriteLine("1. Gestión de Usuarios          2. Gestión de artículos");
            Console.WriteLine("3. Gestión de ventas            4. Salir del programa");
            Console.WriteLine("----------------------------------------");

            while (true)
            {
                int opcion = LeerEntero("Seleccione una opción del menú: ");

            switch (opcion)
                {
                case 1:
                    GestionUsuarios();
                    break;

                case 2:
                    GestionArticulos();
                    break;

                case 3:
                    GestionVentas();
                    break;

                case 4:
                    Console.WriteLine("Se ha cerrado sesión en el programa.");
                    return;

                default:
                    Console.WriteLine("Ingrese una opción del menú válida");
                    continue;
                }                            
                break;
            }
        }
        static void GestionUsuarios()
        {
            Console.WriteLine("Le damos la bienvenida al módulo Gestión de usuarios");

            Console.Write("Ingrese el nombre completo del Usuario 1: ");
            string name1 = Console.ReadLine();
            Console.Write("Ingrese el número de cédula del Usuario 1: ");
            string id1 = Console.ReadLine();

            Console.Write("Ingrese el nombre completo del Usuario 2: ");
            string name2 = Console.ReadLine();
            Console.Write("Ingrese el número de cédula del Usuario 2: ");
            string id2 = Console.ReadLine();

            Console.Write("Ingrese el nombre completo del Usuario 3: ");
            string name3 = Console.ReadLine();
            Console.Write("Ingrese el número de cédula del Usuario 3: ");
            string id3 = Console.ReadLine();

            Console.Write("Ingrese el nombre completo del Usuario 4: ");
            string name4 = Console.ReadLine();
            Console.Write("Ingrese el número de cédula del Usuario 4: ");
            string id4 = Console.ReadLine();

            Console.Write("Ingrese el nombre completo del Usuario 5: ");
            string name5 = Console.ReadLine();
            Console.Write("Ingrese el número de cédula del Usuario 5: ");
            string id5 = Console.ReadLine();
                        
            Console.WriteLine("----------------------------MÓDULO GESTIÓN DE USUARIOS---------------------------");
            Console.WriteLine("1. Ver lista de usuarios                               2. Nuevo usuario");
            Console.WriteLine("3. Editar información de usuario (buscar por c.c)      4. Salir de Gestión de usuarios");
            Console.WriteLine("---------------------------------------------------------------------------------");

            while (true)
            {
                int subopcion = LeerEntero("Seleccione una opción del menú: ");

            string VerLista()
            {
            Console.WriteLine(
           "Lista de usuarios: " +
           $"{id1} {name1}, {id2} {name2}, {id3} {name3}, {id4} {name4}, {id5} {name5}");

                    Console.WriteLine("SELECCIONE UN USUARIO");
                    while (true)
                    {
                        int opcionUsuario = LeerEntero("Ingrese una opción (1-5): ");

                        string resultadoUsuario =
                            (opcionUsuario == 1) ? $"Usuario 1: {id1} {name1}" :
                            (opcionUsuario == 2) ? $"Usuario 2: {id2} {name2}" :
                            (opcionUsuario == 3) ? $"Usuario 3: {id3} {name3}" :
                            (opcionUsuario == 4) ? $"Usuario 4: {id4} {name4}" :
                            (opcionUsuario == 5) ? $"Usuario 5: {id5} {name5}" :
                                                   "Opción inválida";
                                                
                        if (resultadoUsuario == "Opción inválida")
                        {
                            Console.WriteLine("Ingrese una opción del menú válida.");
                            continue;  
                        }
                                             
                        return resultadoUsuario;
                    }
            }
                string NuevoUsuario()
                {
                    Console.WriteLine("-------------MÓDULO NUEVO USUARIO-------------");
                    Console.WriteLine("1. Crear Usuario              2. Salir");                    
                    Console.WriteLine("----------------------------------------------");

                while (true)
                {
                    int opcionNuevo = LeerEntero("Seleccione una opción del menú: ");

                    switch (opcionNuevo)
                    {
                        case 1:
                            Console.Write("Ingrese el nombre del nuevo usuario: ");
                            string name6 = Console.ReadLine();
                            Console.Write("Ingrese el número de cédula del nuevo usuario: ");
                            string id6 = Console.ReadLine();
                            return "Nuevo usuario registrado: " + id6 + " " + name6;

                        case 2:
                            return "Se ha salido del módulo de nuevo usuario.";

                        default:
                            Console.WriteLine("Ingrese una opción del menú válida");
                            continue;
                    }
                }

                }                                                                                 
                                                                  
                string BuscarUsuario()
            {
                Console.Write("Ingrese el número de cédula a buscar: ");
                string cedula = Console.ReadLine();

                return
                    (cedula == id1) ? "Usuario encontrado: " + id1 + " " + name1 :
                    (cedula == id2) ? "Usuario encontrado: " + id2 + " " + name2 :
                    (cedula == id3) ? "Usuario encontrado: " + id3 + " " + name3 :
                    (cedula == id4) ? "Usuario encontrado: " + id4 + " " + name4 :
                    (cedula == id5) ? "Usuario encontrado: " + id5 + " " + name5 :
                    "Usuario no encontrado.";
            }

            string resultado =
                (subopcion == 1) ? VerLista() :
                (subopcion == 2) ? NuevoUsuario() :
                (subopcion == 3) ? BuscarUsuario() :
                (subopcion == 4) ? "Regresando al Menú principal..." :
                                   "Opción inválida";

            Console.WriteLine(resultado);

                if (resultado == "Opción inválida")
                {
                    Console.WriteLine("Intente de nuevo.");
                    continue;   
                }
                break;
            }
        }
        static void GestionArticulos()
        {
            Console.WriteLine("Le damos la bienvenida al módulo Gestión de artículos.");

            string articulo1 = LeerTexto("Ingrese el artículo 1: ");
            string valor1 = LeerTexto("Ingrese el valor 1: ");
            string articulo2 = LeerTexto("Ingrese el artículo 2: ");
            string valor2 = LeerTexto("Ingrese el valor 2: ");
            string articulo3 = LeerTexto("Ingrese el artículo 3: ");
            string valor3 = LeerTexto("Ingrese el valor 3: ");
            string articulo4 = LeerTexto("Ingrese el artículo 4: ");
            string valor4 = LeerTexto("Ingrese el valor 4: ");
            string articulo5 = LeerTexto("Ingrese el artículo 5: ");
            string valor5 = LeerTexto("Ingrese el valor 5: ");

            Console.WriteLine("---------- MENÚ ARTÍCULOS ----------");
            Console.WriteLine("1. Ver lista de artículos");
            Console.WriteLine("2. Nuevo artículo");
            Console.WriteLine("3. Editar información del artículo");
            Console.WriteLine("4. Salir de la gestión");
            int opcion = LeerEntero("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"{articulo1} - {valor1}");
                    Console.WriteLine($"{articulo2} - {valor2}");
                    Console.WriteLine($"{articulo3} - {valor3}");
                    Console.WriteLine($"{articulo4} - {valor4}");
                    Console.WriteLine($"{articulo5} - {valor5}");
                    break;

                case 2:
                    string articulo6 = LeerTexto("Ingrese el nuevo artículo: ");
                    string valor6 = LeerTexto("Ingrese el valor del nuevo artículo: ");
                    Console.WriteLine($"Artículo agregado: {articulo6} - {valor6}");
                    break;

                case 3:
                    Console.WriteLine("EDITAR INFORMACIÓN DEL ARTÍCULO");
                    Console.WriteLine($"1) {articulo1} - {valor1}");
                    Console.WriteLine($"2) {articulo2} - {valor2}");
                    Console.WriteLine($"3) {articulo3} - {valor3}");
                    Console.WriteLine($"4) {articulo4} - {valor4}");
                    Console.WriteLine($"5) {articulo5} - {valor5}");

                    int nro = LeerEntero("Indique el N° de artículo a editar (1-5): ");
                    int que = LeerEntero("¿Qué desea editar? 1=Nombre  2=Valor  3=Ambos: ");

                    string PedirNombre() => LeerTexto("Nuevo nombre: ");
                    string PedirValor() => LeerTexto("Nuevo valor: ");

                    if (nro == 1)
                    {
                        if (que == 1 || que == 3) articulo1 = PedirNombre();
                        if (que == 2 || que == 3) valor1 = PedirValor();
                        Console.WriteLine("Artículo 1 actualizado.");
                    }
                    else if (nro == 2)
                    {
                        if (que == 1 || que == 3) articulo2 = PedirNombre();
                        if (que == 2 || que == 3) valor2 = PedirValor();
                        Console.WriteLine("Artículo 2 actualizado.");
                    }
                    else if (nro == 3)
                    {
                        if (que == 1 || que == 3) articulo3 = PedirNombre();
                        if (que == 2 || que == 3) valor3 = PedirValor();
                        Console.WriteLine("Artículo 3 actualizado.");
                    }
                    else if (nro == 4)
                    {
                        if (que == 1 || que == 3) articulo4 = PedirNombre();
                        if (que == 2 || que == 3) valor4 = PedirValor();
                        Console.WriteLine("Artículo 4 actualizado.");
                    }
                    else if (nro == 5)
                    {
                        if (que == 1 || que == 3) articulo5 = PedirNombre();
                        if (que == 2 || que == 3) valor5 = PedirValor();
                        Console.WriteLine("Artículo 5 actualizado.");
                    }
                    else
                    {
                        Console.WriteLine("Número de artículo inválido.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo de la Gestión de Artículos.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void GestionVentas()
        {
            Console.WriteLine("Le damos la bienvenida al módulo Gestión de ventas.");

            string nombreArticulo = LeerTexto("Ingrese el nombre del artículo: ");
            int cantidadUnidades = LeerEntero("Ingrese la cantidad de unidades en inventario: ");

            Console.WriteLine("---------- MENÚ VENTAS ----------");
            Console.WriteLine("1. Registrar venta");
            Console.WriteLine("2. Salir de Gestión de venta");
            int opcionVenta = LeerEntero("Seleccione una opción: ");

            switch (opcionVenta)
            {
                case 1:
                    Console.WriteLine("Artículo para la venta: " + nombreArticulo);
                    int cantidadComprar = LeerEntero("Ingrese la cantidad de unidades a comprar: ");

                    if (cantidadComprar <= cantidadUnidades)
                        Console.WriteLine("Usted puede comprar el artículo.");
                    else
                        Console.WriteLine("No hay cantidad suficiente del artículo.");
                    break;

                case 2:
                    Console.WriteLine("Saliendo de la Gestión de Ventas. Volviendo al Menú Principal.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static int LeerEntero(string prompt)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            if (!int.TryParse(s, out int n))
            {
                Console.WriteLine("Entrada inválida. Se usará 0.");
                n = 0;
            }
            return n;
        }

        static string LeerTexto(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? "";
        }


    }
}




