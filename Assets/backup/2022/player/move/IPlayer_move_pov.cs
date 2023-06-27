namespace go2022
{
    public interface IPlayer_move_pov : IPlayer_move
    {
        static public void ќбновить нопкиƒвижений(sbyte pov)
        {
            for (byte i = 0; i < 4; i++)
                 нопкиƒвижений[i] =  нопкиƒвижений4[pov, i];
        }
    }
}
