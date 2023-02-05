using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keySide : MonoBehaviour
{

    private BoxCollider2D keyBox;
    public bool isKeyOn = false;

    // Start is called before the first frame update
    private void Start()
    {
        keyBox = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(keyBox.IsTouchingLayers(LayerMask.GetMask("Player")))
        {
            Destroy(gameObject);
            isKeyOn = true;
            FindObjectOfType<lockSide>().killLock();
        }
    }
}