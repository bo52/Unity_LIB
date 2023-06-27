namespace scr2022
{
    using UnityEditor;
    using UnityEngine;
    /// <summary>
    /// Префаб сохранить
    /// </summary>
    static public class stPrefab_method_save
    {
        static public string INFO = "Файл.ПРЕФАБ";
        static public void СохранитьПрефаб(this GameObject go, string id, string path="")
        {
            var m=go.GetComponent<MeshFilter>().sharedMesh;
            if (m.name.Length == 0)
            {
                PrefabUtility.SaveAsPrefabAsset(go, stPrefab_path.PATH_id_prefab(id, path));
            }
        }
    }
}
