using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Contatinho
{
    public string Name { get; set; }
    public string Celular { get; set; }

    public Contatinho(string name, string celular)
    {
        this.Name = name;
        this.Celular = celular;
    }

    public string Nome() { return this.Name; }
}

