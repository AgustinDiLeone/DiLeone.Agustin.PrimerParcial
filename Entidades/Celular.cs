using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular:DispositivoElectronico
    {
        protected double pulgadas;
        protected int almacenamiento;
        protected int RAM;
        protected int cantCamaras;

        public Celular()
        {
            this.pulgadas = 0;
            this.almacenamiento = 0;
            this.RAM = 0;
            this.cantCamaras = 0;

        }
        public Celular(int id, int cantidad, double precio) : base(id, cantidad, precio){}
        public Celular(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura) : base(id, cantidad, precio, modelo, marca, tipoFactura) { }
        public Celular(int id, int cantidad, double precio, double pulgadas, int almacenamiento,
            int RAM, int cantCamaras) :base(id, cantidad, precio)
        {
            this.pulgadas = pulgadas;
            this.almacenamiento = almacenamiento;
            this.cantCamaras = cantCamaras;
            this.RAM = RAM;
        }
        public Celular(int id, int cantidad, double precio, string modelo, string marca, 
            EFactura tipoFactura, double pulgadas, int almacenamiento, int RAM,
            int cantCamaras) : base(id, cantidad, precio, modelo, marca, tipoFactura)
        {
            this.pulgadas = pulgadas;
            this.almacenamiento = almacenamiento;
            this.cantCamaras = cantCamaras;
            this.RAM = RAM;
        }
        public override string MostrarVisor()
        {
            return ($"{base.marca} - {base.modelo} - {base.cantidad}Un - ${base.precioUnitario} - {this.almacenamiento}Gb ROM - {this.RAM}Gb RAM");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"PULGADAS: {this.pulgadas}");
            sb.AppendLine($"ALMACENAMIENTO: { this.almacenamiento}");
            sb.AppendLine($"CANTIDAD DE CAMARAS: { this.cantCamaras}");
            sb.AppendLine($"RAM: {this.RAM}");          
            return sb.ToString();
        }
        
    }
}
