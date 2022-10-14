using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private SpriteRenderer mapRenderer;
    [SerializeField] private float zoomStep;
    [SerializeField] private float minCamSize;
    [SerializeField] private float maxCamSize;

    private Camera defaultCamSize;
    private float mapMinX, mapMaxX, mapMinY, mapMaxY;
    private Vector3 dragOrigin;
    private void Awake()
    {
        defaultCamSize = camera;
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;
        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
    }
    private void Update()
    {
        if(!PauseSystem.instance.gameIsPaused)
        {
            Debug.Log(Button.isOverButton);
            if (!Button.isOverButton)
            {
                if (Input.GetMouseButtonDown(0))
                    dragOrigin = camera.ScreenToWorldPoint(Input.mousePosition);
                if (Input.GetMouseButton(0))
                {
                    Vector3 diff = dragOrigin - camera.ScreenToWorldPoint(Input.mousePosition);
                    camera.transform.position = ClampCamera(camera.transform.position + diff);
                }
            }
            

            if (Input.GetAxis("Mouse ScrollWheel") > 0f)
                ZoomIn();
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
                ZoomOut();
        }
    }

    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = camera.orthographicSize;
        float camWidth = camera.orthographicSize * camera.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);

        return new Vector3(newX, newY, targetPosition.z);
    }

    public void ZoomIn()
    {
        float newSize = camera.orthographicSize - zoomStep;
        if (defaultCamSize.orthographicSize - (maxCamSize * zoomStep) < newSize)
        {
            camera.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
            camera.transform.position = ClampCamera(camera.transform.position);
        }
    }

    public void ZoomOut()
    {
        float newSize = camera.orthographicSize + zoomStep;
        if (defaultCamSize.orthographicSize + (maxCamSize * zoomStep) > newSize)
        {
            camera.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);
            camera.transform.position = ClampCamera(camera.transform.position);
        }
    }
}
