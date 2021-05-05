/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 27 abr. 2021
 * Hora: 19:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel.Design;
using System.Threading;

namespace JuegoApuestas
{
	/// <summary>
	/// Description of Dado.
	/// </summary>
	public class Dado
	{
		private Random numero;
		private int resultado;
		
		public Dado(int desplazamientoX, int desplazamientoY) {
		
			numero = new Random();
			int temporizador = 2;
		
			for (int i = 0 ; i < 10; i++) {
				Console.CursorVisible = false;
				Console.SetCursorPosition(0, 4);
				temporizador *= 2;
				Thread.Sleep(temporizador);
				resultado = numero.Next(1, 7);
				switch (resultado) {
					case 1: 
						 muestraUno(desplazamientoX, desplazamientoY);
						break;
					case 2: 
						 muestraDos(desplazamientoX, desplazamientoY);
						break;
					case 3: 
						 muestraTres(desplazamientoX, desplazamientoY);
						break;
					case 4: 
						 muestraCuatro(desplazamientoX, desplazamientoY);
						break;
					case 5: 
						 muestraCinco(desplazamientoX, desplazamientoY);
						break;
					case 6: 
						 muestraSeis(desplazamientoX, desplazamientoY);
						break;
				}
				
			}
			Console.CursorVisible = true;
			
		}
		
		public int getNumero() {
			return resultado;
		}
		
		private void muestraUno(int x, int y) {
			Console.SetCursorPosition(x, y);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 1);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 2);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 3);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 4);
			Console.WriteLine("████████   ████████");
			Console.SetCursorPosition(x, y + 5);
			Console.WriteLine("████████   ████████");
			Console.SetCursorPosition(x, y + 6);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 7);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 8);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 9);
			Console.WriteLine("███████████████████");
		}		
		
		private void muestraDos(int x, int y) {
			Console.SetCursorPosition(x, y);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 1);
			Console.WriteLine("███   █████████████");
			Console.SetCursorPosition(x, y + 2);
			Console.WriteLine("███   █████████████");
			Console.SetCursorPosition(x, y + 3);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 4);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 5);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 6);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 7);
			Console.WriteLine("█████████████   ███");
			Console.SetCursorPosition(x, y + 8);
			Console.WriteLine("█████████████   ███");
			Console.SetCursorPosition(x, y + 9);
			Console.WriteLine("███████████████████");
			
		}
		
		private void muestraTres(int x, int y) {
			Console.SetCursorPosition(x, y);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 1);
			Console.WriteLine("███   █████████████");
			Console.SetCursorPosition(x, y + 2);
			Console.WriteLine("███   █████████████");
			Console.SetCursorPosition(x, y + 3);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 4);
			Console.WriteLine("████████   ████████");
			Console.SetCursorPosition(x, y + 5);
			Console.WriteLine("████████   ████████");
			Console.SetCursorPosition(x, y + 6);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 7);
			Console.WriteLine("█████████████   ███");
			Console.SetCursorPosition(x, y + 8);
			Console.WriteLine("█████████████   ███");
			Console.SetCursorPosition(x, y + 9);
			Console.WriteLine("███████████████████");
		}
		
		private void muestraCuatro(int x, int y) {
			Console.SetCursorPosition(x, y);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 1);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 2);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 3);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 4);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 5);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 6);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 7);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 8);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 9);
			Console.WriteLine("███████████████████");
		}
		
		private void muestraCinco(int x, int y) {
			Console.SetCursorPosition(x, y);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 1);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 2);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 3);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 4);
			Console.WriteLine("████████   ████████");
			Console.SetCursorPosition(x, y + 5);
			Console.WriteLine("████████   ████████");
			Console.SetCursorPosition(x, y + 6);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 7);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 8);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 9);
			Console.WriteLine("███████████████████");
		}
		
		private void muestraSeis(int x, int y) {
			Console.SetCursorPosition(x, y);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 1);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 2);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 3);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 4);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 5);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 6);
			Console.WriteLine("███████████████████");
			Console.SetCursorPosition(x, y + 7);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 8);
			Console.WriteLine("███   ███████   ███");
			Console.SetCursorPosition(x, y + 9);
			Console.WriteLine("███████████████████");
			
		}
		
	}
}
