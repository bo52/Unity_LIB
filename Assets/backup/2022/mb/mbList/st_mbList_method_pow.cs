using UnityEngine;
namespace mb2022
{
    /// <summary>
    /// если объекта нет,то немедленно создаЄм
    /// </summary>
    static public class st_mbList_method_pow
    {
        static public Mono POW(this mbList mbs, Vector3 v) => mbs.POW(st_mbList.»ƒ(v));
        static public Mono POW(this mbList mbs, Vector3 v, out bool —уществует)
        {
            var r = mbs.POW(st_mbList.»ƒ(v));
            —уществует = mbs.ѕоследн€€ѕроверка—уществовани€Ёлемента;
            return r;
        }
        static public Mono POW(this mbList mbs, string id) => mbs.POW(System.Convert.ToUInt64(id));
        static public Mono POW(this mbList mbs, ulong id)
        {
            var mono = mbs.Ќайти(id);
            if (mbs.ѕоследн€€ѕроверка—уществовани€Ёлемента)
                return mono;
            return mbs.Ќовый(id);
        }
    }
}