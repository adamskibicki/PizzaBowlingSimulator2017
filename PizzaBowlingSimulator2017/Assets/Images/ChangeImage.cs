using UnityEngine;
using System.Collections;

public class ChangeImage : MonoBehaviour
{
    public UnityEngine.UI.Image img;
    public Texture2D texture;
    
    public void ChangeImageNow()
    {
        img.material.mainTexture = texture;
    }

}
