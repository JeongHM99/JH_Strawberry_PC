using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameoverDirector : MonoBehaviour
{
    public TMP_Text text;

    GameDirector gameDirector;
    Rigidbody2D player_rigid;
    Animator player_fail;
    PlayerController playerController;

    void Start()
    {
        gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
        player_rigid = GameObject.Find("player_stand").GetComponent<Rigidbody2D>();
        player_fail = GameObject.Find("player_stand").GetComponent<Animator>();
        playerController = GameObject.Find("player_stand").GetComponent<PlayerController>();

        player_rigid.isKinematic = true;
        playerController.isfail = true;
        player_rigid.velocity = Vector3.zero;
        text.text = "SCORE : " + gameDirector.score.ToString();
        player_fail.SetTrigger("FailTrigger");
    }
}
