using UnityEngine;
//namespace Bo52_08102020215421948.STATIC
namespace utility2022
{
    /// <summary>
    /// ћ≈Ў.“реугольник
    /// –абота—ћешем.“реугольник
    /// </summary>
    static public class stMesh_triangle
    {
        static private readonly Vector2[] UV = { new Vector2(0, 1), new Vector2(1, 1), new Vector2(1, 0) };
        static private readonly int[] TRIANGLES = { 0, 1, 2, };
        static public Mesh —обрать“реугольныйћеш(Vector3[] vs)
        {

            Mesh m = new Mesh();
            m.vertices = vs;
            m.triangles = TRIANGLES;
            m.uv = UV;
            ќбновить(m);
            return m;
        }
        static public void ќбновить(Mesh m)
        {
            m.colors = new[]
            {
                    Color.Lerp(Color.red, Color.green, m.vertices[0].y),
                    Color.Lerp(Color.red, Color.green, m.vertices[1].y),
                    Color.Lerp(Color.red, Color.green, m.vertices[2].y),
            };
            m.normals = new[]{
                m.vertices[0].normalized,
                m.vertices[1].normalized,
                m.vertices[2].normalized,
            };
            m.RecalculateBounds();
            m.RecalculateNormals();
        }
    }
}