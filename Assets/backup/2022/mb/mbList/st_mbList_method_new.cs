namespace mb2022
{
    using scr2022;
    using utility2022;
    static public class st_mbList_method_new
    {
        static public Mono Новый(this mbList mbs, ulong id) => mbs.Новый(id.ToString());
        static public Mono Новый(this mbList mbs, string id) => (Mono)mbs.PARENT.НовыйОбъектПрефаба(mbs.P(), false, id).GetComponent(mbs.P());
    }
}