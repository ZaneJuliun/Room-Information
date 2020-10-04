using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFireTv : MonoBehaviour
{
    public GameManager gameManager;

    public void OnMouseDown()
    {
        gameManager.PlayForestFire();
    }

}
