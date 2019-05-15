using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimationAtEnd : StateMachineBehaviour
{
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (stateInfo.normalizedTime >= 1 || stateInfo.normalizedTime <= 0)
        {
            Debug.Log("Stopped animation");
            animator.speed = 0;
        }
    }
}
