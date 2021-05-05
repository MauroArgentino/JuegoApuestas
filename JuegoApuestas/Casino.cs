/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 2 may. 2021
 * Hora: 03:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace JuegoApuestas
{
	/// <summary>
	/// Description of Casino.
	/// </summary>
	public class Casino
	{
		private int pozo;
		//public enum tipoApuesta { Conservadora, Arriesgada, Desesperada };
		
		public Casino(Jugador jugador1, Jugador jugador2)
		{
			pozo = 10000;
		}
		
		public static void solicitaApuestas(Jugador jugador1, Jugador jugador2){
			//Console.WriteLine("Ingrese apuesta: ");
			
			jugador1.setApuesta(50, 5, 1);
			jugador2.setApuesta(20, 8, 2);
		}
		
		public int arrojaDados(){
			Dado oDado1;
			Dado oDado2;
			
			oDado1 = new Dado(5, 12);
			oDado2 = new Dado(84, 12);
			
			return oDado1.getNumero() + oDado2.getNumero();
			
		}
		
		public int getPozo(){
			return pozo;
		}
		
		public void pagaApuesta(Jugador jugador, int tipoApuesta){
			switch (tipoApuesta) {
				case 1:
					pozo -= jugador.getImporteApostado() * 2;
					jugador.setSaldo(jugador.getSaldo() + jugador.getImporteApostado() * 2);
					break;
				case 2:
					pozo -= jugador.getImporteApostado() * 5;
					jugador.setSaldo(jugador.getSaldo() + jugador.getImporteApostado() * 5);
					break;
				case 3:
					pozo -= jugador.getImporteApostado() * 15;
					jugador.setSaldo(jugador.getSaldo() + jugador.getImporteApostado() * 15);
					break;
				default:
					
					break;
			}
			//pozo -= jugador.getImporteApostado();
			//jugador.cobraApuesta();
			
		}
		
		public void cobraApuesta(Jugador jugador, int tipoApuesta){
			switch (tipoApuesta) {
				case 1:
					pozo += jugador.getImporteApostado();
					jugador.setSaldo(jugador.getSaldo() - jugador.getImporteApostado());
					break;
				case 2:
					pozo += jugador.getImporteApostado() * 2;
					jugador.setSaldo(jugador.getSaldo() - jugador.getImporteApostado() * 2);
					break;
				case 3:
					pozo += jugador.getImporteApostado() * 4;
					jugador.setSaldo(jugador.getSaldo() - jugador.getImporteApostado() * 4);
					break;
				default:
					
					break;
			}
			//pozo -= jugador.getImporteApostado();
			//jugador.cobraApuesta();
			
		}
	}
}
