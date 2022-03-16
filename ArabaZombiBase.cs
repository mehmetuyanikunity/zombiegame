using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArabaZombi
{
    public string ArabaAdi { get; set; }

    public float ArabaHizi { get; set; }

    public float ArabaGucu { get; set; } //Arabayla zombileri ezince, zombi gucu kadar arabanýn gucu duser.

    public float ArabaAnlikHiz { get; set; }

    public string ZombiTuru { get; set; }

    public float ZombiHizi { get; set; }

    public float ZombiGucu { get; set; } //Araba gucu < zombi gucu = Game Over

    public string SilahTuru { get; set; }

    public float SilahHasari { get; set; }

    public float TurboluHiz { get; set; }



    public virtual void Turbo() //5 saniye suresince arabanin mevcut gucu %20 artar.
    {
        ArabaAnlikHiz = TurboluHiz;

        if (ArabaAnlikHiz > ArabaHizi/2)
        {
            TurboluHiz += ArabaHizi / 2;
            Debug.Log("5 saniye turbo calisacak, 20 saniye sonra turbo dolacak.");
        }
    }

}
