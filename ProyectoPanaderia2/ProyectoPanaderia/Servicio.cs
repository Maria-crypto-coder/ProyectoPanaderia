/*
 * Created by SharpDevelop.
 * User: ayala
 * Date: 12/5/2023
 * Time: 17:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProyectoPanaderia
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	class Servicio 
	{
	    private string nombre;
	    private string tiposerv;
	    private string descripcion;
	    private int costoind;
	
	    public Servicio(string nombre, string tiposerv, string descripcion, int costoind) {
	        this.nombre = nombre;
	        this.tiposerv = tiposerv;
	        this.descripcion = descripcion;
	        this.costoind = costoind;
	    }
	    public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
	    public string Tiposerv{
	    	get{return tiposerv;}
	    	set{tiposerv = value;}
	    }
	    public string Descripcion{
	    	get{return descripcion;}
	    	set{descripcion = value;}
	    }
	    public int Costoind{
	    	get{return costoind;}
	    	set{costoind = value;}
	    }
	}
}

