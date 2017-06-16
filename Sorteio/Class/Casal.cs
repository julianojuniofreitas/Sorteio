using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteio.Class
{
    class Casal
    {
        public int Codigo { get; set; }
        public string QRCode { get; set; }
        public string nomeDela { get; set; }
        public string nomeDele { get; set; }

        public Casal(int codigo, string qrCode, string nomeDela, string nomeDele)
        {
            this.Codigo = codigo;
            this.QRCode = qrCode;
            this.nomeDela = nomeDela;
            this.nomeDele = nomeDele;
        }
    }
}
