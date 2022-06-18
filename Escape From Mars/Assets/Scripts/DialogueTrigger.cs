using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject text;
    public GameObject miniGame;
    bool isActivated = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isActivated && collision.gameObject.CompareTag("Player"))
        {
            isActivated = true;
            text.SetActive(true);

            StartCoroutine(Deactivate());
        }

    }
    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(4f);
        text.SetActive(false);
        miniGame.SetActive(true);
    }
}
