using EjercicioEF.Data;
using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class Menu
    {
        NorthwindContext context = new NorthwindContext();

        

        public void MyMenu()
        {
            ShippersLogic shippersLogic = new ShippersLogic(context);
            ProductsLogic productsLogic = new ProductsLogic(context);
            bool aux = true;

            try
            {

                while (aux)
                {
                    Console.WriteLine("Ingrese una opcion: \n\n1)Consultar un producto por ID" +
                                                    "\n2)Consultar todos los productos" +
                                                    "\n3)Consultar un expedidor por ID" +
                                                    "\n4)Consultar todos los expedidores" +
                                                    "\n5)ABM" +
                                                    "\n6)Salir");
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
                            Console.WriteLine("Ingrese una opcion: \n\n1)Ingresar producto" +
                                                    "\n2)Modificar producto por ID" +
                                                    "\n3)Eliminar producto por ID" +
                                                    "\n\n4)Ingresar expedidor" +
                                                    "\n5)Modificar expedidor por ID" +
                                                    "\n6)Eliminar expedidor por ID" +
                                                    "\n\n7)Volver");
                            int n2 = int.Parse(Console.ReadLine());
                            switch (n2)
                            {
                                case 1:

                                    Products nuevoProducto = new Products();
                                    Console.WriteLine("Ingrese el nombre del producto");
                                    nuevoProducto.ProductName = Console.ReadLine();
                                    Console.WriteLine("Ingrese cantidad por unidad");
                                    nuevoProducto.QuantityPerUnit = Console.ReadLine();
                                    Console.WriteLine("Ingrese precio por unidad");
                                    nuevoProducto.UnitPrice = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese unidades en stock");
                                    nuevoProducto.UnitsInStock = short.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese unidades en orden");
                                    nuevoProducto.UnitsOnOrder = short.Parse(Console.ReadLine());
                                    productsLogic.Insert(nuevoProducto);
                                    break;

                                case 2:

                                    Products productoAModificar = new Products();
                                    Console.WriteLine("Ingrese el ID del producto a modificar");
                                    int idProdAModificar = int.Parse(Console.ReadLine());                                   
                                    Console.WriteLine("Ingrese el nombre del producto");
                                    productoAModificar.ProductName = Console.ReadLine();
                                    Console.WriteLine("Ingrese cantidad por unidad");
                                    productoAModificar.QuantityPerUnit = Console.ReadLine();
                                    Console.WriteLine("Ingrese precio por unidad");
                                    productoAModificar.UnitPrice = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese unidades en stock");
                                    productoAModificar.UnitsInStock = short.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese unidades en orden");
                                    productoAModificar.UnitsOnOrder = short.Parse(Console.ReadLine());
                                    productsLogic.Update(productoAModificar, idProdAModificar);
                                    break;

                                case 3:

                                    Console.WriteLine("Ingrese el ID del producto a eliminar");
                                    int idProdAEliminar = int.Parse(Console.ReadLine());
                                    productsLogic.Delete(idProdAEliminar);
                                    break;

                                case 4:

                                    Shippers nuevoExpedidor = new Shippers();
                                    Console.WriteLine("Ingrese el nombre de la empresa");
                                    nuevoExpedidor.CompanyName = Console.ReadLine();
                                    Console.WriteLine("Ingrese el telefono");
                                    nuevoExpedidor.Phone = Console.ReadLine();
                                    shippersLogic.Insert(nuevoExpedidor);
                                    break;
                                case 5:

                                    Shippers expedidorAModificar = new Shippers();
                                    Console.WriteLine("Ingrese el ID del expedidor a modificar");
                                    int idExpAModificar = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el nombre de la empresa a modificar");
                                    expedidorAModificar.CompanyName = Console.ReadLine();
                                    Console.WriteLine("Ingrese el telefono a modificar");
                                    expedidorAModificar.Phone = Console.ReadLine();
                                    shippersLogic.Update(expedidorAModificar, idExpAModificar);
                                    break;

                                case 6:

                                    Console.WriteLine("Ingrese el ID del expedidor a eliminar");
                                    int idExpAEliminar = int.Parse(Console.ReadLine());
                                    shippersLogic.Delete(idExpAEliminar);
                                    break;

                                default:
                                    Console.WriteLine("Ingrese una opcion correcta");
                                    break;
                            }
                            break;
                        case 6:
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