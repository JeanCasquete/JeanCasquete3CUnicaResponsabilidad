using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilidadUnicaEmpleados
{
	class MiPerfil
	{
		int numero;
		string UbicacionUsuario;

		public void Mi_perfil()
		{

			do
			{
				Console.Clear();
				Console.WriteLine("   MI PERFIL \n" +
				"Bienvedio a tu perfil: \n" +
				"Aquí puedes configurar toda la información a cerca de tu cuenta: \n" +
				"  1. si quieres editar tu perfil \n" +
				"  2. si quieres subir una foto \n" +
				"  3. si quieres quieres preguntar o reportar algo \n" +
				"  4. si deseas ver tu información personal \n" +
				"  5. Regresar");
				numero = int.Parse(Console.ReadLine());
				Console.Clear();
				switch (numero)
				{
					case 1:
						Console.WriteLine("Edita tu Perfil: \n" +
						"  - Cambiar foto de perfil \n" +
						"  - Cambiar contraseña \n" +
						"  - Editar infromación personal");
						Console.ReadKey();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine(" Agregar más fotos \n" +
						"        [+]");
						Console.ReadKey();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine(" Escribe aqui si quieres preguntar o reportar algo: ");
						UbicacionUsuario = Console.ReadLine();
						Console.WriteLine(" Hemos enviado tu mensaje con éxito!");
						Console.ReadKey();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("INFORMACIÓN PERSONAL \n" +
						"  **edad \n" +
						"  **nombres \n" +
						"  **apellidos \n" +
						"  **ciudad \n" +
						"  **nacionalidad");
						Console.ReadKey();
						break;
					case 5:
						break;
					default:
						Console.WriteLine(" Ingrese una opción válida!. Presiona una tecla para volver a Intentarlo.");
						break;
				}
				Console.ReadKey();
			} while (numero != 5);
		}
	}
}












            }      
        }
    }
}
