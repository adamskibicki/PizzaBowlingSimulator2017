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
        controllerLeft.PadClicked += reset;
        controllerRight.PadClicked += reset;
    }

    private void OnDisable()
    {
        controllerLeft.PadClicked -= reset;
        controllerRight.PadClicked -= reset;
    }

    private void reset(object sender, ClickedEventArgs e)
    {
        transform.position = new Vector3(0.887f, 0.725f, -14.47f);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
