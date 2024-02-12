using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class ScriptTestMode1
{
    private GameObject Caja1;
    private GameObject Caja2;
    private GameObject Player;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Cargando la escena");
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator Caja1MasPequenia()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(2);
        Debug.Log("Test1");

        Caja1 = GameObject.Find("Box");
        Caja2 = GameObject.Find("Box2");
        Assert.That(Caja1.transform.localScale.x < Caja2.transform.localScale.x,"La caja 2 es mas pequeña");
    }

    [UnityTest]
    public IEnumerator JugadorFuera()
    {
        Debug.Log("Test2, atraviesa el cuadrado verde para true");
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(7);

        Caja1 = GameObject.Find("Box");
        Player = GameObject.Find("Player");

        bool fuera = false;

        var paredes= Caja1.GetComponentsInChildren<GreenController>();
        for (int i = 0; i < paredes.Length; i++)
        {
            if (paredes[i].isTocado())
            {
                fuera = true;
            }
        }

        Assert.That(fuera, "El jugador no ha salido a tiempo");
    }


    [UnityTest]
    public IEnumerator JugadorHaCaido()
    {
        Debug.Log("Test3, atraviesa el cuadrado azul para true");
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(10);

        Player = GameObject.Find("Player");
        Caja2 = GameObject.Find("Box");
        Assert.That(Player.transform.position.y < Caja2.transform.position.y, "El jugador no ha salido a tiempo");
    }

    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }

}
