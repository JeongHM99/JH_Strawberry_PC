using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonDirector : MonoBehaviour
{
    public void StartButton()
    {
        GameObject Music = GameObject.Find("EffectSound");
        Music.GetComponent<MusicDirector>().start_sound_shot();
        SceneManager.LoadScene("GameScene");
    }

    public void Go_Title()
    {
        GameObject Music = GameObject.Find("EffectSound");
        Music.GetComponent<MusicDirector>().button_sound_shot();
        SceneManager.LoadScene("TitleScene");
        Destroy(GameObject.Find("GameDirector"));
        Destroy(GameObject.Find("player_stand"));
    }

    public void Go_Guide()
    {
        GameObject Music = GameObject.Find("EffectSound");
        Music.GetComponent<MusicDirector>().button_sound_shot();
        SceneManager.LoadScene("GuideScene");

    }

    public void RestartButton()
    {
        GameObject Music = GameObject.Find("EffectSound");
        Music.GetComponent<MusicDirector>().button_sound_shot();
        SceneManager.LoadScene("GameScene");
        Destroy(GameObject.Find("GameDirector"));
        Destroy(GameObject.Find("player_stand"));

    }
}
