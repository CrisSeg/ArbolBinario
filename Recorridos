using System;
using System.Collections.Generic;

namespace Complejidad_practica1
{
	public class ArbolBinario<T>
	{
		private T dato;
		private ArbolBinario<T> hijoIzquierdo;
		private ArbolBinario<T> hijoDerecho;
		
		public ArbolBinario(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public ArbolBinario<T> getHijoIzquierdo() {
			return this.hijoIzquierdo;
		}
	
		public ArbolBinario<T> getHijoDerecho() {
			return this.hijoDerecho;
		}
	
		public void agregarHijoIzquierdo(ArbolBinario<T> hijo) {
			this.hijoIzquierdo=hijo;
		}
	
		public void agregarHijoDerecho(ArbolBinario<T> hijo) {
			this.hijoDerecho=hijo;
		}
	
		public void eliminarHijoIzquierdo() {
			this.hijoIzquierdo=null;
		}
	
		public void eliminarHijoDerecho() {
			this.hijoDerecho=null;
		}
	
		public bool esHoja() {
			return this.hijoIzquierdo==null && this.hijoDerecho==null;
		}
		
		public void inorden() {
			//Imprimo por pantalla el hijo izquierdo
			Console.Write(this.getHijoIzquierdo() + " ");
			if (this.hijoIzquierdo != null) {
				hijoIzquierdo.inorden();     //si el nodo tiene hijo izquierdo llamo a la funcion recursivamente
			}	
			
			
			//Imprimo el dato raiz
			Console.Write(this.dato + " ");
			
			//recorro los nodos derechos recursivamente
			if(this.hijoDerecho != null){
				hijoDerecho.inorden();
			}
			Console.Write(this.getHijoDerecho() + " ");
		}
		
		public void preorden() {
			//Imprimo el nodo raiz
			Console.Write(this.dato+" ");

			//Recorro los hijos izquierdos recursivamente
			if (this.getHijoIzquierdo() != null) {
				hijoIzquierdo.preorden();
			}
			
			//Recorro los hijos derechos  recursivamente
			if (this.getHijoDerecho() != null) {
				hijoDerecho.preorden();
			}
		}
		
		public void postorden() {
			//Recorro los hijos izquierdos 
			if (this.hijoIzquierdo != null) {
				hijoIzquierdo.postorden();
			}
			//Imprimo el hijo izquierdo
			Console.Write(this.hijoIzquierdo +" ");
			
			//Recorro los hijos derechos
			if (this.hijoDerecho != null) {
				hijoDerecho.postorden();
			}
			//Imprimo el hijo derecho
			Console.Write(this.hijoDerecho +" ");
			
			//Imprimo la raiz
			Console.Write(this.dato +" ");
		}
		
		public void recorridoPorNiveles() {
			Cola<ArbolBinario<T>> c = new Cola<ArbolBinario<T>>();
			ArbolBinario<T> v;
			
			c.Encolar(this); //This esta haciendo referencia a la raiz
			
			while (!c.Vacia()) {
				v = c.Desencolar();
				Console.Write(v.getDatoRaiz() + " ");
				if (v.getHijoIzquierdo() != null) {
					c.Encolar(v.getHijoIzquierdo());
				}
				if (v.getHijoDerecho() != null) {
					c.Encolar(v.getHijoDerecho());
				}
			}
			
		}
}
