using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MySceneManagement : MonoBehaviour
{


    public void ChangeScene()
    {
        if (SceneManager.GetActiveScene().name == "Final3")
        {
            GameObject pizza = GameObject.FindGameObjectWithTag("Pizza");
            pizza.transform.parent = null;
            DontDestroyOnLoad(pizza);
            SceneManager.LoadScene("LookingAtPizza");
        }
        else
        {
            Destroy(GameObject.FindGameObjectWithTag("Pizza"));
            SceneManager.LoadScene("Final3");
        }
    }
}
