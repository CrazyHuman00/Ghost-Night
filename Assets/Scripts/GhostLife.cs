using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostLife : MonoBehaviour
{
    [SerializeField]int ghostLifePoint;
    [SerializeField]int ghostTwoLifePoint;
    [SerializeField]int ghostThreeLifePoint;

    public GameObject smokePrefab;

    void OnTriggerEnter2D(Collider2D coll)
    {
        // ゴースト1のライフ処理
        if (coll.gameObject.tag == "star" && gameObject.tag == "ghost"){
            ghostLifePoint--;
            Destroy(coll.gameObject);
        }

        // ゴースト2のライフ処理
        if (coll.gameObject.tag == "star" && gameObject.tag == "ghost2"){
            ghostTwoLifePoint--;
            Destroy(coll.gameObject);
        }

        // ゴースト3のライフ処理
        if (coll.gameObject.tag == "star" && gameObject.tag == "ghost3"){
            ghostThreeLifePoint--;
            Destroy(coll.gameObject);
        }

        // ゴースト
        if (ghostLifePoint <= 0){
            Instantiate(smokePrefab, transform.position, Quaternion.identity);
            GameObject.Find("Canvas").GetComponent<UIController> ().addScoreGhost();
            Destroy(gameObject);
        }
        
        if (ghostTwoLifePoint <= 0){
            Instantiate(smokePrefab, transform.position, Quaternion.identity);
            GameObject.Find("Canvas").GetComponent<UIController> ().addScoreGhostTwo();
            Destroy(gameObject);
        }

        if (ghostThreeLifePoint <= 0){
            Instantiate(smokePrefab, transform.position, Quaternion.identity);
            GameObject.Find("Canvas").GetComponent<UIController> ().addScoreGhostThree();
            Destroy(gameObject);
        }
    }
}
