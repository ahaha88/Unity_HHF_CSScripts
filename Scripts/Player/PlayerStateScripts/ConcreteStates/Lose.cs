﻿using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class LoseState : PlayerState
{
    public LoseState()
    {
        this.myState = Player.State.Lose;
    }
    public override void EnterState()
    {
        this.animator.SetTrigger("Lose");

        if (Main.timeLimit > 0f)
        {
            GameObject.FindWithTag("env").GetComponent<SceneManager>().Judge(this.player);
        }
    }

    public override void UpdateState()
    {

    }

    public override void ExitState()
    {

    }

    public override void OnStarted(Player.State state)
    {

    }

    public override void SetAnimationEvent()
    {

    }
}
