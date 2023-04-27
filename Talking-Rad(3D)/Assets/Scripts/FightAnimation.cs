using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightAnimation : StateMachineBehaviour
{
    [SerializeField]
    private float _timeUntilFight;

    [SerializeField]
    private int _numberOfFightAnimations;

    private bool _isFight;
    private float _fightTime;
    private int _fightAnimation;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ResetFight();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_isFight == false)
        {
            _fightTime += Time.deltaTime;

            if (_fightTime > _timeUntilFight && stateInfo.normalizedTime % 1 < 0.02f)
            {
                _isFight = true;
               _fightAnimation = Random.Range(1, _numberOfFightAnimations + 1);


            }
        }
        else if (stateInfo.normalizedTime % 1 > 0.98)
        {
            ResetFight();
        }

        animator.SetFloat("FightAnimation", _fightAnimation, 0.2f, Time.deltaTime);
    }
    private void ResetFight()
    {
        _isFight = false;
        _fightTime = 0;
        _fightAnimation = 0;
    }
}
