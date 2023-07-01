using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchController : MonoBehaviour
{
    [SerializeField]float witchSpeed;
    [SerializeField]float _minY;
    [SerializeField]float _maxY;

    public GameObject starPrefab;
    private Vector2 pos;

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -_minY, _maxY);
        transform.position = new Vector2(-7.31f, pos.y);

        // 上キーを押すことで上に動く
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0, witchSpeed * Time.deltaTime, 0);
        }

        // 下キーを押すことで下に動く
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, -witchSpeed * Time.deltaTime, 0);
        }

        // スペースキーを押すことで球を発射
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(starPrefab, transform.position, Quaternion.identity);
        }

    }
}
