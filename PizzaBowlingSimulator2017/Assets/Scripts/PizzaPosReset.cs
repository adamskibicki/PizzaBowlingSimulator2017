using UnityEngine;
using System.Collections;

public class PizzaPosReset : MonoBehaviour
{
    void Awake()
    {
        GameObject pizza = GameObject.FindGameObjectWithTag("Pizza");
        pizza.transform.position = new Vector3(146.4408f, 25.02513f, 578.7639f);
    }
}
