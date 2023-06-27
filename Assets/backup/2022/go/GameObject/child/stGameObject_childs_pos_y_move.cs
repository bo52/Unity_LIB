namespace scr2022
{
    using UnityEngine;
    /// <summary>
    /// инструмент по смещению дочерних соседей
    /// </summary>
    public class stGameObject_childs_pos_y_move
    {
        static public void СдвинутьДочерниеПоВысоте(GameObject go)
        {
            var y = go.GetComponent<RectTransform>().localPosition.y;
            var i = 0;
            while (go != null)
            {
                go = Следующий(go);
                if (go == null)
                    break;
                var rt = go.GetComponent<RectTransform>();
                rt.localPosition = new Vector3(rt.localPosition.x, y - 0.5f * i * (rt.rect.height + 10), rt.localPosition.z);
                i++;
            }
        }
        static public GameObject Следующий(GameObject go)
        {
            var i = go.transform.GetSiblingIndex();
            if (go.transform.parent.childCount <= i + 1)
                return null;
            return go.transform.parent.GetChild(i + 1).gameObject;
        }
    }
}