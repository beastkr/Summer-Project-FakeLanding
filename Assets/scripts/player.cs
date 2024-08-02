using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Vector3 target;
    public Animator anim;
    public GameObject spawnee;
    [SerializeField] float PlayerSpeed;
    public Slider HPBar;
    public Slider EHPBar;
    public float HP = 10f;
    public float enemyHP = 1000f;
    private float timer = 0f;
    private float shoottimer = 0f;
    public AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0 || enemyHP == 0) timer += Time.deltaTime;
        if (timer >= 1) Die();
        if (timer>=3&&HP==0) SceneManager.LoadScene("dead");
        if (timer >= 3 && enemyHP == 0) SceneManager.LoadScene("enemydead");
        HPBar.value = HP / 5;
        EHPBar.value = enemyHP / 150;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = transform.position.z;
        if (HP>0&&enemyHP>0) transform.position = Vector3.MoveTowards(transform.position, target, PlayerSpeed * Time.deltaTime);
        if (HP > 0 && enemyHP>0)
        {
            shoottimer += Time.deltaTime;
            if (shoottimer >= 0.5) { SpawnObject(90); shoottimer = 0; }
            
        }
    }
    public void SpawnObject(float a)
    {
        
        Instantiate(spawnee, transform.position, Quaternion.Euler(new Vector3(0f, 0f, a)));
        aud.Play();
    }
    public void onHit()
    {
        if (HP > 0&&enemyHP>0)
            HP -= 1;
    }
    public void EnemyHit()
    {
        if (HP > 0 && enemyHP > 0) enemyHP -= 1;
        Debug.Log(enemyHP);
    }
    public void Die()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0,0,0), PlayerSpeed / 3 * Time.deltaTime);
    }
}
