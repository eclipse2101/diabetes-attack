using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreDisplay : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        DisplayScore("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayScore(string scoreValue)
    {
       scoreText.text = "score: " + scoreValue;
    }
}
