using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour, IItem
{
    public float health = 50;

    public void Use(GameObject target)
    {
        // target�� ü���� ȸ���ϴ� ó��
        Debug.Log("ü���� ȸ���ߴ� : " + health);
    }

    // Start is called before the first frame update
    void Start()
    {
        Use(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
