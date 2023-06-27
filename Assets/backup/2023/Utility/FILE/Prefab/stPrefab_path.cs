namespace scr2022
{
    using utility2022;
    static public class stPrefab_path
    {
        static public string PATH_Prefab_local(string path) => "PREFABS/" + path;
        static public string PATH_Prefab(string path) => stResources_path.PATH_resources + PATH_Prefab_local(path);
        static public string PATH_prefab(string path) => PATH_Prefab(path) + "prefab_";
        static public string PATH_id_prefab(string id, string path = "") => stFile_path.PATH_id_exe(PATH_prefab(path), id, "prefab");
    }
}