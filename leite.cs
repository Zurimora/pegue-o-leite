using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using TMPro;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class leite : MonoBehaviour
{
    [SerializeField] GameObject engine;
    [SerializeField] TextMeshProUGUI scoreText;

    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    void CollisionEnter2D(Collision2D collision)
    {
        int score = + 1;
    }
}
