using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static bool isOverButton;
    public RectTransform button;

    // Start is called before the first frame update
    // Update is called once per frame
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (button.GetComponent<Animator>())
            button.GetComponent<Animator>().Play("Hover On");
        isOverButton = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (button.GetComponent<Animator>())
            button.GetComponent<Animator>().Play("Hover Off");
        isOverButton = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void ChangeScene(string scene)
    {
        if(scene.Equals("Quizz"))
        {
            if(Player.instance.currentLife > 0)
                SceneManager.LoadScene(scene);
        }
        else
            SceneManager.LoadScene(scene);
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
        isOverButton = false;
    }
}
