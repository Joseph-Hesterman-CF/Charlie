# 🦊 Charlie vs. Feature Creep

Charlie har precis committat dagens sista buggfix.

Alla tester är gröna. Pull requesten är mergad. Datorn ska precis stängas ner och Charlie börjar packa ihop sina saker för att äntligen gå till puben och ta en välförtjänt öl.

Men precis när han tar på sig jackan flyger dörren upp.

Produktägaren springer in.

> *"Vänta! Innan du går... jag har bara en sista liten sak."*

Charlie suckar och produktägaren fortsätter:

> *"Det är inte en feature. Jag lovar! Det är en liten förbättring."*

En förbättring blir två.  
Två blir tre.

Innan Charlie hinner protestera är vägen full av blockerare, sidospår och teknisk skuld. Vägen till puben, som nyss var enkel och rak, har förvandlats till en labyrint av Feature Creep.

Nu är det er tur att hjälpa Charlie.

Hitta den snabbaste framkomliga vägen genom kaoset och ge Charlie instruktionerna han behöver för att ta sig ur feature creep hell.

## Er uppgift

Nu behöver Charlie er hjälp.

Ni får en karta över skogen. På kartan finns en startpunkt, en pub och en mängd hinder.

Er uppgift är att hitta den enda framkomliga vägen från Charlie till puben och beskriva vägen med en sekvens av rörelseinstruktioner.

Charlie får endast röra sig en ruta åt gången och får bara använda följande instruktioner:

* `U` – upp
* `D` – ner
* `L` – vänster
* `R` – höger

### Exempel

En sekvens av instruktioner kan se ut så här:

```text
RRDDUL
```

## Målet

Hitta en väg från `A` till `Z` utan att gå genom blockerade rutor.

När ni har hittat vägen ska ni ge Charlie den kompletta sekvensen av instruktioner så att han kan ta sig hela vägen till puben.

## Förutsättningar

Innan ni bygger och kör projektet behöver ni ha .NET 10 installerat.
https://dotnet.microsoft.com/en-us/download/dotnet/10.0

## Regler

| Symbol | Betydelse |
|--------|-----------|
| `A` | Charlie (start) |
| `Z` | Puben (mål) |
| `.` | Framkomlig väg |
| `#` | Feature creep (blockerad väg) |

Charlie får inte gå genom `#` och får inte lämna kartan.

## Bedömning

- Fungerande lösning: 5 poäng
- Kreativitet: 0 – 5 poäng
- Samarbete: 0 – 5 poäng
- Hemlig bonus: 5 poäng
