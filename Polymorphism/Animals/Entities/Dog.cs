using System;
namespace Animals.Entities
{
    public class Dog : Animal
    {
        public Dog(string name, string favFood)
        {
            Name = name;
            FavoriteFood = favFood;
        }
        public override string ExplainYourself()
        {
            return base.ExplainYourself() + Environment.NewLine + "DJAFF";
        }
    }
}