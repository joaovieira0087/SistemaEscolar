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

        public 


    }
}   
