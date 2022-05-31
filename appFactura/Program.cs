using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appFactura
{
    internal class Program
    {
        public static string[] articulos = { "Camisas", "Pantalones", "Zapatos" }; //Arreglo de los articulos 
        public static int[] precios = { 4500, 11000, 3000 }; //Arreglo de los precios 
        public static double cantDescuento = 0.05; //Atributo de descuento 
        public static double iva = 0.13;//Atributo de iva 
        static void Main(string[] args)
        {
            bool salir = false; //Bandera para el ciclo 

            while (!salir) //Ciclo 
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos a Boutique Jose Paolo");

                compraArticulos();
                Console.ReadLine();

                Console.WriteLine("Si desea salir del aplicativo precione 1 o 2 si desea realizar otra compra");
                int indiceSeleccionado = int.Parse(Console.ReadLine());

                if(indiceSeleccionado == 1)
                {
                    try
                    {
                        salir = true;
                    }catch (Exception e)
                    {
                        Console.WriteLine("Presione lo que se le solicita en el mensaje");
                    }
                    
                }
                else
                {
                    try
                    {
                        salir = false;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Presione lo que se le solicita en el mensaje");
                    }
                }
            }
            
           

            



        }
        //Metodo para ver articulos y comprar articulos 

        public static string compraArticulos()
        {
            string retornar = "";
            try
            {
               
                Console.WriteLine("Articulos: " + "\n" + "CODIGO      ARTICULO      PRECIO");
                for (int i = 0; i < articulos.Length; i++)
                {
                    int indice = i + 1;
                    Console.WriteLine(indice + "   " + articulos[i] + "   ¢" + precios[i]);
                }
                Console.WriteLine("************************");

                //Cliente selecciona el articulo y ve la factura 
                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Selecciones el código del articulo deseado: ");
                    int indiceSeleccionado = int.Parse(Console.ReadLine());

                    Console.Write("Selecciones  la cantidad de articulos deseados: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    float totalAPagarPorArticulo = precios[indiceSeleccionado - 1] * cantidad;
                    double sacarIva = totalAPagarPorArticulo * iva;
                    double totalAPagarConIva = totalAPagarPorArticulo + sacarIva;
                    double descuentoTotal = totalAPagarConIva * cantDescuento;
                    double totalConDescuento = totalAPagarConIva + descuentoTotal;

                    retornar = "El total a pagar por articulos seleccionados es " + totalAPagarPorArticulo + "\n" +
                               "Iva " + sacarIva + "\n" +
                               "Monto a pagar con impuesto " + totalAPagarConIva + "\n" +
                               "El descuento es de " + descuentoTotal + "\n" +
                               "Monto total a pagar " + totalConDescuento;
                }

                Console.WriteLine("************************");
                Console.WriteLine(retornar);

                return retornar;
            }catch (Exception e)
            {
                retornar = "Digite un codigo valido";
                Console.WriteLine(retornar);
                return retornar;
                
            }
            
        }
    }
}
