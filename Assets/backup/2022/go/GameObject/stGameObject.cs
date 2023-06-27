//Bo52_26122020192451854.GAMEOBJECT.
using UnityEngine;
using System.Collections.Generic;
namespace go2022
{
    using mb2022;
    /// <summary>
    /// РаботаСОбъектом
    /// </summary>
    static public class stGameObject
    {
        static public string INFO = "Объект.Модификация.Удаление";
        #region ПОЛЯ
        static public GAMEOBJECT TEST = new GAMEOBJECT(null, "TEST", "1341_29122020");
        static public GAMEOBJECT CHUNKS = new GAMEOBJECT(null, "CHUNKS", "1341_29122020");
        //Bo52_17102020101208823.MONO_17102020101208823.ЧАНКИ=List<MONO_17102020101208823>
        static public List<Mono> ЧАНКИ = new List<Mono>();
        #endregion
        static public Mono МОНО(this GAMEOBJECT ex) => (Mono)ex.GO.GetComponent(ex.МоноКЛАСС);
        static public string gName(this GAMEOBJECT ex) => ex.Name + "_" + ex.ID;
        static public GameObject go(this GAMEOBJECT ex) => ex.pow_go();

        static public void УдалениеОбъектов(this Transform p)
        {
            while (p.childCount != 0)
                foreach (Transform child in p)
                {
                    Object.DestroyImmediate(child.gameObject);
                }
        }
        static public int ВсегоВертексов(this GameObject go)
        {
            try
            {
                var mf = go.GetComponent<MeshFilter>();

                if (mf == null)
                    return 0;

                if (mf.sharedMesh == null)
                    return 0;
                return mf.sharedMesh.vertices.Length;
            }
            catch
            {

            }
            return 0;
        }
    }
}