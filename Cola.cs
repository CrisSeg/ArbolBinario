using System;
using System.Collections.Generic;

namespace Complejidad_practica1
{
	public class Cola<T>
	{
		private List<T> datos = new List<T>();
		
		public void Encolar(T elem){
			this.datos.Add(elem);
		}
		
		public T Desencolar(){
			T dat = datos[0];
			this.datos.RemoveAt(0);
			
			return dat;
		}
		
		public T tope()
		{return this.datos[0];}
		
		public bool Vacia()
		{return this.datos.Count == 0;}
	}
}
