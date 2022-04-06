using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
			int horasSemana;

			Console.WriteLine("Ingrese el nombre");
			nombre = Console.ReadLine();
			Console.WriteLine("Ingrese el numero de horas que estudia a la semana");
			horasSemana = int.Parse(Console.ReadLine());

			Console.WriteLine("Su nombre es {0} y el numero de horas que estudia a la semana es {1}", nombre, horasSemana);


			//9.Hacer un algoritmo que lea el nombre de un estudiante, la cantidad de materias perdidas y la cantidad
			//de materias ganadas.
			string nombreEstudiante;
			int materiasPerdidas, materiasGanadas;

			Console.WriteLine("Ingrese el nombre");
			nombreEstudiante = Console.ReadLine();
			Console.WriteLine("Ingrese el numero de materias perdidas");
			materiasPerdidas = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el numero de materias ganadas");
			materiasGanadas = int.Parse(Console.ReadLine());

			Console.WriteLine("Su nombre es {0}  el numero de materias perdidas es {1} y el numero de materias ganadas es {2}", nombreEstudiante, materiasPerdidas, materiasGanadas);

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

			double numeroA, numeroB, diferencia;

			Console.WriteLine("Ingrese el valor de A");
			numeroA = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de B");
			numeroB = double.Parse(Console.ReadLine());
			diferencia = numeroA - numeroB;

			Console.WriteLine("La diferencia es: {0}", diferencia);

			// 12.Hacer un algoritmo que lea el nombre de una persona, el valor de la hora trabajada y el número de
			//horas que trabajó. Se debe mostrar el nombre y el pago de la persona.
			int valorHoras, numeroHoras;
			double pago;
			string nombrePersona;

			Console.WriteLine("Ingrese el nombre");
			nombrePersona = Console.ReadLine();
			Console.WriteLine("Ingrese el valor de la hora");
			valorHoras = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la cantidad de la horas trabajadas");
			numeroHoras = int.Parse(Console.ReadLine());
			pago = valorHoras * numeroHoras;

			Console.WriteLine("Su nombre es: {0} y su pago es {1}", nombrePersona, pago);

			//13. Pedir el radio de un círculo y calcular su área. A=PI*r^2.
			double radioCirculo, areaCirculo;

			Console.WriteLine("Ingrese el radio del circulo");
			radioCirculo = double.Parse(Console.ReadLine());
			areaCirculo = Math.PI * Math.Pow(radioCirculo, 2);

			Console.WriteLine("El área del circulo es: {0}", areaCirculo);

			//14. Pedir el radio de una circunferencia y calcular su longitud.
			double radioCircunferencia, longitud;

			Console.WriteLine("Ingrese el radio de una circunferencia");
			radioCircunferencia = double.Parse(Console.ReadLine());
			longitud = Math.Pow(Math.PI, 2) * radioCircunferencia;

			Console.WriteLine("La longitud de la circunferencia es: {0}", longitud);


			//15. Pedir el lado de un cuadrado, mostrar su área y su perímetro.
			double ladoCuadrado, areaCuadrado, perimetroCuadrado;

			Console.WriteLine("Ingrese el lado de un cuadrado");
			ladoCuadrado = double.Parse(Console.ReadLine());
			areaCuadrado = ladoCuadrado * 2;
			perimetroCuadrado = ladoCuadrado * 4;

			Console.WriteLine("El area del cuadrado es: {0} Y su perimetro es {1}", areaCuadrado, perimetroCuadrado);


			//16. Calcular el área de un rectángulo de lados X e Y.
			double areaRectangulo, ladoX, ladoY;

			Console.WriteLine("Ingrese el valor de X del rectangulo");
			ladoX = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el valor de Y del rectangulo");
			ladoY = double.Parse(Console.ReadLine());
			areaRectangulo = ladoX * ladoY;

			Console.WriteLine("El area del rectangulo es: {0}", areaRectangulo);
			Console.ReadKey(true);


			//17. Pedir dos números y decir si son iguales o no.
			double num1, num2;
			Console.WriteLine("Digite numero 1");
			num1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite numero 2");
			num2 = double.Parse(Console.ReadLine());

			if(num1 == num2)
            {
				Console.WriteLine("Los numeros son iguales");
            }
            else
            {
				Console.WriteLine("Los numeros no son iguales");
            }

			//18. Pedir un número e indicar si es positivo o negativo.
			double numero1;
			Console.WriteLine("Digite un numero");
			numero1 = double.Parse(Console.ReadLine());

			if (numero1 > 0)
            {
				Console.WriteLine("El numero es positivo");
            } else
            {
				Console.WriteLine("El numero es negativo");
            }

			//19. Pedir dos números y decir si uno es múltiplo del otro.
			double number1, number2;
			Console.WriteLine("Digite numero 1");
			number1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite numero 2");
			number2 = double.Parse(Console.ReadLine());
			
			if(a % b == 0)
            {
				Console.WriteLine("Es multiplo");
            } else
            {
				Console.WriteLine("No es multiplo");
            }

			//20. Pedir dos números y decir cuál es el mayor.
			double numb1, numb2;
			Console.WriteLine("Digite numero 1");
			numb1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite numero 2");
			numb2 = double.Parse(Console.ReadLine());
			
			if (numb1 > numb2)
            {
				Console.WriteLine("El primer numero es mayor que el segundo");
            } else
            {
				Console.WriteLine("El segundo numero es mayor que el primero");
            }

			//21. Pedir dos números y decir cuál es el mayor o si son iguales.
			double one, two;
			Console.WriteLine("Digite numero 1");
			one = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite numero 2");
			two = double.Parse(Console.ReadLine());

			if(one == two)
            {
				Console.WriteLine("Los numeros son iguales");
            }
			if(one > two)
            {
				Console.WriteLine("El primer numero es mayor que el segundo");
            } else
            {
				Console.WriteLine("El segundo numero es mayor que el primero");
            }

			//22. Pedir dos números y mostrarlos ordenados de mayor a menor.
			double numero_uno, numero_dos;
			Console.WriteLine("Digite numero 1");
			numero_uno = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite numero 2");
			numero_dos = double.Parse(Console.ReadLine());

			if(numero_uno > numero_dos)
            {
				Console.WriteLine("El orden de los numeros es: {0} y {1}", numero_uno, numero_dos);
            } else
            {
				Console.WriteLine("El orden de los numeros es: {0} y {1}", numero_dos, numero_uno);
            }

			//23. Pedir tres números y mostrarlos ordenados de mayor a menor.
			double uno_1, dos_2, tres_3;
			Console.WriteLine("Digite numero 1");
			uno_1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite numero 2");
			dos_2 = double.Parse(Console.ReadLine());
			Console.WriteLine("Digite numero 2");
			tres_3 = double.Parse(Console.ReadLine());

			if(uno_1 > dos_2 && dos_2 > tres_3) { 
				Console.WriteLine("El orden de los numeros es: {0} y {1} y {2}", uno_1, dos_2, tres_3);
				}
				if (dos_2 > uno_1 && tres_3 > uno_1) { 
				Console.WriteLine("El orden de los numeros es: {0} y {1} y {2}", dos_2, tres_3, uno_1);
					}
				if (tres_3 > dos_2 && uno_1 > dos_2) { 
				Console.WriteLine("El orden de los numeros es: {0} y {1} y {2}", tres_3, uno_1, dos_2);
					}


			//24. Pedir un número entre 0 y 9.999 y decir cuántas cifras tiene.
			double cifras;
			Console.WriteLine("Digite numero 1");
			cifras = double.Parse(Console.ReadLine());
            if(cifras < 100)
            {
				Console.WriteLine("El numero tiene 2 cifras");
            } if(cifras < 1000)
            {
				Console.WriteLine("El numero tiene 3 cifras");
            } if(cifras < 10000)
            {
				Console.WriteLine("El numero tiene 4 cifras");
            }

			//25. Pedir una nota de 0 a 5 y mostrarla de la forma: Insuficiente (0 ? 2,9), Suficiente (3 ? 4,5) y Bien (4,6? 5)
			double nota;
			Console.WriteLine("Digite una nota de 0 a 5");
			nota = double.Parse(Console.ReadLine());

			
			if(nota >= 0 && nota < 3)
            {
				Console.WriteLine("Insuficiente");
            }
			else if(nota >= 3 && nota < 4.5) 
            {
				Console.WriteLine("Suficiente");
            }
			else if(nota >= 4.6 && nota <= 5)
            {
				Console.WriteLine("Bien");
            }
			else
            {
				Console.WriteLine("Numero fuera de rango");
            }

			//26. Pedir una nota numérica entera entre 0 y 10, y mostrar dicha nota de la forma: cero, uno, dos, tres...
			double leer_numero;
			Console.WriteLine("Digite un numero entre 0 a 10");
			bool validacion = double.TryParse(Console.ReadLine(), out leer_numero);
			if (validacion == false)
			{
				Console.WriteLine("Numero fuera de rango");
			}
			/*if (leer_numero == 0)
            {
				Console.WriteLine("Cero");
            }
			if (leer_numero == 1)
            {
				Console.WriteLine("Uno");
            }
			if (leer_numero == 3)
            {
				Console.WriteLine("Tres");
            }
			if (leer_numero == 4)
            {
				Console.WriteLine("Cuatro");
            }
			if (leer_numero == 5)
            {
				Console.WriteLine("Cinco");
            }
			if (leer_numero == 6)
            {
				Console.WriteLine("Seis");
            }
			if (leer_numero == 7)
            {
				Console.WriteLine("Siete");
            }
			if (leer_numero == 8)
            {
				Console.WriteLine("Ocho");
            }
			if (leer_numero == 9)
            {
				Console.WriteLine("Nueve");
            }
			if (leer_numero == 10)
            {
				Console.WriteLine("Diez");
            }
            */
			switch (leer_numero)
            {
				case 0:
					Console.WriteLine("Cero");
					break;
				case 1:
					Console.WriteLine("Uno");
					break ;
				case 2:
					Console.WriteLine("Dos");
					break;
				case 3:
					Console.WriteLine("Tres");
					break;
				case 4:
					Console.WriteLine("Cuatro");
					break;
				case 5:
					Console.WriteLine("Cinco");
					break;
				case 6:
					Console.WriteLine("Seis");
					break;
				case 7:
					Console.WriteLine("Siete");
					break;
				case 8:
					Console.WriteLine("Ocho");
					break;
				case 9:
					Console.WriteLine("Nueve");
					break;
				case 10:
					Console.WriteLine("Diez");
					break;
				default:
				Console.WriteLine("Nota incorrecta");
					break;


			}


			//27. Pedir un número y decir si es par o impar.
			int numero_par;
			Console.WriteLine("Digite un numero");
			numero_par = int.Parse(Console.ReadLine());

			if ((numero_par % 2) == 0)
            {
				Console.WriteLine("Es par");
            } else
            {
				Console.WriteLine("Es impar");
            }
			//28. Un trabajador recibe su pago, según la cantidad de horas trabajadas y su valor. Si la cantidad de
			//horas trabajadas es mayor que 40, éstas se consideran horas extra, y tienen un incremento de $10000
			//(diez mil) sobre el valor de la hora. Calcular y mostrar el salario (pago) del trabajador. Nota: leer horas
			//trabajadas y valor de la hora.
			
			double salario, horas_extras, valor_horas, cantidadHoras;



			Console.WriteLine("Ingrese el valor de la hora");
			valor_horas = double.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese la cantidad de la horas trabajadas");
			bool validacionh = double.TryParse(Console.ReadLine(), out cantidadHoras);
			salario = cantidadHoras * valor_horas;
			

			if(cantidadHoras > 40)
            {

				horas_extras = cantidadHoras - 40;
				salario = salario + horas_extras * 10000;
				Console.WriteLine("Tiene horas extras: " + horas_extras);

			}
			Console.WriteLine("El salario es: " + salario);
		

			//29. Dado un monto, calcular el descuento considerando que por encima de 100 el descuento es del 10%
			//y por debajo de 100, el descuento es del 2 %.
			//30.Leer dos números y calcular su división, teniendo en cuenta que el denominador no debe ser 0(cero)


		}
	}
}