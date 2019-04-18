## Integruotų programavimo aplinkų laboratorinis darbas
Atliko: Robertas Gaidis IIf-15
## Naudojimosi instrukcija
Norint paleisti projektą reikia paleisti "laboras.exe" failą, tolimesni žingsniai bus nurodyti punktais ekrane, o norint juos pasirinkti iveskite norima skaiciu kuri atitinka norima pasirinkti punkta ir spauskite klavisa ENTER. 
## "Realeasai"
### 0.1v
Vartotojas iveda studento informaciją (vardas, pavarde, namu darui ir egzamino pazymys). Pagal įvestus duomenis programa suskaičiuoja studento galutiniį balą pagal aprašytą formulę, galutinis balas gali būti skaiciuojamas pagal pazymiu vidurki arba mediana. Galutinio balo skaiciavimo metodas pasirenkamas switch/case pagalba. Galutinis balas su studento vardu ir pavarde isvedamas i ekrana. si uzduotis atlikta pasinaudojus tiek masyvais tiek list konteineriais. Taip pat prideta galimybe jog studento balai uz namu darbus ir egzamina butu generuojami atsitiktinai.
### 0.2v
Šioje versijoje programa papildyta tuo, kad galima būtų studento informaciją nuskaityti iš failo. Ir pagal nuskaitytus duomenis apskaičiuoti studento galutinį balą. Taip pat realizuotas studentų rušiavimas pagal vardus.
### 0.3v
Šioje dalyje atlikta nežymi kodo reorganizacija sukūrus tam tikras klases, nukėlus medianos skaičiavimą i atskirą klasę ir pan.. Taip pat pridėti exceptionai galimų klaidų valdymui, pvz kaip neegzistuojancio failo pasirinkimas.
### 0.4v
Šioje versijoje buvo pridėta klasė penkių failų su atsitiktiniais studentais bei atsitiktiniais pažymiais sukurimui. Kuriami penki txt failai kuriuose yra nuo 10 iki 100000 atsitiktinių studentų. Tuomet tie studentai yra surušiuojami pagal spėjamumą ir sukuriami dar du txt failai su surusiuotais studentais.
Atliktas programos spartos testavimas, parodoma per kiek laiko programa užtrunka apdoroti visus failus.
### 0.5v
Sioje versijoje testuojami skirtingi konteineriai (List, LinkedList, Queue), testams yra naudojamas 1000000 studentų failas, yra matuojamas failų nuskaitymas iš failo, įkėlimas i konteinerį ir išskaidymas i dvi grupes. Testo rezultatai:
- Programa užtruko: 22343ms su **listu**
- Programa užtruko: 200ms su **queue**
- Programa užtruko: 233ms su **linkedlistu**
Pagal atliktus testus matyti, jog programa greičiausiai veikė su queue konteineriu.
### 1.0v
Šioje versijoje, buvo testuojamas konteinerių efektyvumas,testai atliekami su 100000 studentų failu, čia buvo matuojamas studentų išskaidymas į grupes pasinaudojus dviem strategijom, pirmoje strategijoje, bendras studentų konteineris skaidomas į du naujus to paties tipo konteinerius ir į šiuos konteinerius iš pagrindinio keliami reikiami studentai.
Antroje strategijoje sukuriamas tik vienas konteineris į kurį atkeliave studentai yra ištrinami iš pagrindinio konteinerio.
Antrojoje strategijoje naudojant List konteinerį buvo atlikta optimizacija, kurioje visi studentai studentų konteineryje išrikiuojami pagal vidurkį ir jei vidurkis yra mažesnis 5 studentai perkeliami į vargsiukų konteinerį netrinant iškarto studentų po vieną, tada kai studentai perkeliami į vargšiukų konteinerį, visi studentai kurių vidurkis yra mažiau 5 ištrinami iš pagrindinio konteinerio iškarto, taip yra sutaupoma atminties, ir šis metodas yra greitesnis už antrą strategiją. 
Vieno testo rezultatai:
- Programa užtruko: 18ms su **list** (Strategija 1)
- Programa užtruko: 813ms su **list** (Strategija 2)
- Programa užtruko: 288ms su **list** (Strategija 2) ***optimizuota***
- Programa užtruko: 10ms su **queue** (Strategija 1)
- Programa užtruko: 19ms su **queue**(Strategija 2)
- Programa užtruko: 18ms su **linkedlist** (Strategija 1)
- Programa užtruko: 119342ms su **linkedlist** (Strategija 2)
