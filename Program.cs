using System;
using System.ComponentModel.Design;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            WhatsApp app = new WhatsApp();
            int finaliza = 1;

            while (finaliza == 1) {
                Console.WriteLine("Digite 1 para ver os contatos");
                Console.WriteLine("Digite 2 para ver as mensagens");
                Console.WriteLine("Digite 3 para ver fazer uma mensagem");
                Console.WriteLine("Digite 4 para salvar um contato");
                Console.WriteLine("Digite 5 para sair.");
               
                string menu = Console.ReadLine();

                switch (menu) 
                { 
                    case "1":
                        app.ListaContatos(); break;
                    case "2":
                        app.ListaMensagens(); break;
                    case "3":
                        if (app.Contatinhos.Count == 0)
                        {
                            Console.WriteLine("Voce nao tem contatos para atribuir uma mensagem!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Escolha o tipo de Mensagem que deseja fazer: ");
                            Console.WriteLine("1 - Mensagem de texto");
                            Console.WriteLine("2 - Mensagem de Audio");
                            Console.WriteLine("3 - Eviar uma foto");
                            string tipo_mensagem = Console.ReadLine();
                            if (tipo_mensagem == "1")
                            {
                                int novo_indice;

                                app.ListaContatos();
                                Console.WriteLine("Digite o indice do contato que deseja atribuir a mensagem:");
                                string indice = Console.ReadLine();
                                int.TryParse(indice, out novo_indice);
                                Console.WriteLine("Digite sua mensagem");
                                string mensagem = Console.ReadLine();
                                Contatinho contati = app.PegaContato(novo_indice);
                                MsgTexto msgTexto = new MsgTexto(contati, mensagem, mensagem.Length);
                                app.Add_mensagens(msgTexto);
                                Console.WriteLine("Mensagem enviada");
                                break;
                            }

                            else if (tipo_mensagem == "2")
                            {
                                int novo_indice;
                                app.ListaContatos();
                                Console.WriteLine("Digite o indice do contato que deseja atribuir a mensagem:");
                                string index = Console.ReadLine();
                                int.TryParse(index, out novo_indice);
                                Console.WriteLine("Digite sua mensagem");
                                string msg = Console.ReadLine();
                                Contatinho contact = app.PegaContato(novo_indice);
                                MsgAudio msgAudio = new MsgAudio(contact, msg, msg.Length);
                                app.Add_mensagens(msgAudio);
                                Console.WriteLine("Mensagem enviada");
                                break;
                            }
                            else
                            {
                                int novo_indice;
                                app.ListaContatos();
                                Console.WriteLine("Digite o indice do contato que deseja atribuir a mensagem:");
                                string inde = Console.ReadLine();
                                int.TryParse(inde, out novo_indice);
                                Console.WriteLine("Digite sua mensagem");
                                string msgF = Console.ReadLine();
                                Contatinho contacto = app.PegaContato(novo_indice);
                                MsgFoto msgFoto = new MsgFoto(contacto, msgF, msgF.Length);
                                app.Add_mensagens(msgFoto);
                                Console.WriteLine("Mensagem enviada");
                                break;

                            }

                            
                        }
                 
                case "4":
                        Console.WriteLine("Digite o nome do Contato: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite o numero do contato: ");
                        string numero = Console.ReadLine();
                        Contatinho contato = new Contatinho(nome, numero);
                        app.Add_contatinho(contato);
                        Console.WriteLine("Contato Adicionado");

                    break;
                case "5":
                        Console.WriteLine("Até outro dia");
                        finaliza--;
                        break;
                }
            }
        }
    }
}
