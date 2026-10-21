using System;
using System.Collections.Generic;
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
        public int Salario { get; private set; }

        public Professor(string nome, string diciplina, int idade, int salario, string email, int cargasemanal)
        {
            NomeProfessor = nome;
            Diciplina = diciplina;
            Idade = idade;
            Email = email;
            CargaHorariaSemanal = cargasemanal;
            Salario = salario;
        }

        public Professor(string nome, string diciplina, int idade, int salario)
        {
            NomeProfessor = nome;
            Diciplina = diciplina;
            Idade = idade;
            Salario = salario;
        }

        
    }
}   
