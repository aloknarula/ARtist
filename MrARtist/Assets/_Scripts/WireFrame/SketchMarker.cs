using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SketchMarker : MonoBehaviour
{
    // Public //
    public GameObject[] m_sketches;
    public int m_current = 0;
    public Canvas m_3dCanvas;
    // Protected //
    // Private //
    // Access //

    void Start()
    {
        m_3dCanvas.worldCamera = CameraRenderTexture.Instance.m_mainCamera;
        EnableCurrent();
    }

    private void LimitCurrent()
    {
        if (m_current < 0)
            m_current = 0;
        if(m_current >= m_sketches.Length - 1)
            m_current = m_sketches.Length - 1;
    }
    void EnableCurrent()
    {
        LimitCurrent();
        for(int i=0; i<m_sketches.Length; i++)
        {
            m_sketches[i].SetActive(false);
        }
        m_sketches[m_current].SetActive(true);
    }

    [ContextMenu("pre")]
    public void PreviousButton()
    {
        m_current--;
        EnableCurrent();
    }
    [ContextMenu("Next")]
    public void NextBUtton()
    {
        m_current++;
        EnableCurrent();
    }
}
