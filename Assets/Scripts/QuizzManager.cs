using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizzManager : MonoBehaviour
{
    public List<SoalSO> listSoal;
    public SoalSO selectedQuestion;
    public TMP_InputField answer;
    public TextMeshProUGUI question;

    // Start is called before the first frame update
    void Start()
    {
        GetSoalSO();
        question.text = selectedQuestion.question;
    }

    public void GetSoalSO()
    {
        foreach(SoalSO soalSO in listSoal)
        {
            if (soalSO.level == Player.instance.levelSoal)
                selectedQuestion = soalSO;
        }
    }

    public void SubmitAnswer()
    {
        if(answer.text != "" && Player.instance.levelSoal < 20)
        {
            if (selectedQuestion.answer.ToLower().Equals(answer.text.ToLower()))
            {
                Player.instance.coin += selectedQuestion.priceLoot;
            }
            answer.text = "";
            SceneManager.LoadScene("Gameplay");
            Player.instance.levelSoal += 1;
        }
    }
}
