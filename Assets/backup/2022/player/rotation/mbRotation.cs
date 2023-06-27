namespace mb2022
{
    using UnityEngine;
    /// <summary>
    /// ROTATION
    /// поворот камеры на сцене по кнопке
    /// </summary>
    public class mbRotation: Mono, IRotation_pov
    {
        public GameObject ИгровойПерсонаж => gameObject;

        private void Update() => (this as IRotation_pov).update(); 
    }
}