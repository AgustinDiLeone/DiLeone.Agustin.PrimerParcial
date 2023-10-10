using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Televisor : DispositivoElectronico
    {
        protected double pulgadas;
        protected double resolucion;
        protected bool smartTv;


        public Televisor()
        {
            this.pulgadas = 0;
            this.resolucion = 0;

        }
        public Televisor(int id, int cantidad, double precio) : base(id, cantidad, precio) { }
        public Televisor(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura) : base(id, cantidad, precio, modelo, marca, tipoFactura) { }
        public Televisor(int id, int cantidad, double precio, double pulgadas, int resolucion,
            bool smartTv) : base(id, cantidad, precio)
        {
            this.pulgadas = pulgadas;
            this.resolucion = resolucion;
            this.smartTv = smartTv;
        }
        public Televisor(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int resolucion,
            bool smartTv) : base(id, cantidad, precio, modelo, marca, tipoFactura)
        {
            this.pulgadas = pulgadas;
            this.resolucion = resolucion;
            this.smartTv = smartTv;
        }
        public override string MostrarVisor()
        {
            string visor = ($"{base.marca} - {base.modelo} - {base.cantidad}Un - ${base.precioUnitario} - {this.pulgadas}In - {this.resolucion}px ");
            if (this.smartTv)
            {
                visor += "- SMART TV: SI";
            }
            else
            {
                visor += "- SMART TV: NO";
            }
            return visor;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"PULGADAS: {this.pulgadas}");
            sb.AppendLine($"RESOLUCION: {this.resolucion}px");
            if ( this.smartTv )
            {
                sb.AppendLine($"SMART TV: SI");
            }
            else
            {
                sb.AppendLine($"SMART TV: NO");
            }

            return sb.ToString();
        }

    }
}
