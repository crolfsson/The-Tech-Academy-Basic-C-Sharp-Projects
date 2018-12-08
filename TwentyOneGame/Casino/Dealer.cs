using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)//taking card from deck and inserting it to the Players hand(list)
        {
            Hand.Add(Deck.Cards.First());//Hand is a list and lists have add property
            string card = string.Format(Deck.Cards.First().ToString() + "\n");//logs the card
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\rolfsson\Desktop\TTA\C and NET\Logs\log.txt", true))//takes in a path; true means that it will append to the log; false would create a new file
            {
                file.WriteLine(DateTime.Now);//timestamp of this moment
                file.WriteLine(card);//writes the card to the log file
            }//once the closing brace is hit, the memory is cleared.  End result, the card is now in the log and that card is removed from memory
            Deck.Cards.RemoveAt(0);//once card is added to the hand it must be removed from the deck list
        }
    }
}

