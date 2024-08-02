using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletPrefabScript : MonoBehaviour
{
    float BulletSpeed = 0.3f;
    public GameObject player;
    public player MyScript;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PLayer");
        MyScript = player.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position + transform.right * BulletSpeed;
        transform.position = newPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!collision.gameObject.CompareTag("Player")&& !collision.gameObject.CompareTag("enemy")) Destroy(gameObject);

        if (!collision.gameObject.CompareTag("enemy")) { MyScript.EnemyHit(); Destroy(gameObject); }

    }
}
