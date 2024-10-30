using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using UnityEditor;
using System;

public class MainController : MonoBehaviour
{
    List<string> Main_List = new List<string>();
    List<string> Side_List = new List<string>();
    List<string> Soup_List = new List<string>();

    List<string> Main_List_Master = new List<string>();
    List<string> Side_List_Master = new List<string>();

    public TextMeshProUGUI Main_TMPro;
    public TextMeshProUGUI Side_TMPro;
    public TextMeshProUGUI Soup_TMPro;

    DateTime Date = DateTime.Now;

    // Start is called before the first frame update
    void Start()
    {
        Init();

        //if (Date.Day.ToString() == "1")
        //{
        //    Init();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        DateTime TodayNow = DateTime.Now;
    }

    public void Button()
    {
        Debug.Log("Clicked!");
        Main_TMPro.text = Main_List[UnityEngine.Random.Range(0, Main_List.Count)];
        Main_List_Master.Add(Main_TMPro.text);
        Main_List.Remove(Main_TMPro.text);
        //Debug.Log(Main_List_M[Main_List_M.Count - 1]);

        Side_TMPro.text = Side_List[UnityEngine.Random.Range(0, Side_List.Count)];
        Side_List_Master.Add(Side_TMPro.text);
        Side_List.Remove(Side_TMPro.text);

        Soup_TMPro.text = Soup_List[UnityEngine.Random.Range(0, Soup_List.Count)];
    }
    
    
    public void Init()
    {
        string[] Main = { "�`���[�n��", "���炷��", "�V�Ô�", "�J���[", "�e�q��", "�I�����C�X", "�O�F��",
            "�I�����c", "�h���C�J���[", "�h���A", "�a���p�X�^", "�{�̉��������Ă�", "�{�̏Ƃ�Ă�", "���g��",
            "�n���o�[�O", "�`���W���I���[�X", "�g���e�L", "�Ƃ񂩂�", "�؂̐��I�Ă�", "�����̓ؓ�����","�L�̃��j�G��",
            "�I�̉��Ă�", "�T���}�̉��Ă�", "�Ԃ�卪", "�Ԃ�̏Ƃ�Ă�", "����u��", "�����","���D�ݏĂ�",
            "�|�[�N�r�[���Y", "�V�`���[", "���k����", "�����Ă�", "�������݂���", "���̉��Ă�" ,};
        Main_List.AddRange(Main);

        string[] Side = { "��z" , "������", "�ق���񑐂̌Ӗ��a��", "�Ђ����̎ϕ�", "�t�J�T���_","������̌Ӗ��a��", "�����X�e�[�L",
            "�ɂ񂶂񂵂肵��", "������̈�ӏĂ�", "�}�J���j�T���_","�|�e�g�T���_", "�ق���񑐂̂��Ђ���", "���Ⴊ�����K���b�g", "���܂����̊Ðh��",
            "�g���o������", "�܂������̂��炠��", "���ӂ�����", "�g�}�g�ƃI�N���̗��`", "���ł�", "�L�q", "���[���L���x�c",
            "����������", "�h���g", "�`�[�Y������̈�ӗg��", "���_���L���x�c", "�ɂ񂶂�̃c�i�Ӗ��a��", "���₵�̗��Ƃ�",
            "������̂��܉��Ђ�", "�����|�e�g�T���_", "�ق���񑐂̐���" };
        Side_List.AddRange(Side);

        string[] Soup = { "�؏`","�킩�߃X�[�v","���X�`",
            "���܃X�[�v","�J�j�J�}�X�[�v","���؃X�[�v",
            "���܂��X�[�v" };
        Soup_List.AddRange(Soup);
       
    }
}

