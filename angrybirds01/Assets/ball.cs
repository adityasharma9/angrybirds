using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;

    private bool isPressed = false;
    public float releaseTime = .15f;
    public GameObject gameObject;

    private void Update()
    {
       if(isPressed)
        {
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
    void OnMouseDown()
        {
           isPressed = true;
           rb.isKinematic = true;
        }
    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;
        StartCoroutine(Release());
    }
    IEnumerator Release()
    {
        yield return  new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
        yield return new WaitForSeconds(2f);
        if(gameObject!=null)
        {
            gameObject.SetActive(true);

        }

    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Destroy(this);
    }
}
