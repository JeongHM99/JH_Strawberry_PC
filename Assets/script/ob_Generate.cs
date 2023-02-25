using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob_Generate : MonoBehaviour
{
    public GameObject point_10;
    public GameObject point_cat;
    public GameObject point_fox;
    public GameObject life_down;
    public GameObject life_up;
    public GameObject reverse;
    public GameObject bucket;

    GameDirector gameDirector;

    float[] coolTime = { 0.8f, 3.0f, 3.0f, 3.0f, 8.0f, 10.0f, 12.0f };
    float[] count = { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };

    void FixedUpdate()
    {
        gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
    }
    void Update()
    {
        for (int index = 0; index < count.Length; index++)
        {
            this.count[index] += Time.deltaTime;
        }

        if (this.count[0] > this.coolTime[0])
        {
            this.count[0] = 0;
            GameObject go = Instantiate(point_10) as GameObject;
            float px = Random.Range(-2.20f, 2.20f);
            go.transform.position = new Vector3(px, 5.0f, 0.0f);
            if (gameDirector.score < 2000)
            {
                coolTime[0] = Random.Range(0.6f, 1.0f);
            }
            else if (gameDirector.score < 4000)
            {
                coolTime[0] = Random.Range(0.5f, 0.8f);
            }
            else if (gameDirector.score < 6000)
            {
                coolTime[0] = Random.Range(0.3f, 0.5f);
            }
            else if (gameDirector.score < 8000)
            {
                coolTime[0] = Random.Range(0.2f, 0.4f);
            }
            else
            {
                coolTime[0] = Random.Range(0.15f, 0.3f);
            }
        }

        if (this.count[1] > this.coolTime[1])
        {
            this.count[1] = 0;
            GameObject go = Instantiate(point_cat) as GameObject;
            float px = Random.Range(-2.20f, 2.20f);
            go.transform.position = new Vector3(px, 5.0f, 0.0f);
            if (gameDirector.score < 2000)
            {
                coolTime[1] = Random.Range(2.5f, 4.5f);
            }
            else if (gameDirector.score < 4000)
            {
                coolTime[1] = Random.Range(2.0f, 3.5f);
            }
            else if (gameDirector.score < 6000)
            {
                coolTime[1] = Random.Range(1.5f, 3.0f);
            }
            else if (gameDirector.score < 8000)
            {
                coolTime[1] = Random.Range(1.5f, 2.5f);
            }
            else
            {
                coolTime[1] = Random.Range(1.3f, 2.3f);
            }
        }

        if (this.count[2] > this.coolTime[2])
        {
            this.count[2] = 0;
            GameObject go = Instantiate(point_fox) as GameObject;
            float px = Random.Range(-2.20f, 2.20f);
            go.transform.position = new Vector3(px, 5.0f, 0.0f);
            if (gameDirector.score < 2000)
            {
                coolTime[2] = Random.Range(2.5f, 4.5f);
            }
            else if (gameDirector.score < 4000)
            {
                coolTime[2] = Random.Range(2.0f, 3.5f);
            }
            else if (gameDirector.score < 6000)
            {
                coolTime[2] = Random.Range(1.5f, 3.0f);
            }
            else if (gameDirector.score < 8000)
            {
                coolTime[2] = Random.Range(1.5f, 2.5f);
            }
            else
            {
                coolTime[2] = Random.Range(1.3f, 2.3f);
            }
        }

        if (this.count[3] > this.coolTime[3])
        {
            this.count[3] = 0;
            GameObject go = Instantiate(life_down) as GameObject;
            float px = Random.Range(-2.20f, 2.20f);
            go.transform.position = new Vector3(px, 5.0f, 0.0f);
            if (gameDirector.score < 2000)
            {
                coolTime[3] = Random.Range(2.5f, 3.5f);
            } else if (gameDirector.score < 4000)
            {
                coolTime[3] = Random.Range(2.0f, 3.0f);
            } else if (gameDirector.score < 6000)
            {
                coolTime[3] = Random.Range(1.0f, 2.0f);
            } else if (gameDirector.score < 8000)
            {
                coolTime[3] = Random.Range(0.5f, 1.0f);
            } else
            {
                coolTime[3] = Random.Range(0.2f, 0.5f);
            }
        }

        if (this.count[4] > this.coolTime[4])
        {
            this.count[4] = 0;
            GameObject go = Instantiate(life_up) as GameObject;
            float px = Random.Range(-2.20f, 2.20f);
            go.transform.position = new Vector3(px, 5.0f, 0.0f);
            coolTime[4] = Random.Range(10.0f, 15.0f);
        }

        if (this.count[5] > this.coolTime[5])
        {
            this.count[5] = 0;
            GameObject go = Instantiate(reverse) as GameObject;
            float px = Random.Range(-2.20f, 2.20f);
            go.transform.position = new Vector3(px, 5.0f, 0.0f);
            if (gameDirector.score < 2000)
            {
                coolTime[5] = Random.Range(6.0f, 15.0f);
            }
            else if (gameDirector.score < 4000)
            {
                coolTime[5] = Random.Range(5.0f, 10.0f);
            }
            else if (gameDirector.score < 6000)
            {
                coolTime[5] = Random.Range(4.0f, 8.0f);
            }
            else if (gameDirector.score < 8000)
            {
                coolTime[5] = Random.Range(3.0f, 6.0f);
            }
            else
            {
                coolTime[5] = Random.Range(2.0f, 4.0f);
            }
        }

        if (this.count[6] > this.coolTime[6])
        {
            this.count[6] = 0;
            GameObject go = Instantiate(bucket) as GameObject;
            float px = Random.Range(-2.20f, 2.20f);
            go.transform.position = new Vector3(px, 5.0f, 0.0f);
            if (gameDirector.score < 2000)
            {
                coolTime[6] = Random.Range(10.0f, 14.0f);
            }
            else if (gameDirector.score < 4000)
            {
                coolTime[6] = Random.Range(7.0f, 11.0f);
            }
            else if (gameDirector.score < 6000)
            {
                coolTime[6] = Random.Range(5.0f, 9.0f);
            }
            else if (gameDirector.score < 8000)
            {
                coolTime[6] = Random.Range(3.0f, 5.0f);
            }
            else
            {
                coolTime[6] = Random.Range(1.5f, 4.0f);
            }
        }
    }
}
