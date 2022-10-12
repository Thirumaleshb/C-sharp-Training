// See https://aka.ms/new-console-template for more information
using WorkingwithNull;

class program
{
    public static void Main(string[] args)
    {
        PlayACharacter play = new PlayACharacter();
        play.name = "Thiru";
        play.DaySinceLogin = 20;
        //int days = play.DaySinceLogin.HasValue ? play.DaySinceLogin.Value : 0;
        int days = play.DaySinceLogin?? -1;
        Console.WriteLine("The value of days is " + days);
        if (play.DOB.HasValue)
        {
            Console.WriteLine($"The DOB of {play.name} is {play.DOB}");
        }
        else
        {
            Console.WriteLine($"The DOB of {play.name} is Null");
        }
        if (string.IsNullOrEmpty(play.name))
        {
            Console.WriteLine("The string null");
        }
        else
        {
            Console.WriteLine($"The string {play.name} is not null ");
        }
    }

}
