using System;

namespace Desafio2
{
    internal class MsgAudio : Mensagem
    {
        public int Duracao { get; set; }
        public MsgAudio(Contatinho contatinho, string conteudo, int duracao) : base(contatinho, conteudo)
        {
            this.Duracao = duracao;
        }

        public override string ToString()
        {
            return base.ToString() + $" Duracao: {Duracao}";
        }
    }
}
