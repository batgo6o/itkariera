namespace Animals.Entities
{
    public class Animal
    {
        protected string Name;
        protected string FavoriteFood;

        public virtual string ExplainYourself()
        {
            return $"My name is {Name} and my favorite food is {FavoriteFood}";
        }
    }
}