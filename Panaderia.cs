using System;
using System.Collections.Generic;

namespace ProyectoPanaderia
{
    class Panaderia
    {
        public List<Servicio> ListaServicios { get; set; }
        public List<Cliente> ListaClientes { get; set; }
        public List<Pedido>  ListaPedidos { get; set; }
        public int ContadorP { get; set; }
        
        public Panaderia()
        {
            ListaServicios = new List<Servicio>();
            ListaClientes = new List<Cliente>();
            ListaPedidos = new List<Pedido>();
            ContadorP = 1;

            ListaServicios.Add(new Servicio("tortas", "tortas evento", "torta de chocolate", 20000));
            ListaServicios.Add(new Servicio("bebidas", "bebida evento", "gaseosa", 50000));
            ListaClientes.Add(new Cliente("maria", "Ayala", 39406466, "1234892498", "Rep de Francia"));
            ListaClientes.Add(new Cliente("facundo", "Ayala", 12345678, "9876543", "Cariboni"));

        }



    }
}
