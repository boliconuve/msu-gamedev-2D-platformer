using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject portalExit;
    private GameObject playerGO;

    private CapsuleCollider2D myCollider;

    // Start is called before the first frame update
    private void Start()
    {
        playerGO = GameObject.Find("Player");
        myCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            myCollider.enabled = false;
            playerGO.transform.position = portalExit.transform.position - new Vector3(playerGO.transform.localScale.x * -1f, -0.7f, 0);
            Invoke("ActiveCollider", 0.5f);
        }

    }

    private void ActiveCollider() { myCollider.enabled = true; }

}
