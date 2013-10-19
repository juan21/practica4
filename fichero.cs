using System;
using System.IO;
using System.Collections;

namespace agrega_datos
{
	public class fichero
	{
		private ArrayList usuarios = new ArrayList();
		private registro usuario = new registro();
		
		public fichero()
		{
		  this.usuario = new registro();
		  this.usuarios = new ArrayList();
		}
		public void seleccion (){
			leerDocumento ();
			imprimirregistros ();
		}
		public void leerDocumento (){
			string ubicacion;
			try{
				Console.WriteLine("ingresa la direccion /con terninacion .txt/");
				ubicacion = Console.ReadLine();
				
				StreamReader dirReader = new StreamReader(ubicacion);
				
				string dLine = dirReader.ReadLine();
				ArrayList arregloText = new ArrayList ();
				
				while (dLine !=null){
					ingresaregistro(dLine);
					dLine = dirReader.ReadLine();
				}
				dirReader.Close();
			}
			catch(Exception exp){
				Console.WriteLine("SE HA PRODUJIDO UN ERROR:"+exp.Message);
			}
			finally{
				
				Console.WriteLine("Finalizada");
			}
		}
		public void ingresaregistro (string dLine){
			char [] diagonalChar = {'/'};
				string [] palabras = dLine.Split(diagonalChar);
				//char [] comaChar = {','};
                //string [] palabra = dLine.Split(comaChar);
				
				registro usuario = new registro ();
				usuario.id = palabras [0];
			    usuario.nombre = palabras[1];
				usuario.domicilio = palabras[2];
				usuario.telefono =palabras [3];
			
				usuarios.Add(usuario);
			}
		public void imprimirregistros(){
				Console.WriteLine("Numero de registros: "+usuarios.Count);
				foreach (object registro in usuarios){
				this.usuario = (registro) registro;
				imprimirtodos();	
				}
			}
		public void imprimirtodos(){
		
			Console.Write("\nid:");
			Console.WriteLine(this.usuario.id);
			Console.Write("Nombre:");
			Console.WriteLine(this.usuario.nombre);
			Console.Write("Telefono:");
			Console.WriteLine(this.usuario.telefono);
			Console.Write("Domicilio:");
			Console.WriteLine(this.usuario.domicilio);
			}
		}
	}
