using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O_UIController : MonoBehaviour //골동품
{
    public P_UIController puicon;
    public PlayerMovement movement;

    public Text dis;
    public Text main;
    public GameObject back;
    public GameObject All;
    public bool IsOpen;
    public bool IsRearn;
    public bool O_Dark;

    public bool O_Second;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //이건 닫는 코드
        if (Input.GetKeyDown(KeyCode.Escape) && IsOpen == true)
        {

            All.SetActive(false);
            IsOpen = false;
        }
        //이거는 여는 코드
        if (puicon.IsCollision == true)
        {
           
            if (puicon.obj.layer == 7) return;

            if (Input.GetKey(KeyCode.E))
            {
                
                if (puicon.obj.name == "A_Collider")
                {
                    

                    StartCoroutine(A());
                }

                if (puicon.obj.name == "B_Collider")
                {
                    
                    StartCoroutine(B());
                }

                if (puicon.obj.name == "C_Collider")
                {
                    StartCoroutine(C());
                }

                if (puicon.obj.name == "D_Collider")
                {
                    StartCoroutine(D());
                }

                if (puicon.obj.name == "E_Collider")
                {
                    dis.text = "";
                    main.text = "AA";
                    back.SetActive(true);
                }
                else if (puicon.obj.name == "F_Collider")
                {
                    dis.text = "";
                    main.text = "AA";
                    back.SetActive(true);
                }

            }
        }
    }
    //여는중 
    public IEnumerator A()
    {
        IsRearn = true;
        yield return new WaitForSeconds(2f);
                            
        All.SetActive(true);    //백그라운드 활성화 
        IsOpen = true;  //읽는중
        dis.text = "1985년～1986년까지 경상대학교 박물관의 발굴조사에서 출토된 유물이다. 가야 5세기 금귀걸이를 대표하는 작품으로서, 일본에 영향을 미친 당시 금속공예의 수준을 알려주는 중요한 작품이다.";
        main.text = "합천 옥전 28호분 출토 금귀걸이";
        back.SetActive(true);
        IsRearn = false;
        puicon.obj.transform.position = new Vector3(-10f, -10f, -10f);
        O_Dark = true;
        yield break;
    }

    public IEnumerator B()
    {
        IsRearn = true;
        yield return new WaitForSeconds(2f);

        All.SetActive(true);    //백그라운드 활성화 
        IsOpen = true;  //읽는중
        dis.text = "1980～1982년 부산 복천동 22호분 발굴 시 출토된 청동방울이다. 동아시아에서는 유례를 찾아 볼 수 없는 독특한 형태로 가야시대 의례와 청동 공예문화를 대표하는 문화재로서 의미가 크다.";
        main.text = "부산 복천동 22호분 출토 청동칠두령";
        back.SetActive(true);
        IsRearn = false;
        O_Second = true;
        yield break;
    }

    public IEnumerator C()
    {
        IsRearn = true;
        yield return new WaitForSeconds(2f);

        All.SetActive(true);    //백그라운드 활성화 
        IsOpen = true;  //읽는중
        dis.text = "1992년 동의대학교박물관에서 발굴 조사 중 토광목곽묘에서 발굴한 유물이다. 색채에 있어 맑고 투명한 무색과 황색 및 갈색 등의 다채로운 색상의 수정 표면을 매끈하게 다듬은 형태 또한 조형적인 가치가 뛰어나다.";
        main.text = "김해 양동리 제270호분 출토 목걸이";
        back.SetActive(true);
        IsRearn = false;
        //O_Dark = true;
        yield return null;
    }

    public IEnumerator D()
    {
        IsRearn = true;
        yield return new WaitForSeconds(2f);

        All.SetActive(true);    //백그라운드 활성화 
        IsOpen = true;  //읽는중
        dis.text = "주실인 11호분의 피장자 우측에서 출토된 금동관으로, 5～6세기 신라의 출자형 금관과는 달리 대륜에 나뭇가지 모양의 수목형 입식이 연결된 古拙한 관이다. 5～6세기 신라관의 계보 및 가야의 관을 이해하는 데 중요한 자료로 고고학적 가치가 크다.";
        main.text = "부산 복천동 출토 금동관";
        back.SetActive(true);
        IsRearn = false;
       // O_Dark = true; //사용자가 두번째부터 조사하면 망함 
        yield return null;
    }

}
