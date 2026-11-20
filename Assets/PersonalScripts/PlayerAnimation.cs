using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimation : MonoBehaviour
{

    public InputActionAsset PlayerAction;
    public Animator Animator;
    
    void Update()
    {
        if (PlayerAction.FindAction("Move").IsPressed())
        {
            Animator.SetBool("walk", true);
        }
        else
        {
            Animator.SetBool("walk", false);
        }
        if (PlayerAction.FindAction("Jump").IsPressed())
            {
            Animator.SetBool("jump", true);
            }
        else
        {
            Animator.SetBool("jump", false);
        }
    }
}
