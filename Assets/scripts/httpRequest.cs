using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class httpRequest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetRequest("http://localhost:3000/basic"));
    }

    IEnumerator GetRequest(string url)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(url))
        {
            yield return webRequest.SendWebRequest();

            if (webRequest.result == UnityWebRequest.Result.Success)
            {
                // Handle successful response
                Debug.Log("Received: " + webRequest.downloadHandler.text);
            }
            else
            {
                // Handle error
                Debug.LogError("Error: " + webRequest.error);
            }
        }
    }
}






