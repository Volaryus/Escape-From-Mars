using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public float health = 100f;
    public TMP_Text healthText;
    public Slider healthSlider;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        healthText.text = "Health: " + health;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthText.text = "Health: " + health;
        animator.SetBool("TakeDamage", true);
        StartCoroutine(SetBool());
        healthSlider.value = health;

    }
    IEnumerator SetBool()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("TakeDamage", false);
    }
}
