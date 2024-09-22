using System;



abstract class Mensagem
{
    public Contatinho Destinatario {  get; set; }
    public DateTime HoraEnvio { get; set; }
    public string Conteudo { get; set; }

    public Mensagem(Contatinho destinatario, string conteudo)
    {
        this.Destinatario = destinatario;
        this.HoraEnvio = DateTime.Now;
        this.Conteudo = conteudo;
    }

    // Sobrescrevendo o método ToString corretamente
    public virtual string ToString()
    {
        return $"Mensagem para {Destinatario.Nome()} às {HoraEnvio:hh:mm tt}: {Conteudo}";
    }
}
