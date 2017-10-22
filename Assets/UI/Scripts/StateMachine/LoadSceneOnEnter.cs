﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/*
 * Class with method that loads a specific scene when entering Menu state in an animation 
 */
public class LoadSceneOnEnter : StateMachineBehaviour
{
    public string _sceneName;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        SceneManager.LoadScene(_sceneName);
    }
}