using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScene : MonoBehaviour
{
    [SerializeField] private Button _start;
    [SerializeField] private Animator _fade;
    private void Start()
    {
        _start.onClick.AddListener(TransitionInGame);
    }

    private void TransitionInGame()
    {
        Invoke(nameof(LoadScene), 1f);
        _fade.Play("FadeIn");
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("InGame");
    }
}
