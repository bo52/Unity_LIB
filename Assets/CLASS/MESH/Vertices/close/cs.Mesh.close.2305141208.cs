//empty
//empty
//vertices.close закрытие вертексов(stMesh.build.vertices.close.cs2305141208)
using UnityEngine;
namespace LIB.cs2305141208
{
    /// <summary>
    /// stMesh.build.vertices.close.cs2305141208
    /// </summary>
    public interface IClass : cs2305141215.IClass
    {
        GameObject GO { get; }
        Mesh ПолучитьМеш();
        void Закрыть();
    }
    public class Class : cs2305141215.Class, IClass
    {
        private GameObject _go;  public GameObject GO => _go;
        public Class(GameObject go) => this._go = go;
        public virtual void Закрыть()
        {
            var M = ПолучитьМеш();
            var Меш = new cs2305182039.Class(M, GO);
            Меш.Связать();
        }
        public Mesh ПолучитьМеш()
        {
            var M = new Mesh();
            M.vertices = vs.ToArray();

            var uvs = (this as cs2305141222.IClass);
            M.uv = uvs.Развёртка[0].ToArray();
            M.uv2 = uvs.Развёртка[1].ToArray();
            M.uv3 = uvs.Развёртка[2].ToArray();
            M.uv4 = uvs.Развёртка[3].ToArray();
            M.uv5 = uvs.Развёртка[4].ToArray();
            M.uv6 = uvs.Развёртка[5].ToArray();
            M.uv7 = uvs.Развёртка[6].ToArray();
            M.uv8 = uvs.Развёртка[7].ToArray();

            M.triangles = ts.ToArray();
            M.normals = ns.ToArray();
            M.RecalculateNormals();
            M.RecalculateBounds();
            Очистить();
            return M;
        }
    }
}
