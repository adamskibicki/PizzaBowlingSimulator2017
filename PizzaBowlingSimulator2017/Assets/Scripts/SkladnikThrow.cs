using UnityEngine;
using System.Collections;

public class SkladnikThrow : MonoBehaviour
{
    public static GameObject pizza;

    private void Awake()
    {
        pizza = GameObject.Find("pizzaCylinde");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Pizza")
        {
            Destroy(GetComponent<Collider>());
            gameObject.layer = LayerMask.NameToLayer("Skladnik");
            Destroy(GetComponent<Rigidbody>());
            Destroy(this);
        }
    }
}
