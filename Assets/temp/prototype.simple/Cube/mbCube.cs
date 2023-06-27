using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace cube2023
{
    using mesh2023;
    public class mbCube : MonoBehaviour
    {
        public Texture3D ��������������;
        private void Awake()
        {
            �������������� = new Texture3D(stCube_buid.MAX, stCube_buid.MAX, stCube_buid.MAX, TextureFormat.ARGB32, false);
        }
        private void Start()
        {
            //var edit = new Cube_buid(this);
            //edit.test(gameObject);
        }
        public void ���������()
        {
            this.��������(0);
        }
        [CustomEditor(typeof(mbCube))]
        public class gui : Editor
        {
            public override void OnInspectorGUI()
            {
                ((mbCube)target).���������();
            }
        }
    }
    public class Cube_part
    {
        public byte ������;
        public byte ������;
        public byte ������;
        public Vector3Int ����������;
        public Cube_part(Vector3Int v, byte h, byte w)
        {
            ������ = h;
            ������ = w;
            ������ = 1;
            ���������� = v;
        }
        public Vector3 ������ => ����������;
    }
    public static class stCube_buid
    {
        static public byte MAX = 3;
        static public Color empty = new Color(0, 0, 0, 0);
        static public string ���� => "Assets/Resources/default/empty_3d.asset";

        static public void ��������(ref List<Vector3> vs, ref List<int> ts, ref List<Vector3> ns, Vector3 v)
        {
            vs.Add(v);
            ts.Add(vs.Count - 1);
            ns.Add(v.normalized);
        }
        static public Vector3[] ARR = new Vector3[]
        {
            new Vector3(0,0,0),new Vector3(0,1,0),new Vector3(1,0,0),//4
            new Vector3(1,0,0),new Vector3(0,1,0),new Vector3(1,1,0),//4

            new Vector3(0,0,1),new Vector3(1,0,1),new Vector3(0,1,1),//5
            new Vector3(1,0,1),new Vector3(1,1,1),new Vector3(0,1,1),//5

            new Vector3(0,0,0),new Vector3(0,0,1),new Vector3(0,1,1),
            new Vector3(0,1,0),new Vector3(0,0,0),new Vector3(0,1,1),

            new Vector3(1,1,1),new Vector3(1,0,1),new Vector3(1,0,0),
            new Vector3(1,1,1),new Vector3(1,0,0),new Vector3(1,1,0),

            new Vector3(0,0,0),new Vector3(1,0,0),new Vector3(0,0,1),
            new Vector3(1,0,0),new Vector3(1,0,1),new Vector3(0,0,1),

            new Vector3(0,1,1),new Vector3(1,1,0),new Vector3(0,1,0),
            new Vector3(0,1,1),new Vector3(1,1,1),new Vector3(1,1,0),

        };

        static private readonly Vector2[] UV = { 
            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(0, 1), new Vector2(1, 1), new Vector2(1, 0),

            new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 1),
            new Vector2(0, 1), new Vector2(1, 0), new Vector2(1, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),

            new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 0),
            new Vector2(1, 0), new Vector2(1, 1), new Vector2(0, 1),
        };
        static public void �������������(ref List<Vector3> vs, ref List<int> ts, ref List<Vector3> ns, ref List<Vector2> uvs, Vector3 v, int h,int w,int s)
        {
            var i = 0;
            var delta = 1 / (float)MAX;
            foreach (var dv in ARR)
            {
                ��������(ref vs, ref ts, ref ns, delta * (v + Vector3.Scale(dv, h * Vector2.up) + Vector3.Scale(dv, w * Vector2.right) + Vector3.Scale(dv, s * Vector3.forward)));
                uvs.Add(delta * (new Vector2(v.x, v.y)+ Vector2.Scale(UV[i], h * Vector2.up) + Vector2.Scale(UV[i], w * Vector2.right)));
                i++;
            }
        }
        static public Mesh ����������������(this List<Cube_part>ps)
        {
            var m = new Mesh();
            List<Vector3> vs = new List<Vector3>();
            List<int> ts = new List<int>();
            List<Vector3> ns = new List<Vector3>();
            List<Vector2> uvs = new List<Vector2>();
            foreach (var part in ps)
                �������������(ref vs, ref ts, ref ns,ref uvs,part.������, part.������, part.������, part.������);
            m.vertices = vs.ToArray();
            m.triangles = ts.ToArray();
            m.normals = ns.ToArray();
            m.uv = uvs.ToArray();
            return m;
        }
    }
    static public class stCube_build_start
    {
        /// <summary>
        /// ��������� ����������
        /// </summary>
        static private int X = 0;
        static private int Y = 0;
        static private int Z = 0;
        static private byte W = 0;
        static private byte H = 0;
        static public bool ��������������(this Cube_buid build, int x, int y, int z = 0)=>build.mb.��������������.GetPixel(x, y, z).a == 1.0f;
        static public void ��������(this Cube_buid build)
        {
            var part=build.�����.Find((x)=>  {
                var v0 = x.������;
                return x.������==H && x.������== W && v0.x==X&& v0.y == Y && v0.z+ x.������ == Z; 
            });
            if (part==null)  
                build.�����.Add(new Cube_part(new Vector3Int(X, Y, Z), H, W));
            else
                part.������ += 1;

        }

        static public byte ���������������(Cube_buid build,int z)
        {
            byte w = 1;
            H = 1;
            var x = X + 1;
            while (x < stCube_buid.MAX)
            {
                if (build.����[x, Y, z]) break;
                build.����[x, Y, z] = true;
                if (!build.��������������(x, Y, z))
                    break;
                w += 1;

                x += 1;
            }
            return w;
        }
        static public byte ����������������(Cube_buid build)
        {
            var y = Y + 1;
            byte h = 1;
            while (y < stCube_buid.MAX)
            {
                var x = X;
                while (x < X + W)
                {
                    if (build.����[x, y, Z]) return h;
                    build.����[x, y, Z] = true;
                    if (!build.��������������(x, y, Z))
                        return h;
                    x += 1;
                }
                h += 1;
                y += 1;
            }
            return h;
        }

        static public void ����������������(this Cube_buid build)
        {
                while (Y < stCube_buid.MAX)
                {
                X = 0;
                    while (X < stCube_buid.MAX)
                    {                       
                        if (!build.����[X, Y, Z])
                        {
                            build.����[X, Y, Z] = true;
                            if (build.��������������(X, Y, Z))
                            {
                                W = ���������������(build,Z);
                                H = ����������������(build);
                                ��������(build);
                                //X += W;                               
                                return;
                            }
                        }
                        X += 1;
                    }
                    Y += 1;
                }
        }
        static public void ������(this Cube_buid build)
        {
            build.�����.Clear();
            Z = 0;
            while (Z < stCube_buid.MAX)
            {
                Y = 0;
                while (Y < stCube_buid.MAX)
                {
                    X = 0;
                    while (X < stCube_buid.MAX)
                    {
                        if (!build.����[X, Y, Z]) 
                            build.����������������();
                        X++;
                    }
                    Y++;
                }
                Z++;
            }
        }
        static public void ��������(this mbCube mb, byte z)
        {
            for (var y = stCube_buid.MAX - 1; y >= 0; y--)
            {
                GUILayout.BeginHorizontal(new GUILayoutOption[] { GUILayout.Width(18) });
                for (var x = 0; x < stCube_buid.MAX; x++)
                {
                    GUILayout.BeginVertical();
                    GUILayout.BeginHorizontal(new GUILayoutOption[] { GUILayout.Width(10) });
                    var val = mb.��������������.GetPixel(x, y, z).a == 1.0f;
                    var new_val = EditorGUILayout.Toggle("", val, new GUILayoutOption[] { GUILayout.Width(18) });
                    if (val!= new_val)
                    {
                        mb.��������������.SetPixel(x, y, z, new_val ? new Color(0, 0, 0, 1) : new Color(0, 0, 0, 0));

                        var edit = new Cube_buid(mb);
                        edit.�������(mb.gameObject);
                    }
                    GUILayout.EndHorizontal();
                    GUILayout.EndVertical();
                }
                GUILayout.EndHorizontal();
            }
        }
    }

    public class Cube_buid
    {

        public mbCube mb;
        public List<Cube_part> ����� = new List<Cube_part>();
        public bool[,,] ���� = new bool[stCube_buid.MAX, stCube_buid.MAX, stCube_buid.MAX];

        public Cube_buid(mbCube mb)
        {
            this.mb = mb;
        }
        public void ������()
        {
            for (byte x = 0; x < stCube_buid.MAX; x++)
                for (byte y = 0; y < stCube_buid.MAX; y++)
                    for (byte z = 0; z < stCube_buid.MAX; z++)
                        mb.��������������.SetPixel(x, y, z, new Color(0, 0, 0, 1.0f));
            mb.��������������.Apply();
            AssetDatabase.CreateAsset(mb.��������������, stCube_buid.����);
        }
        public void test(GameObject go)
        {
            ������();
            mb.��������������.SetPixel(0, 0, 0, stCube_buid.empty);
            mb.��������������.SetPixel(0, 1, 1, stCube_buid.empty);
            �������(go);
        }
        public Mesh �������(GameObject go)
        {
            this.������();
            var m = �����.����������������();
            //go.�������(m, false);
            return m;
        }
    }
}