using UnityEngine;
namespace scr2022
{
    /// <summary>
    /// ќкруглить
    /// –абота c ¬ектором (ќкругление ¬низ)
    /// </summary>
    static public class stVector_round
    {
        static public Vector3Int ¬екторЅлока => ќкруглить¬екторѕоловиной¬÷елый(stRaycastHit.HIT.point);
        static public int ћинимальное„исло¬низ(this float X)
        {
            int k = X < 0 ? -1 : 1;
            //-0.6f -> -1
            //-0.4f -> +0
            //+0.4f -> +0
            //+0.6f -> +1
            var cel = (int)Mathf.Abs(X);
            var d = Mathf.Abs(X) - cel;
            cel += Mathf.Abs(d) <= 0.5f ? 0 : 1;
            return k * cel;
        }
        static public Vector3 ќкруглить¬екторѕоловиной(this Vector3 v)
        {

            return new Vector3(v.x.ћинимальное„исло¬низ(), v.y.ћинимальное„исло¬низ(), v.z.ћинимальное„исло¬низ());
        }
        static public Vector3Int ќкруглить¬екторѕоловиной¬÷елый(this Vector3 v)
        {

            return new Vector3Int(v.x.ћинимальное„исло¬низ(), v.y.ћинимальное„исло¬низ(), v.z.ћинимальное„исло¬низ());
        }
    }
}
