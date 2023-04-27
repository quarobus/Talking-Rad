using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingAnimation : StateMachineBehaviour
{
    [SerializeField]
    private float _timeUntilTalking;

    [SerializeField]
    private int _numberOfTalkingAnimations;

    private bool _isTalking;
    private float _talkingTime;
    private int _talkingAnimation;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ResetTalking();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_isTalking == false)
        {
            _talkingTime += Time.deltaTime;

            if (_talkingTime > _timeUntilTalking && stateInfo.normalizedTime % 1 < 0.02f)
            {
                _isTalking = true;
                _talkingAnimation = Random.Range(1, _numberOfTalkingAnimations + 1);
                _talkingAnimation = _talkingAnimation * 2 - 1;

                animator.SetFloat("TalkingAnimation", _talkingAnimation - 1);

            }
        }
        else if (stateInfo.normalizedTime % 1 > 0.98)
        {
            ResetTalking();
        }

        animator.SetFloat("TalkingAnimation", _talkingAnimation, 0.2f, Time.deltaTime);
    }
    private void ResetTalking()
    {
        if (_isTalking)
        {
            _talkingAnimation--;
        }
        _isTalking = false;
        _talkingTime = 0;
    }

}
