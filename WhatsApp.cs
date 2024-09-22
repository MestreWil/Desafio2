using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class WhatsApp
    {
        public List<Contatinho> Contatinhos = new List<Contatinho>();
        public List<Mensagem> Mensagens = new List<Mensagem>();

        public WhatsApp() {}

        public void Add_contatinho(Contatinho contatinho)
        {
            Contatinhos.Add(contatinho);
            Console.WriteLine($"Contato: {contatinho.Nome()}");
        }
        public void Add_mensagens(Mensagem mensagem)
        {
            Mensagens.Add(mensagem);
            Console.WriteLine($"Nova mensagem");
        }

        public void ListaContatos()
        {
            if (Contatinhos.Count > 0)
            {
                foreach (Contatinho contatinho in Contatinhos)
                {
                    Console.WriteLine(contatinho.Nome() + " ,");
                }
            }
            else { Console.WriteLine("Nenhum contato cadastrado ainda."); }
        }

        public void ListaMensagens()
        {
            if (Contatinhos.Count > 0)
            {
                foreach (Mensagem mensagem in Mensagens)
                {
                    Console.WriteLine(mensagem.ToString() + " ,");
                }
            }
            else { Console.WriteLine("Nenhuma mensagem enviada"); }
        }

        public Contatinho PegaContato(int indice)
        {
            return Contatinhos[indice];
        }
        
    }
}
