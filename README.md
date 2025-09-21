Dette projekt implementerer et simpelt adgangskontrol-program i C#.  
Formålet er at anvende **boolean logik** til at validere brugeroplysninger.

## Funktionalitet
Programmet spørger brugeren om:
- **Username**
- **Password**
- **User ID**

Adgang gives kun, hvis følgende regler er opfyldt:
- User ID > 65536 → brugeren er admin.
- Username skal være mindst 3 karakterer langt.
- Password skal indeholde mindst ét af tegnene `$`, `[`, `]`, `@`.
- Password skal være mindst 20 karakterer for admin, ellers 16 for standard user.

Hvis betingelserne ikke er opfyldt, udskrives fejlmeddelelser.
