using UnityEngine;
namespace task2022
{
    using scr2022;
    public interface IBlock_ray
    {
        static private bool but = false;
        /// <summary>
        /// блок может уже не существовать!!!
        /// </summary>
        static public Vector3Int ФиксированныйКогдаТоБлок;
        static public void ФиксироватьБлок()
        {
            if (stRaycastHit.HIT.collider == null)
                return;
            ФиксированныйКогдаТоБлок = stVector_round.ВекторБлока;
        }
        static public void Показать()
        {
            stFoldout_gui.Foldout(() =>
            {
                if (stRaycastHit.HIT.collider == null)
                    return;
                GUILayout.Label("Точка=" + stRaycastHit.HIT.point.x + "=" + stRaycastHit.HIT.point.y + "=" + stRaycastHit.HIT.point.z);
                GUILayout.Label("Нормаль=" + stRaycastHit.HIT.normal.x + "=" + stRaycastHit.HIT.normal.y + "=" + stRaycastHit.HIT.normal.z);
                var v = stVector_round.ВекторБлока;
                GUILayout.Label("Блок=" + v.x + "=" + v.y + "=" + v.z);
            }, "HIT=" + (stRaycastHit.HIT.collider != null) + ",ФиксированныйКогдаТоБлок=" + ФиксированныйКогдаТоБлок.ToString(), ref but);
        }
        static public void И() => stRaycastHit.ПуститьЛучПоМаске(9);
        static public void event_leftMouseDown() => ФиксироватьБлок();
    }
}
