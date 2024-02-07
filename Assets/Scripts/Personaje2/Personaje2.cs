using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personajes{
public class Personaje2
{
    private int vida = 300;

    public int RecibirDanio(int danio)
    {
            vida -= danio;
            return vida;
    }
}
}

