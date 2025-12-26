using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum InGameUIMode
{
    Edit,      // 着せ替え・操作中
    Preview    // 撮影後プレビュー
}

public class InGameUIController : MonoBehaviour
{
    [SerializeField] private GameObject _previewPanel;
    [SerializeField] private Button _backToTitle;
    
    private InGameUIMode _mode = InGameUIMode.Edit;

    private void Start()
    {
        _backToTitle.onClick.AddListener(() =>
        {
        });
    }
}
