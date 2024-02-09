namespace gradeStudent;
class Program
{
    static void Main(string[] args)
    {  
        bool loop = true;

        while(loop)
        {
            Console.WriteLine("Digite a nota do aluno:");
            int grade = Convert.ToInt32(Console.ReadLine());
            
            if(grade >= 7)
            loop = false;
            else
                Console.WriteLine("Por gentileza, tente novamente!");
        }
        Console.WriteLine("Parabéns você foi aprovado!");
    }
}

