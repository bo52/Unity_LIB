//empty
//empty
//Vertices.size.delta
using UnityEngine;
namespace LIB.cs2305181649
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClass: cs2305141215.IClass
    {
        /// <summary>
        /// ��������� ����� ��������������
        /// </summary>
        static Vector3 ������������������ = Vector3.zero;
        /// <summary>
        /// ���������� ������ ���������� ������
        /// </summary>
        static sbyte SIZE = 3;
        /// <summary>
        /// ������ ������ �� ����� ��� ��� SIZE = 3
        /// </summary>
        static float MAX => Mathf.Pow(2, SIZE);
        /// <summary>
        /// ������ ����� ������ 1/8 ��� SIZE = 3
        /// </summary>
        static float ������ => 1 / MAX;
        static Vector3 �������� => 0.5f * Vector3.one * (������ - 1);
        new Vector3 �����������������(Vector3 dv) => ������������������ + ������ * (this as cs2305141215.IClass).�����������������(dv) + ��������;
    }
    /// <summary>
    ///
    /// </summary>
    public class Class: cs2305141215.Class, IClass
    {
        static public string INFO = "INFO";
    }
}
