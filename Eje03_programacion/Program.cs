/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 16/03/2022
 * Time: 4:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Eje03_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Ejercicio 06
			string nombreArticulo;
			double valorUnitario, total;
			int cantidad;
			
			Console.WriteLine("Ingrese el nombre del articulo");
			nombreArticulo = Console.ReadLine();
			Console.WriteLine("Ingrese el valor unitario");
			valorUnitario = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la cantidad");
			cantidad = int.Parse(Console.ReadLine());
			total = cantidad * valorUnitario;
			
			Console.WriteLine("El nombre del articulo es {0} y el total a pagar es {1}", nombreArticulo, total);
			
			
			//Ejercicio 07
			double a, b, suma;
			
			Console.WriteLine("Ingrese el valor del primer numero");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor del segundo numero");
			b = double.Parse(Console.ReadLine());
			suma = a + b;
			
			Console.WriteLine("La suma total es: {0}", suma);



			//8. Hacer un algoritmo que lea el nombre de una persona y número de horas que estudia en la semana.
			string nombre;
			int numeroHoras;

			Console.WriteLine("Ingrese el nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el numero de horas que estudia a la semana");
			numeroHoras = int.Parse(Console.ReadLine());

			Console.WriteLine("Su nombre es {0} y el numero de horas que estudia a la semana es {1}", nombre, numeroHoras);


			//9.Hacer un algoritmo que lea el nombre de un estudiante, la cantidad de materias perdidas y la cantidad
			//de materias ganadas.
			string nombre;
			int materiasPerdidas, materiasGanadas;

			Console.WriteLine("Ingrese el nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el numero de materias perdidas");
			materiasPerdidas = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el numero de materias ganadas");
			materiasGanadas = int.Parse(Console.ReadLine());

			Console.WriteLine("Su nombre es {0}  el numero de materias perdidas es {1} y el numero de materias ganadas es {2}", nombre, materiasPerdidas, materiasGanadas);

			//10. Hacer un algoritmo que lea el alto y el ancho de un rectángulo y muestre su área y su perímetro.

			double alto, ancho, area, perimetro;

			Console.WriteLine("Ingrese el alto del rectángulo");
			alto = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el ancho del rectángulo");
			ancho = double.Parse(Console.ReadLine());
			area = ancho * alto;
			perimetro = ancho * 2 + alto * 2;

			Console.WriteLine("El área es {0} y el perimetro es {1}", area, perimetro);

			//11. Hacer un algoritmo que lea dos números enteros A y B y muestre su diferencia.

			double a, b, diferencia;

			Console.WriteLine("Ingrese el valor de A");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de B");
			b = double.Parse(Console.ReadLine());
			diferencia = a - b;

			Console.WriteLine("La diferencia es: {0}", diferencia);

			// 12.Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
			//horas que trabajó. Se debe mostrar el nombre y el pago de la persona.
			int valorHoras, numeroHoras;
			double pago;
			string nombre;

			Console.WriteLine("Ingrese el nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el valor de la hora");
			valorHoras = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la cantidad de la horas trabajadas");
			numeroHoras = int.Parse(Console.ReadLine());
			pago = valorHoras * numeroHoras;

			Console.WriteLine("Su nombre es: {0} y su pago es {1}", nombre, pago);

			//13. Pedir el radio de un círculo y calcular su área. A=PI*r^2.
			double radioCirculo, area;

			Console.WriteLine("Ingrese el radio del circulo");
			radioCirculo = double.Parse(Console.ReadLine());
			area = 2 * Math.PI * radioCirculo;

			Console.WriteLine("El área del circulo es: {0}", area);

			//14. Pedir el radio de una circunferencia y calcular su longitud.
			double radioCircunferencia, longitud;

			Console.WriteLine("Ingrese el radio de una circunferencia");
			radioCircunferencia = double.Parse(Console.ReadLine());
			longitud = 2 * Math.PI * radioCircunferencia;

			Console.WriteLine("La longitud de la circunferencia es: {0}", longitud);


			//15. Pedir el lado de un cuadrado, mostrar su área y su perímetro.
			double ladoCuadrado, area, perimetro;

			Console.WriteLine("Ingrese el lado de un cuadrado");
			ladoCuadrado = double.Parse(Console.ReadLine());
			area = ladoCuadrado * 2;
			perimetro = ladoCuadrado * 4;

			Console.WriteLine("El area del cuadrado es: {0} Y su perimetro es {1}", area, perimetro);


			//16. Calcular el área de un rectángulo de lados X e Y.
			double area, ladoX, ladoY;

			Console.WriteLine("Ingrese el valor de X del rectangulo");
			ladoX = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de Y del rectangulo");
			ladoY = double.Parse(Console.ReadLine());
			area = ladoX * ladoY;

			Console.WriteLine("El area del rectangulo es: {0}", area);
			Console.ReadKey(true);
		}
	}
}