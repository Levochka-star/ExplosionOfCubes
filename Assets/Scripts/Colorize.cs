using UnityEngine;

[RequireComponent(typeof (Renderer))]

public class Colorize: MonoBehaviour
{
    private Renderer _renderer;
    
    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
    }
}
