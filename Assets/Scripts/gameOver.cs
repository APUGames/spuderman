using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    private CircleCollider2D hazard;

    // Start is called before the first frame update
    void Start()
    {
        hazard = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hazard.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
                    print("Die triggered");
                    SceneManager.LoadScene(3);
                    //FindObjectOfType<GameManager>().deathReset();
                }
            }
        }
  
