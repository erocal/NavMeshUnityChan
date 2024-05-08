using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainFunction : MonoBehaviour
{

    #region -- 資源參考區 --

    [Header("RectTransform")]
    [SerializeField] private RectTransform RectTransform_BtnTopView;
    [SerializeField] private RectTransform RectTransform_BtnCreateCharacter;
    [SerializeField] private RectTransform RectTransform_BtnRemoveCharacter;
    [SerializeField] private RectTransform RectTransform_BtnSwitchCamera;
    [SerializeField] private RectTransform RectTransform_BtnArrow;

    #endregion

    #region -- 變數參考區 --

    #endregion

    #region -- 初始化/運作 --

    private void Awake()
    {

    }

    private void Update()
    {

    }

    #endregion

    #region -- 方法參考區 --

    /// <summary>
    /// 移動在MainFunctionGroup除了BtnArrow以外的RectTransform至初始位置
    /// </summary>
    private void MoveBackMainFunctionGroup()
    {
        MoveRectTransformBtnTopView();
        MoveRectTransformBtnCreateCharacter();
        MoveRectTransformBtnRemoveCharacter();
        MoveRectTransformBtnSwitchCamera();
    }

    /// <summary>
    /// 移動RectTransform_BtnTopView
    /// </summary>
    private void MoveRectTransformBtnTopView()
    {

        if (RectTransform_BtnTopView.anchoredPosition.x == -660f)
        {
            RectTransform_BtnTopView.transform.DOLocalMoveX(0f, 1.5f).OnComplete(() => MoveRectTransformBtnCreateCharacter());
        }
        else RectTransform_BtnTopView.transform.DOLocalMoveX(-500f, 1f);

    }

    /// <summary>
    /// 移動RectTransform_BtnCreateCharacter
    /// </summary>
    private void MoveRectTransformBtnCreateCharacter()
    {

        if (RectTransform_BtnCreateCharacter.anchoredPosition.x == -660f)
        {
            RectTransform_BtnCreateCharacter.transform.DOLocalMoveX(0f, 1.2f).OnComplete(() => MoveRectTransformBtnRemoveCharacter());
        }
        else RectTransform_BtnCreateCharacter.transform.DOLocalMoveX(-500f, 1f);

    }

    /// <summary>
    /// 移動RectTransform_BtnRemoveCharacter
    /// </summary>
    private void MoveRectTransformBtnRemoveCharacter()
    {

        if (RectTransform_BtnRemoveCharacter.anchoredPosition.x == -660f)
        {
            RectTransform_BtnRemoveCharacter.transform.DOLocalMoveX(0f, 0.9f).OnComplete(() => MoveRectTransformBtnSwitchCamera());
        }
        else RectTransform_BtnRemoveCharacter.transform.DOLocalMoveX(-500f, 1f);

    }

    /// <summary>
    /// 移動RectTransform_BtnSwitchCamera
    /// </summary>
    private void MoveRectTransformBtnSwitchCamera()
    {

        if (RectTransform_BtnSwitchCamera.anchoredPosition.x == -660f)
        {
            RectTransform_BtnSwitchCamera.transform.DOLocalMoveX(0f, 0.6f).OnComplete(() => { 
                RectTransform_BtnArrow.GetComponent<Button>().interactable = true;
                RectTransform_BtnArrow.localScale = -Vector3.one;
            }); 
        }
        else RectTransform_BtnSwitchCamera.transform.DOLocalMoveX(-500f, 1f);

    }

    #region -- btn --

    public void OnArrow()
    {

        if (RectTransform_BtnArrow == null) return;

        Button BtnArrow = RectTransform_BtnArrow.GetComponent<Button>();

        if (RectTransform_BtnArrow.anchoredPosition.x == 50f)
        {
            BtnArrow.interactable = false;

            MoveRectTransformBtnTopView();

            RectTransform_BtnArrow.transform.DOLocalMoveX(400f, 1f);
        }
        else
        {
            BtnArrow.interactable = false;

            RectTransform_BtnArrow.transform.DOLocalMoveX(50f, 1f).OnComplete(() =>
            {
                BtnArrow.interactable = true;
                RectTransform_BtnArrow.localScale = Vector3.one;
            });

            MoveBackMainFunctionGroup();

        }

    }

    #endregion

    #endregion

}
