/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 16/03/2022
 * Time: 2:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Eje01_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Numeros enteros
			byte num1 = 255;
			ushort num2 = 20000;
			int num3 = 50000;
			long num4; //Definicion
			num4 = 6000000; //Asignacion
			
			Console.WriteLine("El numero 1 es: " + num1);
			Console.WriteLine("El numero 2 es: " + num2);
			Console.WriteLine("El numero 3 es: " + num3);
			Console.WriteLine("El numero 4 es: " + num4);
			
			
			//Numeros decimales
			float peso = (float)50.5;
			double altura = 1.75;
			decimal promedio = (decimal)5.89;
			
			Console.WriteLine("El peso (float) 1 es: " + peso);
			Console.WriteLine("La altura (double) 2 es: " + altura);
			Console.WriteLine("El promedio (decimal) 3 es: " + promedio);
			
			//Caracteres
			char genero = 'M';
			bool esAprendiz = true;
			
			Console.WriteLine("Genero> "+genero);
			Console.WriteLine("Es aprendiz> "+esAprendiz);


			//String
			string nombre = "Anaelsa Rodriguez";
			string direccion = "calle 5 # 3 - 123";
			
			Console.WriteLine("Nombre> "+nombre);
			Console.WriteLine("Direccion> "+direccion);
			
			Console.ReadKey(true); 
		}
	}
}