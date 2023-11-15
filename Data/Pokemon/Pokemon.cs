namespace PokemonBlazor.Data.Pokemon
{
    public class Pokemon
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Type1 { get; set; }

        public string? Type2 { get; set; }

        public string Description { get; set; }

        public Pokemon(string Id, string Name, string Type1, string Type2, string Description) {
            this.Id = Id;
            this.Name = Name;
            this.Type1 = Type1;
            this.Type2 = Type2;
            this.Description = Description;
        }
    }
}