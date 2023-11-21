﻿using edu.Pr.EjercicioAñadirClientes.Dtos;
using edu.Pr.EjercicioAñadirClientes.Servicios;

namespace edu.Pr.EjercicioAñadirClientes.Controladores
{
    /// <summary>
    /// Clase principal de la aplicaión.
    /// <author>CMR-211123</author>
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método main de la aplicación, es el núcleo procedimental.
        /// <author>CMR-211123</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ClienteDtos> listaCLiente = new List<ClienteDtos>();
            List<CuentaBancariaDtos> ListaCuentaBancaria = new List<CuentaBancariaDtos>();
            
            MenuInterfaz mi = new MenuImplementacion();
           ClienteInterfaz oi = new ClienteImplementacion();
            CuentaBancInterfaz ci = new CuentaBancImplementacion();
                

            
            bool cerrarMenu = false;
         
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - ALTA NUEVO CLIENTE");
                        oi.darAltaCliente(listaCLiente);
                        break;

                    case 2:
                        Console.WriteLine("[INFO] - ALTA NUEVA CUENTA BANCARIA");
                        ci.DarAltaCuentaBancaria(ListaCuentaBancaria);
                        break;

                    default:
                        Console.WriteLine("[INFO] - Esta opción no coincide con ninguna");
                        break;
                }
            }

        }
        
    }
}