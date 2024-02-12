using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenController : MonoBehaviour
{
    public bool tocado = false;
    internal bool isTocado()
    {
        return tocado;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tocado = !tocado;
        }
    }
}
