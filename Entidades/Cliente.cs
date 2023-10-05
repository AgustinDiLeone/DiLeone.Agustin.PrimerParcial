using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        protected string nombreEmpresa;
        protected string ubicación;
        protected long cuit;
        protected ETipos tipoCliente;

        public Cliente() 
        {   
            this.cuit = 10000000001;
            this.nombreEmpresa = "NO SE INGRESO";
            this.tipoCliente = ETipos.ConsumidorFinal;
            this.ubicación = "NO SE INGRESO";
        }
        public Cliente(long cuit):this()
        {
            this.cuit = cuit;
        }
        public Cliente(long cuit, string nombreEmpresa, ETipos tipoCliente):this(cuit)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.tipoCliente = tipoCliente;
        }
        public Cliente(string nombreEmpresa, long cuit) : this(cuit)
        {
            this.nombreEmpresa = nombreEmpresa;
        }
        public Cliente(long cuit, string nombreEmpresa,  ETipos tipoCliente, string ubicacion):this (cuit, nombreEmpresa, tipoCliente) 
        {
            this.ubicación = ubicacion;
        }
        public static bool operator ==(Cliente a, Cliente b)
        {
            return a.cuit == b.cuit && a.nombreEmpresa == b.nombreEmpresa;
        }
        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Cliente)
            {
                retorno = this == (Cliente)obj;
            }
            return base.Equals(obj);
        }
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE / EMPRESA: {this.nombreEmpresa} \nCUIT: {this.cuit}\nTIPO: {this.tipoCliente.ToString()} \nUBICACION: {this.ubicación}");

            return sb.ToString();
        }

    }
}
