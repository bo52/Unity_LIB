using UnityEditor;
using UnityEngine;
namespace scr2022
{
    static public class stTexture3d_create
    {
        static byte R = 32;
        static public Texture3D Создать()
        {
            var tex = new Texture3D(R * 24, R * 24, R * 24, TextureFormat.Alpha8, false);
            for (byte x = 0; x < 32; x++)
                for (byte y = 0; y < 32; y++)
                    for (byte z = 0; z < 2; z++)
                        tex.SetPixel(x, y, z, new Color(0, 0, 1, 1));
            tex.Apply();
            string namefile = "Assets/Resources/test.asset";
            AssetDatabase.CreateAsset(tex, namefile);

            return tex;
        }
    }
}