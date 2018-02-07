using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VMUP.InteractionVR;

public class QuestionMarkBtn : InteractiveObject
{
    public ControladorVR controlador;
    public Canvas tutorCanvas;
    public Canvas vmCanvas;
    public Text canvasTitle;
    public Text canvasExplanation;
    private string title;
    private string explanation;

    public InteractiveObject interactiveObject
    {
        get
        {
            return transform.GetComponent<InteractiveObject>();
        }
    }

    public Rigidbody rb
    {
        get
        {
            return transform.GetComponent<Rigidbody>();
        }
    }

    public BoxCollider bc
    {
        get
        {
            return transform.GetComponent<BoxCollider>();
        }
    }

    void OnEnable()
    {
        interactiveObject.OnClicked += Teach;
        interactiveObject.OnHovered += GiveHint;
        interactiveObject.OnExit += Close;
    }

    // Use this for initialization
    void Teach ()
    {
        tutorCanvas.enabled = true;
        vmCanvas.enabled = false;

        switch (controlador.currentObject.name)
        {
            case "QuestionO2Conc":
                title = "Parâmetro O2";
                explanation = "Nível de oxigênio ofertado ao paciente. No ar ambiente está na concentração de 21%. No VM pode ser ofertado até 100% dependendo do quadro clínico e condições do pulmão.";
                break;
            case "QuestionPEEP":
                title = "Parâmetro PEEP";
                explanation = "Pressão residual no pulmão ao final da expiração. Em geral não deve ficar abaixo de 3 cmH2O e somente deve ultrapassar os 10 cmH2O em casos específicos.";
                break;
            default:
                break;
        }

        canvasTitle.text = title;
        canvasExplanation.text = explanation;

        Invoke("CloseExplanation", 10.0f);
    }

    void GiveHint()
    {

    }

    void Close()
    {

    }
	
	void CloseExplanation()
    {
        tutorCanvas.enabled = false;
        vmCanvas.enabled = true;
    }
}
