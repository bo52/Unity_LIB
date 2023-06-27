namespace mb2022
{
    using scr2022;
    static public class st_mbList_path
    {
        static public string DIR(this mbList mbs) => mbs.PATH() + "/";
        static public string PATH(this mbList mbs) => mbs.PARENT.—в“екст("PATH");
        static public string PATH_land(this mbList mbs) => "Resources/PREFABS/" + PATH(mbs) + "/land_";
        static public string PATH_mesh(this mbList mbs) => "Resources/PREFABS/" + PATH(mbs) + "/ms_";
        static public string PATH_prefab(this mbList mbs) => "Resources/PREFABS/" + PATH(mbs) + "/prefab_";
        static public object[] args_save_mesh(this mbList mbs) => new object[] { mbs.DIR(), "Assets/" + mbs.PATH_mesh() };
    }
}