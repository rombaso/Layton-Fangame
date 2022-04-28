using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowColor : MonoBehaviour
{
    private float totalTime = 0;

    private SpriteRenderer m_renderer;
    // Start is called before the first frame update
    void Start()
    {
        // Fetch the renderer
        m_renderer = GetComponent<SpriteRenderer>();
        m_renderer.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        // Add the time elapsed since the last frame
        totalTime += Time.deltaTime;
        // Convert it to a color, apply it to our sprite
        // At first, I wanted to use a gradient but that's a little too long
        m_renderer.color = Color.HSVToRGB(totalTime % 1, 0.5f, 1);
    }
}
