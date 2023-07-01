using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]float backGroundSpeed;
    //34.5
    [SerializeField]float backGroundInitialPos;
    //67.7
    [SerializeField]float backGroundLastPos;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-backGroundSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x < -backGroundInitialPos){
            transform.position = new Vector3(backGroundLastPos, 0, 0);
        }
    }
}
