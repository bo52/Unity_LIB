//empty
//empty
//vertices.close закрытие вертексов(stMesh.build.vertices.close.cs2305141208)
using System;
using UnityEngine;
namespace LIB.cs2305141208
{
    /// <summary>
    /// stMesh.build.vertices.close.cs2305141208
    /// </summary>
    public interface IClass
    {
        cs2305141215.IClass Editor { get; }
        System.Action<cs2305141215.IClass> ФункцияПостройки { get; }
        Mesh ПолучитьМеш();
        Mesh Закрыть();
    }
    public class Class : IClass
    {
        private cs2305141215.IClass _editor;
        public cs2305141215.IClass Editor =>_editor;

        private System.Action<cs2305141215.IClass> _fun_build;
        public System.Action<cs2305141215.IClass> ФункцияПостройки => _fun_build;
        public Class(System.Action<cs2305141215.IClass> ФункцияПостройки,byte НомерРедактора = 1)
        {
            _fun_build = ФункцияПостройки;
            switch (НомерРедактора)
            {
                case 1:
                    _editor = new cs2306291643.Class();
                    break;
                case 2:
                    _editor = new cs2305141209.Class();
                    break;
                case 3:
                    _editor = new cs2305141209.Class();
                    break;
            }
        }
        public virtual Mesh Закрыть()
        {
            ФункцияПостройки(_editor);
            return ПолучитьМеш();
        }
        public Mesh ПолучитьМеш()
        {
            var M = new Mesh();
            M.vertices = _editor.vs.ToArray();

            var uvs = (_editor as cs2305141222.IClass);
            M.uv = uvs.Развёртка[0].ToArray();
            M.uv2 = uvs.Развёртка[1].ToArray();
            M.uv3 = uvs.Развёртка[2].ToArray();
            M.uv4 = uvs.Развёртка[3].ToArray();
            M.uv5 = uvs.Развёртка[4].ToArray();
            M.uv6 = uvs.Развёртка[5].ToArray();
            M.uv7 = uvs.Развёртка[6].ToArray();
            M.uv8 = uvs.Развёртка[7].ToArray();

            M.triangles = _editor.ts.ToArray();
            M.normals = _editor.ns.ToArray();
            M.RecalculateNormals();
            M.RecalculateBounds();
            _editor.Очистить();
            return M;
        }
    }
}
