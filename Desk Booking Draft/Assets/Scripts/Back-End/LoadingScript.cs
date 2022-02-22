using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    [SerializeField] Slider levelBar;
    [SerializeField] Text barValue;
    [SerializeField] GameObject[] objects;
    public bool loading;
    // Start is called before the first frame update
    void Start()
    {
        SceneLoader(0);
        loading = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneLoader(int sceneIndex)
    {
        DontDestroyOnLoad(this.gameObject);
        for (int i = objects.Length - 1; i >= 0; i--)
        {
            objects[i].SetActive(true);
        }
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        //yield return new WaitForSeconds(2);

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            levelBar.value = progress;
            barValue.text = (progress * 100f) + "%";
            loading = true;
            yield return null;
        }
        loading = false;

        for (int i = objects.Length - 1; i >= 0; i--)
        {
            objects[i].SetActive(false);
        }
    }
}
