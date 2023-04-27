using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAnimation : StateMachineBehaviour
{
    [SerializeField]
    private float _timeUntilFirst;

    [SerializeField]
    private int _numberOfFirstAnimations;

    private bool _isFirst;
    private float _firstTime;
    private int _firstAnimation;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ResetFirst();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_isFirst == false)
        {
            _firstTime += Time.deltaTime;

            if (_firstTime > _timeUntilFirst && stateInfo.normalizedTime % 1 < 0.02f)
            {
                _isFirst = true;
                _firstAnimation = Random.Range(1, _numberOfFirstAnimations + 1);
                _firstAnimation = _firstAnimation * 2 - 1;

                animator.SetFloat("FirstAnimation", _firstAnimation - 1);

            }
        }
        else if (stateInfo.normalizedTime % 1 > 0.98)
        {
            ResetFirst();
        }

        animator.SetFloat("FirstAnimation", _firstAnimation, 0.2f, Time.deltaTime);
    }
    private void ResetFirst()
    {
        if (_isFirst)
        {
            _firstAnimation--;
        }
        _isFirst = false;
        _firstTime = 0;
    }

}
