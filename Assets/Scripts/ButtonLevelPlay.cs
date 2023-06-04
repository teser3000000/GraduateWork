using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using TMPro;

namespace Valve.VR.InteractionSystem.Sample
{
    [RequireComponent(typeof(Outline))]
   
    public class ButtonLevelPlay : MonoBehaviour
    {
        [SerializeField] public TMP_Text text;
        [SerializeField] public TMP_Text description;
        [SerializeField] public TMP_Text batteries;
        [SerializeField] public TMP_Text pumpNumber1;
        [SerializeField] public TMP_Text pumpNumber2;
        [SerializeField] public TMP_Text pumpNumber3;
        [SerializeField] public TMP_Text pumpNumber4;
        [SerializeField] public TMP_Text pumpNumber5;
        [SerializeField] public TMP_Text pumpNumber6;

        [SerializeField] public GameObject myLockImage;
        [SerializeField] public GameObject myLockImageTwo;
        [SerializeField] public GameObject myLockImageTree;
        [SerializeField] public GameObject myLockImageFour;
        [SerializeField] public GameObject myLockImageFife;
        [SerializeField] public GameObject myLockImageSix;
        [SerializeField] public GameObject myLockImageSeven;
        
        [SerializeField] public GameObject checkMark; 
        [SerializeField] public GameObject checkMark2; 

        [SerializeField] public GameObject pump1; 
        [SerializeField] public GameObject pump2; 
        [SerializeField] public GameObject pump3; 
        [SerializeField] public GameObject pump4; 
        [SerializeField] public GameObject pump5; 
        [SerializeField] public GameObject pump6; 


        [SerializeField] public GameObject ButtonOne;
        [SerializeField] public GameObject ButtonTwo;
        [SerializeField] public GameObject ButtonTree;
        [SerializeField] public GameObject ButtonFour;
        [SerializeField] public GameObject ButtonFife;
        [SerializeField] public GameObject ButtonSix;
        [SerializeField] public GameObject ButtonSeven;
        [SerializeField] public GameObject ButtonEight;
        [SerializeField] public GameObject ButtonNine;
        [SerializeField] public GameObject ButtonTen;
        [SerializeField] public GameObject ButtonEleven;
        [SerializeField] public GameObject ButtonTwelve;
        [SerializeField] public GameObject ButtonThirteen;

        [SerializeField] public AudioSource startPlane;
        

       
        public bool buttonOne = false;
        public bool buttonTwo = false;
        public bool buttonTree = false;
        public bool buttonFour = false;
        public bool buttonFife = false;
        public bool buttonSix = false;
        public bool buttonSeven = false;
        public bool buttonEight = false;
        public bool buttonNine = false;
        public bool buttonTen = false;
        public bool buttonEleven = false;
        public bool buttonTwelve = false;
        public bool buttonThirteen = false;
        public void Start()
        {
            ResetButtons();
            ResetImg();
            ResetDescription();
            myLockImage.SetActive(true);
            text.text = "1. Включить внешний источник питания";
            description.text = "Оказавшись в самолете, в первую очередь необходимо подать наземное питание";
            
        }

        public void OnButtonDown(Hand fromHand)
        {
            ColorSelf(Color.cyan);
            //fromHand.TriggerHapticPulse(1000);
        }

