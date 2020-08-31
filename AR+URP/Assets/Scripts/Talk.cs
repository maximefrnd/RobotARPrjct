using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour
{

   public Text uiText;
   Animator animator;  

    void Start()
    {
        uiText.text = "";
        animator = GetComponent<Animator>();
    }

    public void talking(){
        animator.SetBool("IsTalking",true);
        uiText.text = "Hello ! I'm a robot";
    }
}
