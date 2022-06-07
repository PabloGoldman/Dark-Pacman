using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutBehaviour : MonoBehaviour
{
    //SpriteRenderer sr;

    //[SerializeField] float timeUntilFadedOut = 10;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    sr = GetComponent<SpriteRenderer>();

    //    StartCoroutine(FadeOutCoroutine());
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (sr.material.color.a < 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    //IEnumerator FadeOutCoroutine()
    //{
    //    while (sr.material.color.a > 0)
    //    {
    //        sr.material.color = new Color(sr.material.color.r, sr.material.color.g, sr.material.color.b, sr.material.color.a - Time.deltaTime);
    //        yield return new WaitForSeconds(0.2f);
    //    }
    //}
}
