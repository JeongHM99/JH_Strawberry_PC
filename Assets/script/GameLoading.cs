using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoading : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
