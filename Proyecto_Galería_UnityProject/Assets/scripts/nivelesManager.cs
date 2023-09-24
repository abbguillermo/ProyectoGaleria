using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class nivelesManager : MonoBehaviour
{
    public static nivelesManager instance;

    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Slider _progressSlider;
    private float _target;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public async void LoadScene(string sceneName)
    {
        _progressSlider.value = 0;
        var scene = SceneManager.LoadSceneAsync(sceneName);
        scene.allowSceneActivation = false;
        _target = 0;
        _loaderCanvas.SetActive(true);

        while (!scene.isDone)
        {
            _target = Mathf.MoveTowards(_target, scene.progress, Time.deltaTime);
            _progressSlider.value = _target;
            if (_target >= 0.9f)
            {
                await Task.Delay(1000);
                _progressSlider.value = 1;
                scene.allowSceneActivation = true;
            }
        }

        /*do
        {
            await Task.Delay(1000); //artifical wait time
            _progressSlider.value = scene.progress;
        }
        while (scene.progress < 0.9f);

        //await Task.Delay(1000);

        scene.allowSceneActivation = true;*/

        StartCoroutine(ActivarEscena());
    }

    /*private void Update()
    {
        _progressSlider.value = Mathf.MoveTowards(_progressSlider.value, _target, 3 * Time.deltaTime);
    }*/

    IEnumerator ActivarEscena()
    {
        yield return new WaitForSeconds(3);
        _loaderCanvas.SetActive(false);
    }
}
