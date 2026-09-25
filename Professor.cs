using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
     public class Professor
     {
        public int Id { get; set; }
        public string NomeProfessor { get; set; }

        public Professor()
        {
        }

        public Professor(string nome_professor)
        {
            NomeProfessor = nome_professor;
        }

        public Professor (int id ,string nome_professor)
        {
            Id = id;
            NomeProfessor = nome_professor;
        }
     }
}   
