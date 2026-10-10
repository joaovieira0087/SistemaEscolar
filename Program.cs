using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Professor> listaProfessor = new List<Professor>();
            int op;
            Console.WriteLine("1 - Cadastrar Professor");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("nome:");
                    string Nome = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Diciplina: ");
                    string Diciplina = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Idade: ");
                    int Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Salario:");
                    int Salario = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Você prencheu as informações obrigatorias");
                    Console.WriteLine("Deseja inserir as opcionais (s/n)");
                    char sn = char.Parse(Console.ReadLine());

                    if(sn == 's')
                    {
                        Console.WriteLine("em dev");
                    }
                    else
                    {
                        Professor novoProfessor = new Professor(Nome,Diciplina,Idade,Salario);  
                        listaProfessor.Add(novoProfessor);
                    }

                    break;
            }
        }
    }
}
