string s;          // la stringa in cui effettuare la ricerca
string inputChar;  // la stringa temporanea per leggere il carattere da tastiera
char c;            // il carattere effettivo da cercare
int indice;        // memorizzerà la posizione trovata (o -1 se non trovato)
int i;             // la variabile contatore/indice per scorrere la stringa
int lunghezza;     // memorizza la lunghezza totale della stringa

// lettura della stringa dall'utente
Console.WriteLine("Inserisci una stringa: ");
s = Console.ReadLine();

// lettura del carattere da cercare
Console.WriteLine("Inserisci il carattere da cercare: ");
inputChar = Console.ReadLine();
c = inputChar[0]; // estrae il primo carattere dalla stringa inserita

// inizializzazione delle variabili di controllo per la ricerca
indice = -1;       // di default impostiamo -1 (ipotizzando che il carattere non ci sia)
i = 0;             // partiamo dal primo carattere (indice 0)
lunghezza = s.Length; // ottiene il numero totale di caratteri della stringa

// while per scorrere la stringa carattere per carattere
while (i < lunghezza)
{
    // verifica se il carattere corrente nella stringa corrisponde a quello cercato
    if (s[i] == c)
    {
        indice = i;       // salva la posizione corrente
        i = lunghezza;    // termina il ciclo forzando la variabile i a raggiungere la lunghezza
    }

    i++; // passa al carattere successivo
}

// stampa il risultato finale a schermo
Console.WriteLine("Risultato: " + indice);

