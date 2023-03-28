

namespace RaceTo21
{
    public class Card
    {
        public string id;//Shot name of the card
        public string displayName;//full name of the card
        public string ImgUrl;
        public Card(string shortCardName,string longCardName,string imgUrl)
        {
            id = shortCardName;
            displayName = longCardName;
            ImgUrl = imgUrl;
        }
    }
}
