//Bo52_16102020220751476.STATIC
namespace utility2022
{
    using UnityEngine;
    static public class stMesh_vertex_modif
    {
        static public string INFO = "Объект.Модификация.Вершина";
        static public string PRODUCT = "Изменить вершину в дочерних объектах родителя";
        static public void МодификацияВершин(this GameObject p, Vector3 old_v, Vector3 new_v)
        {
            Mesh oMesh;
            foreach (Transform child in p.transform)
            {
                oMesh = child.gameObject.GetComponent<MeshFilter>().sharedMesh;
                Vector3[] vertices = oMesh.vertices;
                for (var n = 0; n < oMesh.vertices.Length; n++)
                {
                    if (oMesh.vertices[n] == old_v)
                    {
                        vertices.SetValue(new_v, n);
                    }
                }
                oMesh.vertices = vertices;
                oMesh.RecalculateNormals();
            }

        }
    }
}
