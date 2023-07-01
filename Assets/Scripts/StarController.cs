using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    [SerializeField]float starSpeed;
    [SerializeField]float rotSpeed;
    [SerializeField]float HitNumber;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(starSpeed * Time.deltaTime, 0, 0, Space.World);
        transform.Rotate(0, 0, rotSpeed, Space.World);

        if (transform.position.x > 6.0f){
            Destroy(gameObject);
        }
    }
}
