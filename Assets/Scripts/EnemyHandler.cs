using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    private Animator anim;
    public void KnockoutAnimation()
    {
        anim.SetTrigger(AnimationTags.DIE_TRIGGER);
    }

    void Start()
    {
     anim = GetComponent<Animator>();
    }
    public string LogCollisionEnter;
    private void OnCollisionEnter(Collision collision)
    {
        anim.Play("Knockout");           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
