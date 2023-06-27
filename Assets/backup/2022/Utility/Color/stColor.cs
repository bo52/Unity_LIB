using UnityEngine;

namespace utility2022
{
    /// <summary>
    /// Color
    /// ������������ �����
    /// </summary>
    static public class stColor
    {
        static public string INFO = "����";
        static public Color ���������� = new Color(0.85f, 0.7f, 0.4f);
        static public float ��������������� = 1.0f;
        /// <summary>
        /// �������
        /// �������� ������� �����
        /// </summary>
        /// <param name="c"></param>
        /// <param name="��������"></param>
        /// <returns></returns>
        static public float �������(this ref Color c, sbyte ��������)
        {
            float h, s, dv;
            Color.RGBToHSV(c, out h, out s, out dv);
            if (�������� != 0)
            {
                ��������������� = �������� < 0 ? ��������������� - 0.01f : ��������������� + 0.01f;
                if (��������������� < 0) ��������������� = 0.01f;
                if (��������������� > 1) ��������������� = 1.0f;
            }
            c = Color.HSVToRGB(h, s, ���������������);
            return ���������������;
        }
    }
}