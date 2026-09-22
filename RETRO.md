# Retrospective

1. AI-ul a presupus inițial că pagina de revendicare era ascunsă corect, dar în Unity am observat că ambele pagini puteau fi vizibile.

2. AI-ul a sugerat configurarea unor referințe UI fără să verifice toate legăturile din Inspector, ceea ce a dus la un NullReferenceException în ConfigLoader.

3. AI-ul nu a anticipat că prima versiune WebGL va porni SampleScene în loc de scena UnitY, iar problema a fost descoperită prin testarea în browser.

4. AI-ul a oferit inițial soluții pentru culori care nu se potriveau complet cu modul în care ConfigLoader aplica culorile din configurația externă.

5. AI-ul a presupus în anumite momente că o modificare vizuală era suficientă fără verificarea imediată în Unity, dar rezultatul final a trebuit verificat manual.

6. AI-ul a trebuit corectat în privința formatului codului de cupon, deoarece prima versiune folosea doar cifre și era prea scurtă.

7. AI-ul a recomandat verificarea și testarea repetată a pragurilor de scor deoarece logica trebuia confirmată cu valori reale în Unity.

8. AI-ul a trebuit să verifice modificările generate automat de Unity după WebGL Build, deoarece unele fișiere TMP au fost schimbate automat.

9. AI-ul a sugerat inițial că modificările Git după build pot fi tratate direct, dar a fost necesară verificarea diff-ului înainte de commit.

10. Dacă aș relua proiectul, aș verifica mai devreme scena de build, configurația externă și integrarea WebGL și aș face teste scurte după fiecare etapă importantă.