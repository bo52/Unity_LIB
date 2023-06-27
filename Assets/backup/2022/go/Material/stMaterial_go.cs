using UnityEngine;
namespace go2022
{
    /// <summary>
    /// Материал
    /// </summary>
    static class stMaterial_go
    {
        /// <summary>
        /// один из встроенных шейдеров
        /// </summary>
        //static string шейдер = "Custom/sphere_blend";
        static string шейдер = "Standard";
        //static string шейдер = "Custom/color_shader";
        static public readonly string[] mat_DIRS = new string[]{
            "materials/",
            "materials/8192/",
            "materials/textures/",
        };
        static public void СозданиеМатериала(this GameObject go, string mat = "", byte mat_dir = 0)
        {
            MeshRenderer mr = go.GetComponent<MeshRenderer>();
            if (mr == null)
            {

                mr = go.AddComponent<MeshRenderer>();
                if (mat == "")
                    mr.material = new Material(Shader.Find(шейдер));
            }
            if (mat != "")
                mr.sharedMaterial = Resources.Load(mat, typeof(Material)) as Material;
        }
    }
}