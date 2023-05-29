using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (seconds > Time.deltaTime)
        {
            seconds -= Time.deltaTime;
        }
        else if (minutes > 0)
        {
            minutes--;
            seconds += 60;
            seconds -= Time.deltaTime;
        }
        else
        {
            EditorSceneManager.LoadScene(sceneName);
        }
        print(minutes + ":" + seconds );
    }
}
