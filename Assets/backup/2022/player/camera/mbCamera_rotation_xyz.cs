//Bo52_01022021115929690.EX.CAMERA_01022021115929690.
namespace Bo52_01022021115929690.EX
{
    using UnityEngine;
    public class mbCamera_rotation_xyz : MonoBehaviour
    {
        static public string INFO = "MONO";
        static public string PRODUCT = "поворот камеры по трём осям";
        #region ENUM
        public enum RotationAxes
        {
            MouseXAndY = 0,
            MouseX = 1,
            MouseY = 2
        }
        #endregion
        #region ПОЛЯ
        public RotationAxes axes = RotationAxes.MouseXAndY;
        public float sensitivityHor = 9.0f;
        public float sensitivityVert = 9.0f;
        public float minimumVert = -45.0f;
        public float maximumVert = 45.0f;
        private float _rotationX = 0;
        #endregion
        #region EVENTS
        public void Update()
        {
            if (axes == RotationAxes.MouseX)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
            }
            else if (axes == RotationAxes.MouseY)
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
                float rotationY = transform.localEulerAngles.y;
                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
            else
            {
                _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
                float delta = Input.GetAxis("Mouse X") * sensitivityHor;
                float rotationY = transform.localEulerAngles.y + delta;
                transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
            }
        }
        #endregion
    }
}
