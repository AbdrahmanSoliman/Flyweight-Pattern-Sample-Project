using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageController : MonoBehaviour
{
    private Text message;
    private float hideMsgAfter = 2f;
    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<Text>();
        message.enabled = false;
    }

    public void SetMessage()
    {
        message.text = "You picked up an item!";
        message.enabled = true;
        Invoke(nameof(HideMessage), hideMsgAfter);
    }

    void HideMessage()
    {
        message.enabled = false;
    }
}
