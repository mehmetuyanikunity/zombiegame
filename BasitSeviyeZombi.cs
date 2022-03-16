using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class BasitSeviyeZombi : ArabaZombiBase
{
    public BasitSeviyeZombi(string _zombiTuru, float _zombiHizi, float _zombiGucu)
    {
        ZombiTuru = _zombiTuru;
        ZombiHizi = _zombiHizi;
        ZombiGucu = _zombiGucu;
    }
}
