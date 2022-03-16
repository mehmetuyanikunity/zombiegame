using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainArabaZombi : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void ArabaOlustur()
    {
        NormalAraba _normalAraba = new NormalAraba("Normal Araba", 100f, 500m);
        _normalAraba.Turbo();
        YarisArabasi _yarisArabasi = new YarisArabasi("Yar�� Arabas�", 160f, 800m);
        _yarisArabasi.Turbo();
        DagArabasi _dagArabasi = new DagArabasi("Da� Arabas�", 80f, 1000m);
        _dagArabasi.Turbo();

    }

    void SilahOlustur()
    {
        TekTekSikanSilah _tekTekSikanSilah = new TekTekSikanSilah("Tek Tek S�kan Silah", 10);
        TaramaliSikanSilah _taramaliSikanSilah = new TaramaliSikanSilah("Taramal� S�kan silah", 20);
        BombaAtanSilah _bombaAtanSilah = new BombaAtanSilah("Bomba Atan Silah", 100);
    }

    void ZombiOlustur()
    {
        BasitSeviyeZombi _basitSeviyeZombi = new BasitSeviyeZombi("Basit Seviye Zombi", 20, 10);
        OrtaSeviyeZombi _ortaSeviyeZombi = new OrtaSeviyeZombi("Orta Seviye Zombi", 30, 20);
        IleriSeviyeZombi _ileriSeviyeZombi = new IleriSeviyeZombi("�leri Seviye Zombi", 50, 40);
    }

}
