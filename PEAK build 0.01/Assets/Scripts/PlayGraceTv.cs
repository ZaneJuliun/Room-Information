using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGraceTv : MonoBehaviour
{
    public GameManager gameManager;

    public void OnMouseDown()
    {
        gameManager.PlayGrace();
    }

}
