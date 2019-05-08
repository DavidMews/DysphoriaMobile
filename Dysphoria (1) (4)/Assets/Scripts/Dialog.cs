using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialog
{
    public Sprite portrait;

    [TextArea(3, 10)]
    public string[] sentences;
}
