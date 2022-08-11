
using RapportModule.Frontend;
using RapportModule.Business;



internal class Program
{
    private static void Main(string[] args)
    {
        var message = new UserMessage();
        var userInput = new UserInput(message);

        userInput.GetGrade();

    }
}