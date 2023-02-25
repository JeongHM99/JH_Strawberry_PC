using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SC_ObjectController : MonoBehaviour
{
    GameDirector gameDirector;
    float speed_sum;

    void Start()
    {
        gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
        speed_sum = -3.0f;
    }
    void Update()
    {
        if (gameDirector.score >= 500 && gameDirector.score < 2000) speed_sum = -4.0f;
        if (gameDirector.score >= 2000 && gameDirector.score < 5000) speed_sum = -5.0f;
        if (gameDirector.score >= 5000 && gameDirector.score < 7000) speed_sum = -6.0f;
        if (gameDirector.score >= 7000 && gameDirector.score < 9000) speed_sum = -6.5f;
        if (gameDirector.score >= 9000 && gameDirector.score < 10000) speed_sum = -7.0f;

        transform.Translate(0, speed_sum * Time.deltaTime, 0);

        if (transform.position.y < -4.0f)
        {
            Destroy(gameObject);
        }
    }
}
