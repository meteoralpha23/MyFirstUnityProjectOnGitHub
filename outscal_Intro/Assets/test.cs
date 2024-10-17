using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class test : MonoBehaviour
{

    [SerializeField] Button button;
    [SerializeField] string newScene;
    [SerializeField] Button button2;
    [SerializeField] string MasterScene;

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
        button2.onClick.AddListener(loadMasterScene);
    }

    private void OnButtonClick()
    {

       SceneManager.LoadScene(newScene);

    }

    private void loadMasterScene()
    {
        SceneManager.LoadScene(MasterScene);
    }

}
