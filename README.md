# G1 Loyalty MiniGame

Unity 2D WebGL mini-game pentru un sistem de loialitate.

## Cerințe

- Unity 6000.0.83f1
- Web Build Support
- Visual Studio 2022

## Rulare

1. Clonează repository-ul și deschide proiectul în Unity Hub.
2. Deschide scena `Assets/UnitY.unity`.
3. Apasă Play sau construiește proiectul pentru Web.

## Configurare local

Configurația este în:

`Assets/StreamingAssets/config.json`

Logo-ul este în:

`Assets/StreamingAssets/logo.png`

Pragul cupoanelor, culorile și logo-ul pot fi schimbate prin fișierul de configurare fără modificarea codului Unity.

## Funcționalitate

La finalul jocului:
- scorul este afișat;
- scorul este comparat cu pragurile din configurare;
- utilizatorul primește reducerea corespunzătoare;
- dacă există cupon, poate deschide pagina de revendicare;
- este generat un cod de cupon.