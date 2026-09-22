# G1 Loyalty MiniGame

Unity 2D WebGL mini-game pentru un sistem de loialitate.

## Cerințe

- Unity 6000.0.83f1
- Web Build Support
- Visual Studio 2022

## Rulare

1. Clonează repository-ul:
   `git clone https://github.com/maxim7104/G1-Loyalty-MiniGame.git`
2. Deschide folderul proiectului în Unity Hub și așteaptă importul proiectului.
3. Deschide scena `Assets/UnitY.unity` și apasă Play.

## Configurare local

Configurația este în:

`Assets/StreamingAssets/config.json`

Logo-ul este în:

`Assets/StreamingAssets/logo.png`

Pragul cupoanelor, culorile și logo-ul pot fi schimbate prin fișierul de configurare fără modificarea codului Unity.

Exemplu de configurație:

```json
{
  "logo": "logo.png",
  "primaryColor": "#FF0000",
  "secondaryColor": "#FFFFFF",
  "couponThresholds": [
    { "score": 500, "coupon": "7%" },
    { "score": 1000, "coupon": "15%" },
    { "score": 2000, "coupon": "20%" }
  ]
}