Questo progetto consiste nella realizzazione di un lettore MP3 con interfaccia grafica in C# utilizzando Windows Forms.
Il programma permette di:
- Riprodurre brani audio nei formati .mp3 e .wav.
- Gestire una playlist caricata da una cartella, visualizzarla in una ListBox e salvarla sul proprio PC.
- Ricercare e visualizzare i testi delle canzoni tramite un'API gratuita (Lyrics OVH).

Funzionalità principali:
- Riproduzione audio:
  Il lettore può riprodurre file audio e visualizzare il nome del brano selezionato.
- Caricamento Playlist:
  È possibile caricare i brani da una cartella specifica. Il programma carica solo i file audio validi (mp3, wav) e li mostra nella lista.
- Salvataggio Playlist:
  Permette di salvare i brani selezionati in una playlist che può essere ricaricata successivamente.
- Ricerca dei testi (Lyrics):
  Utilizza un'API gratuita (Lyrics OVH) per cercare i testi delle canzoni. I testi vengono visualizzati in una lista separata nella form.
- Cancellazione dei brani:
  Permette di cancellare i brani in coda (o in riproduzione) senza commettere errori.
- Uscita sicura:
  Prima di uscire dal programma, l'utente viene avvisato con un messaggio di conferma.

Struttura del programma:
Form1: Interfaccia principale, che contiene la lista dei brani e dei testi. Ha 5 pulsanti per caricare i file, caricare la playlist e salvarla, cercare i testi manualmente e cancellare i brani presenti in coda (o in riproduzione).
Form2: Una finestra di ricerca dove l'utente può inserire artista e titolo manualmente in caso il nome del file sia sbagliato e/o non rispetti i campi.

Conclusioni:
Il progetto che ho realizzato è un lettore mp3 e wav che supporta la riproduzione, il caricamento di playlist e la ricerca dei testi tramite un API, è semplice e versatile, permettendo il suo utilizzo su ogni dispositivo, riproducendo l’audio in background mentre si studia o si lavora.

Sorti Andrea 4IC
