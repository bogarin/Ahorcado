using System;

namespace Ahorcados
{
	class Adivinar 
	{
		private string []palabras={"abeja","cabeza","guitarra"};
		private string []adivinar={"Zumba que te zumbarás, \nva y viene sin descanso, \nde flor en flor trasnportando \ny nuestra vida endulzando.",
			"Unas son redondas, \notras ovaladas, \nunas piensan mucho, \notras casi nada.",
			"Me rascan continuamente\nde forma muy placentera,\nmi voz es muy bien timbrada\ny mi cuerpo de madera."};
		private string adpalabra;
		private string adivina; 

		public string AdPalabra{
			get{return adpalabra;}
			set{ adpalabra = value;}
		}

		public string ADivina {
			get{ return adivina;}
			set{ adivina = value;}
		}

		public Adivinar(int numero)
		{
			adpalabra=palabras[numero];
			ADivina=adivinar[numero];
		}

		public int longitud()
		{
			return adpalabra.Length;
		}

		public bool comparacion(int posicion,string letra)
		{
			if(AdPalabra[posicion]==letra[0])
			{
				return true;
			}
			return false;
		}
	}
}

