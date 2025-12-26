using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeView : MonoBehaviour
{
  [SerializeField] private Animator _fade;
  
  public void FadeIn()
  {
    _fade.Play("FadeIn");
  }
    
  public void FadeOut()
  {
    _fade.Play("FadeOut");
  }
}
