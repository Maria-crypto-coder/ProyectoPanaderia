/*
 * Created by SharpDevelop.
 * User: ayala
 * Date: 17/5/2023
 * Time: 01:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProyectoPanaderia
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	class PedidosException : Exception
	{
	    public PedidosException(string message) : base(message) 
	    {
		}
	}
}
