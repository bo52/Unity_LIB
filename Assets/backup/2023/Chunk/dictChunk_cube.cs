using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace chunk2023
{
    using mesh2023;
    using gui2023;
    using utility2023;
    using cube2023;
    public class dictChunk_cube : Dictionary<ulong, Vector3>
    {
        public Dictionary<ulong, byte> Блоки = new Dictionary<ulong, byte>();
        public void Изменить(GameObject go, System.Action act = null, bool load = false)
        {
            if (load) Загрузить(go);
            act?.Invoke();
            //постройка chunk
            //foreach (var b in Блоки)
                //Конструктор.Вертексы.Куб(b.Key.GET_V(), b.Value);
            //(Конструктор as IMesh).Закрыть(go, !load);
        }
        static readonly Vector3[] Соседи_путь = new Vector3[]
        {
                Vector3.back,
                Vector3.down,
                Vector3.left,

                Vector3.left+Vector3.back,
                Vector3.left+Vector3.down,
                Vector3.left+Vector3.back+Vector3.down,
                Vector3.back+Vector3.down,
        };
        static public readonly byte[] Соседи_номер_вершины = new byte[] { 4, 2, 1, 5, 3, 7, 6 };
        public void Очистить()
        {
            this.Clear();
            Блоки.Clear();
        }
        public void ОбновитьКодСоседейПоКоординатеБлока(Vector3 Координата, ulong ID, bool удаление)
        {
            //var существует = Блоки.ContainsKey(ID);
            for (var i = 0; i < Соседи_путь.Length; i++)
            {
                var v = Координата + Соседи_путь[i];
                var id = v.GET_ID();
                //Debug.Log(v + "=" + id.GET_V());
                var есть = Блоки.ContainsKey(id);
                var B = есть ? Блоки[id] : 0;

                var b = B + Mathf.Pow(2, Соседи_номер_вершины[i]) * (удаление ? -1 : 1);
                B = (byte)(b < 0 ? 0 : b);

                if (B == 0)
                {
                    if (есть)
                        Блоки.Remove(id);
                }
                else
                {
                    if (!есть) Блоки.Add(id, 0);
                    Блоки[id] = (byte)B;
                }

            }
        }
        public void Загрузить(GameObject go)
        {
            Очистить();
            var m = go.ФайлМеша();
            if (m != null)
                for (var i = 0; i < m.vertices.Length; i++)
                {
                    var v = new Vector3(m.uv2[i].x, m.uv2[i].y, m.uv3[i].x);
                    var id = v.GET_ID();

                    if (Блоки.ContainsKey(id)) continue;
                    var code = (byte)m.uv3[i].y;
                    if (code.ПервыйИндексКодаСуществует()) this.Add(id, v);
                    Блоки.Add(id, code);
                }
        }
        public void Инверсия(GameObject go, Vector3 Координата)
        {
            Изменить(go, () =>
            {
                var id = Координата.GET_ID();
                bool ТочкаСуществует = this.ContainsKey(id);
                bool БлокСуществует = Блоки.ContainsKey(id);
                switch (ТочкаСуществует)
                {
                    case true://удаление
                    this.Remove(id);
                    //b
                    if (БлокСуществует) Блоки[id] -= 1;
                        if (Блоки[id] == 0)
                            Блоки.Remove(id);
                        break;
                    case false://добавление
                    this.Add(id, Координата);
                    //b
                    if (!БлокСуществует) Блоки.Add(id, 0);
                        Блоки[id] += 1;
                        break;
                }
                ОбновитьКодСоседейПоКоординатеБлока(Координата, id, ТочкаСуществует);

            });
        }
        #region вспомогательное
        static public readonly GUILayoutOption[] width = new GUILayoutOption[] { GUILayout.Width(18) };
        static public readonly GUILayoutOption[] Width = new GUILayoutOption[] { GUILayout.Width(18) };
        #endregion
        public void ПройтиПоКарте(ref byte Z_current, GameObject go, byte step)
        {
            GUILayout.BeginVertical();
            stSlider.ползунок_байты(ref Z_current, 0, (byte)(step - 1));

            stBtn.btn("default", () =>
            {
                Очистить();
                Инверсия(go, Vector3.zero);
            });

            for (var y = step - 1; y >= 0; y--)
            {
                GUILayout.BeginHorizontal(width);
                for (var x = 0; x < step; x++)
                {
                    EditorGUILayout.LabelField(x.ToString() + y.ToString(), Width);

                    GUILayout.BeginVertical();
                    GUILayout.BeginHorizontal(new GUILayoutOption[] { GUILayout.Width(10) });

                    var v = new Vector3(x, y, Z_current);
                    var ид = v.GET_ID();
                    var val = ContainsKey(ид);
                    var new_x = EditorGUILayout.Toggle("", val, width);

                    if (new_x != val)
                        Инверсия(go, v);
                    GUILayout.EndHorizontal();
                    GUILayout.EndVertical();
                }
                GUILayout.EndHorizontal();
            }
            GUILayout.EndVertical();
        }
        static public void Изменить(GameObject go, Vector3 Координата) => new dictChunk_cube().Инверсия(go, Координата);
        static public void Изменить(GameObject go) => new dictChunk_cube().Изменить(go);
    }
}