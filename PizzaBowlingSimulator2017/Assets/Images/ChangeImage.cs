using UnityEngine;
using System.Collections;

public class ChangeImage : MonoBehaviour
{
    public GameObject img;
    public Sprite texture;
    
    public void ChangeImageNow()
    {
        img.GetComponent<UnityEngine.UI.Image>().overrideSprite = texture;
    }

}
