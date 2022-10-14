using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileEditor : MonoBehaviour
{
    public Button button;
    public TMP_InputField inputText;
    public PlayerStatus playerStatus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubmitTeamName(string scene)
    {
        if(inputText.text.Equals(""))
        {
            Debug.Log("Please Enter Your Team Name");
        }
        else
        {
            Player.instance.teamName = inputText.text;
            Debug.Log(Player.instance.teamName);
            inputText.text = "";
            if (button != null)
                button.ChangeScene(scene);
        }
    }
}
