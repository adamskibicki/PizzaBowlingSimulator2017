using UnityEngine;
using System.Collections;

public class ChangeImage : MonoBehaviour
{
    public GameObject img;
    public Sprite texture;
    
    void Awake()
    {
        img = GameObject.FindGameObjectWithTag("ImageInLookingAtPizza");
    }

    public void ChangeImageNow()
    {
        img.GetComponent<UnityEngine.UI.Image>().overrideSprite = texture;
    }

}
