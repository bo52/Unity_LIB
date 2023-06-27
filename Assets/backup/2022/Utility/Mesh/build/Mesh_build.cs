//Bo52_08052021133208718.constr.Mesh.Surface_08052021133208718.
//Constr_08052021133208718
//Bo52_08052021133208718.constr.Mesh.Surface
namespace utility2022
{
    using System.Collections.Generic;
    using UnityEngine;
    using Utility2023;

    /// <summary>
    /// Mesh.Constr
    /// ñîáğàòü áëîêè
    /// </summary>
    public class Mesh_build
    {
        public List<Vector3> vertices = new List<Vector3>();
        public List<int> triangles = new List<int>();
        public List<Vector3> normals = new List<Vector3>();
        public List<Color> colors = new List<Color>();
        public List<Vector2>[] uv = new List<Vector2>[8]
        {
                    new List<Vector2> { },
                    new List<Vector2> { },
                    new List<Vector2> { },
                    new List<Vector2> { },
                    new List<Vector2> { },
                    new List<Vector2> { },
                    new List<Vector2> { },
                    new List<Vector2> { },
        };
        public virtual Mesh ÎÒÊĞÛÒÈÅ => ÑÒĞÎÈÒÜ;
        public virtual Mesh ÑÒĞÎÈÒÜ => ÌÅØ;
        public virtual Mesh ÌÅØ => ÇÀÊĞÛÒÈÅ;
        public virtual Mesh ÇÀÊĞÛÒÈÅ
        {
            get
            {
                var m = new Mesh();
                m.vertices = vertices.ToArray();
                m.triangles = triangles.ToArray();
                m.normals = normals.ToArray();
                m.colors = colors.ToArray();

                //çàôèêñèğîâàòü â UV
                //ÊÎÎĞÄÈÍÀÒÀ ÒÅÊÑÒÓĞÛ
                m.uv = uv[0].ToArray();
                m.uv2 = uv[1].ToArray();
                m.uv3 = uv[2].ToArray();
                m.uv4 = uv[3].ToArray();
                m.uv5 = uv[4].ToArray();
                m.uv6 = uv[5].ToArray();
                m.uv7 = uv[6].ToArray();
                m.uv8 = uv[7].ToArray();
                m.Ïåğåñ÷¸òÌåø();
                Î÷èñòèòü();
                return m;
            }
        }
        public virtual Mesh Çàêğûòèå() => ÇÀÊĞÛÒÈÅ;
        public virtual void Î÷èñòèòü()
        {
            vertices.Clear();
            triangles.Clear();
            normals.Clear();
            colors.Clear();
            uv[0].Clear();
            uv[1].Clear();
            uv[2].Clear();
            uv[3].Clear();
            uv[4].Clear();
            uv[5].Clear();
            uv[6].Clear();
            uv[7].Clear();
        }
    }
}
