using UnityEngine;
namespace mb2022
{
    using go2022;
    public interface IRotation_pov : IRotation_rot
    {
        /// <summary>
        /// �������� ������ � b_root,rot,pov
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static public bool ������������������������������(byte i)
        {
            if (i == byte.MaxValue)
                return false;
            b_root = �������������������[i];
            rot = 0;
            pov -= b_root;
            if (pov < 0)
                pov = 3;
            if (pov > 3)
                pov = 0;

            IPlayer_move_pov.����������������������(pov);
            ������������ = true;
            return true;
        }
        static bool ������������������������������(byte i)
        {
            if (!Input.GetKeyDown(��������������[i]))
                return false;
            return ������������������������������(i);
        }
        static public void �������������()
        {
            if (rot > -1)
                return;

            for (byte i = 0; i < ��������������.Length; i++)
            {
                if (������������������������������(i))
                    return;
            }
        }
        void update()
        {
            �������������();
            ���������������();
        }
    }
}
