using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SimpleFramework;

public class UIManagerState : SimpleState
{
    // Public //
    public CanvasGroup m_canvasGroup;
    // Protected //
    // Private //
    // Access //

    public override void Awake()
    {
        base.Awake();

        m_canvasGroup = GetComponent<CanvasGroup>();
        if(m_canvasGroup == null)
        {
            m_canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
        m_canvasGroup.alpha = 0;
    }

    public override void Start()
    {
        base.Start();
        gameObject.SetActive(false);
    }

    public override void OnEnter()
    {
        base.OnEnter();

        gameObject.SetActive(true);
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        m_canvasGroup.alpha += Time.deltaTime;
    }

    public override void OnExit()
    {
        base.OnExit();
        m_canvasGroup.alpha = 0f;
        gameObject.SetActive(false);
    }
}
