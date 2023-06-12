/*
 * Created by SharpDevelop.
 * User: ayala
 * Date: 12/5/2023
 * Time: 17:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;


namespace ProyectoPanaderia
{
		class Program 
		{
		    public static List<Servicio> ListaServicios = new List<Servicio>();
		    public static List<Cliente> ListaClientes = new List<Cliente>();
		    public static List<Pedido> ListaPedidos = new List<Pedido>();
		    public static int contadorP = 1;
		
		    public static void Main(string[] args) 
		    {
		        ListaServicios.Add(new Servicio("comida", "comida evento", "tallarines", 20000));
		        ListaServicios.Add(new Servicio("bebidas", "bebida evento", "gaseosa", 50000));
		        ListaClientes.Add(new Cliente("maria", "Ayala",39406466 ,"1234892498", "Rep de Francia"));
		        ListaClientes.Add(new Cliente("facundo", "Ayala",12345678 ,"9876543", "Cariboni"));
		        
			bool salir = false;
		
		        while (!salir) {
		        	
		            Console.WriteLine("Menu de opciones:");
		            Console.WriteLine("1- agregar un servicio");
		            Console.WriteLine("2- eliminar un servicio");
		            Console.WriteLine("3- ver lista de servicios");
		            Console.WriteLine("4- tomar un pedido");
		            Console.WriteLine("5- mostrar pedidos");
		            Console.WriteLine("6- lista de clientes");
		           
		            Console.WriteLine("8- Registrar pago");
		            Console.WriteLine("9- baja de un pedido");
		            Console.WriteLine("0- salir");
		
		            Console.Write("Elegir una opcion: ");
		            string opcion = Console.ReadLine();
		
		            switch (opcion) {
		                case "1":
		            		AgregarUnServicio();
		                    break;
		                case "2":
		                    BorrarServ();
		                    break;
		                case "3":
		                    MostrarListadeServicios();
		                    break;
		                case "4":
		                    TomarUnPedido();
		                    break;
		                case "5":
		                    MostrarListadePedidos();
		                    break;
		                case "6":
		                    MostrarListadeClientes();
		                    break;
		                case "7":
						    break;
						case "8":
						    RegistrarUnPago();
						    break;
						case "9":
						    BajarPedido();
						    break;
		                case "0":
							salir = true;
		                    break;
		                default:
		                    Console.WriteLine("Opción invalida.");
		                    break;
		            }
		
		            Console.WriteLine();
		        }
		    }
		    
			public static void BorrarServ()
			{
				
		        Console.Write("nombre del servicio a eliminar: ");
		        string nombre = Console.ReadLine();
		
		        bool encontrar = false;
		        for (int i = 0; i < ListaServicios.Count; i++) {
		            if (ListaServicios[i].Nombre == nombre) {
		                ListaServicios.RemoveAt(i);
		                encontrar = true;
		                break;
		            }
		        }
		        if (encontrar) 
		        {
		            Console.WriteLine("eliminado");
		        } 
		        else 
		        {
		            Console.WriteLine("no se encontro el servicio");
		        }
		        Console.WriteLine("Presionar cualquier tecla para volver");
			    Console.ReadKey();
			    Console.Clear();
			}
		    
			public static void AgregarUnServicio()
			{
		        Console.Write("nombre del servicio: ");
		        string nombre = Console.ReadLine();
		        Console.Write("tipo de servicio: ");
		        string tipo = Console.ReadLine();
		        Console.Write("descripción del servicio: ");
		        string descripcion = Console.ReadLine();
		        Console.Write("costo del servicio: ");
		        int costo = int.Parse(Console.ReadLine());
		
		        Servicio s = new Servicio(nombre, tipo, descripcion, costo);
		        ListaServicios.Add(s);
		
		        Console.WriteLine("agregado");
		        Console.WriteLine("/nPresionar cualquier tecla para volver");
			    Console.ReadKey();
			    Console.Clear();
			
			}
		    
		    public static void TomarUnPedido() {
		        Console.Write("DNI del cliente: ");
		        int dni = int.Parse(Console.ReadLine());
		        Console.Write("fecha del evento(DD/MM/AAAA): ");
		        DateTime fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
		        Console.Write("nombre del servicio del pedido (separados por /): ");
		        string nom = Console.ReadLine();
		        Console.Write("seña del pedido: ");
		        int seña = int.Parse(Console.ReadLine());
		        int costoTotal = 0;
		
		        Cliente c = BuscarC(dni);	
		        
		        if (c == null) {
		            Console.Write("nombre del cliente: ");
		            string nombre = Console.ReadLine();
		            Console.Write("apellido: ");
		            string apellido = Console.ReadLine();
		            Console.Write("telefono: ");
		            string telefono = Console.ReadLine();
		            Console.Write("direccion:");
		            string direccion = Console.ReadLine();
		
		            c = new Cliente(nombre, apellido, dni, telefono, direccion);
		            ListaClientes.Add(c);
		        }
		
		        string[] nombreS = nom.Split('/');
		        List<Servicio> PedidosS = new List<Servicio>();
		
		        foreach (string servicioN in nombreS) {
		            Servicio s = BuscarS(servicioN);
		
		            if (s != null) {
		                PedidosS.Add(s);
		                costoTotal += s.Costoind;
		            }
		        }
		if(PedidosS.Count == 0) {
		            Console.WriteLine("no se encontraron servicios");
		            return;
		        }
		        
		        try{
		        	if((int)PedidosFecha(fecha) >=2)
		        	{
		        		throw new PedidosException("yatiene 2 pedidos para esta fecha");
		        	}
		        }
		        catch(PedidosException ex)
		        {
		        	Console.WriteLine("se capturo una excepcion: " + ex.Message);
		        }
		        
		        Pedido p = new Pedido(contadorP, c, fecha, PedidosS, costoTotal, seña, costoTotal - seña);
		        ListaPedidos.Add(p);
		        contadorP++;
		
		        Console.WriteLine("registrado");
		        Console.WriteLine("Presionar cualquier tecla para volver");
			    Console.ReadKey();
			    Console.Clear();
		    }
			
			public static void RegistrarUnPago()
			{
			    Console.Write("codigo del pedido: ");
			    int codigo = int.Parse(Console.ReadLine());
			    Console.Write("monto a pagar: ");
			    int montoPagar = int.Parse(Console.ReadLine());
			
			    Pedido p = BuscarP(codigo);
			
			    if (p != null)
			    {
			        int saldoActual = p.CostoT - p.Seña;
			
			        if (montoPagar >= saldoActual)
			        {
			            p.Seña += saldoActual;
			            p.Saldo = 0;
			            Console.WriteLine("pago registrado, el saldo del pedido se abono completamente");
			        }
			        else
			        {
			            p.Seña += montoPagar;
			            p.Saldo -= montoPagar;
			            Console.WriteLine("registrado, se redujo el saldo");
			        }
			    }
			    else
			    {
			        Console.WriteLine("no se encontro el pedido con ese codigo");
			    }
			
			    Console.WriteLine("Presionar cualquier tecla para volver al menu");
			    Console.ReadKey();
			    Console.Clear();
			}
			
			public static Pedido BuscarP(int codigo) {
		        foreach (Pedido p in ListaPedidos) {
		            if (p.Cod == codigo) {
		                return p;
		            }
		        }
		        return null;
		    }


			public static void BajarPedido()
			{
			    Console.Write("codigo del pedido a dar de baja: ");
			    int codP = int.Parse(Console.ReadLine());
			
			    Pedido p = BuscarP(codP);
			
			    if (p != null)
			    {
			        DateTime fechaActual = DateTime.Now.Date;
			        if (p.Fecha > fechaActual.AddMonths(1))
			        {
			            Console.Write("cancelado");
			            Console.Write("no se reintegra la seña");
			        }
			        else if(p.Fecha == fechaActual && p.Saldo ==0)
			        {
			        	ListaPedidos.Remove(p);
			        	Console.WriteLine("eliminado");
			        }
			        else
			        {
			        	Console.WriteLine("debe pagar el servicio completo");
			        	p.Saldo=p.CostoT;
			        	p.Seña=0;
			        }
			    }
			    else
			    {
			    	Console.WriteLine("no se encontro el pedido");
			    }
			    Console.WriteLine("Presionar cualquier tecla para volve");
			    Console.ReadKey();
			    Console.Clear();
			                  
			}

			
			public static object PedidosFecha(DateTime fecha)
			{
		        int contador = 0;
		        foreach (Pedido p in ListaPedidos) {
		            if (p.Fecha == fecha) {
		                contador++;
		            }
		        }
		        return contador;
		    }			
			public static Servicio BuscarS(string nombreS)
			{
		        foreach (Servicio s in ListaServicios) {
		            if (s.Nombre.ToLower() == nombreS.ToLower()) {
		                return s;
		            }
		        }
		
		        return null;
		    }
			
			public static void MostrarListadeServicios()
		    {
		        Console.WriteLine("Lista de Servicios:");
		        foreach (Servicio s in ListaServicios)
		        {
		            Console.WriteLine(s.Nombre);
		        }
		        
		        Console.WriteLine("Presionar cualquier tecla para volver");
			    Console.ReadKey();
			    Console.Clear();
		    }

		
		    public static Cliente BuscarC(int dni) {
		        foreach (Cliente c in ListaClientes) {
		            if (c.Dni == dni) {
		                return c;
		            }
		        }
		
		        return null;
		    }
		
		    
		
		    public static void MostrarListadePedidos() {
		        Console.Write("DNI del cliente para ver los pedidos: ");
		        int dni = int.Parse(Console.ReadLine());
		
		        Cliente c = BuscarC(dni);
		
		        if (c == null) {
		            Console.WriteLine("no se encontro el cliente. xv");
		            return;
		        }
		
		        Console.WriteLine("Pedidos del cliente " + c.Nombre + " " + c.Apellido + ":");
		
		        foreach (Pedido p in ListaPedidos) {
		            if (p.clientes == c) {
		                Console.WriteLine("codigo: " + p.Cod);
		                Console.WriteLine("fecha del evento: " + p.Fecha);
		                Console.WriteLine("servicio: ");
		
		                foreach (Servicio s in p.Servicios) {
		                    Console.WriteLine("- " + s.Nombre + ": $" + s.Costoind);
		                }
		
		                Console.WriteLine("costo total: $" + p.CostoT);
		                Console.WriteLine("seña: $" + p.Seña);
		                Console.WriteLine("saldo: $" + p.Saldo);
		                Console.WriteLine();
		            }
		        }
		        
		        Console.WriteLine("Presionar cualquier tecla para volver");
			    Console.ReadKey();
			    Console.Clear();
		    }
			
			public static void MostrarListadeClientes()
			{
			    Console.Clear();
			    Console.WriteLine("Lista de clientes:");
			    
			    foreach (Cliente c in ListaClientes)
			    {
			        Console.WriteLine("nombre: " + c.Nombre + " " + c.Apellido);
			        Console.WriteLine("DNI: "+ c.Dni);
			        Console.WriteLine("telefono: " + c.Telefono);
			        Console.WriteLine("direccion: "+ c.Direccion);
			        Console.WriteLine("-----------------------------");
			    }
			    
			    Console.WriteLine("Presionar cualquier tecla para volver");
			    Console.ReadKey();
			    Console.Clear();
			}

		}
}