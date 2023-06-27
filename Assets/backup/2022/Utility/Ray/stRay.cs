//Bo52_1610202014335583.STATIC
namespace utility2022
{
    using UnityEditor;
    using UnityEngine;
    /// <summary>
    /// ЛУЧ
    /// На Сцене пустить Луч (на объект по фильтру тега,слоя)
    /// </summary>
    static public class stRay
    {
        static public void ВыделитьВершинуНаСцене()
        {
            RaycastHit HIT;

            Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
            int layerMask = 1 << 9;

            if (!Physics.Raycast(ray, out HIT, Mathf.Infinity, layerMask))
                return;

            if (HIT.collider == null)
                return;

            if (HIT.collider.gameObject.tag == "vertex")
                Selection.objects = new Object[1] { HIT.collider.gameObject };
        }
    }
}
