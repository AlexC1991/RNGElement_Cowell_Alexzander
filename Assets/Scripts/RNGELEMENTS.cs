using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using TMPro;

namespace AlexzanderCowell
{
    public class RNGELEMENTS : MonoBehaviour
    {
        [Header("RNG Elements")]
        [SerializeField] private GameObject element1;
        [SerializeField] private GameObject element2;
        [SerializeField] private GameObject element3;
        [SerializeField] private GameObject element4;
        [SerializeField] private GameObject element5;


        [Header("Canvas 1 & 2")]
        [SerializeField] private GameObject canvas1;
        [SerializeField] private GameObject canvas2;

        private bool rngCheck1;
        private bool rngCheck2;
        private bool rngCheck3;
        private bool rngCheck4;
        private bool rngCheck5;
        private bool timerStart;
        private bool Answer1 = false;
        private bool Answer2 = false;
        private bool Answer3 = false;
        private bool Answer4 = false;
        private bool Answer5 = false;
        

        [Header("Timer")]
        [Range(0,10)]
        [SerializeField] private float rngTimer;
        
        private float rngTimerRestart;
        private float rngCounter1;
        private float rngCounter2;
        private float rngCounter3;
        private float rngCounter4;
        private float rngCounter5;
        private float rngAnswer1;
        private float rngAnswer2;
        private float rngAnswer3;
        private float rngAnswer4;
        private float rngAnswer5;
        private float rngAnswerReset = 0;
        private int totalWin1 = 0;
        private int totalWin2 = 0;
        private int totalWin3 = 0;
        private int totalWin4 = 0;
        private int totalWin5 = 0;
      


        [Header ("Text Box")]
        [SerializeField] Text displayedTimer;
        [SerializeField] Text elementCount1;
        [SerializeField] Text elementCount2;
        [SerializeField] Text elementCount3;
        [SerializeField] Text elementCount4;
        [SerializeField] Text elementCount5;
        [SerializeField] TextMeshProUGUI winningResults;

        [Header("Text Color Change")]
        [SerializeField] GameObject textColor;


        void Start()
        {
            canvas1.SetActive (true);
            canvas2.SetActive (false);
            rngTimerRestart = rngTimer;
            rngAnswer1 = rngAnswerReset;
            rngAnswer2 = rngAnswerReset;
            rngAnswer3 = rngAnswerReset;
            rngAnswer4 = rngAnswerReset;
            rngAnswer5 = rngAnswerReset;
            rngCheck1 = false;
            rngCheck2 = false;
            rngCheck3 = false;
            rngCheck4 = false;
            timerStart = false;
            
            
        }

        // Update is called once per frame
        void Update()
        {
            ResultsDisplayed();
            displayedTimer.text = "Timer: " + rngTimer.ToString("f2");
            elementCount1.text = totalWin1.ToString("f0");
            elementCount2.text = totalWin2.ToString("f0");
            elementCount3.text = totalWin3.ToString("f0");
            elementCount4.text = totalWin4.ToString("f0");
            elementCount5.text = totalWin5.ToString("f0");


            //if (rngTimer == rngTimerRestart)
           // {
                //canvas1.SetActive(true);
                //canvas2.SetActive(false);
               // rngAnswer1 = rngAnswerReset;
               // rngAnswer2 = rngAnswerReset;
               // rngAnswer3 = rngAnswerReset;
               // rngAnswer4 = rngAnswerReset;
               // rngAnswer5 = rngAnswerReset;
               // rngCheck1 = true;
               // rngCheck2 = true;
               // rngCheck3 = true;
               // rngCheck4 = true;
               // rngCheck5 = true;
                //timerStart = true;
               // Answer1 = false;
               // Answer2 = false;
              //  Answer3 = false;
              //  Answer4 = false;
              //  Answer5 = false;
           // }
           
           Debug.Log(rngCounter1);
           Debug.Log(rngCounter2);
           Debug.Log(rngCounter3);
           Debug.Log(rngCounter4);
           Debug.Log(rngCounter5);

            //if (timerStart)
            //{
             //   rngTimer -= 1f * Time.deltaTime;
            //}

            //if (rngCheck1)
            //{
                rngCounter1 = Random.Range(1, 10);
                
                if (rngCounter1 == 4)
                {
                    rngAnswer1 += (1);
                    totalWin1 += 1;
                }
            //}
            
           // if (rngCheck2)
            //{
                rngCounter2 = Random.Range(1, 20);
                
                if (rngCounter2 == 7)
                {
                    rngAnswer2 += (1);
                    totalWin2 += 1;
                }
            //}

            //if (rngCheck3)
            //{
                rngCounter3 = Random.Range(2, 100);
                
                if (rngCounter3 == 51)
                {
                    rngAnswer3 += (1);
                    totalWin3 += 1;
                }
            //}

            //if (rngCheck4)
            //{
                rngCounter4 = Random.Range(1, 250);

                if (rngCounter4 == 80)
                {
                    rngAnswer4 += (1);
                    totalWin4 += 1;
                }
            //}

            //if (rngCheck5)
            //{
                rngCounter5 = Random.Range(1, 2000);

                if (rngCounter5 == 389)
                {
                    rngAnswer5 += (1);
                    totalWin5 += 1;
                }
            //}
                
            //if (rngTimer <= 0.2f)
            //{
                //timerStart = false;
                //rngCheck1 = false;
                //rngCheck2 = false;
                //rngCheck3 = false;
                //rngCheck4 = false;
                //rngCheck5 = false;               
                //rngTimer = 0;
                //canvas1.SetActive(false);
                //canvas2.SetActive(true);
                //ResultsDisplayed();
                
                //if (!rngCheck1 && !rngCheck2 && !rngCheck3 && !rngCheck4 && !rngCheck5)
                //{
                  //  ResetTimer();
                //}
            //}
                        
        }

