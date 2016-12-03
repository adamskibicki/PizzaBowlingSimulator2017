using UnityEngine;
using System.Collections;

public class SkladnikThrow : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Pizza")
        {
            Destroy(GetComponent<Collider>());
            Destroy(GetComponent<Rigidbody>());
            Destroy(this);
        }
    }
}
