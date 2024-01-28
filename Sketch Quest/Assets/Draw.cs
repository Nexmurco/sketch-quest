using UnityEngine;
using UnityEngine.UI;

public class Draw : MonoBehaviour
{
    public Camera m_camera;
    public GameObject brush;

    LineRenderer currentLineRenderer;

    Vector3 lastPos;

    // void Start()
    // {
    //     capCam.targetTexture = new RenderTexture(300, 300, 24);
    //     overlayImage.texture = capCam.targetTexture;
    // }

    private void Update()
    {
        Drawing();
    }

    void Drawing() 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        else if (Input.GetKey(KeyCode.Mouse0))
        {
            PointToMousePos();
        }
        else 
        {
            currentLineRenderer = null;
        }
    }

    void CreateBrush() 
    {
        GameObject brushInstance = Instantiate(brush);
        currentLineRenderer = brushInstance.GetComponent<LineRenderer>();

        //because you gotta have 2 points to start a line renderer, 
        Vector3 mousePos = m_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_camera.transform.position.z * -1));

        currentLineRenderer.SetPosition(0, mousePos);
        currentLineRenderer.positionCount++;
        currentLineRenderer.SetPosition(1, mousePos);
    }

    void AddAPoint(Vector2 pointPos) 
    {
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex, pointPos);
    }

    void PointToMousePos() 
    {
        Vector3 mousePos = m_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_camera.transform.position.z * -1));
        // mousePos.z = 1f;
        if (lastPos != mousePos) 
        {
            AddAPoint(mousePos);
            lastPos = mousePos;
        }
    }

    // public void Save ()
    // {
    //     StartCoroutine(CoSave());
    // }

    // private IEnumerator CoSave()
    // {
    //     yield return new WaitForEndOfFrame();
    // }
};