using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyPartsListManager : MonoBehaviour
{
    public Image brainImg;
    public Image heartImg;


    public void OnHeartFound() 
    {
        heartImg.color = new Color(1, 1, 1, 1);
    }

    public void OnBrainfFound()
    {
        brainImg.color = new Color(1, 1, 1, 1);
    }

}
