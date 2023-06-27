using UnityEngine;
namespace go2023
{
    static public class stGo
    {
        static public string INFO = "Объект.Модификация.Удаление";
        static public string PRODUCT = "РаботаСОбъектом";

        static public void УдалениеОбъектов(this Transform p)
        {
            while (p.childCount != 0)
                foreach (Transform child in p)
                {
                    Object.DestroyImmediate(child.gameObject);
                }
        }
    }
}