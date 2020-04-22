using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    public void Update()
    {
        if (player.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        scoreText.text = player.position.z.ToString("0");
        
    }
    // Start is called before the first frame update
    
}
