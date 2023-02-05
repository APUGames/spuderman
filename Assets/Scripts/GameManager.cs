using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Scene 1 is Title Screen
    //Scene 2 is Main Level
    //Scene 3 is Death Screen
    //Scene 4 is Win Screen


    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
