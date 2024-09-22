using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MsgTexto : Mensagem
{
    public int numChar;
    
    public MsgTexto(Contatinho contatinho, string conteudo, int numChar) : base(contatinho, conteudo)
    {
        this.numChar = numChar;
    }

    public override string ToString()
    {
        return base.ToString() + $" Numero de caracteres: {numChar}";
    }
}

