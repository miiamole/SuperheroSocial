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
                SuperPower = new List<SuperpowerModel>(){powers[1],powers[2]},
                Image = SuperheroManager.images[0],
            }
        };

        public static List<SuperpowerModel> powers { get; set; } = new()
        {
            new SuperpowerModel ()
            {
                Superpower = "X-Ray Vision"
            },
            new SuperpowerModel ()
            {
                Superpower = "Flight"
            },
            new SuperpowerModel ()
            {
                Superpower = "Super Speed"
            },
            new SuperpowerModel ()
            {
                Superpower = "Telepathy"
            },
            new SuperpowerModel ()
            {
                Superpower = "Telekinesis"

            },
            new SuperpowerModel ()
            {
                Superpower = "Elemental Control"
            },
            new SuperpowerModel ()
            {
                Superpower = "Teleportation"
            },

        };

    }
}
