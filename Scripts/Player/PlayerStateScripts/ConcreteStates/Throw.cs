﻿using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class ThrowState : AttackState
{
    public ThrowState()
    {
        this.myState = Player.State.Throw;
    }
    public override void EnterState()
    {
        this.animator.SetTrigger("Throw");

        player.status.popularity += player.fgm.attackDataDic[player.currentAttackTag].pop_damage;

        // stomach
    }
    public override void UpdateState()
    {

    }

    public override void ExitState()
    {

    }
    
    public override void SetAnimationEvent()
    {

    }
}