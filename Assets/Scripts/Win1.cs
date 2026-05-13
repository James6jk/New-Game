using UnityEngine;
using UnityEngine.SceneManagement; 

public class Win1 : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
       
            SceneManager.LoadScene("Intro Scene");
        }
    }
}
