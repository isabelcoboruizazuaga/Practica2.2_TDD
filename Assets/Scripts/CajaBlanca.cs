using UnityEngine;
public class boss : MonoBehaviour
{
    //Atributos o propiedades
    private float vida;
    private bool muerto;

    // Start is called before the first frame update
    void Start()
    {
        vida = 100.0f;
        muerto = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (vida == 0)
        {
            this.muerto = true;
            Fin();
        }
        else
        {
            this.muerto = false;

            ataque(true, true);

        }
    }

    public void ataque(bool isParry, bool hayArma)
    {
        //Implementa aquí la función sobre la que se va a realizar la prueba
        if (isParry)
        {
            vida -= 20;
        }
        else
        {
            if (hayArma)
            {
                vida -= 10;
            }
            else
            {
                vida -= 8;
            }
        }
    }
    public void Fin()
    {
    }
}

