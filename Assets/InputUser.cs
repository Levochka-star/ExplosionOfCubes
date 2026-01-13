using System;
using UnityEngine;

public class InputUser : MonoBehaviour
{
    private KeyCode _buttonPressed = KeyCode.Mouse2;

    public event Action<Vector3> OnCliced;

    private void Update()
    {
        if (Input.GetKeyDown(_buttonPressed))
        {
            OnCliced?.Invoke(Input.mousePosition);
        }
    }
}