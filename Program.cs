using System;
using System.Collections.Generic;

namespace Complejidad_practica1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Raiz
			ArbolBinario<int> primerArbol = new ArbolBinario<int>(1);
			
			//Hijos
			ArbolBinario<int> hijoIzquierdo = new ArbolBinario<int>(2);
			ArbolBinario<int> hijoDerecho = new ArbolBinario<int>(3);
			ArbolBinario<int> hijoIIzquierdo = new ArbolBinario<int>(4);
			
			//Implementacion del Arbol
			primerArbol.agregarHijoIzquierdo(hijoIzquierdo);
			primerArbol.agregarHijoDerecho(hijoDerecho);
			hijoIzquierdo.agregarHijoIzquierdo(hijoIIzquierdo);
			
			Console.WriteLine("Recorrido por Preorder: ");
			primerArbol.preorden();
			
			Console.WriteLine("Recorrido por Inorder: ");
			primerArbol.inorden();
			
			Console.WriteLine("Recorrido por Postorden: ");
			primerArbol.postorden();
			
			Console.WriteLine("Recorrido por niveles: ");
			//primerArbol.recorridoPorNiveles();
			
			
			//Arbol del ejercicio de entrega
			ArbolBinario<int> EjeEntrega = new ArbolBinario<int>(1);
			ArbolBinario<int> EEHI = new ArbolBinario<int>(2);
			ArbolBinario<int> EEHD = new ArbolBinario<int>(3);
			ArbolBinario<int> EEHII = new ArbolBinario<int>(4);
			ArbolBinario<int> EEHDI = new ArbolBinario<int>(5);
			ArbolBinario<int> EEHDD = new ArbolBinario<int>(6);
			ArbolBinario<int> EEHDII = new ArbolBinario<int>(7);
			
			EjeEntrega.agregarHijoIzquierdo(EEHI);
			EjeEntrega.agregarHijoDerecho(EEHD);
			EEHI.agregarHijoIzquierdo(EEHII);
			EEHD.agregarHijoIzquierdo(EEHDI);
			EEHD.agregarHijoDerecho(EEHDD);
			EEHDI.agregarHijoIzquierdo(EEHDII);
			
			//EjeEntrega.nuevo(EjeEntrega);
			
			//EjeEntrega.preorden();
			Console.ReadKey();
		}
	}
}