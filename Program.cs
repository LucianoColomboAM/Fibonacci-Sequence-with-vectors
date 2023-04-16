/*
 * Creado por SharpDevelop.
 * Usuario: Maria
 * Fecha: 16/11/2017
 * Hora: 12:14 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Fibonacci_con_vectores
{
	class Program
	{
		class Fibonacci_Vectores{
			int N;
			int [] V;
			public void Susecion(){
				Console.Write("Ingrese las veces que desea calcular la sucesion de Fibonacci: ");
				N=int.Parse(Console.ReadLine());
				V=new int[N];
				Console.Write("Sucesion de Fibonacci: ");
				for(int i=0 ; i<=N-1;i++){
					if(i==0||i==1){
						V[i]=1;
					}else{
						V[i]=V[i-2]+V[i-1];
					}
					Console.Write(V[i]+",");
				}
				Console.WriteLine();
			}
		}
		public static void Main(string[] args)
		{	
			Fibonacci_Vectores F = new Fibonacci_Vectores();
			F.Susecion();
			Console.Write("Presiona una tecla para terminar . . . ");
			Console.ReadKey(true);
		}
	}
}