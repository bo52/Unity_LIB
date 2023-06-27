using System.Collections.Generic;
using UnityEngine;
public interface IVertices
{

    /// <summary>
    /// центральный вектор
    /// </summary>
    Vector3 Центр{
        get;
        set;
    }
    /// <summary>
    /// набор вершин
    /// </summary>
    List<Vector3> vs{
        get;
    }
    /// <summary>
    /// нумерация вершин
    /// </summary>
    List<int> ts{
        get;
    }
    /// <summary>
    /// нормали
    /// </summary>
    List<Vector3> ns{
        get;
    }
    void Очистить();
    void Строим(Vector3 dv, System.Func<Vector2[]> fun);
    void Строим(byte face, byte НомерВершины, sbyte size);
}
