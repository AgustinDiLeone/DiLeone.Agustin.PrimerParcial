using System.Text;

namespace Entidades
{
    public abstract class DispositivoElectronico
    {
        protected int id;
        protected DateTime horaCompra;
        protected int cantidad;
        protected string marca;
        protected string modelo;
        protected double precioUnitario;
        protected EFactura tipoFactura;
        protected bool entregado;

        public abstract string MostrarVisor();

        public DispositivoElectronico()
        {
            this.id = -1;
            this.horaCompra = DateTime.Now;
            this.cantidad = -1;
            this.precioUnitario = -1;
            this.tipoFactura = EFactura.A;
            this.marca = "NO SE INGRESO";
            this.modelo = "NO SE INGRESO";

        }
        public DispositivoElectronico(int id, int cantidad, double precio) : this()
        {
            this.id = id;
            this.cantidad = cantidad;
            this.precioUnitario = precio;

        }
        public DispositivoElectronico(int id, int cantidad, double precio, string marca, string modelo) : this(id, cantidad, precio)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public DispositivoElectronico(int id, int cantidad, double precio, string modelo, string marca, EFactura tipoFactura) : this(id,cantidad, precio, modelo, marca)
        {
            this.tipoFactura = tipoFactura;
        }


        public static bool operator ==(DispositivoElectronico a, DispositivoElectronico b)
        {
            return a.id == b.id && a.horaCompra == b.horaCompra;
        }
        public static bool operator !=(DispositivoElectronico a, DispositivoElectronico b)
        {
            return !(a == b);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is DispositivoElectronico)
            {
                retorno = this == (DispositivoElectronico)obj;
            }
            return base.Equals(obj);
        }

        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"HORA DE COMPRA: {this.horaCompra.ToString()}");
            sb.AppendLine($"CANTIDAD: {this.cantidad}");
            sb.AppendLine($"PRECIO UNITARIO: {this.precioUnitario.ToString()}");
            sb.AppendLine($"MARCA: {this.marca}");
            sb.AppendLine($"MODELO: {this.modelo}");
            sb.AppendLine($"FACTURA TIPO: {this.tipoFactura.ToString()}");
            return sb.ToString();
        }

    }

}