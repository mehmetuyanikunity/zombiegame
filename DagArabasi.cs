using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DagArabasi : ArabaZombi
{
    public DagArabasi(string _adi, float _hizi, decimal _gucu)
    {
        ArabaAdi = _adi;
        ArabaHizi = _hizi;
        ArabaGucu = _gucu;
    }

    public override void Turbo()
    {
        ArabaAnlikHiz = TurboluHiz;

        if (ArabaAnlikHiz > ArabaHizi * 0.4)
        {
            TurboluHiz += ArabaHizi * 2;
            Debug.Log("Turbo Aktif");
        }
    }
}
