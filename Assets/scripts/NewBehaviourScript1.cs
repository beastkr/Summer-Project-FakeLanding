using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript1 : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void again()
    {
        SceneManager.LoadScene("marsloading");
    }
    public void menu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
