using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    [Header("Q1")]
    public Text o1;
    public Text o2;
    public Text o3;
    public Text o4;

    public Text a11;
    public Text a12;
    public Text a13;
    public Text a14;

    [Header("Graph1")]

    public Image graph11;
    public Image graph12;
    public Image graph13;
    public Image graph14;


    [Header("Q2")]
    public Text o21;
    public Text o22;
    public Text o23;
    public Text o24;

    public Text a21;
    public Text a22;
    public Text a23;
    public Text a24;

    [Header("Graph2")]

    public Image graph21;
    public Image graph22;
    public Image graph23;
    public Image graph24;






    [Header("ELSE")]

    public Text totalR;

    public int totalRespons;


    // Start is called before the first frame update
    void Start()
    {
        totalRespons = PlayerPrefs.GetInt("totalRespons") + 1;
        PlayerPrefs.SetInt("totalRespons", totalRespons);



        totalR.text = ("Количество опрошенных: " + totalRespons);
        //Первый вопрос


        graph11.fillAmount = (float)PlayerPrefs.GetInt("NQ1o1") / totalRespons;
        graph12.fillAmount = (float)PlayerPrefs.GetInt("NQ1o2") / totalRespons;
        graph13.fillAmount = (float)PlayerPrefs.GetInt("NQ1o3") / totalRespons;
        graph14.fillAmount = (float)PlayerPrefs.GetInt("NQ1o4") / totalRespons;

        o1.text = (PlayerPrefs.GetInt("NQ1o1") * 100 / totalRespons).ToString() + "%";
        o2.text = (PlayerPrefs.GetInt("NQ1o2") * 100 / totalRespons).ToString() + "%";
        o3.text = (PlayerPrefs.GetInt("NQ1o3") * 100 / totalRespons).ToString() + "%";
        o4.text = (PlayerPrefs.GetInt("NQ1o4") * 100 / totalRespons).ToString() + "%";

        a11.text = "Европейские требования и нормы"; if (a11.text == PlayerPrefs.GetString("NQ1Answer")) a11.color = new Color32(255, 0, 0, 255);
        a12.text = "Механизм развития промышленности"; a12.color = new Color32(0, 189, 1,255);
        a13.text = "Попытки убить российскую промышленность"; if (a13.text == PlayerPrefs.GetString("NQ1Answer")) a13.color = new Color32(255, 0, 0, 255);
        a14.text = "Небольшой драматический театр"; if (a14.text == PlayerPrefs.GetString("NQ1Answer")) a14.color = new Color32(255, 0, 0, 255);


        //Второй вопрос

        graph21.fillAmount = (float)PlayerPrefs.GetInt("NQ2o1") / totalRespons;
        graph22.fillAmount = (float)PlayerPrefs.GetInt("NQ2o2") / totalRespons;
        graph23.fillAmount = (float)PlayerPrefs.GetInt("NQ2o3") / totalRespons;
        graph24.fillAmount = (float)PlayerPrefs.GetInt("NQ2o4") / totalRespons;

        o21.text = (PlayerPrefs.GetInt("NQ2o1") * 100 / totalRespons).ToString() + "%";
        o22.text = (PlayerPrefs.GetInt("NQ2o2") * 100 / totalRespons).ToString() + "%";
        o23.text = (PlayerPrefs.GetInt("NQ2o3") * 100 / totalRespons).ToString() + "%";
        o24.text = (PlayerPrefs.GetInt("NQ2o4") * 100 / totalRespons).ToString() + "%";

        a21.text = "Попытаетесь выйти из I категории"; if (a21.text == PlayerPrefs.GetString("NQ2Answer")) a21.color = new Color32(255, 0, 0, 255);
        a22.text = "Будет внедрять НДТ и реализовывать программу повышения экологической эффективности"; a22.color = new Color32(0, 189, 1, 255);
        a23.text = "Ничего не будите делать, просто платить штрафы"; if (a23.text == PlayerPrefs.GetString("NQ2Answer")) a23.color = new Color32(255, 0, 0, 255);
        a24.text = "Проведете модернизацию предприятия, чтобы быть лучше НДТ"; if (a24.text == PlayerPrefs.GetString("NQ2Answer")) a24.color = new Color32(255, 0, 0, 255);






    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            PlayerPrefs.DeleteAll();
            Debug.LogError("Удалили");
        }
    }
}
