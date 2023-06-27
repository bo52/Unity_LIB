namespace task2022
{
    static public class stContent_file
    {
        static public string ÔאיכÏנופאבא(string ןאעק, string id) => stContent_path.PATH_prefab + ןאעק + id + ".prefab";
        static public string ÔאיכÈםעונפויסא(string id) => ÔאיכÏנופאבא("0.UI/UI_", id);
        static public string ÔאיכÌורא(string id) => ÔאיכÏנופאבא("1.MESH/MESH_", id);
    }
}
