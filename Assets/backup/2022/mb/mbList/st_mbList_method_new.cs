namespace mb2022
{
    using scr2022;
    using utility2022;
    static public class st_mbList_method_new
    {
        static public Mono �����(this mbList mbs, ulong id) => mbs.�����(id.ToString());
        static public Mono �����(this mbList mbs, string id) => (Mono)mbs.PARENT.������������������(mbs.P(), false, id).GetComponent(mbs.P());
    }
}