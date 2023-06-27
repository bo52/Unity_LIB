using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace chunk2023
{
    using mesh2023;
    using cube2023;
    using utility2023;
    public class Chunk : Vertices,spBuild.Cube256.Int
    {
        private List<ulong> Точки => null;
        private List<ulong> Оставшиеся = new List<ulong>();
        private Dictionary<ulong, Vector3> Обработанные = new Dictionary<ulong, Vector3>();
        private Dictionary<ulong, byte> Блоки = new Dictionary<ulong, byte>();
        public Chunk():base()
        {
            СоздатьБлоки();
        }
        public void СоздатьБлоки()
        {
            Обработанные.Clear();
            Оставшиеся.Clear();
            Блоки.Clear();

            Оставшиеся = Точки.ToList();

            for (var i = Оставшиеся.Count - 1; i >= 0; i--)
                СоздатьБлоки(Оставшиеся[i], Оставшиеся[i].GET_V());
            //foreach (var b in Блоки)
                //(this as ICube256_vs).Куб(b.Key.GET_V(), b.Value);
            //сохранить меш в файл
            //(this as IMesh).Закрыть(go);
        }

        public bool СоздатьБлоки(ulong ID, Vector3 V)
        {
            if (Обработанные.ContainsKey(ID)) return false;

            byte code = 0;
            for (var i = 0; i < IBlock8_vs.ВершиныОтносительноКоординатыБлока.Length; i++)
                code += (byte)(Точки.IndexOf((V + IBlock8_vs.ВершиныОтносительноКоординатыБлока[i]).GET_ID()) == -1 ? 0 : Mathf.Pow(2, i));

            Обработанные.Add(ID, V);
            Оставшиеся.Remove(ID);

            if (code == 0) return true;

            Блоки.Add(ID, code);
            if (code.ПервыйИндексКодаСуществует())
                for (var i = 0; i < stCube_neighbours.Соседи_путь[0].Length; i++)
                {
                    var v = V + stCube_neighbours.Соседи_путь[0][i];
                    СоздатьБлоки(v.GET_ID(), v);
                }
            return true;
        }
    }
}