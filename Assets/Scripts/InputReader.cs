using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private KeyCode _clikedOnCube = KeyCode.Mouse2;

    public event Action<Vector3> Clicking;

    private void Update()
    {
        if (Input.GetKeyDown(_clikedOnCube))
        {
            Clicking?.Invoke(Input.mousePosition);
        }
    }
}