        private void ResultsDisplayed()
        {
            if (rngAnswer1 >= 180)
            {
                Answer1 = true;
            }

            if (rngAnswer2 >= 186)
            {
                Answer2 = true;
            }

            if (rngAnswer3 >= 42)
            {
                Answer3 = true;
            }

            if (rngAnswer4 >= 23)
            {
                Answer4 = true;
            }

            if (rngAnswer5 >= 6)
            {
                Answer5 = true;
            }

            if (Answer1)
            {                             
                if (!Answer2)
                {
                    if (!Answer3)
                    {
                        if (!Answer4)
                        {
                            if (!Answer5)
                            {
                                totalWin1 += (1);
                                textColor.GetComponent<TextMeshProUGUI>().color = Color.cyan;
                                winningResults.text = "You Win A Common".ToString();
                                ResetTimer();
                            }
                        }
                    }
                }
                
            }
            
            if (Answer2 == true)
            {
                if (Answer3 == false)
                {
                    if (Answer4 == false)
                    {
                        if (Answer5 == false)
                        {                           
                            Answer1 = false;
                            totalWin2 += (1);
                            textColor.GetComponent<TextMeshProUGUI>().color = Color.yellow;
                            winningResults.text = "You Win A Good".ToString();
                            ResetTimer();
                        }
                    }
                }
                
            }
            
            if (Answer3 == true)
            {
                if (Answer4 == false)
                {
                    if (Answer5 == false)
                    {                        
                        Answer1 = false;
                        Answer2 = false;
                        totalWin3 += (1);
                        textColor.GetComponent<TextMeshProUGUI>().color = Color.green;
                        winningResults.text = "You Win A Strong".ToString();
                        ResetTimer();
                    }
                }
                
            }
            
            if (Answer4 == true)
            {
                if (Answer5 == false)
                {
                    Answer1 = false;
                    Answer2 = false;
                    Answer3 = false;
                    totalWin4 += (1);
                    textColor.GetComponent<TextMeshProUGUI>().color = Color.red;
                    winningResults.text = "You Win A Rare".ToString();
                    ResetTimer();
                }
                
            }

            if (Answer5 == true)
            {
                Answer1 = false;
                Answer2 = false;
                Answer3 = false;
                Answer4 = false;
                totalWin5 += (1);
                textColor.GetComponent<TextMeshProUGUI>().color = Color.magenta;
                winningResults.text = "You Win A Unique".ToString();
                ResetTimer();
            }
        }

        private void ResetTimer()
        {
            rngTimer = rngTimerRestart;
            canvas1.SetActive(true);
            canvas2.SetActive(false);
            
        }
    }
}
