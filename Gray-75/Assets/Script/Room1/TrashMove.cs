using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMove : MonoBehaviour
{
    public GameObject trash;
    public GameObject cat;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == player.name)
        {
            player.transform.LookAt(cat.transform);
            cat.GetComponent<CatMove>().Schrodinger();
        }
    }
    public void trashout() {
        trash.GetComponent<Animation>().Play();
    }
}
