namespace mb2022
{
    using scr2022;
    static public class st_mbList_file
    {
        static public string ex = ".asset";
        static public void �����������(this mbList mbs)
        {
            if (stButton_gui.������("DIR")) System.Diagnostics.Process.Start(stPrefab_path.PATH_Prefab(mbs.DIR()));
        }
    }
}