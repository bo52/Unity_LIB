//empty
//empty
//������� ������
using System.Collections.Generic;
using UnityEngine;
namespace LIB.st2305211735
{
    /// <summary>
    /// public interface IRegion10_build : IRegion10_bs
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// ��������������
        /// </summary>
        static public void fun230521173500()
        {

        }
        /// <summary>
        /// ����������������������
        /// </summary>
        /// <param name="�����������������"></param>
        static public void fun230521173501(this cs2305211723.IClass Reg, bool �����������������)
        {
            var R = cs2305211723.IClass.R/*����� ������ �� ���*/;
            for (var x = 0; x < R; x++)
                for (var y = 0; y < R; y++)
                    for (var z = 0; z < R; z++)
                    {
                        var ���������� = new Vector3(x, y, z);
                        var id = Reg.���������������(����������);
                        var ���������� = ����������������� ? (y == R - 1) : false;
                        var ����������� = (byte)(���������� ? 51 : 255);
                        fun230521173502/*��������������������*/(Reg,id, ����������, �����������);
                    }
        }
        /// <summary>
        /// �������������
        /// </summary>
        /// <param name="Reg"></param>
        /// <param name="id"></param>
        /// <param name="����������"></param>
        /// <param name="��������"></param>
        /// <returns></returns>
        static public byte fun230521173502(this cs2305211723.IClass Reg, uint id, Vector3 ����������, byte ��������)
        {
            var b = Reg.��������������(id);
            //�������� ��� �����
            if (!b) Reg.������������.Add(id, ��������);
            return Reg.������������[id];
        }
        /// <summary>
        /// �������
        /// </summary>
        /// <param name="Reg"></param>
        static public void fun230521173503(this cs2305211723.IClass Reg)
        {
            if (Reg.������������.Count == 0) return;
            //spBuild.IVertices.������������������ = stRegion_curr.���������;

            var ms = new List<Mesh>();
            foreach (var b in Reg.������������)
            {
                ms.Add(st2305161619.Class.fun230516161902("block" + b.Value.ToString()));
            }
            var mesh = st2305072045.Class.fun230507204503(ms);
            st2305072046.Class.fun230507204600_��������������������(mesh,(Reg as MonoBehaviour).gameObject);
        }
    }
}
