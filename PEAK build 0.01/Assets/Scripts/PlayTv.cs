using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayTv : MonoBehaviour
{
    public GameManager gameManager;
    
    public void OnMouseDown()
    {
        gameManager.PlayCubeSat();
    }


}
