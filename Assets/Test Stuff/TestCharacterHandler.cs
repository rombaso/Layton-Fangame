using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterHandler : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    void OnMouseOver()
    {
        m_Animator.SetBool("Speaking", true);
    }

    void OnMouseExit()
    {
        m_Animator.SetBool("Speaking", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
