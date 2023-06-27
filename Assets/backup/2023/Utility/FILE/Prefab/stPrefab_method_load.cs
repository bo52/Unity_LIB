using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Utility2022
{
    using mb2022;
    using scr2022;
    using utility2022;
    static public class stPrefab_method_load
    {
        static public GameObject ЗагрузитьПрефаб(string full_path, GameObject p = null)
        {
            var file = stPrefab_path.PATH_Prefab_local(full_path);
            file = stText_cut.ВырезатьРасширение(file);

            var go = GameObject.Instantiate(Resources.Load(file), new Vector3(0, 0, 0), Quaternion.identity) as GameObject;

            if (p != null)
                go.transform.parent = p.transform;

            //go.GetComponent<Mono>().ОсобыеНастройки(null, null);
            return go;
        }
        static public GameObject ЗагрузитьПрефаб(string file, Vector3 v, Transform p)
        {
            GameObject go = Object.Instantiate(Resources.Load(stPrefab_path.PATH_Prefab_local(file), typeof(GameObject))) as GameObject;
            go.transform.position = Vector3.zero;
            go.transform.SetParent(p);
            go.transform.localPosition = v;
            return go;
        }
        static public GameObject ЗагрузитьПрефаб(string id, string path, GameObject p = null)=>ЗагрузитьПрефаб(stPrefab_path.PATH_id_prefab(id, path), p);
        static public void ЗагрузитьПрефабы(string PATH, GameObject p = null)
        {
            var f = stPrefab_path.PATH_Prefab(PATH);
            var rows = System.IO.Directory.GetFiles(f, "*.prefab");
            foreach (var path in rows)
                ЗагрузитьПрефаб(path, p);
        }
    }
}