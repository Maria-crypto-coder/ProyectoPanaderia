/*
 * Created by SharpDevelop.
 * User: ayala
 * Date: 12/5/2023
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProyectoPanaderia
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	class Cliente 
	{
	    private string nombre;
	    private string apellido;
	    private int dni;
	    private string telefono;
	    private string direccion;
	
	    public Cliente(string nombre, string apellido, int dni, string telefono, string direccion) {
	        this.nombre = nombre;
	        this.apellido = apellido;
	        this.dni = dni;
	        this.telefono = telefono;
	        this.direccion = direccion;
	    }
	
		public string Nombre{
	    	get{return nombre;}
	    	set{nombre = value;}
	    }
	    public string Apellido{
	    	get{return apellido;}
	    	set{apellido = value;}
	    }
	    public int Dni{
	    	get{return dni;}
	    	set{dni = value;}
	    }
	    public string Telefono{
	    	get{return telefono;}
	    	set{telefono = value;}
	    }
	    public string Direccion{
	    	get{return direccion;}
	    	set{direccion = value;}
	    }
	}
}
