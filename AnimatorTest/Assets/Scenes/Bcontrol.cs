using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bcontrol : MonoBehaviour
{
    private Animator _animator = default;

    private int Transf;
    private int Rot;
    private int Size;
    private int Color;
    private int ClickTrigger = -1;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        Transf = Animator.StringToHash("Transf");
        Rot = Animator.StringToHash("Rot");
        Size = Animator.StringToHash("Size");
        Color = Animator.StringToHash("Color");
        ClickTrigger = Animator.StringToHash("Buttom");
        
    }

    public void OnClick()
    {
        _animator.SetFloat(Color, Random.Range(0f, 1f));
        _animator.SetFloat(Rot, Random.Range(0f, 1f));
        _animator.SetFloat(Size, Random.Range(0f, 1f));
        _animator.SetFloat(Transf, Random.Range(0f, 1f));
        _animator.SetTrigger(ClickTrigger);
    }
}
