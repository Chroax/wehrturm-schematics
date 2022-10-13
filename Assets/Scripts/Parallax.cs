using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] RawImage background;
    [SerializeField] RawImage middleground;
    [SerializeField] RawImage frontground;
    [SerializeField] float backX;
    [SerializeField] float backY;
    [SerializeField] float middleX;
    [SerializeField] float middleY;
    [SerializeField] float frontX;
    [SerializeField] float frontY;

    // Update is called once per frame
    void Update()
    {
        background.uvRect = new Rect(background.uvRect.position + new Vector2(backX, backY) * Time.deltaTime, background.uvRect.size);
        middleground.uvRect = new Rect(middleground.uvRect.position + new Vector2(middleX, middleY) * Time.deltaTime, middleground.uvRect.size);
        frontground.uvRect = new Rect(frontground.uvRect.position + new Vector2(frontX, frontY) * Time.deltaTime, frontground.uvRect.size);
    }
}
