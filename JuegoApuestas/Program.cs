/*
 * Creado por SharpDevelop.
 * Alumnos: Montenegro, Mauro Javier.
		    Pascuet, José Elías.
		    Rodriguez, Gustavo Joaquín.
      		Rojas, Silvio.
       		Verza, Esteban.
 * Fecha: 1 may. 2021
 * Hora: 21:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Threading;

namespace JuegoApuestas
{
	class Program
	{
		public static void Main(string[] args)
		{
			GUI interfazGrafica = new GUI();
			Console.CursorVisible = false;
			interfazGrafica.Intro();
			Thread.Sleep(2000);
			
			Juego nuevoJuego;
			
			nuevoJuego = new Juego(ref interfazGrafica);
			
			Console.SetCursorPosition(0, 29);
			Console.Write("G A M E    O V E R");
			Console.ReadKey(true);
		}
	}
}