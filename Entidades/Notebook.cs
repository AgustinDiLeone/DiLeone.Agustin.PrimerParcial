using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Notebook:DispositivoElectronico
    {
        protected double pulgadas;
        protected int resolucion;
        protected int almacenamiento;
        protected int RAM;
        protected string sistemaOperativo;
        protected bool SSD;

        public Notebook()
        {

            this.pulgadas = 0;
            this.almacenamiento = 0;
            this.resolucion = 0;
            this.RAM = 0;
            this.sistemaOperativo = "NO SE INGRESO";

        }
        public Notebook(int id, int cantidad, double precio) : base(id, cantidad, precio) { }
        public Notebook(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura) : base(id, cantidad, precio, modelo, marca, tipoFactura) { }
        public Notebook(int id, int cantidad, double precio, double pulgadas, int almacenamiento,
            int RAM, int resolucion, string sistemaOperativo) : base(id, cantidad, precio)
        {
            this.pulgadas = pulgadas;
            this.almacenamiento = almacenamiento;
            this.resolucion = resolucion;
            this.sistemaOperativo = sistemaOperativo;
            this.RAM = RAM;
        }
        public Notebook(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int almacenamiento, int RAM,
             int resolucion, string sistemaOperativo, bool SSD) : base(id, cantidad, precio, modelo, marca, tipoFactura)
        {
            this.pulgadas = pulgadas;
            this.almacenamiento = almacenamiento;
            this.resolucion = resolucion;
            this.sistemaOperativo = sistemaOperativo;
            this.RAM = RAM;
            this.SSD = SSD;
        }
        public override string MostrarVisor()
        {
            return ($"{base.marca} - {base.modelo} - {base.cantidad}Un - ${base.precioUnitario} -" +
                $" {this.pulgadas}In - {this.resolucion}px - {this.sistemaOperativo}");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"PULGADAS: {this.pulgadas}");
            sb.AppendLine($"ALMACENAMIENTO: {this.almacenamiento}");
            sb.AppendLine($"RAM: {this.RAM}");
            sb.AppendLine($"RESOLUCION: {this.resolucion}");
            sb.AppendLine($"SISTEMA OPERATIVO: {this.sistemaOperativo}");

            return sb.ToString();
        }
    }
}
