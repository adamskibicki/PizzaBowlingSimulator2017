using UnityEngine;
using System.Collections;
using VRTK;

public class ResetBall : MonoBehaviour
{
    [SerializeField]
    private SteamVR_TrackedController controllerLeft;
    [SerializeField]
    private SteamVR_TrackedController controllerRight;


    // Use this for initialization
    private void OnEnable()
    {
        controllerLeft.Gripped += reset;
        controllerRight.Gripped += reset;
        controllerLeft.PadClicked += ChangeScene;
        controllerRight.PadClicked += ChangeScene;
    }

    private void OnDisable()
    {
        controllerLeft.Gripped -= reset;
        controllerRight.Gripped -= reset;
        controllerLeft.PadClicked -= ChangeScene;
        controllerRight.PadClicked -= ChangeScene;
    }

    private void reset(object sender, ClickedEventArgs e)
    {
        transform.position = new Vector3(0.887f, 0.725f, -14.47f);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    private void ChangeScene(object sender, ClickedEventArgs e)
    {
        Invoke("change", 3f);
        Fading.Instance.FadeOut(3f,Color.black);
    }

    private static void change()
    {
        GameObject.FindWithTag("GameController").GetComponent<MySceneManagement>().ChangeScene();
    }
}
