using System.Collections.Generic;
namespace block2023
{
    using utility2023;
    public interface IBlock
    {
        stVector_ulong_data ����������
        {
            get;
        }
        bool ����������
        {
            get;
        }
        byte ���
        {
            get;
            set;
        }
        Dictionary<ulong, IBlock> �����
        {
            get;
        }
    }
}