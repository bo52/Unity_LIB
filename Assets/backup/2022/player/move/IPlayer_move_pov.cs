namespace go2022
{
    public interface IPlayer_move_pov : IPlayer_move
    {
        static public void ����������������������(sbyte pov)
        {
            for (byte i = 0; i < 4; i++)
                ��������������[i] = ��������������4[pov, i];
        }
    }
}
