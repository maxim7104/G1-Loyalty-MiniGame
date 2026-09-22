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

## Ce am făcut manual fără AI

Am făcut manual configurarea obiectelor din Unity, am asignat elementele UI în Inspector, am verificat aspectul vizual al paginilor, am testat pragurile de scor și am verificat funcționarea build-ului WebGL în browser.

Aceste lucruri au fost făcute manual deoarece rezultatul trebuia verificat direct în Unity și în browser, iar AI nu poate confirma singur că interfața și build-ul se comportă corect în proiectul local.

## Ce aș face diferit în primele 10 minute

Dacă aș relua proiectul, în primele 10 minute aș verifica mai întâi structura scenei, Build Profiles și modul în care este încărcat config.json. Aș stabili de la început ce obiecte UI trebuie conectate în Inspector și aș face un test WebGL foarte devreme. De asemenea, aș stabili de la început structura documentației și a commit-urilor Git pentru a evita verificările și corectările de la final.