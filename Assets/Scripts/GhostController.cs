using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    float besideSpeed;
    [SerializeField]float besideSpeedStandard;

    
    // Start is called before the first frame update
    void Start()
    {
        this.besideSpeed = besideSpeedStandard * Random.Range(0.1f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-besideSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x < -10.0f){
            Destroy(gameObject);
            GameObject.Find("Canvas").GetComponent<UIController> ().LifeCount();
        }
    }
}
