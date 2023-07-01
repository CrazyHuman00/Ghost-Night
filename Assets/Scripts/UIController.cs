using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public GameObject[] witchLifeArray = new GameObject[3];
    public static int score = 0;
    int witchLifePoint = 3;

    [SerializeField]TextMeshProUGUI scoreText;

    // プレイヤーライフの処理
    public void LifeCount()
    {
        if (witchLifePoint > 0){
            witchLifeArray[witchLifePoint - 1].SetActive(false);
            witchLifePoint--;
        }
    }

    // ゴースト1のスコアの処理
    public void addScoreGhost()
    {
        score += 10;
    }

    // ゴースト2のスコアの処理
    public void addScoreGhostTwo()
    {
        score += 30;
    }

    // ゴースト3のスコアの処理
    public void addScoreGhostThree()
    {
        score += 50;
    }

    // プレイ中のスコアカウントの処理
    void ScoreCount()
    {
        scoreText.text = "SCORE:" + score.ToString();
    }

    // 最終カウントの処理
    //void LastScore()
    //{
    //    lastScoreText.text = "SCORE " + score.ToString();
    //}

    // ゲームオーバーの処理
    //void GameOver()
    //{
    //    gameOverText.text = "GAME OVER";
    //}

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (witchLifePoint == 0){
            SceneManager.LoadScene("GameOver");
        }else{
            ScoreCount();
        }
    }
}
