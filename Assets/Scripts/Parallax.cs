using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    public RawImage background;
    public RawImage middleground;
    public RawImage frontground;
    public float backX;
    public float backY;
    public float middleX;
    public float middleY;
    public float frontX;
    public float frontY;

    // Update is called once per frame
    void Update()
    {
        background.uvRect = new Rect(background.uvRect.position + new Vector2(backX, backY) * Time.deltaTime, background.uvRect.size);
        middleground.uvRect = new Rect(middleground.uvRect.position + new Vector2(middleX, middleY) * Time.deltaTime, middleground.uvRect.size);
        frontground.uvRect = new Rect(frontground.uvRect.position + new Vector2(frontX, frontY) * Time.deltaTime, frontground.uvRect.size);
    }
}
