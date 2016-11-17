using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pesadas
    {
        [Key]
        public int PesadaId { get; set; }

        public int ComprobanteId { get; set; }

        public int Sacos { get; set; }

        public int CamionLleno { get; set; }

        public int CamionVacio { get; set; }

        public int KgBruto { get; set; }

        public int FactorConversion { get; set; }

        public Double QuintalesSecos { get; set; }

        public Pesadas(int comprobanteId, int sacos, int camionLleno, int camionVacio, int kgBruto, int factorConversion, Double quintalesSecos)
        {
            this.CamionLleno = camionLleno;
            this.CamionVacio = camionVacio;
            this.ComprobanteId = comprobanteId;
            this.Sacos = sacos;
            this.KgBruto = kgBruto;
            this.FactorConversion = factorConversion;
            this.QuintalesSecos = quintalesSecos;
        }

        public Pesadas()
        {
        }
    }
}
