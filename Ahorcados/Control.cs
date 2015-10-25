using System;

namespace Ahorcados
{
	public class Control
	{
		private Adivinar adivina;
		private char[] resultado;
		private string letraResivida;
		private bool vandera;
		private int errores;
		public int Errores{
			get{return errores;}
			set{errores=value;}
		}
		public Control ()
		{
			adivina = null;
			letraResivida = "";
			vandera = false;
			errores = 0;
		}

		public void letraComparacion(int posicion)
		{
		resiviendoPosicion (posicion);
			do {
				vandera = false;
				comparaciones ();
				imprecionResultado ();
			} while(equivocaciones()&felicidades());
		}

		private void resiviendoPosicion(int posicion){
			adivina = new Adivinar (posicion);
			resultado=new char[adivina.longitud ()];
			guionesBajos ();
		}

		private void comparaciones(){
			letraResivida=informacion();
			for(int i=0;i<resultado.Length;i++){
				letraGuionBajo(adivina.comparacion(i,letraResivida),i);
			}
		}

		private void guionesBajos(){
			for(int i=0; i<resultado.Length;i++){
				resultado [i] = '_';
			}
		}

		private void imprecionResultado(){
			foreach (char c in resultado) {
				Console.Write(c + " ");
			}
			Console.WriteLine();
		}
		private string informacion(){
			System.Console.WriteLine (adivina.ADivina);
			return System.Console.ReadLine();
		}

		private void letraGuionBajo(bool desicion, int i){
			if(desicion){
				resultado[i]=letraResivida[0];
				vandera = true;
			}
		}

		private bool equivocaciones(){
			if (vandera==false) {
				Errores++;
				System.Console.WriteLine("vamos mal solo tienes 3 intentos y ya llevas mal {0} ",Errores);
				if(Errores == 3){
					System.Console.WriteLine("Te as equivocado estas ahorcado :(");
					return false; 
				}
			}
			return true;
		}

		private bool felicidades(){
			int contador = 0;
			foreach (char c in resultado) {if (c != '_') {contador++;}}
			if (contador == resultado.Length) {
				System.Console.WriteLine("Felisidades!!!!");
				return false;
			}
			return true;
		}
	}
}

