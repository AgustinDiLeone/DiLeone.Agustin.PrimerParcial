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
        protected int cuit;
        protected ETipos tipoCliente;

        public Cliente() 
        {   
            this.cuit = 00000000000;
            this.nombreEmpresa = "NO SE INGRESO";
            this.tipoCliente = ETipos.ConsumidorFinal;
            this.ubicación = "NO SE INGRESO";
        }
        public Cliente(int cuit)
        {
            this.cuit = cuit;
        }
        public Cliente(int cuit, string nombreEmpresa, ETipos tipoCliente):this(cuit)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.tipoCliente = tipoCliente;
        }
        public Cliente(string nombreEmpresa, int cuit) : this(cuit)
        {
            this.nombreEmpresa = nombreEmpresa;
        }
        public Cliente(string nombreEmpresa, int cuit, ETipos tipoCliente, string ubicacion):this (cuit, nombreEmpresa, tipoCliente) 
        {
            this.ubicación = ubicacion;
        }
    }
}
