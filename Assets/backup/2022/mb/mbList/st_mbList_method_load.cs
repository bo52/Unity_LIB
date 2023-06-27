namespace mb2022
{
    using scr2022;
    static public class st_mbList_method_load
    {
        static public void Загрузить(this mbList mbs)
        {
            var f = stPrefab_path.PATH_Prefab(mbs.DIR());
            var i0 = f.Length;
            var rows = System.IO.Directory.GetFiles(f, "*" + st_mbList_file.ex);

            foreach (var path in rows)
                mbs.Новый(path.Substring(i0 + "ms_".Length).Replace(st_mbList_file.ex, ""));
        }
        static public void ЗагрузитьПрефабы(this mbList mbs)
        {
            var p = mbs.method_scene_delete();
            if (p == null)
                return;
            mbs.Загрузить();
        }
    }
}