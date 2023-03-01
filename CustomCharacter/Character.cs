namespace CustomCharacter
{
    public class Character
    {
        public Head Head { get; set; }
        public Body Body { get; set; }
        
        public Extremities Hands { get; set; }
        public Legs Legs { get; set; }

        public Character(Head head, Body body, Extremities hands, Legs legs)
        {
            Head = head;
            Body = body;
            Hands = hands;
            Legs = legs;
        }
        
    }
}