using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void OnEnable()
    {
        Collider2D[] contacts = Physics2D.OverlapCircleAll(transform.position, 1f);
        foreach (var contact in contacts)
        {
            if(contact.TryGetComponent(out Coin coin))
            {
                coin.gameObject.SetActive(false);
            }
        }
    }
}
