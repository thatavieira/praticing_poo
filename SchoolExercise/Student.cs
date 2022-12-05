namespace SchoolExercise;

public class Student
{
    // atributos
    public string name;

    public double note1, note2;
    
    // media
    public double average()
    {
        return (note1 + note2) / 2;
    }
    
    // situacao
    public string situation(double average)
    {
         return average >= 7 ? "approved" : "disapproved";
    }
    
    // mensagem
    public void message()
    {
        double getAverage = average();

        string getSituation = situation(getAverage);
        
        Console.WriteLine(name+" está "+getSituation+" com media "+getAverage);
    }
}