        //когда отпустил кнопку
        public void OnButtonUp(Hand fromHand)
        {
            buttonOne = !buttonOne;
            if (buttonOne == true)
            {
                text.text = "2. Включить навигационные огни";
                description.text = "Навигационные огни являются знаком того, " +
                    "что экипаж в кабине ведет подготовку к полету";
                myLockImage.SetActive(false);
                myLockImageTwo.SetActive(true);
                ButtonOne.GetComponent<Outline>().enabled = false;
                ButtonTwo.GetComponent<Outline>().enabled = true;
            }
            else
            {
                text.text = "1. Включить внешний источник питания";
                description.text = "Оказавшись в самолете, в первую очередь необходимо подать наземное питание";
                myLockImage.SetActive(true);
                myLockImageTwo.SetActive(false);
                ButtonOne.GetComponent<Outline>().enabled = true;
                ButtonTwo.GetComponent<Outline>().enabled = false;
            }
        }
        public void OnButtonTWO(Hand fromHand)
        {
            if(buttonOne == true)
            {
                buttonTwo = !buttonTwo;
                if (buttonTwo == true)
                {
                    text.text = "3. Включите батареи";
                    description.text = "Первая батарея";
                    batteries.text = "Вторая батарея";
                    myLockImageTwo.SetActive(false);
                    myLockImageTree.SetActive(true);
                    ButtonTwo.GetComponent<Outline>().enabled = false;
                    ButtonTree.GetComponent<Outline>().enabled = true;
                    ButtonFour.GetComponent<Outline>().enabled = true;
                }
            }
            else
            {
                text.text = "1. Включить внешний источник питания";
                description.text = "Оказавшись в самолете, в первую очередь необходимо подать наземное питание";
                myLockImage.SetActive(true);
                myLockImageTwo.SetActive(false);
                ButtonOne.GetComponent<Outline>().enabled = true;
                ButtonTwo.GetComponent<Outline>().enabled = false;
            }

        }
        public void OnButtonTREE(Hand fromHand)
        {
            if (buttonTwo == true)
            {
                buttonTree = !buttonTree;
                if(buttonTree == true)
                {
                    checkMark.SetActive(true);
                    ButtonTree.GetComponent<Outline>().enabled = false;
                    Check3_4();
                }
                else
                {
                    ButtonTree.GetComponent<Outline>().enabled = true;
                    checkMark.SetActive(false);
                }
            }
        }
        public void OnButtonFOUR(Hand fromHand)
        {
            if (buttonTwo == true)
            {
                buttonFour = !buttonFour;
                if(buttonFour == true)
                {
                    checkMark2.SetActive(true);
                    ButtonFour.GetComponent<Outline>().enabled = false;
                    Check3_4();
                }
                else
                {
                    ButtonFour.GetComponent<Outline>().enabled = true;
                    checkMark2.SetActive(false);
                }
            }
        }
        public void OnButtonFIFE(Hand fromHand)
        {
            if (buttonTree == true && buttonFour == true)
            {
                buttonFife = !buttonFife;
                if (buttonFife == true)
                {
                    pump1.SetActive(true);
                    ButtonFife.GetComponent<Outline>().enabled = false;
                    Сheck();
                }
                else
                {
                    pump1.SetActive(false);
                    ButtonFife.GetComponent<Outline>().enabled = true;
                }
            }
        }
        public void OnButtonSIX(Hand fromHand)
        {
            if (buttonTree == true && buttonFour == true)
            {
                buttonSix = !buttonSix;
                if (buttonSix == true)
                {
                    pump2.SetActive(true);
                    ButtonSix.GetComponent<Outline>().enabled = false;
                    Сheck();
                }
                else
                {
                    pump2.SetActive(false);
                    ButtonSix.GetComponent<Outline>().enabled = true;
                }
            }
        }
        public void OnButtonSEVEN(Hand fromHand)
        {
            if (buttonTree == true && buttonFour == true)
            {
                buttonSeven = !buttonSeven;
                if (buttonSeven == true)
                {
                    pump3.SetActive(true);
                    ButtonSeven.GetComponent<Outline>().enabled = false;
                    Сheck();

                }
                else
                {
                    pump3.SetActive(false);
                    ButtonSeven.GetComponent<Outline>().enabled = true;
                }
            }
        }
        public void OnButtonEIGHT(Hand fromHand)
        {
            if (buttonTree == true && buttonFour == true)
            {
                buttonEight = !buttonEight;
                if(buttonEight == true)
                {
                    pump4.SetActive(true);
                    ButtonEight.GetComponent<Outline>().enabled = false;
                    Сheck();

                }
                else
                {
                    pump4.SetActive(false);
                    ButtonEight.GetComponent<Outline>().enabled = true;
                }
            }
        }
        public void OnButtonNINE(Hand fromHand)
        {
            if (buttonTree == true && buttonFour == true)
            {
                buttonNine = !buttonNine;
                if(buttonNine == true)
                {
                    pump5.SetActive(true);
                    ButtonNine.GetComponent<Outline>().enabled = false;
                    Сheck();
                }
                else
                {
                    pump5.SetActive(false);
                    ButtonNine.GetComponent<Outline>().enabled = true;
                }

            }
        }
        public void OnButtonTEN(Hand fromHand)
        {
            if (buttonTree == true && buttonFour == true)
            {
                buttonTen = !buttonTen;
                if (buttonTen == true)
                {
                    pump6.SetActive(true);
                    ButtonTen.GetComponent<Outline>().enabled = false;
                    Сheck();
                }
                else
                {
                    pump6.SetActive(false);
                    ButtonTen.GetComponent<Outline>().enabled = true;
                }
            }
        }
        public void OnButtonELEVEN(Hand fromHand)
        {
            if (buttonFife == true && buttonSix == true && buttonSeven == true && buttonEight == true && buttonNine == true && buttonTen == true)
            {
                buttonEleven = !buttonEleven;
                if (buttonEleven == true)
                {
                    text.text = "6. Включить вспомогательную силовую установку";
                    description.text = "";
                    myLockImageTwo.SetActive(false);
                    ButtonEleven.GetComponent<Outline>().enabled = false;
                    ButtonTwelve.GetComponent<Outline>().enabled = true;
                    myLockImageFife.SetActive(false);
                    myLockImageSix.SetActive(true);
                }
            }
        }
        public void OnButtonTWELVE(Hand fromHand)
        {
            if (buttonEleven == true)
            {
                buttonTwelve = !buttonTwelve;
                if (buttonTwelve == true)
                {
                    text.text = "7. Включить стартер";
                    description.text = "";
                    ButtonTwelve.GetComponent<Outline>().enabled = false;
                    ButtonThirteen.GetComponent<Outline>().enabled = true;
                    myLockImageSix.SetActive(false);
                    myLockImageSeven.SetActive(true);
                }
            }
        }
        public void OnButtonFOURTEEN(Hand fromHand)
        {
            if (buttonTwelve == true)
            {
                CheckFinaly();
            }
        }
        public void OnButtonTHIRTEEN(Hand fromHand)
        {
            if (buttonTwelve == true)
            {
                buttonThirteen = !buttonThirteen;
                if (buttonThirteen == true)
                {
                    text.text = "8. вввв";
                    description.text = "";
                    ButtonTwelve.GetComponent<Outline>().enabled = false;
                    ButtonThirteen.GetComponent<Outline>().enabled = true;
                    startPlane.Play();
                }
            }
        }
        public void Сheck()
        {
            if (buttonFife == true && buttonSix == true && buttonSeven == true && buttonEight == true && buttonNine == true && buttonTen == true)
            {
                ResetDescription();
                text.text = "5. Включить сигнальный огонь";
                description.text = "Сигнальный огонь сообщает наземному обсуживанию, что мы запускаем двигаетли агрегаты";
                ButtonEleven.GetComponent<Outline>().enabled = true;
                ResetImg();
                myLockImageFour.SetActive(false);
                myLockImageFife.SetActive(true);
            }
        }
        public void Check3_4()
        {
            if (buttonTree == true && buttonFour == true)
            {

                text.text = "4. Включить топливные насосы";
                batteries.text = "";
                description.text = "Для запуска двигателей, " +
                    "необхобходимо активировать воздушную силовую установку." +
                    " Для ее активации, необходимо запустить топливные насосы";

                checkMark2.SetActive(false);
                checkMark.SetActive(false);

                myLockImageTree.SetActive(false);
                myLockImageFour.SetActive(true);

                pumpNumber1.text = "Первый насос";
                pumpNumber2.text = "Второй насос";
                pumpNumber3.text = "Третий насос";
                pumpNumber4.text = "Четвертый насос";
                pumpNumber5.text = "Пятый насос";
                pumpNumber6.text = "Шестой насос";

                ButtonFife.GetComponent<Outline>().enabled = true;
                ButtonSix.GetComponent<Outline>().enabled = true;
                ButtonSeven.GetComponent<Outline>().enabled = true;
                ButtonEight.GetComponent<Outline>().enabled = true;
                ButtonNine.GetComponent<Outline>().enabled = true;
                ButtonTen.GetComponent<Outline>().enabled = true;
            }
        }
        public void CheckFinaly()
        {
            if (buttonOne == true && buttonTwo == true && buttonTree == true && buttonFour == true && buttonFife == true && buttonSix == true && buttonSeven == true && buttonEight == true && buttonNine == true && buttonTen == true && buttonEleven == true && buttonTwelve == true && buttonThirteen == true)
            {
                SceneManager.LoadScene("Complited");
            }
        }
        public void ResetButtons()
        {
            ButtonTwo.GetComponent<Outline>().enabled = false;
            ButtonTree.GetComponent<Outline>().enabled = false;
            ButtonFour.GetComponent<Outline>().enabled = false;
            ButtonFife.GetComponent<Outline>().enabled = false;
            ButtonSix.GetComponent<Outline>().enabled = false;
            ButtonSeven.GetComponent<Outline>().enabled = false;
            ButtonEight.GetComponent<Outline>().enabled = false;
            ButtonNine.GetComponent<Outline>().enabled = false;
            ButtonTen.GetComponent<Outline>().enabled = false;
            ButtonEleven.GetComponent<Outline>().enabled = false;
            ButtonTwelve.GetComponent<Outline>().enabled = false;
            ButtonThirteen.GetComponent<Outline>().enabled = false;
        }
        public void ResetImg()
        {
            checkMark.SetActive(false);
            checkMark2.SetActive(false);
            myLockImage.SetActive(false);
            myLockImageTwo.SetActive(false);
            myLockImageTree.SetActive(false);
            myLockImageFour.SetActive(false);
            myLockImageFife.SetActive(false);
            myLockImageSix.SetActive(false);
            myLockImageSeven.SetActive(false);
            pump1.SetActive(false);
            pump2.SetActive(false);
            pump3.SetActive(false);
            pump4.SetActive(false);
            pump5.SetActive(false);
            pump6.SetActive(false);
        }
        public void ResetDescription()
        {
            batteries.text = "";
            pumpNumber1.text = "";
            pumpNumber2.text = "";
            pumpNumber3.text = "";
            pumpNumber4.text = "";
            pumpNumber5.text = "";
            pumpNumber6.text = "";
        }
        //когда кнопка нажата
        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();

            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
    }
}
