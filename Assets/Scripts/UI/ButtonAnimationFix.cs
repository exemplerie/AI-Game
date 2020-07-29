using UnityEngine;

public class ButtonAnimationFix : MonoBehaviour
{
    public void FixAnimation()
    {
        // For button release animation to properly finish
        Animator animator = GetComponent<Animator>();
        animator.CrossFade("Normal", 0f);
        animator.Update(0f);
    }
}
