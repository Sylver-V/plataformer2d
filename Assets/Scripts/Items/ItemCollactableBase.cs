using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableBase : MonoBehaviour
{

    public string comparteTag = "Player";
    public ParticleSystem particleSystem;
    //public float timeToHide = 3;
    //public GameObject graphicItem;


    private void Awake()
    {
        if (particleSystem != null) particleSystem.transform.SetParent(null);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag(comparteTag))
        {
            Collect();
        }
    }



    protected virtual void Collect()
    {
        //Debug.Log("Collect");
        //if(graphicItem != null) graphicItem.SetActive(false);
        //Invoke(nameof(HideObject), timeToHide);
        gameObject.SetActive(false);
        OnCollect();
    }

    //private void HideObject()
    //{
    //    gameObject.SetActive(false);
    //}


    protected virtual void OnCollect()
    {
        if(particleSystem != null) particleSystem.Play();
    }
}
