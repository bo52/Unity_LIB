using UnityEngine;
namespace mb2022
{
    public interface IRotation_param
    {
        #region pov
        /// <summary>
        /// ������� ������ ������ ������� "����� ��������" ������ �� 0 �� 3
        /// </summary>
        static public sbyte pov = 0;
        static public byte �������
        {
            get
            {
                switch (pov)
                {
                    case 0: return 4;
                    case 1: return 1;
                    case 2: return 5;
                    case 3: return 0;
                }
                return 4;
            }
        }
        #endregion
        /// <summary>
        /// ������� �������� ����� � ������
        /// </summary>
        static public readonly sbyte[] ������������������� = new sbyte[2] { -1, +1 };
        /// <summary>
        /// ������ �������� ����� � ������
        /// </summary>
        static public readonly string[] �������������� = new string[2] { "e", "q" };
        static public readonly Vector3[] ��������������� = new Vector3[4] {
            new Vector3(1, 0, 0),
            new Vector3(0, 0, 1),
            new Vector3(1, 0, 0),
            new Vector3(0, 0, 1),
        };
        /// <summary>
        /// ������� �������� �� ������� �������������������
        /// ���������� ���������� ����������� ��� ��������
        /// </summary>
        static public sbyte b_root = 1;
        static public bool ������������ = false;
    }
}