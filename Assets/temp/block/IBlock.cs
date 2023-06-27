using System.Collections.Generic;
namespace block2023
{
    using utility2023;
    public interface IBlock
    {
        stVector_ulong_data Координата
        {
            get;
        }
        bool существует
        {
            get;
        }
        byte Код
        {
            get;
            set;
        }
        Dictionary<ulong, IBlock> Карта
        {
            get;
        }
    }
}