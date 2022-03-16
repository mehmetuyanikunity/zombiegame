using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class DagArabasi : ArabaZombiBase
{
    public DagArabasi(string _adi, float _hizi, float _gucu)
    {
        ArabaAdi = _adi;
        ArabaHizi = _hizi;
        ArabaGucu = _gucu;
    }

    public override void Turbo()
    {
        if (ArabaHizi > ArabaHizi * 0.6)
        {
            Debug.Log("5 saniye turbo calisacak, 20 saniye sonra turbo dolacak.");
        }
    }
}
