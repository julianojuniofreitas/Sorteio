using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sorteio
{
    public partial class main : Form
    {

        private IList<string> nomes;

        public IList<string> Nomes { get => nomes; set => nomes = value; }

        public main()
        {
            InitializeComponent();
            //CarregarNomes();
        }

        private void main_DoubleClick(object sender, EventArgs e)
        {
            CarregarNomes();
            string nomeSorteado = Sorteio();
            Console.WriteLine("O nome sorteado foi: " + nomeSorteado);
            Console.ReadKey();
        }

        private void CarregarNomes()
        {
            Console.WriteLine("Insira nomes ou enter para sair");
            string nome = string.Empty;

            do
            {
                Console.WriteLine("Nome-->");
                nome = Console.ReadLine();

                if (!string.IsNullOrEmpty(nome))
                    Nomes.Add(nome);

            } while (nome != string.Empty);
        }

        private string Sorteio()
        {
            Random random = new Random();
            int posicao = random.Next(0, Nomes.Count - 1);
            return Nomes[posicao].ToString();
        }
    }
}
