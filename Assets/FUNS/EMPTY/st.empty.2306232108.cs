//empty
//empty
//empty
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.IO;
namespace LIB.st2306232108
{
    /// <summary>
    /// ������������ ��������� ������� ��������� �����
    /// </summary>
    static public class Class
    {
        static public string INFO = "INFO";
        /// <summary>
        /// ���������� ��������� ������������ ������ ����
        /// </summary>
        static public readonly uint[] field230623210801 = new uint[2] { byte.MaxValue, 134217727 };
        /// <summary>
        /// 
        /// </summary>
        /// <param name="���">�����</param>
        /// <param name="n">2^n ����� �������</param>
        /// <param name="�������"></param>
        /// <returns></returns>
        static public bool fun230623210800(uint ���,byte n,byte �������=1)
        {
            switch (n)
            {
                case 0: return ��� % 2 != 0;
                case 26: return ��� >= 67108864;
                default:
                    var min = (uint)((float)(���) / 2);
                    return false;
            }
            var pow = Mathf.Pow(2, n);
            var next = pow - 1;
            var pow2 = 2 * pow;
            if (fun230623210802(���, ref pow))
                return true;
            while (pow < field230623210801[�������])
                if (fun230623210802(���, ref pow))
                    return true;
            return false;
        }
        static public bool fun230623210802(uint ���, ref float pow)
        {       
            if (��� >= pow && ��� < 2*pow) return true;
            pow += pow2;
            return false;
        }
        /// <summary>
        /// ��� �� ������
        /// ��������������������������
        /// </summary>
        /// <param name="���"></param>
        /// <returns></returns>
        static public bool fun230623210803(this uint ���) => (��� % 2) != 0;
        ///exit
    }
}
