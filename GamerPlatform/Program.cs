namespace GamerPlatform
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Gamer gamer = new Gamer(){IdNumber = 19384118218, FirstName = "BERK",LastName = "KARANFİLOĞLU",BirthYear = 1994};
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
        }
    }
}
