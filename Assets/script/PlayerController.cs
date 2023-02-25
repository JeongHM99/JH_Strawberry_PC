using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    GameDirector gameDirector;
    Renderer playerColor;

    float walkForce = 1300.0f;
    float maxWalkSpeed = 3.0f;
    public bool inputLeft = false;
    public bool inputRight = false;
    public bool isfail = false;

    float reverse_count = 0.0f;
    float reverse_cool = 5.0f;

    public AudioClip debuff_sound;
    public AudioClip score_sound;
    AudioSource aud;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        gameDirector = GameObject.Find("GameDirector").GetComponent<GameDirector>();
        playerColor = gameObject.GetComponent<Renderer>();
        aud = GetComponent<AudioSource>();
    }

    void Update()
    {
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        if (gameDirector.reverse_on == true)
        {
            this.reverse_count += Time.deltaTime;
            key *= -1;
            playerColor.material.color = new Color(255 / 255f, 197 / 255f, 197 / 255f);
        }
        if (reverse_count > reverse_cool)
        {
            reverse_count = 0.0f;
            playerColor.material.color = new Color(255 / 255f, 255 / 255f, 255 / 255f);
            gameDirector.reverse_on = false;
        }

        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce * Time.deltaTime);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3((key * -0.5f), 0.5f, 1);
        }

        if(speedx == 0 && isfail == false)
        {
            this.animator.Rebind();
        }

        this.animator.speed = speedx / 2.0f;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "point_10(Clone)")
        {
            aud.PlayOneShot(score_sound);
            Destroy(other.gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().point_10();
        }

        if (other.gameObject.name == "point_cat(Clone)")
        {
            aud.PlayOneShot(score_sound);
            Destroy(other.gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().point_30();
        }

        if (other.gameObject.name == "point_fox(Clone)")
        {
            aud.PlayOneShot(score_sound);
            Destroy(other.gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().point_30();
        }

        if (other.gameObject.name == "life_down(Clone)")
        {
            aud.PlayOneShot(debuff_sound);
            Destroy(other.gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().life_down();
        }

        if (other.gameObject.name == "life_up(Clone)")
        {
            aud.PlayOneShot(score_sound);
            Destroy(other.gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().life_up();
        }

        if (other.gameObject.name == "reverse(Clone)")
        {
            aud.PlayOneShot(debuff_sound);
            Destroy(other.gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().reverse();
        }

        if (other.gameObject.name == "bucket(Clone)")
        {
            aud.PlayOneShot(debuff_sound);
            Destroy(other.gameObject);

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().bucket();
        }
    }
}
