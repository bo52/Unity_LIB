//empty
//empty
//Region10.Block8.Cube256 � ���� 10*10*10
using System.Collections.Generic;
using UnityEngine;
namespace LIB.cs2305211723
{
    /// <summary>
    /// IRegion10_bs
    /// </summary>
    public interface IClass
    {
        /// <summary>
        /// ������ ������� (���������� ������ �� ����� ���)
        /// </summary>
        static public byte R = 10;
        public Dictionary<uint, byte> ������������ { get; }
        #region ����������
        public bool ��������������(Vector3 v) => ��������������(���������������(v));
        public bool ��������������(uint id) => ������������.ContainsKey(id);
        public uint ���������������(Vector3 v);
        public Vector3 ���������������(uint id);
        #endregion
    }
    public class Class
    {
        public uint ���������������(Vector3 v) => st2305211717.Class.fun230521171703(v);
        public Vector3 ���������������(uint id) => st2305211717.Class.fun230521171704(id);
    }
}
