using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public string sceneName;
    public TextMeshProUGUI text;

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
        int roundSeconds = Mathf.RoundToInt(seconds);
        text.text = minutes + ":" + roundSeconds;
    }
}
