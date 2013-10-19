using System;

namespace agrega_datos
{
	class Program
	{
			                  
		public static void Main(string[] args)
		{
			try {
				fichero entrada = new fichero ();
				entrada.seleccion ();
				Console.ReadLine ();
			}
			catch (Exception exp){
				Console.WriteLine ("SE HA PRODUJIDO UN ERROR:"+exp.Message);
			}
			finally{
				Console.WriteLine("finalizada");
			}
		}
	}
}