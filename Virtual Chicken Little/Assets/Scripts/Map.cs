using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public void StartTutorial()
    {
      SceneManager.LoadScene("Tutorial");
    }

    public void StartTown()
    {
      SceneManager.LoadScene("Town");
    }

    public void StartFarm()
    {
      SceneManager.LoadScene("Farm");
    }

}
