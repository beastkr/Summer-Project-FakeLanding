using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    float count = 0f;
    public GameObject player;
    public player MyScript;
    void Start()
    {
        player = GameObject.Find("PLayer");
        MyScript = player.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.GetBool("hit"))
        {
            count += Time.deltaTime;
        }
        else { count = 0; }
        if (count >= 0.1) { count = 0; anim.SetBool("hit", false); };
    }
    void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player" && !(anim.GetBool("hit"))) { anim.SetBool("hit", true); MyScript.onHit(); }
    }
}
