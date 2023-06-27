using System.Collections.Generic;
using UnityEngine;
namespace chunk2023
{
    using block2023;
    using go2023;
    public class mbChunk_cube : MonoBehaviour
    {
        private dictChunk_cube РедакторЧанк = new dictChunk_cube();
        public void Загрузить()
        {
            РедакторЧанк.Изменить(gameObject, null, true);
        }
        GameObject go;
        GameObject Объект
        {
            get
            {
                if (go == null)
                {
                    go = stGo_scene.Земля;
                    РедакторЧанк.Изменить(go, null, true);
                }
                return go;
            }
        }
        Dictionary<ulong, Block> Карта;
        private byte Z_current;
        public void ТекущийОбъект() => GUILayout.Label("Объект=" + Объект.gameObject.name + "," + Объект.gameObject.transform.position);
        public void ПройтиПоКарте()
        {
            ТекущийОбъект();
            //РедакторЧанк.ПройтиПоКарте(ref Z_current, Объект, step);
        }
    }
}