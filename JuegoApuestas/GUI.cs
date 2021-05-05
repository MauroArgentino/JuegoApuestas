/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 3 may. 2021
 * Hora: 19:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Threading;

namespace JuegoApuestas
{
	/// <summary>
	/// Description of GUI.
	/// </summary>
	public class GUI
	{
		public GUI()
		{
			
		}
		
		public void Intro(){
			String[] grupo = {"       ';,.,'   .;ccc::;'.   .;ccc,.;:. .:cccc:;;.       .,;,'.               .';:'",
							"     ,kKl.;OO.  .dWMNo;0NO;  .xWMNl'OO. .OMMMKclXXx'    :00ccKO;            ,xOxc:.",
							"    ;KMK,  ;k;   :NMN:.xMM0'  cNMN:.xd   oMMM0',0MWk.  cXM0',KMK;          cXWd''.",
							"   .xWMK,   ..   :NMN:.xMMO.  cNMN:.xd   oMMM0',0MM0' .OWM0',KMWx.        '0MWkdKXd.",
							"   'OMM0;;kkkd.  :NMNo:0Xd'   cWMN:.xd   oMMM0',KMWx. '0MM0',KMMO.        cNMWl.kMWd.",
							"   .OMMK,;KMMd.  :NMNxlKXd'   cNMN:.xd   oMMMXoo0Ol.  '0MM0',KMMO.        lWMWc.xMMk.",
							"   .dWMK,,KMWo   :NMN:.xMMk.  cNMN:.xd   oWMMKc..     .xWM0',KMWd         ;XMWc.kMMx.",
							"    'OWK,,KMWo   :NMN:.xWWO.  :XMNc.ko   oWMM0'        ,0M0',KWO.         .dWWc.kMK;",
							"     .lxlcloOc  .dXXKl.cKXO,  .ck0kdl.  'kXXX0c         .oxllxl.           .ckxoxd'"};
			
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.SetCursorPosition(0, 3);
			Console.WriteLine("\t        ':c:,,,:loc.        ,l'         .;c;,;col,  .;llo:'  .:lol'        ':ll;.    .;:;,,;cl:.");
			Console.WriteLine("\t     .ckOl'.    .l0c       ;XMx.       ,OO,   .o0x'  'OMNc    .dNMXc.       ;0k.   ,xOo'    .:OXk,");
			Console.WriteLine("\t    ;0Wk.         ,;      .d0NNc      .xWd.     .'.  .xMK,     ;O0XNk'      .dl   lXX:        .xWNo.");
			Console.WriteLine("\t   ,KM0,                 .o:'kM0'      oWNd'         .dMK,     ;x,,OWXo.    .ol  cNMd.         '0MNc");
			Console.WriteLine("\t  .dWMx.                 co. :XWd.     .oXWXkl,      .xMK,     ;x' .lKW0:.  .ol .kMWl           dWMO.");
			Console.WriteLine("\t  .kMMx.                ,Oo'':0MX:       'lkXWNkl,   .dMK,     ;x'   'xNNk, .ol .OMWl           lWM0'");
			Console.WriteLine("\t   lNM0'               .xx:;;;oKMO.         'oKMMK,  .dMK,     ;x'     ;0WXo,dl .xMMx.          oWWd.");
			Console.WriteLine("\t   .xWWd.          ..  ox.     lNWo   '.      :XMNc  .xMK,     ;x'      .oXWXKl  '0MXc         '0WO.");
			Console.WriteLine("\t    .lKNk,       .ld. :O;      .xMX;  ok'     :XMO'  .xMX;     :O;        ,kNWl   'xNXl.      'kXd.");
			Console.WriteLine("\t      .:dxoc;,,;cod;.:xx;.     .o00x:.,dkl;,;cdo:.  .:x00o'. .,oOo,.       .c0l     ,lxdc;,,;col'");
			Console.WriteLine("\t          ..'''...  .....      .......  ..'''.      .......   .....          ..        ..'''..");
			Console.ResetColor();
						                                                                 
            Console.SetCursorPosition(0, 16);                                   
            for (int i = 0; i < grupo.LongLength; i++) {
            	Console.WriteLine("\t\t{0}", grupo[i]);
            	Thread.Sleep(75);
            }
			
		}
		
		public void solicitaIngresoJugador(Jugador jugador) {
			String nombre = "MAURO";
			
			jugador.setNombre(nombre);
		}
		
