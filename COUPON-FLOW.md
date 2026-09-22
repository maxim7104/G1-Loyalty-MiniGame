# Coupon Flow

La finalul jocului, scorul este comparat cu pragurile definite în config.

Dacă scorul nu atinge primul prag:
- este afișat mesajul „FĂRĂ CUPON”;
- butonul de revendicare nu este afișat.

Dacă scorul atinge un prag:
- este afișată reducerea câștigată;
- apare butonul „Revindecă cuponul”.

La apăsarea butonului:
1. pagina finală este ascunsă;
2. pagina de revendicare este afișată;
3. este generat un cod de cupon.

Pe pagina de revendicare există și un buton Back pentru revenirea la pagina finală.

Codul fluxului este implementat în `Assets/CouponUI.cs`.