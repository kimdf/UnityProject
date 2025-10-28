using TMPro;
using UnityEngine;

public enum NpcType //NPC ����
{
    elf,
    dwarf,
    human,
    guide
}

public class NpcInfo : MonoBehaviour
{
    [SerializeField] private NpcType type;

    NpcTalkData npcTalkData;
    UIManager uimanager;

    public TextMeshProUGUI NpcName;
    public TextMeshProUGUI NpcTalk;

    public string Name; // NPC�̸��� ���� �Է�

    bool guideTalking = false;

    int i = 0;

    private void Start()
    {
      //  npcTalkData = FindAnyObjectByType<NpcTalkData>();
        uimanager = FindAnyObjectByType<UIManager>();
    }

    //public void printText()
    //{
    //    int selet = Random.Range(0, 5); 
    //    switch (type)
    //    {
    //        case NpcType.elf:
    //            NpcTalk.text = npcTalkData.elflist[selet];
    //            break;
    //        case NpcType.dwarf:
    //            NpcTalk.text = npcTalkData.dwarflist[selet];
    //            break;
    //        case NpcType.human:
    //            NpcTalk.text = npcTalkData.humanlist[selet];
    //            break;
    //        case NpcType.guide:
    //            guideTalking = true;
    //            i = 0;
    //            break;
    //    }
    //}

    //private void Update()
    //{
    //    if (guideTalking)
    //    {
    //        NpcTalk.text = npcTalkData.guidelist[i];
    //        if (Input.GetKeyDown(KeyCode.Space) && i < 4)
    //        {
    //            NpcTalk.text = npcTalkData.guidelist[i];
    //            if (i < 3) i += 1;
    //        }
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") // �浹 �̺�Ʈ�� ���� �÷��̾�� ������ �۵�
        {
            //printText();
            //if (npcTalkData == null)
            //    NpcName.text = Name;
            //uimanager.SetOnNPCTalkUI(); // ��ȭ UI �ѱ�
        }
    }

    private void OnCollisionExit2D(Collision2D collision) // �浹���� ����� UI����
    {
       // uimanager.SetOffNPCTalkUI(); // ��ȭ UI ����
        if (guideTalking == true) guideTalking = false;
    }

    private class NpcTalkData
    {
    }
}