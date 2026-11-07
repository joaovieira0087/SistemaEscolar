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
            int op = 0;

            while (op != 5)
            {
                
                Console.WriteLine("1 - Cadastrar Professor");
                Console.WriteLine("2 - Lista Professor");
                Console.WriteLine("3 - Excluir Professor");
                Console.WriteLine("4 - Editar Professor");
                Console.WriteLine("5 - Sair");
                Console.WriteLine(regrasBasicas.Espacamento());
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
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
                        double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine(regrasBasicas.Espacamento());
                        Console.WriteLine("Você prencheu as informações obrigatorias");
                        Console.WriteLine("Deseja inserir as opcionais (s/n)");
                        string sn = Console.ReadLine()?.ToUpper();
                        Console.Clear();

                        if (sn == "S")
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
                            Console.Clear();
                        }
                        break;

                    case 2:
                        Console.Clear();
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
                        Console.Clear();
                        Console.WriteLine("Excluir Professor");
                        Professor.ListaProfessor(listaProfessor);
                        Console.WriteLine();

                        bool excluidoComSucesso = false;

                        do
                        {
                            Console.Write("Escolha o número que será excluído: ");
                            if (int.TryParse(Console.ReadLine(), out op))
                            {
                                excluidoComSucesso = Professor.ExcluirProfessor(listaProfessor, op);

                                if (excluidoComSucesso)
                                {
                                    Console.WriteLine("Professor excluído com sucesso!");
                                    Console.WriteLine();
                                    break; 
                                }

                                Console.WriteLine("Erro ao excluir. Número não encontrado.");
                            }
                            else
                            {
                                Console.WriteLine("Número inválido.");
                            }

                            Console.Write("Tente novamente (s/n): ");

                        } while (Console.ReadLine()?.ToUpper() == "S");

                    break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Editar Professor");
                        Professor.ListaProfessor(listaProfessor);
                        Console.WriteLine();

                        bool EditadoComSucesso = false;

                        do
                        {
                            Console.Write("Escolha o Professor que sera editado: ");
                            if (int.TryParse(Console.ReadLine(), out op))
                            {
                                EditadoComSucesso = Professor.EditarProfessor(listaProfessor, op);

                                if (EditadoComSucesso)
                                {
                                    Console.WriteLine("Professor editado com sucesso!");
                                    Console.WriteLine();
                                    break;
                                }

                                Console.WriteLine("Erro ao Editar. Número não encontrado.");
                            }

                            else
                            {
                                Console.WriteLine("Número inválido.");
                            }

                                Console.Write("Tente novamente (s/n): ");

                        } while (Console.ReadLine()?.ToUpper() == "S");
                    break;

                    case 5:
                        Console.WriteLine("Até logo");
                    break;
                }
            }
        }
    }
}

