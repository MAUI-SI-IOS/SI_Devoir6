using Devoir3_builder.State;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir3_builder.data
{
    public class Pizza
    {

        public required IOrderState state;

        Grandeur grandeur;
        string pate;
        string sauce;
        string garnitures;
        decimal prix;

        public void setPrix(decimal prix)
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

        public override string ToString() // pour tester
        {
            return $@" Pizza:
                        Grandeur: {grandeur},
                        Pate: {pate},
                        Sauce: {sauce},
                        Garnitures: {garnitures},
                        Prix: {prix}
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
