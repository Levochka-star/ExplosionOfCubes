using System;
using UnityEngine;

public class InputUser : MonoBehaviour
{
    private KeyCode _clikedOnCube = KeyCode.Mouse2;

    public event Action<Vector3> Clicking;

    private void Update()
    {
        if (Input.GetKeyDown(_clikedOnCube))
        {
            Debug.Log("button pressed");
            Clicking?.Invoke(Input.mousePosition);
        }
    }
}