using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        GAMEMANAGER.instance.score = GAMEMANAGER.instance.score * (SceneManager.GetActiveScene().buildIndex + 1);

        GAMEMANAGER.instance.prevScore = GAMEMANAGER.instance.score;

        if (SceneManager.GetActiveScene().buildIndex + 2 > SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(0);
        } else
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
