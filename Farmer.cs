using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    [SerializeField] GameObject engine;
    [SerializeField] GameObject foodPrefab;
    [SerializeField] GameObject bacPrefab;
    [SerializeField] float screenWidthInUnits = 0f;


    private float velocidade;
    private Vector2 direcao;
    
    void Start()
    {
        velocidade = 2;
        direcao = Vector2.zero;
    }

    void Update()
    {
        Move();
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject); //remove the fruit object
    }


    private void Move()
    {
        direcao = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector2.left * velocidade;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector2.right * velocidade;
        }
    }
}
