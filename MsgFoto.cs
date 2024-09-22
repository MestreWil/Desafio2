using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class MsgFoto : Mensagem
    {
        public int Tamanho { get; set; }
        public MsgFoto(Contatinho contatinho, string conteudo, int tamanho) : base(contatinho, conteudo)
        {
            this.Tamanho = tamanho;
        }

        public override string ToString()
        {
            return base.ToString() + $" Tamanho: {Tamanho}";
        }
    }
}
