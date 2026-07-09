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

Hitta den **enda** framkomliga vägen genom kaoset och ge Charlie instruktionerna han behöver för att ta sig ur feature creep hell.

---

## Förutsättningar

Innan du bygger och kör projektet behöver du ha .NET 10 installerat.

## Regler

| Symbol | Betydelse |
|--------|-----------|
| `A` | Charlie (start) |
| `Z` | Puben (mål) |
| `.` | Framkomlig väg |
| `#` | Feature creep (blockerad väg) |

### Charlie får endast röra sig

| Kod | Rörelse |
|-----|---------|
| `U` | Upp |
| `D` | Ner |
| `L` | Vänster |
| `R` | Höger |

Exempel:

```text
RRDDUL
