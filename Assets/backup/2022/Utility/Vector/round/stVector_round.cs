using UnityEngine;
namespace scr2022
{
    /// <summary>
    /// ���������
    /// ������ c �������� (���������� ����)
    /// </summary>
    static public class stVector_round
    {
        static public Vector3Int ����������� => ������������������������������(stRaycastHit.HIT.point);
        static public int ��������������������(this float X)
        {
            int k = X < 0 ? -1 : 1;
            //-0.6f -> -1
            //-0.4f -> +0
            //+0.4f -> +0
            //+0.6f -> +1
            var cel = (int)Mathf.Abs(X);
            var d = Mathf.Abs(X) - cel;
            cel += Mathf.Abs(d) <= 0.5f ? 0 : 1;
            return k * cel;
        }
        static public Vector3 ������������������������(this Vector3 v)
        {

            return new Vector3(v.x.��������������������(), v.y.��������������������(), v.z.��������������������());
        }
        static public Vector3Int ������������������������������(this Vector3 v)
        {

            return new Vector3Int(v.x.��������������������(), v.y.��������������������(), v.z.��������������������());
        }
    }
}
