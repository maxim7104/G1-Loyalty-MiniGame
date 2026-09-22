# External Configuration

Jocul folosește un fișier JSON extern pentru configurarea localului.

Fișierul este:

`Assets/StreamingAssets/config.json`

Exemplu:

{
  "logo": "logo.png",
  "primaryColor": "#FF0000",
  "secondaryColor": "#FFFFFF",
  "couponThresholds": [
    {
      "score": 500,
      "coupon": "7%"
    },
    {
      "score": 1000,
      "coupon": "15%"
    },
    {
      "score": 2000,
      "coupon": "20%"
    }
  ]
}

## Ce poate fi modificat

- logo-ul;
- culoarea principală;
- culoarea secundară;
- pragurile de scor;
- valoarea reducerii.

Fișierul este încărcat la pornirea jocului.

Astfel, configurația unui local poate fi schimbată fără modificarea codului Unity.

Logo-ul folosit de configurație este:

`Assets/StreamingAssets/logo.png`