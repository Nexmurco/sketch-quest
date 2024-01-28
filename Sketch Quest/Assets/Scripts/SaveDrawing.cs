using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDrawing : MonoBehaviour
{
    public void Save ()
    {
        StartCoroutine(CoSave());
    }

    private IEnumerator CoSave()
    {
        yield return new WaitForEndOfFrame();
    }
}
