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
            while (true)
            {
                Console.WriteLine("------------------MENÚ------------------");
                Console.WriteLine("1. Gestión de Usuarios          2. Gestión de artículos");
                Console.WriteLine("3. Gestión de ventas            4. Salir del programa");
                Console.WriteLine("----------------------------------------");

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
                        break;
                }
                                
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

                void NuevoUsuario()
                {                    
                    while (true)
                    {
                        Console.WriteLine("-------------MÓDULO NUEVO USUARIO-------------");
                        Console.WriteLine("1. Crear Usuario              2. Salir");
                        Console.WriteLine("----------------------------------------------");

                        int opcionNuevo = LeerEntero("Seleccione una opción del menú: ");

                        switch (opcionNuevo)
                        {
                            case 1:
                                Console.Write("Ingrese el nombre del nuevo usuario: ");
                                string name6 = Console.ReadLine();
                                Console.Write("Ingrese el número de cédula del nuevo usuario: ");
                                string id6 = Console.ReadLine();
                                Console.WriteLine("Nuevo usuario registrado:" + id6 + " " + name6);
                                Console.WriteLine();
                                break;

                            case 2:
                                return;

                            default:
                                Console.WriteLine("Ingrese una opción del menú válida");
                                break;
                        }
                    }
                }

                string EditarUsuario()
                {
                    Console.WriteLine("Lista de usuarios:");
                    Console.WriteLine($"1. {id1} - {name1}");
                    Console.WriteLine($"2. {id2} - {name2}");
                    Console.WriteLine($"3. {id3} - {name3}");
                    Console.WriteLine($"4. {id4} - {name4}");
                    Console.WriteLine($"5. {id5} - {name5}");

                    while (true)
                    {
                        int opcionUsuario = LeerEntero("Ingrese una opción (1-5): ");
                                                
                        if (opcionUsuario < 1 || opcionUsuario > 5)
                        {
                            Console.WriteLine("Ingrese una opción del menú válida.");
                            continue;
                        }

                        Console.Write("Ingrese el nuevo nombre para este usuario: ");
                        string nuevoNombre = Console.ReadLine();
                                            
                        if (opcionUsuario == 1) name1 = nuevoNombre;
                        else if (opcionUsuario == 2) name2 = nuevoNombre;
                        else if (opcionUsuario == 3) name3 = nuevoNombre;
                        else if (opcionUsuario == 4) name4 = nuevoNombre;
                        else if (opcionUsuario == 5) name5 = nuevoNombre;

                        return "Nombre de usuario actualizado.";
                    }
                }

                if (subopcion == 2)
                {
                    NuevoUsuario();
                    
                    Console.WriteLine("----------------------------MÓDULO GESTIÓN DE USUARIOS---------------------------");
                    Console.WriteLine("1. Ver lista de usuarios                               2. Nuevo usuario");
                    Console.WriteLine("3. Editar información de usuario (buscar por c.c)      4. Salir de Gestión de usuarios");
                    Console.WriteLine("---------------------------------------------------------------------------------");
                    continue;
                }
                                
                string resultado =
                    (subopcion == 1) ? VerLista() :
                    (subopcion == 3) ? EditarUsuario() :
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
                        
            string articulo1 = LeerTexto("Ingrese el nombre del artículo 1: ");
            string valor1 = LeerTexto("Ingrese el valor unitario del artículo 1: ");
            string articulo2 = LeerTexto("Ingrese el nombre del artículo 2: ");
            string valor2 = LeerTexto("Ingrese el valor unitario del artículo 2: ");
            string articulo3 = LeerTexto("Ingrese el nombre del artículo 3: ");
            string valor3 = LeerTexto("Ingrese el valor unitario del artículo 3: ");
            string articulo4 = LeerTexto("Ingrese el nombre del artículo 4: ");
            string valor4 = LeerTexto("Ingrese el valor unitario del artículo 4: ");
            string articulo5 = LeerTexto("Ingrese el nombre del artículo 5: ");
            string valor5 = LeerTexto("Ingrese el valor unitario del artículo 5: ");
            
            string articulo6 = "";
            string valor6 = "";

            while (true)
            {
                Console.WriteLine("---------- MENÚ ARTÍCULOS ----------");
                Console.WriteLine("1. Ver lista de artículos");
                Console.WriteLine("2. Nuevo artículo");
                Console.WriteLine("3. Editar información del artículo");
                Console.WriteLine("4. Salir de Gestión de Artículos");
                Console.WriteLine("------------------------------------");

                int opcion = LeerEntero("Seleccione una opción (1-4): ");

                if (opcion < 1 || opcion > 4)
                {
                    Console.WriteLine("Ingrese una opción del menú válida");
                    continue; 
                }

                if (opcion == 1)
                {
                    VerListaArticulos();
                }
                else if (opcion == 2)
                {
                    NuevoArticulo();
                }
                else if (opcion == 3)
                {
                    EditarArticulo();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo de la Gestión de Artículos. Volviendo al Menú Principal.");
                    return; 
                }
            }

            void VerListaArticulos()
            {
                Console.WriteLine("Lista de artículos:");
                Console.WriteLine($"1. {articulo1}");
                Console.WriteLine($"2. {articulo2}");
                Console.WriteLine($"3. {articulo3}");
                Console.WriteLine($"4. {articulo4}");
                Console.WriteLine($"5. {articulo5}");

                while (true)
                {
                    int op = LeerEntero("Ingrese una opción (1-5): ");

                    if (op < 1 || op > 5)
                    {
                        Console.WriteLine("Ingrese una opción del menú válida");
                        continue;
                    }

                    if (op == 1)
                        Console.WriteLine($"Artículo 1: {articulo1} - {valor1}");
                    else if (op == 2)
                        Console.WriteLine($"Artículo 2: {articulo2} - {valor2}");
                    else if (op == 3)
                        Console.WriteLine($"Artículo 3: {articulo3} - {valor3}");
                    else if (op == 4)
                        Console.WriteLine($"Artículo 4: {articulo4} - {valor4}");
                    else if (op == 5)
                        Console.WriteLine($"Artículo 5: {articulo5} - {valor5}");

                    break; 
                }
            }

            void NuevoArticulo()
            {
                while (true)
                {
                    Console.WriteLine("---------- MÓDULO NUEVO ARTÍCULO ----------");
                    Console.WriteLine("1. Crear Artículo");
                    Console.WriteLine("2. Salir");
                    Console.WriteLine("-------------------------------------------");

                    int opcionNuevo = LeerEntero("Seleccione una opción (1-2): ");

                    if (opcionNuevo < 1 || opcionNuevo > 2)
                    {
                        Console.WriteLine("Ingrese una opción del menú válida");
                        continue;
                    }

                    if (opcionNuevo == 1)
                    {
                        articulo6 = LeerTexto("Ingrese el nombre del artículo 6: ");
                        valor6 = LeerTexto("Ingrese el valor unitario del artículo 6: ");
                        Console.WriteLine($"Artículo 6 registrado: {articulo6} - {valor6}");
                    }
                    else if (opcionNuevo == 2)
                    {                        
                        return;
                    }
                }
            }

            void EditarArticulo()
            {
                Console.WriteLine("Lista de artículos para editar precio:");
                Console.WriteLine($"1. {articulo1}");
                Console.WriteLine($"2. {articulo2}");
                Console.WriteLine($"3. {articulo3}");
                Console.WriteLine($"4. {articulo4}");
                Console.WriteLine($"5. {articulo5}");

                int opArticulo;

                while (true)
                {
                    opArticulo = LeerEntero("Ingrese una opción (1-5): ");

                    if (opArticulo < 1 || opArticulo > 5)
                    {
                        Console.WriteLine("Ingrese una opción del menú válida");
                        continue;
                    }

                    break;
                }

                string nuevoPrecio = LeerTexto("Ingrese el nuevo precio para este artículo: ");

                if (opArticulo == 1)
                    valor1 = nuevoPrecio;
                else if (opArticulo == 2)
                    valor2 = nuevoPrecio;
                else if (opArticulo == 3)
                    valor3 = nuevoPrecio;
                else if (opArticulo == 4)
                    valor4 = nuevoPrecio;
                else if (opArticulo == 5)
                    valor5 = nuevoPrecio;

                Console.WriteLine("Precio del artículo actualizado.");
            }
        }
        static void GestionVentas()
        {
            Console.WriteLine("Le damos la bienvenida al módulo Gestión de ventas.");
                       
            string articulo1 = LeerTexto("Ingrese el nombre del artículo 1: ");
            int cantidad1 = LeerEntero("Ingrese la cantidad de unidades del artículo 1: ");
            string articulo2 = LeerTexto("Ingrese el nombre del artículo 2: ");
            int cantidad2 = LeerEntero("Ingrese la cantidad de unidades del artículo 2: ");
            string articulo3 = LeerTexto("Ingrese el nombre del artículo 3: ");
            int cantidad3 = LeerEntero("Ingrese la cantidad de unidades del artículo 3: ");
            string articulo4 = LeerTexto("Ingrese el nombre del artículo 4: ");
            int cantidad4 = LeerEntero("Ingrese la cantidad de unidades del artículo 4: ");
            string articulo5 = LeerTexto("Ingrese el nombre del artículo 5: ");
            int cantidad5 = LeerEntero("Ingrese la cantidad de unidades del artículo 5: ");

            while (true)
            {
                Console.WriteLine("---------- MENÚ VENTAS ----------");
                Console.WriteLine("1. Registrar venta");
                Console.WriteLine("2. Salir de Gestión de venta");
                Console.WriteLine("---------------------------------");

                int opcionVenta = LeerEntero("Seleccione una opción (1-2): ");

                if (opcionVenta < 1 || opcionVenta > 2)
                {
                    Console.WriteLine("Ingrese una opción del menú válida");
                    continue; 
                }

                if (opcionVenta == 2)
                {
                    Console.WriteLine("Saliendo de la Gestión de Ventas. Volviendo al Menú Principal.");
                    return; 
                }

                int productosSeleccionados = 0;

                while (productosSeleccionados < 5)
                {
                    Console.WriteLine("Lista de artículos:");
                    Console.WriteLine($"1. {articulo1}");
                    Console.WriteLine($"2. {articulo2}");
                    Console.WriteLine($"3. {articulo3}");
                    Console.WriteLine($"4. {articulo4}");
                    Console.WriteLine($"5. {articulo5}");

                    int opcionArticulo;

                    while (true)
                    {
                        opcionArticulo = LeerEntero("Seleccione un artículo (1-5): ");

                        if (opcionArticulo < 1 || opcionArticulo > 5)
                        {
                            Console.WriteLine("Ingrese una opción del menú válida");
                            continue;
                        }

                        break;
                    }

                    int cantidadComprar = LeerEntero("Ingrese la cantidad de unidades a comprar: ");

                    int stockDisponible = 0;
                    string nombreSeleccionado = "";

                    if (opcionArticulo == 1)
                    {
                        stockDisponible = cantidad1;
                        nombreSeleccionado = articulo1;
                    }
                    else if (opcionArticulo == 2)
                    {
                        stockDisponible = cantidad2;
                        nombreSeleccionado = articulo2;
                    }
                    else if (opcionArticulo == 3)
                    {
                        stockDisponible = cantidad3;
                        nombreSeleccionado = articulo3;
                    }
                    else if (opcionArticulo == 4)
                    {
                        stockDisponible = cantidad4;
                        nombreSeleccionado = articulo4;
                    }
                    else if (opcionArticulo == 5)
                    {
                        stockDisponible = cantidad5;
                        nombreSeleccionado = articulo5;
                    }

                    if (cantidadComprar <= stockDisponible)
                    {
                        Console.WriteLine($"Venta registrada: {nombreSeleccionado} - Cantidad: {cantidadComprar}");

                        if (opcionArticulo == 1) cantidad1 -= cantidadComprar;
                        else if (opcionArticulo == 2) cantidad2 -= cantidadComprar;
                        else if (opcionArticulo == 3) cantidad3 -= cantidadComprar;
                        else if (opcionArticulo == 4) cantidad4 -= cantidadComprar;
                        else if (opcionArticulo == 5) cantidad5 -= cantidadComprar;
                    }
                    else
                    {
                        Console.WriteLine("No hay cantidad suficiente del artículo.");
                    }

                    productosSeleccionados++;

                    if (productosSeleccionados >= 5)
                    {
                        Console.WriteLine("Ya ha ingresado el máximo de 5 productos para esta venta.");
                        Console.WriteLine("Finalizando registro de venta. Volviendo al Menú Principal.");
                        return;
                    }

                    int opcionNuevo;

                    while (true)
                    {
                        Console.WriteLine("¿Desea ingresar un nuevo producto? 1=Sí  2=No");
                        opcionNuevo = LeerEntero("Seleccione una opción (1-2): ");

                        if (opcionNuevo < 1 || opcionNuevo > 2)
                        {
                            Console.WriteLine("Ingrese una opción del menú válida");
                            continue;
                        }

                        break;
                    }

                    if (opcionNuevo == 2)
                    {
                        Console.WriteLine("Finalizando registro de venta. Volviendo al Menú Principal.");
                        return; 
                    }

                }
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
