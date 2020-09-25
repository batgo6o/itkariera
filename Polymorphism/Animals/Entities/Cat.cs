namespace Animals.Entities
{
    public class Cat : Animal
    {
        public Cat(string name, string favFood)
        {
            Name = name;
            FavoriteFood = favFood; 
        }

        public override string ExplainYourself()
        {
            return $"{base.ExplainYourself()}\nMeow";
        }
    }
}