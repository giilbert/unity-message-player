using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    [SerializeField]
    private GameObject yourMessagePrefab;
    [SerializeField]
    private GameObject otherMessagePrefab;

    private void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    private void SendOtherMessage(string message)
    {
        GameObject otherMessage = Instantiate(otherMessagePrefab, transform);
        otherMessage.GetComponent<Message>().SetMessage(message);
    }

    private void SendMyMessage(string message)
    {
        GameObject myMessage = Instantiate(yourMessagePrefab, transform);
        myMessage.GetComponent<Message>().SetMessage(message);
    }

    private IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            SendOtherMessage("hello!!");
            yield return new WaitForSeconds(0.5f);
            SendMyMessage("hi!!!");
            yield return new WaitForSeconds(0.5f);
        }
    }
}
