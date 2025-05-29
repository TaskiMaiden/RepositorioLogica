using UnityEngine;

public class AtivarDesativarDestruir : MonoBehaviour
{

    public GameObject refCapsula;
    public GameObject refHexagono;
    public Transform spawnPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // if(Input.GetKeyDown(KeyCode.Space)){

        //     refCapsula.SetActive(false);

        // }

        // if(Input.GetKeyDown(KeyCode.Z)){

        //     refCapsula.SetActive(true);

        // }

        // if(Input.GetMouseButtonDown(1)){

        //     Destroy(refCapsula);

        // }

        if(Input.GetKeyDown(KeyCode.M)){

            Instantiate(refHexagono, spawnPoint);

        }

        
    }
    
}
