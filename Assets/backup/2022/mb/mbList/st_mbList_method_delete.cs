using UnityEngine;
namespace mb2022
{
    using go2022;
    using scr2022;
    static public class st_mbList_method_delete
    {
        static public Transform method_scene_delete(this mbList mbs)
        {
            mbs.Clear();
            stGameObject.”далениеќбъектов(mbs.PARENT.transform);

            return mbs.PARENT.transform;
        }
        static public void method_delete(this mbList mbs, string PATH, string exe, GameObject go)
        {
            var path = Application.dataPath + "/" + PATH + go.name + "." + exe;
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
                System.IO.File.Delete(path + ".meta");
            }
        }
        static public void method_delete_scene(this mbList mbs, Mono item)
        {
            Object.DestroyImmediate(item.gameObject);
            mbs.Remove(item);
        }
        static public void method_delete(this mbList mbs, int i) => method_delete(mbs, mbs[i]);
        static public void method_delete(this mbList mbs, Mono item)
        {
            var go = item.gameObject;
            mbs.method_delete(mbs.PATH_mesh(), "asset", go);
            mbs.method_delete(mbs.PATH_prefab(), "prefab", go);
            mbs.method_delete(mbs.PATH_land(), "ncs", go);
            mbs.method_delete_scene(item);
        }
        static public void ”далить¬сеѕрефабы(this mbList mbs)
        {
            mbs.method_scene_delete();
            mbs.DIR().”далить¬сеѕрефабы»зѕапки();
        }
    }
}