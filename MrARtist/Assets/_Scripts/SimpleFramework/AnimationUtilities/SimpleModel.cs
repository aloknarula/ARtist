using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SimpleFramework
{
    public class SimpleModel : MonoBehaviour
    {
        // PUBLIC
        public Animator m_animator;
        // PROTECTED
        protected SimpleStateMachineMono m_stateMachine;
        // PRIVATE
        // ACCESS

        public virtual void Start()
        {
            m_stateMachine = GetComponentInParent<SimpleStateMachineMono>();

            if(m_stateMachine == null)
            {
                Debug.LogError(name + " missing StateMachine in parent");
                return;
            }

            m_stateMachine.RegisterModel(this);
        }
    }
}
