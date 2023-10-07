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

        private List<DispositivoElectronico> dispositivos;

        public List<DispositivoElectronico> Dispositivos
        {
            get { return this.dispositivos; }
        }


        public Cliente() 
        {   
            this.cuit = 10000000001;
            this.nombreEmpresa = "NO SE INGRESO";
            this.tipoCliente = ETipos.ConsumidorFinal;
            this.ubicación = "NO SE INGRESO";
            this.dispositivos = new List<DispositivoElectronico>();
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
                      
        public static Cliente operator +(Cliente cliente, DispositivoElectronico dispo)
        {
            if (cliente != dispo)
            {
                cliente.dispositivos.Add(dispo);

            }
            else
            {
                Console.WriteLine("El cliente ya lo compro");
            }
            return cliente;
        }
        public static Cliente operator -(Cliente cliente, DispositivoElectronico dispo)
        {
            if (cliente == dispo)
            {
                cliente.dispositivos.Remove(dispo);
            }
            else
            {
                Console.WriteLine("No se encontro");
            }
            return cliente;
        }
        public static bool operator ==(Cliente cliente, DispositivoElectronico dispositivo)
        {

            return cliente.dispositivos.Contains(dispositivo); // tiene que tener el Equals

        }
        public static bool operator !=(Cliente cliente, DispositivoElectronico dispositivo)
        {
            return !(cliente == dispositivo);
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
        public string MostrarVisor()
        {
            return ($"{this.nombreEmpresa} - {this.cuit} - {this.tipoCliente.ToString()}");
            
        }
        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-----------------------------------------");
            sb.AppendLine($"NOMBRE / EMPRESA: {this.nombreEmpresa} \nCUIT: {this.cuit}\nTIPO: {this.tipoCliente.ToString()} \nUBICACION: {this.ubicación}");
            sb.AppendLine($"-----------------------------------------");
            if (this.dispositivos != null)
            {
                for (int i = 0; i < this.dispositivos.Count; i++)
                    sb.AppendLine(this.dispositivos[i].ToString());
            }
            return sb.ToString();
        }
    }
}
