using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SketchMarker : MonoBehaviour
{
    // Public //
    public GameObject[] m_sketches;
    public int m_current = 0;
    // Protected //
    // Private //
    // Access //

    void Start()
    {
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

    public void PreviousButton()
    {
        m_current--;
        LimitCurrent();
    }
    public void NextBUtton()
    {
        m_current++;
        LimitCurrent();
    }
}
