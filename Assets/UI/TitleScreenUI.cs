using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class TitleScreenUI : MonoBehaviour
{
    private Button m_Button;
    // Start is called before the first frame update
    void Start()
    {
        var uiDoc = GetComponent<UIDocument>();
        m_Button = uiDoc.rootVisualElement.Q<Button>("PlayButton");
        m_Button.clicked += OnStartButtonPressed;
        // Just an example for UI event callbacks. Does not do much for now
        // Also, we have USS to update the element style so we probably won't need this
        m_Button.RegisterCallback<MouseEnterEvent>(OnPointerEnter);
    }

    void OnStartButtonPressed()
    {
        Debug.Log("Button clicked!");
        // TODO Put a spinner while we're loading the next frame with LoadSceneAsync instead.
        SceneManager.LoadScene("NameInput");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(MouseEnterEvent eventData) {
        Debug.Log("Hovered!");
    }
}
