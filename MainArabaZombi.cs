using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainArabaZombi : MonoBehaviour
{
    
    void Start()
    {
        ArabaOlustur();
    }

    
    void Update()
    {
        
    }

    void ArabaOlustur()
    {
        NormalAraba _normalAraba = new NormalAraba("Normal Araba", 100f, 500f);
        _normalAraba.Turbo();
        YarisArabasi _yarisArabasi = new YarisArabasi("Yarýþ Arabasý", 160f, 800f);
        DagArabasi _dagArabasi = new DagArabasi("Dað Arabasý", 80f, 1000f);

    }

    void SilahOlustur()
    {
        TekTekSikanSilah _tekTekSikanSilah = new TekTekSikanSilah("Tek Tek Sýkan Silah", 10);
        TaramaliSikanSilah _taramaliSikanSilah = new TaramaliSikanSilah("Taramalý Sýkan silah", 20);
        BombaAtanSilah _bombaAtanSilah = new BombaAtanSilah("Bomba Atan Silah", 100);
    }

    void ZombiOlustur()
    {
        BasitSeviyeZombi _basitSeviyeZombi = new BasitSeviyeZombi("Basit Seviye Zombi", 20, 10);
        OrtaSeviyeZombi _ortaSeviyeZombi = new OrtaSeviyeZombi("Orta Seviye Zombi", 30, 20);
        IleriSeviyeZombi _ileriSeviyeZombi = new IleriSeviyeZombi("Ýleri Seviye Zombi", 50, 40);
    }

}
