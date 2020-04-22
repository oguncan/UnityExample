using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
