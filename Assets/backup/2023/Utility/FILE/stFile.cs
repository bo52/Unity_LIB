using mesh2023;
using UnityEditor;
using UnityEngine;
namespace utility2023
{
    #region stFile
    public static class stFile
    {
        static public string INFO = "Проверка";
        static public string PRODUCT = "файл сохранен?";

        static public bool Сохранён(string path) => (path != "" && System.IO.File.Exists(path) == true);
    }

    static public class stFile_prefab_path
    {
        static public string Prefab_path(this string path) => stFile_resource_path.PATH + "PREFABS/" + path;
        static public string prefab_path(this string path) => Prefab_path(path) + "prefab_";
        static public string prefab_path_id(this string id, string path = "") => prefab_path(path).PATH_id_exe(id, "prefab");
    }

    static public class stFile_resource_path
    {
        static public string INFO = "Файл";
        static public string PRODUCT = "полный путь к файлу";
        #region Resources
        static public string PATH => Application.dataPath + "/Resources/";
        static public string PATH_resources_local(this string full_path) => full_path.Replace(PATH, "");
        static public string PATH_id_exe(this string path, string id, string exe) => path + id + "." + exe;
        #endregion
    }

    public static class stFile_mesh
    {
        static public string INFO = "Файл.МЕШ";
        static public string PRODUCT = "Меш сохранить,загрузить";
        static public Mesh ФайлМеша(string asset) => stFile.Сохранён(asset) ? (Mesh)AssetDatabase.LoadAssetAtPath(asset, typeof(Mesh)) : null;
        static public Mesh ФайлМеша(this GameObject go) => ФайлМеша(LIB.st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(go.name));
        static public Mesh ФАЙЛ_МЕША(this string id) => ФайлМеша(LIB.st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(id));
    }
    #endregion
}