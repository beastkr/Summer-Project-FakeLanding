using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    private float timer = 0f;
    public GameObject game;
    void Start()
    {
        DontDestroyOnLoad(game.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 50) SceneManager.LoadScene("marsloading");
    }
    public void skip()
    {
        SceneManager.LoadScene("marsloading");
    }
}
