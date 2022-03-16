using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YarisArabasi : ArabaZombi
{
    public YarisArabasi(string _adi, float _hizi, decimal _gucu)
    {
        ArabaAdi = _adi;
        ArabaHizi = _hizi;
        ArabaGucu = _gucu;
    }

    public override void Turbo()
    {
        ArabaAnlikHiz = TurboluHiz;

        if (ArabaAnlikHiz > ArabaHizi * 0.6)
        {
            TurboluHiz += ArabaHizi * 2;
            Debug.Log("Turbo Aktif");
        }
    }
}
