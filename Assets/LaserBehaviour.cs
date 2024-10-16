using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviour : MonoBehaviour
{

    [SerializeField] private float ThresholdY = 7f;


    // Start is called before the first frame update
    void Start()
    {
        // "LaserCoroutine" rutinini baslat
        StartCoroutine(nameof(LaserCoroutine));
    }

    IEnumerator LaserCoroutine()
    {
        // Bu obje yok olana kadar bekle-git islemine devam et
        while (this.gameObject != null)
        {
            // 1 saniye bekle
            yield return new WaitForSeconds(1f);

            // 1 saniye bekledikten sonra 1 birim yukari git.
            transform.position = transform.position + Vector3.up;
        }
    }


    private void Update()
    {
        // lazerin konum vektorunun y degeri "ThresholdY" esik degerinden buyukse laser objesini yok et.
        if(transform.position.y > ThresholdY) Destroy(gameObject);
    }




}
