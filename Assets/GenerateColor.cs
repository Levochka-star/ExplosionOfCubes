using UnityEngine;

public class GenerateColor: MonoBehaviour
{
    private Renderer _renderer;
    private Color _myColor;
    private Color _randomColor;

    private void Awake()
    {
        _randomColor = Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);

        _renderer = GetComponent<Renderer>();

        _myColor = _randomColor;
    }

    private void Start()
    {
        _renderer.material.color = _myColor;
    }
}
