# Retrospective

## 1. Configurarea inițială a proiectului

La început, unele setări și pași pentru Unity nu au fost corecte din prima. Am verificat rezultatul direct în Unity și am corectat configurația.

## 2. Pagina de revendicare

Pagina de revendicare nu a fost ascunsă corect la început. Am observat problema în interfața Unity și am corectat starea inițială a obiectului.

## 3. Referințele UI

ConfigLoader a produs un NullReferenceException deoarece unele referințe către elementele UI nu erau asignate. Console-ul Unity a ajutat la identificarea problemei.

## 4. Configurația pragurilor

Au fost necesare teste cu diferite valori de scor pentru a verifica dacă afișarea cuponului și butonul de revendicare funcționează corect.

## 5. Culorile din configurație

Aplicarea culorilor a necesitat verificarea referințelor UI și a configurației. Problema a fost găsită prin testare și corectată în Unity.

## 6. Web Build

Prima versiune Web a pornit scena SampleScene în locul scenei UnitY. Problema a fost identificată în browser și corectată în lista scenelor pentru build.

## 7. Testarea logo-ului

Am verificat schimbarea logo-ului prin modificarea fișierului extern și verificarea rezultatului în Unity și în Web Build.

## 8. Git

Inițial Git nu era instalat și a trebuit instalat și configurat. După aceea proiectul a fost inițializat ca repository și conectat la GitHub.

## 9. Autentificarea GitHub

La primul push, GitHub a cerut autentificare în browser. După autentificare, push-ul a fost finalizat cu succes.

## 10. Lecția principală

AI a fost util pentru ghidare și cod, dar soluțiile nu trebuie acceptate automat. Fiecare etapă importantă trebuie verificată în Unity, Console, browser și Git.