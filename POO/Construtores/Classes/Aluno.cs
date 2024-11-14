using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Aluno
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string matricula { get; set; }

        public Aluno(string nm, int id, string mt){
            nome = nm;
            idade = id;
            matricula = mt;
        }

        public void ExibirDados()
        {
            Console.WriteLine(@$"
            nome: {nome}
            idade: {idade}
            matricula: {matricula}
            ");
        }
    }
}