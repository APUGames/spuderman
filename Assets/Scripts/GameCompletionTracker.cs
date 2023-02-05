using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameCompletionTracker : MonoBehaviour {

    private GameObject playerObj = null;
    private Vector3 beginLoc;
    private Vector3 endLoc;
    private float levelLen;
    private Vector3 playerLoc;

    private void Start()
    {
        //If you want to find it by NAME. For t$$anonymous$$s you have to make sure you only have 1 object named "Player".
        if (playerObj == null) {
            playerObj = GameObject.Find("Player_Test");
        }
    }

    private void Update()
    {
        beginLoc = GameObject.Find("SceneBeginLoc").transform.position;
        endLoc = GameObject.Find("SceneEndLoc").transform.position;
        playerLoc = playerObj.transform.position;
        Debug.Log("endLoc " + endLoc);
        Debug.Log("playerLoc" + playerLoc);
        levelLen = Vector2.Distance(beginLoc, endLoc);
        // calculate distance between begin and end
        float currentDist = Vector2.Distance(playerLoc, endLoc);
        Debug.Log("currentDist: " + currentDist);
        // compare player distance to total distance, invert, map between 0 - 100
        float effectiveLevelComplete = (1 - Mathf.InverseLerp(0, levelLen, currentDist)) * 100; 
        Debug.Log("effectiveLevelComplete: " + effectiveLevelComplete);
        // update FMOD param
        var emitter = GetComponent<FMODUnity.StudioEventEmitter>();
        emitter.SetParameter("level_completion", effectiveLevelComplete);
    }
}