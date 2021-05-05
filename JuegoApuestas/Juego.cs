/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 2 may. 2021
 * Hora: 04:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace JuegoApuestas
{
	/// <summary>
	/// Description of Juego.
	/// </summary>
	public class Juego
	{
		private String nombre;
		private Jugador jugador1;
		private Jugador jugador2;
		private Casino oCasino;
		
		
		private void muestraJugadores(Jugador jugador1, Jugador jugador2){
			Console.Clear();
//			Console.BackgroundColor = ConsoleColor.DarkGray;
//			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("JUGADOR 1");
			Console.ResetColor();
			Console.WriteLine(" {0}", jugador1.getNombre());
			Console.WriteLine("SALDO: {0}", jugador1.getSaldo());
			Console.SetCursorPosition(43, 0);
			Console.Write("CASINO");
			Console.SetCursorPosition(40, 1);
			Console.Write("POZO: {0}", oCasino.getPozo());
			Console.SetCursorPosition(80, 0);
			Console.Write("JUGADOR 2: {0}", jugador2.getNombre());
			Console.SetCursorPosition(80, 1);
			Console.Write("SALDO: {0}", jugador2.getSaldo());
		}
		
		private static void solicitaNombreJugador(int numeroJugador, ref Jugador jugador, ref String nombre){
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 3);
			Console.WriteLine("                             ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 2);
			Console.WriteLine("          JUGADOR {0}          ", numeroJugador);
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) - 1);
			Console.WriteLine("                             ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2));
			Console.WriteLine("                             ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 1);
			Console.WriteLine("                             ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 2);
			Console.Write("      INGRESE EL NOMBRE      ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 3);
			Console.WriteLine("                             ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2));
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.WriteLine("                         ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 10, (Console.WindowHeight / 2) + 1);
			
			Console.SetCursorPosition((Console.WindowWidth / 2) - 8, (Console.WindowHeight / 2));
			Console.CursorVisible = true;
			Console.ForegroundColor = ConsoleColor.Black;
			nombre = Console.ReadLine();
			Console.ResetColor();
		}
		
		
		
		public Juego(ref GUI interfazGrafica)
		{
			int resultado;
			
			Console.Clear();
			solicitaNombreJugador(1, ref jugador1, ref nombre);
			
			Console.CursorVisible = true;
			
			jugador1 = new Jugador(nombre);
			solicitaNombreJugador(2, ref jugador2, ref nombre);
			jugador2 = new Jugador(nombre);
			oCasino =  new Casino(jugador1, jugador2);
			do {
				//muestraJugadores(jugador1, jugador2);
				interfazGrafica.refrescaDatosPantalla(jugador1, jugador2, oCasino);
				interfazGrafica.solicitaApuestas(jugador1, jugador2, 6, 6, 70, 6);
				//Console.ReadKey(true);
				interfazGrafica.refrescaDatosPantalla(jugador1, jugador2, oCasino);
				resultado = oCasino.arrojaDados();
				if (resultado == jugador1.getNumeroApostado()) {
					//Console.WriteLine("El jugador {0} ha ganado!", jugador1.getNombre());
					Console.SetCursorPosition(3, 25);
					Console.WriteLine("¡¡¡ YOU WIN !!!");
					oCasino.pagaApuesta(jugador1, jugador1.getTipoApuesta());
				} else {
					//Console.WriteLine("El jugador {0} ha perdido!", jugador1.getNombre());
					Console.SetCursorPosition(3, 25);
					oCasino.cobraApuesta(jugador1, jugador1.getTipoApuesta());
					Console.WriteLine("¡¡¡ YOU LOSE !!!");
				}
				if (resultado == jugador2.getNumeroApostado()) {
					//Console.WriteLine("El jugador {0} ha ganado!", jugador2.getNombre());
					Console.SetCursorPosition(80, 25);
					Console.WriteLine("¡¡¡ YOU WIN !!!");
					oCasino.pagaApuesta(jugador2, 3);
				} else {
					//Console.WriteLine("El jugador {0} ha perdido!", jugador2.getNombre());
					Console.SetCursorPosition(80, 25);
					Console.WriteLine("¡¡¡ YOU LOSE !!!");
				}
				Console.ReadKey();
			} while (jugador1.getSaldo() >= 0 && jugador2.getSaldo() >= 0 && oCasino.getPozo() >= 0);
		}
	}
}
