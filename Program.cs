using SistemaEscolar.SistemaEscolar;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            RegrasBasicas regrasBasicas = new RegrasBasicas();

            while (true)
            {
                int op;
                Console.WriteLine("1 - Cadastrar Professor");
                Console.WriteLine("2 - Lista Professor");
                Console.WriteLine("3 - Excluir Professor");
                Console.WriteLine(regrasBasicas.Espacamento());
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("nome: ");
                        string Nome = Console.ReadLine();
                        Console.WriteLine(regrasBasicas.Espacamento());
                        Console.Write("Diciplina: ");
                        string Diciplina = Console.ReadLine();
                        Console.WriteLine(regrasBasicas.Espacamento());
                        Console.Write("Idade: ");
                        int Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine(regrasBasicas.Espacamento());
                        Console.Write("Salario: ");
                        double Salario = int.Parse(Console.ReadLine());
                        Console.WriteLine(regrasBasicas.Espacamento());
                        Console.WriteLine("Você prencheu as informações obrigatorias");
                        Console.WriteLine("Deseja inserir as opcionais (s/n)");
                        char sn = char.Parse(Console.ReadLine());

                        if (sn == 's')
                        {
                            Console.Write("Email: ");
                            string Email = Console.ReadLine();
                            Console.WriteLine(regrasBasicas.Espacamento());
                            Console.Write("Carga Horaria Semanal: ");
                            int CargaHorariaSemanal = int.Parse(Console.ReadLine());
                            Console.WriteLine(regrasBasicas.Espacamento());
                            Professor novoProfessor = new Professor(Nome, Diciplina, Idade, Salario, Email, CargaHorariaSemanal);
                            listaProfessor.Add(novoProfessor);
                            Console.WriteLine();
                        }
                        else
                        {
                            Professor novoProfessor = new Professor(Nome, Diciplina, Idade, Salario);
                            listaProfessor.Add(novoProfessor);
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Lista Professores: ");

                        if (listaProfessor.Count == 0)
                        {
                            Console.WriteLine("Não a professores cadastrados");
                            Console.WriteLine();
                        }
                        else
                        {

                            Professor.ListaProfessor(listaProfessor);
                            Console.WriteLine();
                        }
                    break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Excluir Professor");

                    break;
                }
            }
        }
    }
}

