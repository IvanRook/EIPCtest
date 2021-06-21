using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextQuestionScr : MonoBehaviour
{


    
    public int thisQScore;

    string GoName;
    string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        GoName = this.name;
        SceneName = SceneManager.GetActiveScene().name;

    }

    public void ScoreOn()
    {
        
    }
    public void LoadNextScene()
    {
        //SceneManager.LoadScene(1);  
        StartCoroutine(ChangeAfter2SecondsCoroutine());
        switch (GoName)
        {
            case "Option1":
                thisQScore = PlayerPrefs.GetInt(SceneName + "o1");
                thisQScore += 1;
                PlayerPrefs.SetInt(SceneName + "o1", thisQScore);
                break;
            case "Option2":
                thisQScore = PlayerPrefs.GetInt(SceneName + "o2");
                thisQScore += 1;
                PlayerPrefs.SetInt(SceneName + "o2", thisQScore);
                break;
            case "Option3":
                thisQScore = PlayerPrefs.GetInt(SceneName + "o3");
                thisQScore += 1;
                PlayerPrefs.SetInt(SceneName + "o3", thisQScore);
                break;
            case "Option4":
                thisQScore = PlayerPrefs.GetInt(SceneName + "o4");
                thisQScore += 1;
                PlayerPrefs.SetInt(SceneName + "o4", thisQScore);
                break;
            case "Option5":
                thisQScore = PlayerPrefs.GetInt(SceneName + "o5");
                thisQScore += 1;
                PlayerPrefs.SetInt(SceneName + "o5", thisQScore);
                break;
            case "Option6":
                thisQScore = PlayerPrefs.GetInt(SceneName + "o6");
                thisQScore += 1;
                PlayerPrefs.SetInt(SceneName + "o6", thisQScore);
                break;
            case "Option7":
                thisQScore = PlayerPrefs.GetInt(SceneName + "o7");
                thisQScore += 1;
                PlayerPrefs.SetInt(SceneName + "o7", thisQScore);
                break;
                
        }
        

    }

    IEnumerator ChangeAfter2SecondsCoroutine() { 


       // Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(0.5f);
        Debug.Log(this.name);

        Debug.Log(GetComponentInParent<Transform>().childCount);
        
       // Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
