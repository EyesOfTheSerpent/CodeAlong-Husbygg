namespace CodeAlong_Husbygg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);
            RunCode();
        }

        private static void RunCode()
        {
            DecorateCMD();
            MainClass MC = new();
            MC.MainMenu();
        }

        private static void DecorateCMD()
        {
            Console.Title = "Sinnasnekkern 1.0";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /*
         * ---- Oppgave -----
         * Lag en app som kan bygge et hus. Et hus kan bestå av etasjer og rom. 
         * Brukeren skal kunne velge hva slags type rom den vil legge til om det er bad, kjøkken, soverom eller stue. 
         * Et hus er ikke ferdig før hver etasje består av nøyaktig 5 rom, 
         * og det kan ikke være flere enn 1 bad eller 1 kjøkken pr etasje. 
         * Når huset er ferdig, skal applikasjonen printe ut informasjon om hvilke rom huset består av.
         */

        /*
         * ----- Notater (Oppgave) -----
         * 5 etasjer
         * Maks 1 bad, maks 1 kjøkken
         * Når huset er ferdig (5 rom), skal det printes ut.
         */

        /*
         * ----- Notater (Konklusjon) -----
         * - Jeg kunne ha laget flere objekter som er de ulike rommene, og la dem alle arve fra Room.
         * - Derimot var det unødvendig med tanke på hva oppgaven ba om.
         * - I tillegg har logikken blitt fikset (inkludert noen ekstra features som kan være nyttig).
         * - Logikken bak hvordan man sjekket hvilket rom som ekisterte, 
         *   var skrevet på en måte som fikk den til å slå til uansett om det skulle kun være enten a eller b.
         * - Trenger kun tre ulike klasser. Ikke mer for hva oppgaven spurte etter.
         * - Kanskje litt unødvendig å skrive Description som private og ta den med metoder. Kunne ha gjort den 
         *   public isteden. Tok kun med tanke av innkapsling.
         */
    }
}
