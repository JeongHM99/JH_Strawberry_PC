using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameDirector : MonoBehaviour
{
    public TMP_Text text;
    public GameObject life_Gage_1;
    public GameObject life_Gage_2;
    public GameObject life_Gage_3;
    public Sprite sunset;

    public int score = 0;
    int player_life = 3;

    public bool reverse_on = false;

    void Start()
    {
        SetText();
        SetLife();
    }

    public void point_10()
    {
        score += 10;
        SetText();
    }

    public void point_30()
    {
        score += 30;
        SetText();
    }

    public void life_down()
    {
        player_life -= 1;
        SetLife();
    }

    public void life_up()
    {
        if (player_life < 3)
        {
            player_life += 1;
        }
        SetLife();
    }

    public void reverse()
    {
        reverse_on = true;
    }

    public void bucket()
    {
        player_life = 0;
        SetLife();
    }

    public void SetText()
    {
        SpriteRenderer BackSprite = GameObject.Find("background").GetComponent<SpriteRenderer>();

        text.text = score.ToString();
        if(score >= 5000 && score <= 5100)
        {
            BackSprite.sprite = sunset;
        }

        if (score >= 10000)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
     public void SetLife()
    {
        switch (player_life)
        {
            case 3:
                this.life_Gage_1.GetComponent<Image>().fillAmount = 1;
                this.life_Gage_2.GetComponent<Image>().fillAmount = 1;
                this.life_Gage_3.GetComponent<Image>().fillAmount = 1;
                break;
            case 2:
                this.life_Gage_1.GetComponent<Image>().fillAmount = 1;
                this.life_Gage_2.GetComponent<Image>().fillAmount = 1;
                this.life_Gage_3.GetComponent<Image>().fillAmount = 0;
                break;
            case 1:
                this.life_Gage_1.GetComponent<Image>().fillAmount = 1;
                this.life_Gage_2.GetComponent<Image>().fillAmount = 0;
                this.life_Gage_3.GetComponent<Image>().fillAmount = 0;
                break;
            case 0:
                this.life_Gage_1.GetComponent<Image>().fillAmount = 0;
                this.life_Gage_2.GetComponent<Image>().fillAmount = 0;
                this.life_Gage_3.GetComponent<Image>().fillAmount = 0;
                SceneManager.LoadScene("GameoverScene");
                DontDestroyOnLoad(this.gameObject);
                DontDestroyOnLoad(GameObject.Find("player_stand"));
                break;
            default:
                break;
        }
    }
 
}
