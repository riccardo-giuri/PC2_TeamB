using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float Duration;
    public float Magnitude;

    public IEnumerator Shake()
    {
        Vector3 originalPosition = transform.localPosition;
        float elapsed = 0.0f;

        while (elapsed < Duration)
        {
            float x = Random.Range(-1f, 1f) * Magnitude;
            float y = Random.Range(-1f, 1f) * Magnitude;

            transform.localPosition = new Vector3(x, y, originalPosition.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPosition;
    }
}
