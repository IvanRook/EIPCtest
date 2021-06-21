using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answer : MonoBehaviour
{
    string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnswerCount()
    {
        Debug.Log("Ответ : " + OptionChoice.o1);
        Debug.Log("Ответ : " + OptionChoice.o2);
        Debug.Log("Ответ : " + OptionChoice.o3);
        Debug.Log("Ответ : " + OptionChoice.o4);

        PlayerPrefs.SetInt(SceneName + "o1", OptionChoice.o1);
        PlayerPrefs.SetInt(SceneName + "o2", OptionChoice.o2);
        PlayerPrefs.SetInt(SceneName + "o3", OptionChoice.o3);
        PlayerPrefs.SetInt(SceneName + "o4", OptionChoice.o4);

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(0);
        }
        else  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
