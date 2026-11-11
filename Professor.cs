using SistemaEscolar.SistemaEscolar;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
     public class Professor
     {
        public string NomeProfessor { get; set; }
        public string Diciplina { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public int CargaHorariaSemanal { get; set; }
        public double Salario { get; private set; }

        public Professor(string nome, string diciplina, int idade, double salario, string email, int cargasemanal)
        {
            NomeProfessor = nome;
            Diciplina = diciplina;
            Idade = idade;
            Email = email;
            CargaHorariaSemanal = cargasemanal;
            Salario = salario;
        }

        public Professor(string nome, string diciplina, int idade, double salario)
        {
            NomeProfessor = nome;
            Diciplina = diciplina;
            Idade = idade;
            Salario = salario;
        }

        public static bool ExcluirProfessor(List<Professor> professor, int op)
        {
            int opcao = op - 1;
            if (opcao >= 0 && opcao < professor.Count)
            { 
                professor.RemoveAt(opcao);
                return true;
            }
            return false;
        }

        public static bool EditarProfessor(List<Professor> professors, int op)
        {
            int opcao = op - 1;
            if (opcao >= 0 && opcao < professors.Count)
            {
                RegrasBasicas regrasBasicas = new RegrasBasicas();
                Console.Clear();
                Console.WriteLine();
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

                    professors[opcao] = novoProfessor;

                    Console.WriteLine();
                }
                else
                {
                    Professor novoProfessor = new Professor(Nome, Diciplina, Idade, Salario);
                    professors[opcao] = novoProfessor;
                    Console.WriteLine();
                    Console.Clear();
                }

                return true;
            }

            return false;
        }

        public static void ListaProfessor(List<Professor> professor)
        {
            RegrasBasicas regrasBasicas = new RegrasBasicas();

            regrasBasicas.ReiniciarContador();
            int quant = professor.Count;
            foreach (Professor prof in professor)
            {
                Console.WriteLine($"{regrasBasicas.ProximaPosicao()} - " +
                    $"{"Nome:" + prof.NomeProfessor} " +
                    $"{"Displina:" + prof.Diciplina}" +
                    $" {"Idade:" + prof.Idade}" +
                    $" {"Salario:" + prof.Salario.ToString("F2", CultureInfo.InvariantCulture)}" +
                    $" {"Carga-Hora:" + prof.CargaHorariaSemanal}" +
                    $" {"Email:" + prof.Email}"
                    );
            }
        }
    }
}   
