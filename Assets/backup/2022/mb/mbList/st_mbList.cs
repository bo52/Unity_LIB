using UnityEngine;
namespace mb2022
{
    using utility2022;
    using scr2022;
    static public class st_mbList
    {
        static public ulong ИД(Vector3 v) => stVector_min_max.GET_ID(v);
        static public System.Type P(this mbList mbs) => (System.Type)mbs.PARENT.Поле("P");
    }
}