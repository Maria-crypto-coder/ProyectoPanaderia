/*
 * Created by SharpDevelop.
 * User: ayala
 * Date: 12/5/2023
 * Time: 17:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ProyectoPanaderia
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	 class Pedido 
	{
	    private int cod;
	    private Cliente cliente;
	    private DateTime fecha;
	    private List<Servicio> servicio;
	    private int costoT;
	    private int seña;
	    private int saldo;
	
		public Pedido(int cod, Cliente cliente, DateTime fecha, List<Servicio> servicio, int costoT, int seña, int saldo) {
		        this.cod = cod;
		        this.cliente = cliente;
		        this.fecha = fecha;
		        this.servicio = servicio;
		        this.costoT = costoT;
		        this.seña = seña;
		        this.saldo = saldo;
		    }
	    public int Cod{
	    	get{return cod;}
	    	set{cod = value;}
	    }
	     public Cliente clientes{
	    	get{return cliente;}
	    	set{cliente = value;}
	    }
	     public DateTime Fecha{
	    	get{return fecha;}
	    	set{fecha = value;}
	    }
	     public List<Servicio> Servicios{
	    	get{return servicio;}
	    	set{servicio = value;}
	    }
	     public int CostoT{
	    	get{return costoT;}
	    	set{costoT = value;}
	    }
	     public int Seña{
	    	get{return seña;}
	    	set{seña = value;}
	    }
	     public int Saldo{
	    	get{return saldo;}
	    	set{saldo = value;}
	    }
	    
	}
}
