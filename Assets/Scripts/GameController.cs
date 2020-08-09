using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    bool isLose;
    public CanvasGroup logicButtonsCanvasGroup;
    public CanvasGroup playerLoseCanvasGroup;
    public Character character;

    void Start()
    {
        isLose = false;
        Utility.SetCanvasGroupEnabled(playerLoseCanvasGroup, false);
    }

    void Update()
    {
        if (character.transform.position.y < -5.5f) {
            PlayerLost();
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void PlayerLost()
    {
        Debug.Log("Player lost");
        Utility.SetCanvasGroupEnabled(logicButtonsCanvasGroup, false);
        Utility.SetCanvasGroupEnabled(playerLoseCanvasGroup, true);
    }
}
