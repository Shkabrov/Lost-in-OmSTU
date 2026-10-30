using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public float counterQuit;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        counterQuit -= Time.deltaTime;

        if (counterQuit <= 0)
        {
            Application.Quit();

            Debug.Log("Game Quit");
        }
    }
}
