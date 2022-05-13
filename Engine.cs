using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using TMPro;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class Engine : MonoBehaviour
{
        [SerializeField] TextMeshProUGUI lifesText;

    
    public int lifes = 3;
    [SerializeField] bool gameOver = false;

    [SerializeField] GameObject gameOverMenu;

    void Start()
    {

    }

    void Update()
    {

        
        if (lifes < 1)
        {
            lifesText.text = "";
        }
        else
        {
            lifesText.text = lifes.ToString();
        }


        if (gameOver)
        {
            gameOverMenu.SetActive(true);
        }
        else
        {
            gameOverMenu.SetActive(false);
        }

        if (gameOverMenu.activeSelf)
        {
            Time.timeScale = 0f;
        }

        if (lifes < 1)
        {
            gameOver = true;
        }

    }
}
