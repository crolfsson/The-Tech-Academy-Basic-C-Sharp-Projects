using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            //nested loop - will loop through all faces and for each face, loop through each suit
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //Creates a card, assigns it a Face based on the value of j in the loop, ultimately creating a deck 
                    Card card = new Card();
                    card.Face = (Face)i;//casting to Face
                    card.Suit = (Suit)j;//casting to Suit
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }


        public void Shuffle(int times = 1)//No static or out parameter, use void instead of deck since its in own method
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;//does not need to return anything
            }
        }

        //DIFFERENT METHODS OF SHUFFLING USED IN PROGRAM.CS
        //public static Deck Shuffle(Deck deck)//shuffle once
        //{
        //    List<Card> TempList = new List<Card>();
        //    Random random = new Random();

        //    while (deck.Cards.Count > 0)
        //    {
        //        int randomIndex = random.Next(0, deck.Cards.Count);
        //        TempList.Add(deck.Cards[randomIndex]);
        //        deck.Cards.RemoveAt(randomIndex);
        //    }
        //    deck.Cards = TempList;
        //    return deck;
        //}

        //public static Deck Shuffle(Deck deck, int times)//overload method - shuffle multiple times
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

        //public static Deck Shuffle(Deck deck, int times = 1)//when adding int times with number and for loop, this creates same effect as overload method without extra method code
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
        //        }
        //        deck.Cards = TempList;
        //    }
        //    return deck;

        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)//verifying how many times deck was shuffled using "out"
        //{
        //timesShuffled = 0;//define out variable
        //for (int i = 0; i < times; i++)
        //{
        //    timesShuffled++;//adding one to the variable each time it is shuffled
        //    List<Card> TempList = new List<Card>();
        //    Random random = new Random();

        //    while (deck.Cards.Count > 0)
        //    {
        //        int randomIndex = random.Next(0, deck.Cards.Count);
        //        TempList.Add(deck.Cards[randomIndex]);
        //        deck.Cards.RemoveAt(randomIndex);
        //    }
        //    deck.Cards = TempList;
        //}
        //return deck;
        //}

    }
}

