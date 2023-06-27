using UnityEditor;
using UnityEngine;
namespace scr2022
{
    #region RaycastHit
    static public class stRaycastHit
    {
        static public RaycastHit HIT;
        static public GameObject ѕуститьЋуч()
        {
            var ev = Event.current;
            if (ev == null)
                return null;
            Ray ray = HandleUtility.GUIPointToWorldRay(ev.mousePosition);

            if (!Physics.Raycast(ray, out HIT, Mathf.Infinity))
                return null;

            if (HIT.collider == null)
                return null;
            return HIT.collider.gameObject;
        }
        static public GameObject ѕуститьЋучѕоћаске(int layerMask)
        {
            Ray ray = HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);
            layerMask = 1 << layerMask;
            Physics.Raycast(ray, out HIT, Mathf.Infinity, layerMask);

            return HIT.collider == null ? null : HIT.collider.gameObject;
        }
    }
    #endregion
}