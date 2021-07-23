using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMove : MonoBehaviour
{
    public GameObject catstand;
    public GameObject catdied;
    public GameObject blood;
    private bool catDied;

    // Start is called before the first frame update
    void Start()
    {
        catDied = false;
        catstand.SetActive(true);
        catdied.SetActive(false);
        blood.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Schrodinger() {
        if (!catDied)
        {
            catstand.SetActive(false);
            catdied.SetActive(true);
            blood.SetActive(true);
            blood.GetComponent<Animation>().Play();
            catDied = true;
        }
    }
}
