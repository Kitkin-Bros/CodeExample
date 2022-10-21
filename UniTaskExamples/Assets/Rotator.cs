using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public IEnumerator CoroutineRotate(float duration) {
        var end = Time.time + duration;
        while (Time.time < end) {
            transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
            yield return null;
        }
    }
    public async void AsyncRotate(float duration) {
        var end = Time.time + duration;
        while (Time.time < end) {
            transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
            await Task.Yield();
        }
    }
    
    public async Task AsyncRotateWithReturn(float duration) {
        var end = Time.time + duration;
        while (Time.time < end) {
            transform.Rotate(new Vector3(1, 1) * Time.deltaTime * 150);
            await Task.Yield();
        }
    }
}
