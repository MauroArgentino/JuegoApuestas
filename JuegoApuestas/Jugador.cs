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
	/// Description of Jugador.
	/// </summary>
	public class Jugador
	{
		private String _nombre;
		private int _saldo;
		private int _apuestaImporte;
		private int _apuestaNumero;
		private int _tipoApuesta;
		
		public Jugador(String nombre)
		{
			_nombre = nombre;
			_saldo = 100;
		}
		
		public String getNombre(){
			return _nombre;
		}
		
		public void setNombre(String nombre){
			_nombre = nombre;
		}
		
		public int getSaldo(){
			return _saldo;
		}
		
		public bool setApuesta(int importe, int numero, int tipoApuesta) {
			
			if (importe <= _saldo) {
				_apuestaImporte = importe;
				_apuestaNumero = numero;
				_tipoApuesta = tipoApuesta;
				//_saldo -= importe;
				return true;
			} else {
				return false;
			}
		}
		
		public void setSaldo(int ganancia){
			_saldo = ganancia;
		}
		
		public int getNumeroApostado(){
			return _apuestaNumero;
		}
		
		public int getImporteApostado(){
			return _apuestaImporte;
		}
		
		public int getTipoApuesta(){
			return _tipoApuesta;
		}
		
		public void setTipoApuesta(int tipoApuesta){
			_tipoApuesta = tipoApuesta;
		}
	}
}
