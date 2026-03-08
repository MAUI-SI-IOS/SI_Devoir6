using Devoir3_builder.State;
using Devoir6.decorator;

namespace Devoir3_builder.data
{
    public class Pizza:IPizzaDecorator
    {

        public required IOrderState state;

        Grandeur grandeur;
        string pate;
        string sauce;
        string garnitures;
        int prix;

        public void setPrix(int prix)
        {
            this.prix = prix;
        }

        public void setGrandeur(Grandeur grandeur)
        {
            this.grandeur = grandeur;
        }
        public void setPate(string pate)
        {
            this.pate = pate;
        }
        public void setSauce(string sauce)
        {
            this.sauce = sauce;
        }
        public void setGarniture(string garnitures)
        {
            this.garnitures = garnitures;
        }
        public int GetPrice() {
          return (this.pizza != null ? pizza.GetPrice() : 0) + prix;

        }
        public string GetDescription() {
          return (this.pizza != null ? pizza.GetDescription() : 0) + this.ToString();

        }

        public override string ToString() // pour tester
        {
            return $@" Pizza:
                        Grandeur: {grandeur},
                        Pate: {pate},
                        Sauce: {sauce},
                        Garnitures: {garnitures},
                        Prix: {this.GetPrice()}
                    ";
        }
    


       public enum Grandeur
        {
            Petite,
            Moyenne,
            Grande
        }
    }
}
