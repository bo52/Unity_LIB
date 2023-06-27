//Bo52_14012021185335420.CONTROL_14012021185335420.
namespace task2022
{
    using UnityEngine;
    /// <summary>
    /// скорость анимации
    /// </summary>
    public class mbAnim_speed: MonoBehaviour
    {
        Animator anim;
        void Start()=>anim = GetComponent<Animator>();
        private void Update()
        {
            float move = Input.GetAxis("Horizontal");
            anim.SetFloat("Speed",move);
            if (Input.GetKeyDown(KeyCode.A))
            {
                anim.SetInteger("Speed", -1);
            }
        }
    }
}