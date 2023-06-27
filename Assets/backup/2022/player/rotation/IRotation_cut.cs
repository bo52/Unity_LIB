using UnityEngine;
namespace mb2022
{
    public interface IRotation_cut : IRotation_param
    {
        static public Vector3Int ¬ектор—мещени€(Vector3 V, int Z)
        {
            Vector3Int v = Vector3Int.zero;
            switch (pov)
            {
                case 0:
                    v = new Vector3Int(0, 0, (int)V.z + Z);
                    break;
                case 1:
                    v = new Vector3Int((int)V.x + Z, 0, 0);
                    break;
                case 2:
                    v = new Vector3Int(0, 0, (int)V.z + Z);
                    break;
                case 3:
                    v = new Vector3Int((int)V.x + Z, 0, 0);
                    break;
            }
            //if (Bo52.SCENE.REGIONS != null)
            //{
            //if (Bo52.SCENE.REGIONS.MONO.EDITOR != null)
            //{
            //if (Bo52.SCENE.REGIONS.MONO.EDITOR.MONO.CUBE != null)
            //{
            //    v += Bo52.SCENE.REGIONS.MONO.EDITOR.MONO.CUBE.¬ектор–егиона;
            //}
            //}
            //}
            return v;
        }
        static public bool ¬ходит¬—рез(Vector3 V, Vector3 v, Vector3Int v0)
        {
            switch (pov)
            {
                case 0:
                case 2:
                    v.z += (int)V.z;

                    v.z += pov == 2 ? -1 : 1;
                    return v.z == v0.z;
                case 1:
                case 3:
                    v.x += (int)V.x;
                    v.x += pov == 1 ? -1 : 1;
                    return v.x == v0.x;
            }

            //switch (pov)
            //{
            //case 0: return v.z + 1 == v0.z;
            //case 1: return (int)V.x + v.x + 1 == v0.x;
            //case 1: return (int)V.x + v.x - 1 == v0.x;
            //case 2: return (int)V.z + v.z == v0.z;
            //case 2: return (int)V.z + v.z - 1 == v0.z;
            //case 3: return (int)V.x + v.x == v0.x;
            //case 3: return (int)V.x + v.x + 1 == v0.x;
            //}
            return false;
        }
    }
}
