using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Progress : MonoBehaviour
{
    
    private BoxCollider2D winner;

    // Start is called before the first frame update
    void Start()
    {
        winner = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (winner.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            print("you win");
            SceneManager.LoadScene(2);
            
        }
    }
}

