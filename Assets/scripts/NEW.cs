using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NEW : MonoBehaviour
{
    // Start is called before the first frame update
    private float timer = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 25) SceneManager.LoadScene("mainmenu");
    }
}
