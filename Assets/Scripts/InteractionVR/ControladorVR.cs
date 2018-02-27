using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace VMUP.InteractionVR
{
    public class ControladorVR : MonoBehaviour
    {
        // comprimento do raio que colide com objetos
        public float rayLength = 100f;

        public Transform cam;
        
        // variavel guarda o objeto que e atingido pelo raycast
        private RaycastHit hit;

        public InteractiveObject currentObject;

        // referencia para a camera principal na cena
        public Camera mainCamera
        {
            get
            {
                return Camera.main;
            }
        }

        // imagem que representa o ponto que interage com os objetos
        public Image rectile;

        // imagem que representa um objeto alvo de interacao
        public Image target;

        // tamanho do ponto quando encontra um objeto interativo
        public Vector2 rectileInteractionSize;

        // tamanho do ponto normal, sem interacao
        public Vector2 rectileNormalSize;

        // texto na cena para debug
        public Text debugText;

        //inicializa o objeto MonoBehaviour
        void Start()
        {
            UnityEngine.XR.InputTracking.Recenter();

#if UNITY_WSA
    Debug.Log("Stand Alone OSX");
#endif
        }

        // executa em todos os frames 
        void Update()
        {
            Interact();
        }

        //----------------------------------------------------------------
        // Interacao do Usuario com objetivos interativos na cena
        //----------------------------------------------------------------

        void Interact()
        {
            //cria um raio que tem origem na posicao da camera e se estende no eixo z da camera (frente)
            Ray ray = new Ray(cam.position, cam.forward);

            // se atinge um objeto interativo na cena...
            if (Physics.Raycast(ray, out hit, rayLength))
            {
                Debug.DrawRay(cam.position, cam.forward, Color.yellow, rayLength);

                //se este objeto e um objeto interativo...
                if (hit.collider.tag.Equals("Object"))
                {
                    currentObject = hit.collider.GetComponent<InteractiveObject>();

                    Debug.Log(hit.collider.gameObject.name);

                    // anima a escala do ponto
                    rectile.rectTransform.DOSizeDelta(rectileInteractionSize,1f);

                    // torna-se o objeto alvo vermelho
                    rectile.DOColor(Color.cyan, 1f);

                    //Input para Gear VR (Android)

                    if (Input.GetMouseButtonDown(0))
                    {
                        if (currentObject != null)
                            currentObject.OnClick();
                    }

                    if (currentObject != null)
                        currentObject.OnHover();
                }
            }
                
            // quando nao esta colidindo com objetivos interativos...
            else
            {
               // anima a escala do ponto para a forma inicial
                rectile.rectTransform.DOSizeDelta(rectileNormalSize,1f);

                // retorna a cor padrao do objeto alvo
                rectile.DOColor(Color.white, 1f);

                if (currentObject != null)
                    currentObject.Exit();
            }
        }
    }
}