using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UICasesScreen : MonoBehaviour
{
    [SerializeField] private Button leftBtn;
    [SerializeField] private Button rightBtn;
    public int indexCaseCurrent;
    public string nameCaseCurrent;
    public string difficulteCaseCurrent;
    [SerializeField] private TextMeshProUGUI descTxt;
    [SerializeField] private TextMeshProUGUI nameTxt;
    [SerializeField] private TextMeshProUGUI difficulteTxt;



    private void Start()
    {
        leftBtn.onClick.AddListener(()=>{
            indexCaseCurrent -= 1;
            if (indexCaseCurrent == -1)
            {
                indexCaseCurrent = CasesManeger.instanse.cases.Length -1;
            }
            descTxt.text = CasesManeger.instanse.cases[indexCaseCurrent].descriptionCase;
            nameTxt.text = CasesManeger.instanse.cases[indexCaseCurrent].nameCase;
            difficulteTxt.text = CasesManeger.instanse.cases[indexCaseCurrent].difficulteCase;
            print("Влево");
        });
        rightBtn.onClick.AddListener(() => {
            indexCaseCurrent += 1;
            if (indexCaseCurrent == CasesManeger.instanse.cases.Length)
            {
                indexCaseCurrent = 0;
            }
            descTxt.text = CasesManeger.instanse.cases[indexCaseCurrent].descriptionCase;
            nameTxt.text = CasesManeger.instanse.cases[indexCaseCurrent].nameCase;
            difficulteTxt.text = CasesManeger.instanse.cases[indexCaseCurrent].difficulteCase;
            print("Вправо");
        });
    }
}