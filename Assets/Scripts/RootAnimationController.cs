using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootAnimationController : MonoBehaviour
{
    private LineRenderer lineRenderer;

    [SerializeField]
    private Texture[] textures;

    private int animateStep = 0;

    [SerializeField]
    private float fps = 30f;

    private float fpsCounter;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        fpsCounter += Time.deltaTime;

        if (fpsCounter >= 1f / fps)
        {
            if (animateStep < textures.Length)
            {
                animateStep++;
            }

            lineRenderer.material.SetTexture("_MainTex", textures[animateStep]);

            fpsCounter = 0f;

        }
    }
}
