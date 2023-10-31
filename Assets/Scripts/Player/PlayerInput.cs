using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float Horizontal
    {
        get;

        private set;
    }

    public float Vertical
    {
        get;

        private set;
    }

    public bool LeftMouse()
    {
        if(BossDeath.Finish != true)
        {
            return Input.GetMouseButtonDown(0);
        }

        return false;
    }

    private void Update()
    {
        if(BossDeath.Finish != true)
        {
            Horizontal = Input.GetAxis("Horizontal");

            Vertical = Input.GetAxis("Vertical");
        }

    }
}
