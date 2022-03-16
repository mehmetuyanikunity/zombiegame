using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class NormalAraba : ArabaZombi
{
    public NormalAraba(string _adi, float _hizi, decimal _gucu)
    {
        ArabaAdi = _adi;
        ArabaHizi = _hizi;
        ArabaGucu = _gucu;
    }

    public override void Turbo()
    {
        ArabaAnlikHiz = TurboluHiz;

        if (ArabaAnlikHiz > ArabaHizi * 0.5)
        {
            TurboluHiz += ArabaHizi * 2;
            Debug.Log("Turbo Aktif");
        }
    }

}
