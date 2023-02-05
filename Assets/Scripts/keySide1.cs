using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySide1 : MonoBehaviour
{

    private BoxCollider2D keyBox2;
    public bool isKeyOn = false;

    // Start is called before the first frame update
    private void Start()
    {
        keyBox2 = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(keyBox2.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Destroy(gameObject);
            isKeyOn = true;
            FindObjectOfType<lockSide1>().killLock2();
        }
    }
}
