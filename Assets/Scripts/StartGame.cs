using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class StartGame : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public void startTheGame()
    {
        MenuManager.Instance.playerData.playerName = nameText.text;

        SceneManager.LoadScene(1);
    }
}