		public void solicitaApuestas(Jugador jugador1, Jugador jugador2, int desplazamientoXJugador1,int desplazamientoYJugador1, int desplazamientoXJugador2, int desplazamientoYJugador2){
			//Console.WriteLine("Ingrese apuesta: ");
			int importe, numero, tipoApuesta = 1;
			
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1);
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
			Console.ForegroundColor = ConsoleColor.White;
			for (int i = 6; i < 13; i++) {
				Console.SetCursorPosition(10, i);
				Console.Write("                ");
			}
			
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1);
			Console.Write("\t\tAPUESTA");
			//jugador1.setApuesta(importe, numero, tipoApuesta);
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1 + 1);
			Console.WriteLine("\tIMPORTE:");
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1 + 2);
			Console.WriteLine("\tNUMERO: ");
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1 + 3);
			Console.WriteLine("\tTIPO APUESTA", jugador1.getNumeroApostado());
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1 + 4);
			Console.WriteLine("\tCONSERVADORA", jugador1.getImporteApostado());
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1 + 5);
			Console.WriteLine("\tARRIESGADA", jugador1.getImporteApostado());
			Console.SetCursorPosition(desplazamientoXJugador1, desplazamientoYJugador1 + 6);
			Console.WriteLine("\tDESESPERADA", jugador1.getImporteApostado());
			Console.ResetColor();
			Console.SetCursorPosition(desplazamientoXJugador1 + 10, desplazamientoYJugador1 + 1);
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("     ");
			Console.SetCursorPosition(desplazamientoXJugador1 + 10, desplazamientoYJugador1 + 2);
			Console.Write("     ");
			Console.SetCursorPosition(desplazamientoXJugador1 + 10, desplazamientoYJugador1 + 1);
			importe = int.Parse(Console.ReadLine());
			Console.SetCursorPosition(desplazamientoXJugador1 + 10, desplazamientoYJugador1 + 2);
			numero = int.Parse(Console.ReadLine());
			Console.ResetColor();
			
			//bool salir = false;
			short itemActual = 0;
						
			ConsoleKeyInfo tecla;
			
			
			string[] menuItems = { "CONSERVADORA", "ARRIESGADA", "DESESPERADA" };
			
			Console.CursorVisible = false;
			do
			{
			   	Console.SetCursorPosition(desplazamientoXJugador1 + 10, desplazamientoYJugador1 + 1);
			    
				  
//			   	Console.BackgroundColor = ConsoleColor.DarkCyan;
//				Console.ForegroundColor = ConsoleColor.White;
//				Console.WriteLine("\t\tSISTEMA DE LIQUIDACIÓN DE SUELDOS\t\t");
//				Console.ResetColor();
			   
			    for (int i = 0; i < menuItems.Length; i++) {
			   		Console.BackgroundColor = ConsoleColor.DarkMagenta;
						Console.ForegroundColor = ConsoleColor.White;
			        if (itemActual == i) {
			           Console.BackgroundColor = ConsoleColor.Yellow;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.SetCursorPosition(desplazamientoXJugador1 + 2, desplazamientoYJugador1 + i + 4);
			            Console.WriteLine(menuItems[i]);
//			            Console.ResetColor();
			        } else {
			   			Console.SetCursorPosition(desplazamientoXJugador1 + 2, desplazamientoYJugador1 + i + 4);
			             Console.BackgroundColor = ConsoleColor.DarkMagenta;
						Console.ForegroundColor = ConsoleColor.White;
			   			
			   			Console.WriteLine(menuItems[i]);
			            
			        }
			    }
			    Console.SetCursorPosition(0, 25);
			    Console.ResetColor();
			    Console.ForegroundColor = ConsoleColor.Yellow;
			    Console.Write("Seleccione una opción con las flechas y presione Enter");
			    tecla = Console.ReadKey(true);
			
			    if (tecla.Key == ConsoleKey.DownArrow) {
			        itemActual++;
			        if (itemActual > menuItems.Length - 1) {
			        	itemActual = 0;
			        }
			    } else if (tecla.Key == ConsoleKey.UpArrow) {
			        itemActual--;
			        if (itemActual < 0) {
			        	itemActual = Convert.ToInt16(menuItems.Length - 1);
			        }
			    }
			    
			    if(tecla.Key == ConsoleKey.Enter) {
					switch (itemActual) {
								case 0 :
									//Console.Clear();
									tipoApuesta = 1;
									break;
								case 1 :
									//Console.Clear();
									tipoApuesta = 2;
//									diasLaborablesEntreFechas();
									break;
								case 2 :
									//Console.Clear();
									tipoApuesta = 3;
									break;
								
								default:
									Console.WriteLine("Ha ingresado una opción incorrecta.");
									break;
							}
			    }
			   
			} while (tecla.KeyChar != 13);
//			return salir;
			
			
			jugador1.setApuesta(importe, numero, tipoApuesta);
			//jugador2.setApuesta(20, 8, 2);
		}
		
		public void refrescaDatosPantalla(Jugador jugador1, Jugador jugador2, Casino oCasino){
			Console.Clear();
      		Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.ForegroundColor = ConsoleColor.White;
			for (int i = 0; i < 4; i++) {
				Console.SetCursorPosition(0, i);
				Console.Write("                                  ");
			}
			Console.SetCursorPosition(0, 0);
			
			Console.Write("\tJUGADOR 1:");
			Console.WriteLine(" {0}", jugador1.getNombre());
			Console.WriteLine("\tSALDO: {0}", jugador1.getSaldo());
			Console.WriteLine("\tVALOR APOSTADO: {0}", jugador1.getNumeroApostado());
			Console.WriteLine("\tIMPORTE APOSTADO: {0}", jugador1.getImporteApostado());
			Console.ResetColor();
			
			Console.SetCursorPosition(43, 0);
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.Write("                         ");
			Console.SetCursorPosition(53, 0);
			Console.Write("CASINO");
			Console.SetCursorPosition(43, 1);
			Console.Write("                         ");
			Console.SetCursorPosition(50, 1);
			Console.Write("POZO: {0}", oCasino.getPozo());
			Console.ResetColor();
			
			Console.BackgroundColor = ConsoleColor.DarkGray;
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(80, 0);
			for (int i = 0; i < 4; i++) {
				Console.SetCursorPosition(80, i);
				Console.Write("                                  ");
			}
			Console.SetCursorPosition(80, 0);
			Console.Write("\tJUGADOR 2: {0}", jugador2.getNombre());
			Console.SetCursorPosition(80, 1);
			Console.Write("\tSALDO: {0}", jugador2.getSaldo());
			Console.SetCursorPosition(80, 2);
			Console.WriteLine("\tVALOR APOSTADO: {0}", jugador2.getNumeroApostado());
			Console.SetCursorPosition(80, 3);
			Console.WriteLine("\tIMPORTE APOSTADO: {0}", jugador2.getImporteApostado());
			Console.ResetColor();
		}
	}
}
