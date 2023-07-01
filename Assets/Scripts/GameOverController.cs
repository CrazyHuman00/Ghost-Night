using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverController : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI lastScoreText;

    // Start is called before the first frame update
    void Start()
    {
        lastScoreText.text = "SCORE " + UIController.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
