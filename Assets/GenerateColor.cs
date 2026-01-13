using UnityEngine;

public class GenerateColor: MonoBehaviour
{
    private Renderer _renderer;

    private Color _myColor;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();

        _myColor = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
    }

    private void Start()
    {
        _renderer.material.color = _myColor;
    }
}
