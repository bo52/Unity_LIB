using UnityEngine;
namespace mb2022
{
    public interface IRotation_rot : IRotation_param
    {
        static GameObject go;
        /// <summary>
        /// ������� �������� �� 0 �� 45 ��������. ���� ������� �� ���������� �� -1
        /// </summary>
        static public float rot = -1;
        /// <summary>
        /// ��������� ������ ����������� �� �� ���� ����� (x,y)
        /// </summary>
        static public bool ����������������� = false;
        virtual public void ��������������() => ����������������� = true;
        public GameObject ��������������� => go;
        virtual public void �������������() => rot = -1;
        public void ������������(byte n = 2) => ���������������.transform.rotation *= Quaternion.AngleAxis(n * b_root, new Vector3(0, 1, 0));
        public void ���������������()
        {
            if (rot < 0)
                return;
            if (rot == 0)
            {
                ��������������();
                ����������������� = false;
            }

            ������������();
            rot += 1;

            if (rot >= 45)
                �������������();
        }
    }
}