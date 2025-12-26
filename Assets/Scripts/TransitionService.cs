using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneId
{
  Title = 0,
  InGame = 1,
}

public class TransitionService : MonoBehaviour
{
  private readonly FadeView _fadeView;
  private readonly MonoBehaviour _coroutineRunner;
  
  public TransitionService(FadeView fadeView, MonoBehaviour runner)
  {
    _fadeView = fadeView;
    _coroutineRunner = runner;
  }

  public void StartTransition(SceneId id) // ラッパーを作ってコルーチンを開始することによって遷移時の消失を防ぐ
  {
    StartCoroutine(Transition(id));
  }
    
  private IEnumerator Transition(SceneId id)
  {
     _fadeView.FadeIn();
    yield return new WaitForSeconds(1f);
    
    SceneManager.LoadScene(id.ToString());
    
    yield return null;
    _fadeView.FadeOut();
  }
}
