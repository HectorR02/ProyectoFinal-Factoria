using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pesadas
    {
        [Key]
       // [Browsable(false)]
        public int PesadaId { get; set; }
       // [Browsable(false)]
        public int ComprobanteId { get; set; }

        public int Sacos { get; set; }

        public int CamionLleno { get; set; }

        public int CamionVacio { get; set; }

        public int KgBruto { get; set; }

        public int Convercion { get; set; }

        public Double QuinSecos { get; set; }

        public Pesadas(int comprobanteId, int sacos, int camionLleno, int camionVacio, int kgBruto, int factorConversion, Double quintalesSecos)
        {
            this.CamionLleno = camionLleno;
            this.CamionVacio = camionVacio;
            this.ComprobanteId = comprobanteId;
            this.Sacos = sacos;
            this.KgBruto = kgBruto;
            this.Convercion = factorConversion;
            this.QuinSecos = quintalesSecos;
        }

        public Pesadas()
        {
        }
    }
}
