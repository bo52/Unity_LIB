using UnityEngine;
namespace mb2022
{
    /// <summary>
    /// ���� ������� ���,�� ���������� ������
    /// </summary>
    static public class st_mbList_method_pow
    {
        static public Mono POW(this mbList mbs, Vector3 v) => mbs.POW(st_mbList.��(v));
        static public Mono POW(this mbList mbs, Vector3 v, out bool ����������)
        {
            var r = mbs.POW(st_mbList.��(v));
            ���������� = mbs.��������������������������������������;
            return r;
        }
        static public Mono POW(this mbList mbs, string id) => mbs.POW(System.Convert.ToUInt64(id));
        static public Mono POW(this mbList mbs, ulong id)
        {
            var mono = mbs.�����(id);
            if (mbs.��������������������������������������)
                return mono;
            return mbs.�����(id);
        }
    }
}