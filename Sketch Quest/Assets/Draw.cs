using UnityEngine;

public class Draw : MonoBehaviour
{
    public Camera m_camera;
    public GameObject brush;

    LineRenderer currentLineRenderer;

    Vector3 lastPos;

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
            Debug.Log("continuing line...");
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
        // mousePos.z = 1f;

        Debug.Log(mousePos);
        currentLineRenderer.SetPosition(0, mousePos);
        // Debug.Log("CHECK 1");
        // lastPos = mousePos;
        currentLineRenderer.positionCount++;
        currentLineRenderer.SetPosition(1, mousePos);
        // Debug.Log("CHECK 2");
    }

    void AddAPoint(Vector2 pointPos) 
    {
        Debug.Log(currentLineRenderer.positionCount);
        currentLineRenderer.positionCount++;
        // currentLineRenderer.size++;
        // Debug.Log(currentLineRenderer.positionCount);
        int positionIndex = currentLineRenderer.positionCount - 1;
        Debug.Log(currentLineRenderer.positionCount);
        currentLineRenderer.SetPosition(positionIndex, pointPos);
        Debug.Log("CHECK");
    }

    void PointToMousePos() 
    {
        Vector3 mousePos = m_camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_camera.transform.position.z * -1));
        // mousePos.z = 1f;
        Debug.Log("COMPARING POSITIONS");
        if (lastPos != mousePos) 
        {
            Debug.Log("ADDING POSITION");
            AddAPoint(mousePos);
            lastPos = mousePos;
        }
    }

};