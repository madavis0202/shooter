using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    private Animator anim;
    public string LogCollisionEnter;
    public void KnockoutAnimation()
    {
        anim.SetTrigger(AnimationTags.DIE_TRIGGER);
    }

    void Start()
    {
	anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( gameObject.name == "LasCaras")
        {
            anim.Play("KO");
            Debug.Log("FONE");
        }
        if (gameObject.name == "LasCarasTwin")
        {
            anim.Play("KO2");
            Debug.Log("F00");
        }
        if (gameObject.name == "LasCarasTriplet")
        {
            //anim.Play("KO3");
            Debug.Log("FREE");
        }
        
    }
}
