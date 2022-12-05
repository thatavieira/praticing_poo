using System;

namespace SchoolExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // instaciar objeto da classe Aluno
            Student A = new Student();
            A.name = "Denis";
            A.note1 = 8;
            A.note2 = 10;
            A.message();
        }
    }
}