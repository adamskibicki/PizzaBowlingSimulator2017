using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    [HideInInspector]
    public bool isGrabbed = false;

    private Vector3 lastFramePosition;
    private float lastFrameTime;

    void OnCollisionEnter(Collision col)
    {
        if(!isGrabbed && col.gameObject.CompareTag("Hand"))
        {
            Grab(col.gameObject);
        }
        if(isGrabbed && col.gameObject.CompareTag("ThrowTrigger"))
        {
            Throw();
        }
    }

    void Grab(GameObject go)
    {
        gameObject.transform.parent = go.gameObject.transform;
    }

    void Throw()
    {
        gameObject.transform.parent = null;
        float time = Time.deltaTime - lastFrameTime;
        Vector3 distance = transform.position - lastFramePosition;
        Vector3 force = distance * time * 100;
        gameObject.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
    }

    void Update()
    {
        lastFrameTime = Time.deltaTime;
        lastFramePosition = transform.position;
    }
}
