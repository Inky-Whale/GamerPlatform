namespace GamerPlatform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Gamer gamer = new Gamer(){IdNumber = 1234516, FirstName = "",LastName = "",BirthYear = 1111};
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
        }
    }
}
