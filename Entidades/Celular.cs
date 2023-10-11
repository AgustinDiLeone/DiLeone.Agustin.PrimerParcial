using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Celular:DispositivoElectronico
    {
        protected double pulgadas;
        protected int almacenamiento;
        protected int ram;
        protected int cantCamaras;

        public double Pulgadas
        {
            get { return this.pulgadas; }

            set { this.pulgadas = value; }
        }
        public int Almacenamiento
        {
            get { return this.almacenamiento; }
            set { this.almacenamiento = value; }
        }
        public int Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public int CantCamaras
        {
            get { return this.cantCamaras; }
            set { this.cantCamaras = value; }
        }

        public Celular():base()
        {
            this.pulgadas = 0;
            this.almacenamiento = 0;
            this.ram = 0;
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
            this.ram = RAM;
        }
        public Celular(int id, int cantidad, double precio, string modelo, string marca, 
            EFactura tipoFactura, double pulgadas, int almacenamiento, int RAM,
            int cantCamaras) : base(id, cantidad, precio, modelo, marca, tipoFactura)
        {
            this.pulgadas = pulgadas;
            this.almacenamiento = almacenamiento;
            this.cantCamaras = cantCamaras;
            this.ram = RAM;
        }
        public override string MostrarVisor()
        {
            return ($"{base.marca} - {base.modelo} - {base.cantidad}Un - ${base.precioUnitario} - {this.pulgadas}In - {this.almacenamiento}Gb ROM - {this.ram}Gb ram");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"PULGADAS: {this.pulgadas}");
            sb.AppendLine($"ALMACENAMIENTO: { this.almacenamiento}");
            sb.AppendLine($"CANTIDAD DE CAMARAS: { this.cantCamaras}");
            sb.AppendLine($"RAM: {this.ram}");          
            return sb.ToString();
        }
        
    }
}
