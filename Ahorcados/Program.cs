using System;

namespace Ahorcados
{
	class MainClass : Control
	{
		public MainClass()
		:base()
		{}

		public void escojer()
		{
			Console.WriteLine("Escribir del 1 al 3 para escojer\n la palabra a adivinar suette!!!!!");
			menu(int.Parse(Console.ReadLine()));
			regresar ();
		}

		private void menu(int caseSwitch)
		{
			switch (--caseSwitch)
			{
			case 0:
				System.Console.WriteLine ("La adivinanza es de insectos!!!!!!");
				recibiendo (caseSwitch);
				break;
				case 1:
					System.Console.WriteLine("La adivinanza es del cuerpo humano!!!!!!!!");
					recibiendo (caseSwitch);
				break;
				case 2:
					System.Console.WriteLine("La adivinanza es de instrumentos musicales!!!!!!!");
					recibiendo (caseSwitch);
				break;
			default:
				System.Console.WriteLine ("Ese numero no es correcto");
				break;
			}

		} 

		private void recibiendo(int numero){
			base.letraComparacion (numero);
			base.Errores = 0;
		}

		private void regresar(){
			System.Console.WriteLine (" quieres volver a intentarlo? (s/n)");
			if (Console.ReadLine () == "s") {
				escojer ();
			} else {
				System.Console.WriteLine ("bye bye.....");
			}
		}

		public static void Main (string[] args)
		{
			MainClass obj = new MainClass ();
			obj.escojer ();
		}
	}
}
