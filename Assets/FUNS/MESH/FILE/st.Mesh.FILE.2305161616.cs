//Bo52_04032021130903272.STAT.FILE.
//Bo52_04032021130903272.STAT.FILE_mesh
//Меш сохранить,загрузить
using UnityEditor;
using UnityEngine;
namespace LIB.st2305161616
{
    /// <summary>
    /// stFILE_mesh
    /// Файл.МЕШ
    /// Меш сохранить,загрузить
    /// </summary>
    static public class Class
    {
        /// <summary>
        /// СохранитьМешФайлом
        /// </summary>
        /// <param name="M"></param>
        /// <param name="index"></param>
        static public void fun230516161600(Mesh M, int index)
        {
            if (M == null) return;
            if (index < 0) return;
            AssetDatabase.CreateAsset(M, st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(index.ToString()));
        }
        /// <summary>
        /// МешОбъекта
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        static public Mesh fun230516161603(GameObject go)
        {
            var mf = go.GetComponent<MeshFilter>();
            if (mf == null)
                return null;
            return mf.sharedMesh;
        }
        ///exit
    }
}
