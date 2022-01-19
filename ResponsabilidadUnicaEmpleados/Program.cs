using System;

namespace ResponsabilidadUnicaEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aquí se declaran todas las variables que se usarán en esta clase
            int variable;
            int numero;
            Registro registro = new Registro();
            //Mensaje de bienvenida y menú de interacción principal
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDO A RENTACAR : \n" +
                "  1. Registrarse \n" +
                "  2. Iniciar Sesión \n" +
                "  3. Cerrar Aplicación \n" +
                "Ingresa 1 para registrarte, o 2 para logearte directamente");
                variable = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (variable)
                {
                    case 1:
                        Console.Clear();
                        //Registro
                        registro.registrar();
                        registro.Edad();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        //inicio de sesión
                        Inicio_de_Sesion inicio_de_sesion = new Inicio_de_Sesion();
                        inicio_de_sesion.Login();
                        Console.ReadKey();
                        //Segundo menú de interacción principal
                        do
                        {
                            Console.Clear();
                            Mensaje_Bienvenida mensaje_bienvenida = new Mensaje_Bienvenida();
                            mensaje_bienvenida.Bienvenida();
                            numero = int.Parse(Console.ReadLine());
                            Console.Clear();
                            switch (numero)
                            {
                                case 1:
                                    Console.Clear();
                                    //Busqueda de auto
                                    BusquedaAuto busquedaAuto = new BusquedaAuto();
                                    busquedaAuto.Busqueda_Auto();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    //Autos registrados
                                    Console.WriteLine(" **Autos Registrados** \n" +
                                    "Aquí puedes ver los autos que ya han sido registrados en RentaCar \n");
                                    //Primer auto registrado
                                    AutosRegistrados autos = new AutosRegistrados();
                                    autos.PrimerAuto();
                                    Console.WriteLine("");
                                    //Segundo auto registrado
                                    autos.SegundoAuto();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    //Mi Perfil
                                    MiPerfil perfil = new MiPerfil();
                                    perfil.Mi_perfil();
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.Clear();
                                    //Más opciones
                                    MasOpciones masopciones = new MasOpciones();
                                    masopciones.Mas_opciones();
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("\n" +
                                    "Se ha cerrado tu sesión");
                                    Console.ReadKey();
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese una opción válida!. Presiona una tecla para volver a Intentarlo.");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (numero != 5);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n" +
                        "Hasta Pronto");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("¡ Ingrese una opción correcta ! .. presiona una tecla para continuar");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            } while (variable != 3);
        }
    }
}
