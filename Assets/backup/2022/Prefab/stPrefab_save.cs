//Bo52_06102020175649832.PREFAB.
namespace prefab2022
{
    using UnityEngine;
    using UnityEditor;
    /// <summary>
    /// SAVE
    /// управление ПРЕФАБОМ
    /// </summary>
    static public class stPrefab_save
    {
        static public void СохнаитьПрефаб(this GameObject go,string namefile)
        {
            namefile = "Assets/Resources/" + namefile+".prefab";
            if (System.IO.File.Exists(namefile))
            {
                bool b;
                PrefabUtility.SaveAsPrefabAsset(go, namefile,out b);
                Debug.Log("Сохранение="+b);
            }
            else
                PrefabUtility.CreatePrefab(namefile, go);
        }

    }
}
