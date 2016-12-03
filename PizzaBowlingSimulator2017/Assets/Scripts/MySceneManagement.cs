using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MySceneManagement : MonoBehaviour
{
    void ChangeScene()
    {
        if (SceneManager.GetActiveScene().name == "Final3")
        {
            SceneManager.LoadScene("LookingAtPizza");
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("Pizza"));
            SceneManager.LoadScene("Final3");
        }
    }
}
