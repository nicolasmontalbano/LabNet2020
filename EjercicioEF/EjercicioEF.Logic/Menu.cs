using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class Menu
    {

        ShippersLogic shippersLogic = new ShippersLogic();
        ProductsLogic productsLogic = new ProductsLogic();

        public void MyMenu()
        {
            bool aux = true;

            try
            {

                while (aux)
                {
                    Console.WriteLine("Ingrese una opcion: \n\n1)Consultar un producto por ID" +
                                                    "\n2)Consultar todos los productos" +
                                                    "\n3)Consultar un expedidor por ID" +
                                                    "\n4)Consultar todos los expedidores" +
                                                    "\n5)Salir");
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:

                            Console.WriteLine("Ingrese ID de producto");
                            int idProd = int.Parse(Console.ReadLine());
                            var product = productsLogic.GetOne(idProd);
                            Console.WriteLine($"\nID del producto: {product.ProductID}," +
                                                  $"\nNombre del producto: {product.ProductName}," +
                                                  $"\nCantidad por unidad: {product.QuantityPerUnit}," +
                                                  $"\nPrecio por unidad: {product.UnitPrice}," +
                                                  $"\nUnidades en stock: {product.UnitsInStock}," +
                                                  $"\nUnidades en orden: {product.UnitsOnOrder}\n");
                            break;
                        case 2:
                            var productos = productsLogic.GetAll();
                            foreach (var prod in productos)
                            {
                                Console.WriteLine($"ID del producto: {prod.ProductID}," +
                                                  $"\nNombre del producto: {prod.ProductName}," +
                                                  $"\nCantidad por unidad: {prod.QuantityPerUnit}," +
                                                  $"\nPrecio por unidad: {prod.UnitPrice}," +
                                                  $"\nUnidades en stock: {prod.UnitsInStock}," +
                                                  $"\nUnidades en orden: {prod.UnitsOnOrder}\n");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese ID de expedidor" +
                                "");
                            int idShip = int.Parse(Console.ReadLine());
                            var shipper = shippersLogic.GetOne(idShip);
                            Console.WriteLine($"\nID del expedidor: {shipper.ShipperID}," +
                                                  $"\nNombre de la compania: {shipper.CompanyName}," +
                                                  $"\nTelefono: {shipper.Phone}\n");
                            break;
                        case 4:
                            var shippers = shippersLogic.GetAll();
                            foreach (var ship in shippers)
                            {
                                Console.WriteLine($"\nID del expedidor: {ship.ShipperID}," +
                                                  $"\nNombre de la compania: {ship.CompanyName}" +
                                                  $"\nTelefono: {ship.Phone}\n");
                            }
                            break;
                        case 5:
                            aux = false;
                            break;

                        default:
                            Console.WriteLine("\nOpcion incorrecta\n");
                            break;
                    }
                }

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"No existe el ID ingresado");
            }

            Console.WriteLine("Presione una tecla para salir");

            Console.ReadKey();

        }

    }
}