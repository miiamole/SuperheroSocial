namespace SuperheroSocial
{
    public class SuperheroManager
    {
        private static List<SuperheroModel> heroes { get; set; } = new List<SuperheroModel>()
        {
            new SuperheroModel ()
            {
                Id = 1,
                Name = "Superman",
                SecretIdentity = "Clark Kent",

            }
        };

    }
}
