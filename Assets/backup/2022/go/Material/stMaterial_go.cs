using UnityEngine;
namespace go2022
{
    /// <summary>
    /// ��������
    /// </summary>
    static class stMaterial_go
    {
        /// <summary>
        /// ���� �� ���������� ��������
        /// </summary>
        //static string ������ = "Custom/sphere_blend";
        static string ������ = "Standard";
        //static string ������ = "Custom/color_shader";
        static public readonly string[] mat_DIRS = new string[]{
            "materials/",
            "materials/8192/",
            "materials/textures/",
        };
        static public void �����������������(this GameObject go, string mat = "", byte mat_dir = 0)
        {
            MeshRenderer mr = go.GetComponent<MeshRenderer>();
            if (mr == null)
            {

                mr = go.AddComponent<MeshRenderer>();
                if (mat == "")
                    mr.material = new Material(Shader.Find(������));
            }
            if (mat != "")
                mr.sharedMaterial = Resources.Load(mat, typeof(Material)) as Material;
        }
    }
}