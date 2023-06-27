using UnityEngine;
namespace go2022
{
    using scene2022;
    static public class stGameObject_new
    {
    static public GameObject new_go(this GAMEOBJECT ex)
    {
        var f = "PREFABS/" + ex.ID;
        ex.GO = System.IO.File.Exists(Application.dataPath + "/Resources/" + f + ".prefab") == false ? new GameObject() :
        Object.Instantiate(Resources.Load(f, typeof(GameObject))) as GameObject;
        return ex.GO;
    }
    static public GameObject reload_go(this GAMEOBJECT ex, object[] atr)
    {
        var name = ex.gName();
        ex.GO = GameObject.Find(name);
        if (ex.GO != null)
            GameObject.DestroyImmediate(ex.GO);
        ex.GO = ex.new_go();
        #region для new и reload объекта
        ex.GO.name = name;
        ex.GO.transform.parent = ex.РОДИТЕЛЬ == null ? stScene_go.CONTENT.transform : ex.РОДИТЕЛЬ.GO.transform;
        #endregion
        return ex.GO;
    }
    static public GameObject pow_go(object atr) => pow_go(new object[] { atr });
    static public GameObject pow_go(this GAMEOBJECT ex, object[] atrs = null)
    {
        if (atrs != null)
            ex.ATRs = atrs;

        if (ex.GO == null)
            ex.reload_go(ex.ATRs);

        ex.ОсобыеНастройки(ex.ATRs);
        return ex.GO;
    }
}
}