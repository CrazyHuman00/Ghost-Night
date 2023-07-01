using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostGenerator : MonoBehaviour
{
    public GameObject ghostPrefab;
    public GameObject ghost2Prefab;
    public GameObject ghost3Prefab;
    [SerializeField]float ghostInstanceTime;
    [SerializeField]float ghostTwoInstanceTime;
    [SerializeField]float ghostThreeInstanceTime;
    [SerializeField]float ghostPosition;
    [SerializeField]float ghostRange;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenGhost", 1, ghostInstanceTime);
        InvokeRepeating("GenGhostTwo", 1, ghostTwoInstanceTime);
        InvokeRepeating("GenGhostThree", 1, ghostThreeInstanceTime);
    }

    // ゴースト1を生成する
    void GenGhost()
    {
        Instantiate(ghostPrefab, new Vector2(8, ghostPosition * Random.Range(-ghostRange, ghostRange)), Quaternion.identity);
    }

    // ゴースト2を生成する
    void GenGhostTwo()
    {
        Instantiate(ghost2Prefab, new Vector2(8, ghostPosition * Random.Range(-ghostRange, ghostRange)), Quaternion.identity);
    }

    // ゴースト3を生成する
    void GenGhostThree()
    {
        Instantiate(ghost3Prefab, new Vector2(8, ghostPosition * Random.Range(-ghostRange, ghostRange)), Quaternion.identity);
    }
}
