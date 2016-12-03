using UnityEngine;

[RequireComponent(typeof(Collider))]
public class BallThrowTriggerController : MonoBehaviour
{
    private void Start()
    {

    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        ThrowBall();
    }

    private void ThrowBall()
    {

    }
}
