using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planetas : MonoBehaviour{

    public GameObject planeta;
    public Button btnSiguiente;
    public Text txtPlanetas;
    public Material matP1, matP2,matP3, matP4, matP5, matP6, matP7, matP8, matP9;
    public AudioClip snd1, snd2, snd3, snd4, snd5, snd6, snd7, snd8, snd9;

    private int contadorPlaneta = 0;
    private AudioSource reproductor;

    // Start is called before the first frame update
    void Start(){
        planeta.SetActive(false);
        reproductor = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    private void Update(){
        if (contadorPlaneta > 0){
            planeta.SetActive(true);
        }
    }

    public void BtnSiguiente() {
        if (DefaultObserverEventHandler.PatronDetectado == 1 ){
            contadorPlaneta++;
            DibujaPlanetas();
        }
        
    }

    private void DibujaPlanetas(){
        switch (contadorPlaneta) {
            case 1:
                planeta.transform.localScale = new Vector3(0.383f, 0.383f, 0.383f);
                planeta.GetComponent<MeshRenderer>().material = matP1;
                txtPlanetas.text = "Mercurio";
                reproductor.clip = snd1;
                reproductor.Play();
                break;
            case 2:
                planeta.transform.localScale = new Vector3(0.949f,0.949f,0.949f);
                planeta.GetComponent<MeshRenderer>().material = matP2;
                txtPlanetas.text = "Venus";
                reproductor.clip = snd2;
                reproductor.Play();
                break;
            case 3:
                planeta.transform.localScale = new Vector3(1f, 1f, 1f);
                planeta.GetComponent<MeshRenderer>().material = matP3;
                txtPlanetas.text = "Tierra";
                reproductor.clip = snd3;
                reproductor.Play();
                break;
            case 4:
                planeta.transform.localScale = new Vector3(0.532f, 0.532f, 0.532f);
                planeta.GetComponent<MeshRenderer>().material = matP4;
                txtPlanetas.text = "Marte";
                reproductor.clip = snd4;
                reproductor.Play();
                break;
            case 5:
                planeta.transform.localScale = new Vector3(11.209f, 11.209f, 11.209f);
                planeta.GetComponent<MeshRenderer>().material = matP5;
                txtPlanetas.text = "Júpiter";
                reproductor.clip = snd5;
                reproductor.Play();
                break;
            case 6:
                planeta.transform.localScale = new Vector3(9.449f, 9.449f, 9.449f);
                planeta.GetComponent<MeshRenderer>().material = matP6;
                txtPlanetas.text = "Saturno";
                reproductor.clip = snd6;
                reproductor.Play();
                break;
            case 7:
                planeta.transform.localScale = new Vector3(4.007f, 4.007f, 4.007f);
                planeta.GetComponent<MeshRenderer>().material = matP7;
                txtPlanetas.text = "Urano";
                reproductor.clip = snd7;
                reproductor.Play();
                break;
            case 8:
                planeta.transform.localScale = new Vector3(3.883f, 3.883f, 3.883f);
                planeta.GetComponent<MeshRenderer>().material = matP8;
                txtPlanetas.text = "Neptuno";
                reproductor.clip = snd8;
                reproductor.Play();
                break;
            case 9:
                planeta.transform.localScale = new Vector3(0.186f, 0.186f, 0.186f);
                planeta.GetComponent<MeshRenderer>().material = matP9;
                txtPlanetas.text = "Plutón";
                reproductor.clip = snd9;
                reproductor.Play();
                contadorPlaneta = 0;
                break;
        }

    }
}
