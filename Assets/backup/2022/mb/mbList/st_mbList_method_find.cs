using UnityEngine;
namespace mb2022
{
    static public class st_mbList_method_find
    {
        static public Mono �����(this mbList mbs, Vector3 v) => mbs.�����(new Vector3Int((int)v.x, (int)v.y, (int)v.z));
        static public Mono �����(this mbList mbs, Vector3Int v) => mbs.�����(st_mbList.��(v));
        static public Mono �����(this mbList mbs, ulong id)
        {
            mbs.�������������������������������������� = false;
            foreach (var mono in mbs)
            {
                if (mono.ID == id.ToString())
                {
                    mbs.�������������������������������������� = true;
                    return mono;
                }
            };
            return default;
        }
    }
}