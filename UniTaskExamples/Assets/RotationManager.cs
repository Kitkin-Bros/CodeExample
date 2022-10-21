using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class RotationManager : MonoBehaviour {
    [SerializeField]
    public List<Rotator> rotators;

    [SerializeField]
    public GameObject finishedText;

    public void BeginCoroutineTest() {
        for (var i = 0; i < rotators.Count; i++) {
            StartCoroutine(rotators[i].CoroutineRotate(1 + 1 * i));
        }
    }
    
    public void BeginAsyncTest() {
        for (var i = 0; i < rotators.Count; i++) {
           rotators[i].AsyncRotate(1 + 1 * i);
        }
    }
    public async void BeginAsyncSequentialTest() {
        for (var i = 0; i < rotators.Count; i++) {
            await rotators[i].AsyncRotateWithReturn(1 + 1 * i);
        }
    }
    public async void BeginAsyncWaitForallComplition() {
        finishedText.SetActive(false);
        var tasks = new List<Task>();
        for (var i = 0; i < rotators.Count; i++) {
            tasks.Add( rotators[i].AsyncRotateWithReturn(1 + 1 * i));
        }

        await Task.WhenAll(tasks);
        finishedText.SetActive(true);
    }
    public async void BeginAsyncSequentialWaitForAllComplition() {
        finishedText.SetActive(false);
        await rotators[0].AsyncRotateWithReturn(2);
        var tasks = new List<Task>();
        for (var i = 1; i < rotators.Count; i++) {
            tasks.Add( rotators[i].AsyncRotateWithReturn(1 + 1 * i));
        }

        await Task.WhenAll(tasks);
        finishedText.SetActive(true);
    }

    public async void PrintRandomNumberAsync() {
        var randomNumber =  await GetRandomNumber();
        Debug.Log(randomNumber);
    }

    private async Task<int> GetRandomNumber() {
        var randomNumber =  Random.Range(1, 5);
        await rotators[0].AsyncRotateWithReturn(randomNumber);
        return randomNumber;
    }
    //Sequential Coroutine

    IEnumerator SequentialCoroutines() {
        yield return StartCoroutine(Action1());
        yield return StartCoroutine(Action2());
        yield return StartCoroutine(Action3());
    }

    IEnumerator Action1() {
        //DO thing
        yield return new WaitForSeconds(1);
    }
    IEnumerator Action2() {
        //DO thing
        yield return new WaitForSeconds(1);
    }
    IEnumerator Action3() {
        //DO thing
        yield return new WaitForSeconds(1);
    }

    //Sequential Async by returning Task
    public async Task Action1Async() {
        //Do thing
        await Task.Yield();
    } 
    
}
