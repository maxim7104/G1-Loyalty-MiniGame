# AI Log

## Tool folosit

ChatGPT a fost folosit ca asistent pentru implementarea și integrarea proiectului Unity 2D WebGL.

## Promptul inițial

Am nevoie să construiesc partea mea dintr-un proiect Unity 2D WebGL pentru un loyalty mini-game. Partea mea este integrarea locală: ecran final cu scor și cupon, configurare externă pentru logo, culori și praguri și posibilitatea ca un local să schimbe configurația fără să modifice proiectul Unity.

## 3 prompturi importante

1. Explică-mi pas cu pas cum să fac în Unity un ecran final care afișează scorul și cuponul.
2. Ajută-mă să încarc configurația dintr-un fișier JSON extern în Unity.
3. Ajută-mă să configurez Git și GitHub pentru proiectul Unity.

## Unde AI a greșit sau a indus în eroare

1. La un moment dat pagina de revendicare nu era ascunsă corect. Problema a fost observată prin verificarea interfeței Unity și a fost corectată prin setarea stării inițiale a paginii.

2. ConfigLoader a produs un NullReferenceException deoarece unele referințe UI nu erau asignate. Problema a fost identificată în Console și referințele au fost completate în Inspector.

3. Prima versiune Web a pornit scena SampleScene în locul scenei UnitY. Problema a fost observată în browser și a fost corectată în Build Profiles / Scene List.

## Ce am scris manual

Am introdus și modificat manual fișierele de configurare JSON, am testat pragurile de cupoane și am verificat rezultatul în Unity și în browser.

Am configurat manual referințele UI din Inspector și am verificat schimbarea logo-ului și a culorilor din configurația externă.

## Ce aș face diferit

În primele 10 minute aș verifica mai devreme scena configurată pentru Web Build, referințele UI din Inspector și structura proiectului înainte de a începe testarea în browser.

## Lecția principală

AI a fost util pentru pașii tehnici, dar fiecare rezultat a fost verificat în Unity, Console și browser. Erorile au fost descoperite prin testare, nu presupuse ca fiind corecte doar pentru că soluția a fost sugerată de AI.