using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArabaZombiBase
{
    public string ArabaAdi { get; set; }

    public float ArabaHizi { get; set; }

    public float ArabaGucu { get; set; } //Arabayla zombileri ezince, zombi g�c� kadar araban�n g�c� d��er.

    public string ZombiTuru { get; set; }

    public float ZombiHizi { get; set; }

    public float ZombiGucu { get; set; } //Araba g�c� < zombi g�c� = Game Over

    public string SilahTuru { get; set; }

    public float SilahHasari { get; set; }



    public virtual void Turbo()
    {
        if (ArabaHizi > ArabaHizi*0.5)
        {
            Debug.Log("5 saniye turbo �al��acak, 20 saniye sonra turbo dolacak.");
        }
    }

}
