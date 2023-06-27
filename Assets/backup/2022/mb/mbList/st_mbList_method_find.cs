using UnityEngine;
namespace mb2022
{
    static public class st_mbList_method_find
    {
        static public Mono Найти(this mbList mbs, Vector3 v) => mbs.Найти(new Vector3Int((int)v.x, (int)v.y, (int)v.z));
        static public Mono Найти(this mbList mbs, Vector3Int v) => mbs.Найти(st_mbList.ИД(v));
        static public Mono Найти(this mbList mbs, ulong id)
        {
            mbs.ПоследняяПроверкаСуществованияЭлемента = false;
            foreach (var mono in mbs)
            {
                if (mono.ID == id.ToString())
                {
                    mbs.ПоследняяПроверкаСуществованияЭлемента = true;
                    return mono;
                }
            };
            return default;
        }
    }
}