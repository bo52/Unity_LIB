//empty
//empty
//удаление дочерних игровых объектов
using UnityEngine;
namespace LIB.st2305221205
{
    /// <summary>
    /// stGo
    /// </summary>
    static public class Class
    {
        static public string INFO = "Объект.Модификация.Удаление";
        static public string PRODUCT = "РаботаСОбъектом";
        /// <summary>
        /// найти родителя по имени и удалить все дочерние объекты
        /// </summary>
        /// <param name="p"></param>
        /// <param name="name"></param>
        static public void fun230522120500(this GameObject p, string name)
        {
            var build = p.transform.Find(name);
            if (build == null) return;
            (build.gameObject)?.fun230522120501();
        }
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="go"></param>
        static public void fun230522120501(this GameObject go)=> Object.DestroyImmediate(go);
        /// <summary>
        /// УдалениеОбъектов
        /// </summary>
        /// <param name="p"></param>
        static public void fun230522120502(this Transform p)
        {
            while (p.childCount != 0)
                foreach (Transform child in p)
                    child.gameObject.fun230522120501();
        }
        ///exit
    }
}