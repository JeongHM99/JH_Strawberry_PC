using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirector : MonoBehaviour
{
    public PlayerController playerScript;

    public void LeftDown()
    {
        playerScript = GameObject.Find("player_stand").GetComponent<PlayerController>();
        playerScript.inputLeft = true;
    }

    public void LeftUp()
    {
        playerScript = GameObject.Find("player_stand").GetComponent<PlayerController>();
        playerScript.inputLeft = false;
    }

    public void RightDown()
    {
        playerScript = GameObject.Find("player_stand").GetComponent<PlayerController>();
        playerScript.inputRight = true;
    }

    public void RightUp()
    {
        playerScript = GameObject.Find("player_stand").GetComponent<PlayerController>();
        playerScript.inputRight = false;
    }
}
