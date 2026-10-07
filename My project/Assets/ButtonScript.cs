using UnityEngine;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public TMP_Text textbox;

    public void OnClick()
    {
        textbox.text = "Hello World!";
    }
}