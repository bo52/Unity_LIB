//empty
//empty
//empty
using UnityEditor;
using UnityEngine;
namespace LIB.cs2305162045
{
    /// <summary>
    /// КомпонентыМеша
    /// </summary>
    public struct Class
    {
        static public string INFO = "INFO";
        public GameObject go;
        public Mesh m;
        public string Файл;
        public Class(Mesh m, GameObject go = null, string Файл = "")
        {
            this.m = m;
            this.go = go;
            this.Файл = Файл;
        }
        public void Связать()
        {
            st2305072046.Class.fun230507204600_ПривязатьМешКОбъекту(m,go);
            Сохранить();
        }
        /// <summary>
        /// СохранитьМешОбъекта
        /// </summary>
        /// <param name="Меш"></param>
        private void Сохранить()
        {
            if (Файл == "") return;
            //go.GetComponent<MeshFilter>().sharedMesh
            var f = st2305181538.Class.fun230518153801_ПолучитьФайлМешаПоИмени(Файл);
            AssetDatabase.CreateAsset(m, f);
        }
    }
}
