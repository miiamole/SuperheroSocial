namespace SuperheroSocial
{
    public class SuperheroManager
    {
        public static List<string> images = new List<string>()
        {
            "\\image\\batman.jpg",
            "\\image\\captainamerica.jpg",
            "\\image\\flash.jpg",
            "\\image\\greenlantern.jpg",
            "\\image\\humantorch.jpg",
            "\\image\\invisablewoman.jpg",
            "\\image\\mrfantastic.jpg",
            "\\image\\spiderman.jpg",
            "\\image\\superman.jpg",
            "\\image\\thing.jpg",
            "\\image\\thor.jpg",
        };
        public static List<SuperheroModel> heroes { get; set; } = new List<SuperheroModel>()
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
