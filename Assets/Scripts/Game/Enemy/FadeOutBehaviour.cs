using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutBehaviour : MonoBehaviour
{
    MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponentInChildren<MeshRenderer>();

        StartCoroutine(FadeOutCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (mr.material.color.a < 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator FadeOutCoroutine()
    {
        while (mr.material.color.a > 0)
        {
            mr.material.color = new Color(mr.material.color.r, mr.material.color.g, mr.material.color.b, mr.material.color.a - Time.deltaTime);
            yield return new WaitForSeconds(0.15f);
        }
    }
}
