using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FloorEffectScript : MonoBehaviour
{
    public GameObject Root;
    
    public int Size = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        GenerateAllObjs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateAllObjs()
    {
        GameObject current;
        for (int i = 1; i < Size+1; i++)
        {
            for (int j = 1; j < Size+1; j++)
            {
                
                current = Instantiate(Root);
                current.name = "FloorTile_" + 10*i + j;
                current.transform.position = new Vector3((Size+1 / i) * Root.transform.lossyScale.x,current.transform.position.y, (Size+1 / j) * Root.transform.lossyScale.z);
                if (current.transform.position.Equals(Root.transform.position))
                {
                    Destroy(current);
                }
            }
            
        }
    }
}
