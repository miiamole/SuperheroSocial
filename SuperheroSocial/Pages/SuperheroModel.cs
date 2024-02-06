namespace SuperheroSocial.Pages
{
    public class SuperheroModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string SecretIdentity { get; set; }

        public List<Superpower> Superpower { get; set; } = new();

        public string Image { get; set; }
    }
}
