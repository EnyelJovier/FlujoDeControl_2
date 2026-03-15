
using System;

namespace Examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductoElectronico prod1 = new ProductoElectronico();
            prod1.Nombre = "Laptop";
            prod1.Codigo = "P1001";
            prod1.Precio = 45000;
            prod1.Cantidad = 5;
            prod1.MesesGarantia = 12;

            Console.WriteLine("PRODUCTO ELECTRONICO:");
            prod1.MostrarProducto();

            ProductoAlimento prod2 = new ProductoAlimento();
            prod2.Nombre = "Leche";
            prod2.Codigo = "A2002";
            prod2.Precio = 75;
            prod2.Cantidad = 20;
            prod2.Vencimiento = "15/05/2026";

            Console.WriteLine("\nDATOS ALIMENTO:");
            prod2.MostrarProducto();
        }

        public class Producto
        {
            // ATRIBUTOS PRIVADOS
            private string nombre;
            private string codigo;
            private double precio;
            private int cantidad;

            public Producto() { }

            // PROPIEDADES
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public double Precio
            {
                get { return precio; }
                set { precio = value; }
            }

            public int Cantidad
            {
                get { return cantidad; }
                set { cantidad = value; }
            }

            public virtual double CalcularImpuesto() => 0;

            public virtual void MostrarProducto()
            {
                Console.WriteLine("Articulo: " + Nombre);
                Console.WriteLine("Codigo: " + Codigo);
                Console.WriteLine("Precio: " + Precio);
                Console.WriteLine("Cantidad: " + Cantidad);
            }
        }

        public class ProductoElectronico : Producto
        {
            private int mesesGarantia;

            public int MesesGarantia
            {
                get { return mesesGarantia; }
                set { mesesGarantia = value; }
            }

            public ProductoElectronico() { }

            public override double CalcularImpuesto()
            {
                return Precio * 0.18;
            }

            public override void MostrarProducto()
            {
                base.MostrarProducto();
                Console.WriteLine("Garantia: " + MesesGarantia + " meses");
                Console.WriteLine("Impuesto: " + CalcularImpuesto());
            }
        }

        public class ProductoAlimento : Producto
        {
            private string vencimiento;

            public string Vencimiento
            {
                get { return vencimiento; }
                set { vencimiento = value; }
            }

            public ProductoAlimento() { }

            public override double CalcularImpuesto()
            {
                return Precio * 0.08;
            }

            public override void MostrarProducto()
            {
                base.MostrarProducto();
                Console.WriteLine("Vence el: " + Vencimiento);
                Console.WriteLine("Impuesto calculado : " + CalcularImpuesto());
            }
        }
    }
}