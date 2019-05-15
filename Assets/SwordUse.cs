using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class SwordUse : MonoBehaviour
{
    public Animator swordToAnimate;
    private bool _opened;
    private VRTK_InteractableObject _linkedObject;

    protected virtual void OnEnable()
    {
        _linkedObject = _linkedObject == null ? GetComponent<VRTK_InteractableObject>() : _linkedObject;

        if (_linkedObject != null)
        {
            _linkedObject.InteractableObjectUsed += InteractableObjectUsed;
            _linkedObject.InteractableObjectUnused += InteractableObjectUnused;
        }
        PlayAnimation(0);
    }

    protected virtual void OnDisable()
    {
        if (_linkedObject != null)
        {
            _linkedObject.InteractableObjectUsed -= InteractableObjectUsed;
            _linkedObject.InteractableObjectUnused -= InteractableObjectUnused;
        }
    }

    protected virtual void InteractableObjectUsed(object sender, InteractableObjectEventArgs e)
    {
        _opened = true;
        PlayAnimation(1);
    }

    protected virtual void InteractableObjectUnused(object sender, InteractableObjectEventArgs e)
    {
        _opened = false;
        PlayAnimation(-1);
    }
    
    private void PlayAnimation(float speed)
    {
        var playTime = swordToAnimate.GetCurrentAnimatorStateInfo(0).normalizedTime;
        print(playTime);
        playTime = Mathf.Clamp01(playTime);
        swordToAnimate.SetFloat("direction", speed);
        swordToAnimate.Play("OpenClose", -1, playTime);
        
    }
}

