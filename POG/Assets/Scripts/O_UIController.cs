using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O_UIController : MonoBehaviour //��ǰ
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

    public AudioSource Rain;
    public AudioSource BGM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //�̰� �ݴ� �ڵ�
        if (Input.GetKeyDown(KeyCode.Escape) && IsOpen == true)
        {
            Rain.Play();
            BGM.Stop();
            All.SetActive(false);
            IsOpen = false;
        }
        //�̰Ŵ� ���� �ڵ�
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

                if (puicon.obj.name == "E_Collider")
                {
                    StartCoroutine(E());
                }

                if (puicon.obj.name == "G _Collider")
                {
                    dis.text = "";
                    main.text = "AA";
                    back.SetActive(true);
                }
                
                if (puicon.obj.name == "F_Collider")
                {
                    dis.text = "";
                    main.text = "AA";
                    back.SetActive(true);
                }

            }
        }
    }
    //������ 
    public IEnumerator A()
    {
        IsRearn = true;
        yield return new WaitForSeconds(2f);
                            
        All.SetActive(true);    //��׶��� Ȱ��ȭ 
        IsOpen = true;  //�д���
        dis.text = "1985�⢦1986����� �����б� �ڹ����� �߱����翡�� ����� �����̴�. ���� 5���� �ݱͰ��̸� ��ǥ�ϴ� ��ǰ���μ�, �Ϻ��� ������ ��ģ ��� �ݼӰ����� ������ �˷��ִ� �߿��� ��ǰ�̴�.";
        main.text = "��õ ���� 28ȣ�� ���� �ݱͰ���";
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

        All.SetActive(true);    //��׶��� Ȱ��ȭ 
        IsOpen = true;  //�д���
        dis.text = "1980��1982�� �λ� ��õ�� 22ȣ�� �߱� �� ����� û������̴�. ���ƽþƿ����� ���ʸ� ã�� �� �� ���� ��Ư�� ���·� ���߽ô� �Ƿʿ� û�� ������ȭ�� ��ǥ�ϴ� ��ȭ��μ� �ǹ̰� ũ��.";
        main.text = "�λ� ��õ�� 22ȣ�� ���� û��ĥ�η�";
        back.SetActive(true);
        IsRearn = false;
        O_Second = true;
        yield break;
    }

    public IEnumerator C()
    {
        IsRearn = true;
        yield return new WaitForSeconds(2f);

        All.SetActive(true);    //��׶��� Ȱ��ȭ 
        IsOpen = true;  //�д���
        dis.text = "1992�� ���Ǵ��б��ڹ������� �߱� ���� �� �䱤��������� �߱��� �����̴�. ��ä�� �־� ���� ������ ������ Ȳ�� �� ���� ���� ��ä�ο� ������ ���� ǥ���� �Ų��ϰ� �ٵ��� ���� ���� �������� ��ġ�� �پ��.";
        main.text = "���� �絿�� ��270ȣ�� ���� �����";
        back.SetActive(true);
        IsRearn = false;
        //O_Dark = true;
        yield return null;
    }

    public IEnumerator E()
    {
        IsRearn = true;
        yield return new WaitForSeconds(2f);

        All.SetActive(true);    //��׶��� Ȱ��ȭ 
        IsOpen = true;  //�д���
        dis.text = "1980��1981����� �λ���б� �ڹ������� �߱��� ������ ���Ǻ����μ�, 5���� �� �λ꿡 �־��� ���� ������ ����� �ι��� �����̴�.";
        main.text = "11ȣ�� ���� ���� �ź���� ������ ��� �� �ܰ�ȣ";
        back.SetActive(true);
        IsRearn = false;
       // O_Dark = true; //����ڰ� �ι�°���� �����ϸ� ���� 
        yield return null;
    }

}
