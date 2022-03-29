using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapToggleScript : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] GameObject _3DButton;
    [SerializeField] GameObject _2DButton;
    // Start is called before the first frame update
    void Start()
    {
        CheckLastToggle();
    }

    public void CheckLastToggle()
    {
        if (PlayerPrefs.GetInt("3DMapToggle") == 0)
        {
            camera.orthographic = true;
            camera.transform.rotation = Quaternion.Euler(90, 0, 0);
            Vector3 defaultPos = Vector3.Lerp(transform.position, new Vector3(0, 100, -10), 0.5f);
            camera.transform.position = new Vector3(0, 100, -10);
            _2DButton.SetActive(false);
            _3DButton.SetActive(true);
            if (PlayerPrefs.HasKey("CameraPosX"))
            {
                camera.transform.position = new Vector3(PlayerPrefs.GetFloat("CameraPosX"), PlayerPrefs.GetFloat("CameraPosY"), PlayerPrefs.GetFloat("CameraPosZ"));
            }
        }
        if (PlayerPrefs.GetInt("3DMapToggle") == 1)
        {
            camera.orthographic = false;
            camera.transform.rotation = Quaternion.Euler(50, 0, 0);
            Vector3 defaultPos = Vector3.Lerp(transform.position, new Vector3(0, 160, -160), 0.5f);
            camera.transform.position = new Vector3(0, 100, -50);
            _3DButton.SetActive(false);
            _2DButton.SetActive(true);
            if (PlayerPrefs.HasKey("CameraPosX"))
            {
                camera.transform.position = new Vector3(PlayerPrefs.GetFloat("CameraPosX"), PlayerPrefs.GetFloat("CameraPosY"), PlayerPrefs.GetFloat("CameraPosZ"));
            }
        }
        else if (!PlayerPrefs.HasKey("3DMapToggle"))
        {
            PlayerPrefs.SetInt("3DMapToggle", 0);
        }
    }

    public void ToggleCamera3D()
    {
        camera.orthographic = false;
        camera.transform.rotation = Quaternion.Euler(50,0,0);
        Vector3 defaultPos = Vector3.Lerp(transform.position, new Vector3(0, 160, -160), 0.5f);
        camera.transform.position = new Vector3(0, 100, -50);
        _3DButton.SetActive(false);
        _2DButton.SetActive(true);
        PlayerPrefs.SetInt("3DMapToggle", 1);
    }

    public void ToggleCamera2D()
    {
        camera.orthographic = true;
        camera.transform.rotation = Quaternion.Euler(90, 0, 0);
        Vector3 defaultPos = Vector3.Lerp(transform.position, new Vector3(0, 100, -10), 0.5f);
        camera.transform.position = new Vector3(0, 100, -10);
        _2DButton.SetActive(false);
        _3DButton.SetActive(true);
        PlayerPrefs.SetInt("3DMapToggle", 0);
    }
}
