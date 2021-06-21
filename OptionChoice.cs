using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OptionChoice : MonoBehaviour, IPointerEnterHandler
{
    string SceneName;
    public static int o1, o2, o3,o4;
    public float tweenTime;
    public float ScaleTimes;
    // Start is called before the first frame update
    void Start()
    {
        SceneName = SceneManager.GetActiveScene().name;
        //transform.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
            Debug.LogError("Удалили");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.selectedObject == false)
        {
            LeanTween.cancel(gameObject);
            transform.localScale = Vector3.one;
            LeanTween.scale(gameObject, Vector3.one * ScaleTimes, tweenTime).setEasePunch();
            
        }

    }

    public void Option1()
    {
        int answer1 = PlayerPrefs.GetInt(SceneName + "o1");
        PlayerPrefs.SetInt(SceneName + "o1", answer1 + 1);


    }
    public void Option2()
    {
        int answer2 = PlayerPrefs.GetInt(SceneName + "o2");
        PlayerPrefs.SetInt(SceneName + "o2", answer2 + 1);

    }
    public void Option3()
    {

        int answer3 = PlayerPrefs.GetInt(SceneName + "o3");
        PlayerPrefs.SetInt(SceneName + "o3", answer3 + 1);

    }

    public void Option4()
    {
        int answer4 = PlayerPrefs.GetInt(SceneName + "o4");
        PlayerPrefs.SetInt(SceneName + "o4", answer4 + 1);



    }

    public void AnswerNext()
    {
        PlayerPrefs.SetString(SceneName + "Answer", this.GetComponentInChildren<Text>().text);

        LeanTween.cancel(gameObject);
        transform.localScale = Vector3.one;
        LeanTween.scale(gameObject, Vector3.one * ScaleTimes, tweenTime).setEasePunch();


        if (o1 == 1) Debug.Log("Первый ответ 1: " + o1);
        if (o2 == 1) Debug.Log("Первый ответ 2: " + o2);
        if (o3 == 1) Debug.Log("Первый ответ 3: " + o3);
        if (o4 == 1) Debug.Log("Первый ответ 4: " + o4);


        int answer1 = PlayerPrefs.GetInt(SceneName + "o1");
        int answer2 = PlayerPrefs.GetInt(SceneName + "o2");
        int answer3 = PlayerPrefs.GetInt(SceneName + "o3");
        int answer4 = PlayerPrefs.GetInt(SceneName + "o4");

        print("Ответов на': "+ SceneName + "o1"+"   " + answer1);
        print("Ответов на': " + SceneName + "o2" + "   " + answer2);
        print("Ответов на': " + SceneName + "o3" + "   " + answer3);
        print("Ответов на': " + SceneName + "o4" + "   " + answer4);

        if (SceneManager.GetActiveScene().buildIndex == 5)
          {
              SceneManager.LoadScene(0);
          }
          else SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        //SceneManager.LoadScene(0);

    }


}
