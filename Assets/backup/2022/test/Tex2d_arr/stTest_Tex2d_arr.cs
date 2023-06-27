//Bo52_16012021121834615.PROTOTYPE.
namespace test2022
{
    using UnityEngine;

    public static class stTest_Tex2d_arr
    {
        static public string INFO = "Texture2DArray";
        static public string PRODUCT = "хранить три вектора";
        static public bool FIXED = false;
        static public byte MAX = 16;
        static public Texture2DArray TEX = new Texture2DArray(MAX+2, MAX + 2, MAX + 2, TextureFormat.RGBAFloat, false);
        static public void test()
        {
            //code
        }
        static public string ЧетыреЦифры(float x,out char d)
        {
            var s = x.ToString();
            var i = s.IndexOf(",") + 1;

            var I = i + 2;
            d = (s.Length > I)?s[I] :'0';
            return s.Substring(i, 2);
        }
        static public float ЧетыреЦифры(Vector3 v)
        {
            char d1, d2, d3;
            var x = ЧетыреЦифры(v.x, out d1);
            var y = ЧетыреЦифры(v.y, out d2);
            var z = ЧетыреЦифры(v.z, out d3);
            var s = "1" + x + y + z;
            //var u= System.Convert.ToInt64(s);
            var f= System.Convert.ToSingle(s);
            return f;
        }
        static public Color ЧетыреЦифры(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            return new Color(ЧетыреЦифры(v1), ЧетыреЦифры(v2), ЧетыреЦифры(v3));
        }
        static public Vector3 ЧетыреЦифрыВектора(float X)
        {
            var s = X.ToString();
            var x = System.Convert.ToSingle("0," + s.Substring(1,2));
            var y = System.Convert.ToSingle("0," + s.Substring(3,2));
            var z = System.Convert.ToSingle("0," + s.Substring(5,2));

            return new Vector3(x, y, z) - 0.5f * Vector3.one;
        }

        static public void ЧетыреЦифры(Color c, out Vector3 v1, out Vector3 v2, out Vector3 v3 )
        {
            v1 = ЧетыреЦифрыВектора(c.r);
            v2 = ЧетыреЦифрыВектора(c.g);
            v3 = ЧетыреЦифрыВектора(c.b);

            Debug.Log(v1.x + "," + v1.y + "," + v1.z + "|"
                + v2.x + "," + v2.y + "," + v2.z + "|"
                + v3.x + "," + v3.y + "," + v3.z);
        }
        static public void SAVE()
        {
            if (!stButton_gui.кнопка("PROTOTYPE_SAVE "+ PRODUCT, 300))
                return;
            var cs=TEX.GetPixels(0);

            var t = 0.7323823473456323476663251f;
            var v1 = new Vector3(0.4012f, 0.1234f, 0.2123f);
            var v2 = new Vector3(0.2123f, 0.3234f, 0.2345f);
            var v3 = new Vector3(0.1234f, 0.0234f, 0.1325f);
            Debug.Log(v1.x+","+v1.y+","+ v1.z+"|"
                + v2.x + "," + v2.y + "," + v2.z +"|"
                + v3.x + "," + v3.y + "," + v3.z);

            v1 += 0.5f * Vector3.one;
            v2 += 0.5f * Vector3.one;
            v3 += 0.5f * Vector3.one;
            //[1][0000][0000][0000]
            cs[0] = ЧетыреЦифры(v1, v2, v3);
            var c = cs[0];
            Debug.Log(c.r+"|"+ c.g+"|"+ c.b);
            Debug.Log(cs[0].r);
            TEX.SetPixels(cs,0);
            TEX.Apply();

            cs = TEX.GetPixels(0);
            c = cs[0];
            Debug.Log(c.r + "|" + c.g + "|" + c.b);

            ЧетыреЦифры(c, out v1, out v2, out v3);

            test();
        }
        static public void LOAD()
        {
            if (!stButton_gui.кнопка("PROTOTYPE_LOAD " + PRODUCT, 300))
                return;
            var cs = TEX.GetPixels(0);
            var c = cs[0];
            Debug.Log(c.r);
        }
        static public void GUI()
        {
            SAVE();
            LOAD();
        }
    }
}
