# Unityn käyttöliittymä ja peliasetukset

Näissä harjoituksissa toteutat 2 yksinkertaista käyttöliittymää Unity 3D-projekteihin ja harjoittelet asetusten tallentamista paikallisesti sekä pilvipalveluun.

## Tehtävä 1

Toteuta alla näkyvän mukainen käyttöliittymä SampleSceneen. Käytä tässä kansion **Task1_PlayerPrefs** Unity-projektia. Käyttöliittymään on lisätty Canvas, Text ja Button. Kun **Buttonia** klikataan, kasvaa **score** muuttujan arvo ja se esitetään **Text**-näkymässä kuten kuvassa esitetty. Tämän lisäksi toteuta toiminto, joka tallentaa scoren myös paikallisesti tietokoneelle niin että kun peli käynnistetään uudelleen, score jatkaa siitä mihin se edellisellä kerralla jäi. Käytä tässä Unityn PlayerPrefs-luokkaa https://docs.unity3d.com/ScriptReference/PlayerPrefs.html

![Task1](/Img/1.PNG?raw=true) 

Kun tehtävä on valmis, tee **git commit** ja **push origin**. Laita kommentiksi **commitin** yhteyteen esim. "Tehtävä 1 suoritettu".

## Tehtävä 2

Käytä tässä tehtävässä kansion **Task2_UnityAnalytics_RemoteConfig** Unity-projektia. Tässä tehtävässä toiminto on täsmälleen sama kuin edellisessä tehtävässä, mutta sen sijaan että käyttäisit **PlayerPrefs**-luokkaa tallentamaan **Score**-muuttujan sisällön, luetkin scoren pelin käynnistyessä Unityn Analytics Servicen kautta sen tarjoamaan **Remote Settings**-toiminnon avulla: https://docs.unity3d.com/Manual/UnityAnalyticsRemoteSettings.html

Löydät Remote Settingsin käyttöön täältä hyvät ohjeet: https://docs.unity3d.com/Manual/UnityAnalyticsRemoteSettingsCreating.html

Luo ensin siis Analytics-palvelun kautta esim. **scoreCloud**-niminen arvo ja lataa se Unityn Remote Config näkymässä.

![Task2](/Img/2.PNG?raw=true) 

![Task2](/Img/3.PNG?raw=true) 

Kun olet saanut edellisen tehtyä, toteuta peliin koodi joka lukee kyseisen scoreCloud arvon aina näkyvillä olevaan Text-kenttään.

Kun tehtävä on valmis, tee **git commit** ja **push origin**. Laita kommentiksi **commitin** yhteyteen esim. "Tehtävä 2 suoritettu".
