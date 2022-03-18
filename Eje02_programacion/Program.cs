/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 16/03/2022
 * Time: 4:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Eje02_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre; //Definir la variable
			Console.WriteLine("Digite su nombre"); //Se muestra mensaje al usuario
			nombre = Console.ReadLine(); //se captura el dato del usuario
			
			Console.WriteLine("Su nombre es {0}", nombre);
			//----------------------------------
			//INT
			int edad;
			Console.WriteLine("Cuál es su edad");
			edad = int.Parse(Console.ReadLine());
			Console.WriteLine("Su edad es: {0}", edad);
			
			//DOUBLE
			double peso;
			Console.WriteLine("Cuál es su peso");
			peso = double.Parse(Console.ReadLine());
			Console.WriteLine("Su peso es: {0}", peso);
			
		
			Console.ReadKey(true);
		}
	}
}