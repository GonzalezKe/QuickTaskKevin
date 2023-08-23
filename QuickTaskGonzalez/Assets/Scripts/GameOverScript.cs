using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverText.gameObject.SetActive(true);
    }
}

