using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadAnimator: MonoBehaviour
{

    #region Attributes
    private Animator animator;
    private const string IDLE_ANIMATION_BOOL = "Idle";
    private const string GOOD_ANIMATION_BOOL = "Good";
    private const string BAD_ANIMATION_BOOL = "Bad";
    public Dropdown LiftForm;
    #endregion

    public void formType()
    {

        switch (LiftForm.value)
        {
            case 1:
                AnimateIdle();
                break;

            case 2:
                AnimateGood();
                break;
            case 3:
                AnimateBad();
                break;


            default:
                AnimateIdle();
                break;
        }
    }
    #region
    public void AnimateIdle()
    {
        Animate(IDLE_ANIMATION_BOOL);
    }
    public void AnimateGood()
    {
        Animate(GOOD_ANIMATION_BOOL);
    }
    public void AnimateBad()
    {
        Animate(BAD_ANIMATION_BOOL);
    }
    #endregion

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Animate(string boolName)
    {
        DisableOtherAnimations(animator, boolName);
        animator.SetBool(boolName, true);
    }


    private void DisableOtherAnimations(Animator animator, string animation)
    {
        foreach(AnimatorControllerParameter parameter in animator.parameters)
        {
            if(parameter.name!= animation)
            {
                animator.SetBool(parameter.name, false);
            }
        }
    }
}
