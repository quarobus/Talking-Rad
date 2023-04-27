using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerPlayForward : MonoBehaviour
{
    public Animator ForwardAnimation;

    public void PlayForward()
    {
        ForwardAnimation.SetTrigger("TriggerPlayForward");
    }
}
