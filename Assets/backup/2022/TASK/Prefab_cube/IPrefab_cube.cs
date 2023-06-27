using UnityEngine;
namespace task2022
{
    public interface IPrefab_cube
    {
        static public Vector3 �������������(mbPrefab_cube mb, Vector3 dv)
        {
            if (dv == Vector3.left || dv == Vector3.down || dv == Vector3.back)
                return new Vector3(0, 0, 0);
            else if (dv == Vector3.right)
                return new Vector3(mb.������, 0, 0);
            else if (dv == Vector3.up)
                return new Vector3(0, mb.������, 0);
            else if (dv == Vector3.forward)
                return new Vector3(0, 0, mb.������);

            return Vector3.zero;
        }
    }
}