using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SAE_Projekt_Auto
{
    public partial class Form1 : Form
    {   //Marvin
        public List<Wagen> AutolisteSpeichern = new List<Wagen>();
        public List<Wagen> AutolisteSuchen= new List<Wagen>();
        //Marvin

        //Daniel
        string startupPath = Environment.CurrentDirectory;                                                   //gibt den Pfad zur�ck, in dem die ausf�hrte Datei liegt
        string dateiName = "AutoDatenbank.csv";
        string dateiPfad;

        public Form1()
        {
            InitializeComponent();
            laden();
        }

        public void laden()
        {
            
            dateiPfad = Path.Combine(startupPath, dateiName);                                                

            if (!File.Exists(dateiPfad))
            {
                using (StreamWriter writer = File.CreateText(dateiPfad))                                     // Erstellen der Datei, falls sie nicht existiert
                {

                    writer.WriteLine("Marke,Modell,Kilometerstand,Baujahr,Preis");                           // Header der CSV Datei

                }

                rtbAusgabe.AppendText($"Die Datei '{dateiName}' wurde im Pfad '{startupPath}' erstellt.");   //Ausgabe in Textbox
            }
            else
            {
                rtbAusgabe.AppendText($"Die Datei '{dateiName}' existiert bereits im Pfad '{startupPath}'."); //Ausgabe in Textbox
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btSpeichern_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(tbMarke.Text) ||                                                     //if Abfrage ob Textboxen leer sind
                String.IsNullOrWhiteSpace(tbModell.Text) ||
                String.IsNullOrWhiteSpace(tbKilometerstand.Text) ||
                String.IsNullOrWhiteSpace(tbBaujahr.Text) ||
                String.IsNullOrWhiteSpace(tbPreis.Text))
            {
                rtbAusgabe.Text = "Es m�ssen alle Felder ausgef�llt sein, um Ihr Inserat zu speichern.";
            }
            else
            {
                string marke = tbMarke.Text;
                string modell = tbModell.Text;
                string kilometerstand = tbKilometerstand.Text;
                string baujahr = tbBaujahr.Text;
                string preis = tbPreis.Text;

                Wagen newAuto = new Wagen                                                                     //Erstellt neues Objekt nach Wagen typ in Klasse AutolisteSpeichern
                {
                    Marke = marke,
                    Modell = modell,
                    Kilometerstand = kilometerstand,
                    Baujahr = baujahr,
                    Preis = preis
                };
                AutolisteSpeichern.Add(newAuto);

                SchreibeInCSV(AutolisteSpeichern);
                AutolisteSpeichern.RemoveAt(AutolisteSpeichern.Count - 1);                                     //l�scht Objekt aus AutolisteSpeichern

                tbMarke.Clear();                                                                              //Cleart Textboxen
                tbModell.Clear();
                tbKilometerstand.Clear();
                tbBaujahr.Clear();
                tbPreis.Clear();
            }
        }

        private void SchreibeInCSV(List<Wagen> autolisteSpeichern)
        {
            rtbAusgabe.Clear();

            dateiPfad = Path.Combine(startupPath, dateiName);
         
            using (StreamWriter sw = new StreamWriter(dateiPfad,true))                                             // StreamWriter aufruf zur CSV-Datei
            {                           
                foreach (Wagen auto in autolisteSpeichern)                                                        //Durchl�uft jedes Objekt der liste AutolisteSpeichern
                {
                    sw.WriteLine($"{auto.Marke},{auto.Modell},{auto.Kilometerstand},{auto.Baujahr},{auto.Preis}"); //Autoinfos werden in CSV-Datei geschrieben
                }
            }

            rtbAusgabe.AppendText($"Daten wurden in die CSV-Datei geschrieben: '{dateiPfad}' ");                 //Ausgabe der Statusbox
        }

                //Daniel

                //Abdul
        private void btSuchen_Click(object sender, EventArgs e)
        {

            LadeAutoInformationen();                                                                         // Methode zum Lese der CSV-Datei 

            string marke = tbMarke.Text;                                                                     // Eingegebene Daten aus den Textboxen
            string modell = tbModell.Text;  
            string kilometerstand = tbKilometerstand.Text;
            string baujahr = tbBaujahr.Text;
            string preis = tbPreis.Text;
         
            var uebereinstimmungen = AutolisteSuchen.Where(autosuche =>                                      // Filter der eingegebenen Daten mit den Objekten aus der LadeAutoInformationen Liste
            {
                if (!string.IsNullOrWhiteSpace(marke) && !autosuche.Marke.Equals(marke, StringComparison.OrdinalIgnoreCase))
                    return false;

                if (!string.IsNullOrWhiteSpace(modell) && !autosuche.Modell.Equals(modell, StringComparison.OrdinalIgnoreCase))                  //Filtert Raus ob textboxen leer oder beschrieben sind, Ignoriert leere textboxen
                    return false;                                                                                                                //ignoriert case sensitive

                if (!string.IsNullOrWhiteSpace(kilometerstand) && !autosuche.Kilometerstand.Equals(kilometerstand, StringComparison.OrdinalIgnoreCase))
                    return false;

                if (!string.IsNullOrWhiteSpace(baujahr) && !autosuche.Baujahr.Equals(baujahr, StringComparison.OrdinalIgnoreCase))
                    return false;

                if (!string.IsNullOrWhiteSpace(preis) && !autosuche.Preis.Equals(preis, StringComparison.OrdinalIgnoreCase))
                    return false;

                return true; 
            }
            ).ToList();
                
            rtbHauptausgabe.Text = "";                                                                                                               // Gib die �bereinstimmungen in der Hauptausgabe aus
            foreach (var wagen in uebereinstimmungen)
            {
                rtbHauptausgabe.AppendText($"Marke: {wagen.Marke}, Modell: {wagen.Modell}, Kilometerstand: {wagen.Kilometerstand}km, Baujahr: {wagen.Baujahr}, Preis: {wagen.Preis}�\n");             
            }

            rtbAusgabe.Clear();
            rtbAusgabe.AppendText($"Suche nach: {marke} {modell} {kilometerstand} {baujahr} {preis}");
        }

        private void LadeAutoInformationen()
        {
            dateiPfad = Path.Combine(startupPath, dateiName);

            try
            {
                AutolisteSuchen.Clear();                                                              // Leere die Liste, um alte Daten zu entfernen
               
                using (StreamReader reader = new StreamReader(dateiPfad))                             // Lese die CSV-Datei Zeile f�r Zeile
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');                                             // Trennt ,
                    
                        Wagen wagen = new Wagen                                                       // Erstellt ein neues Objekt und f�llt es mit den Daten der CSV-Datei
                        {
                            Marke = parts[0],
                            Modell = parts[1],
                            Kilometerstand = parts[2],
                            Baujahr = parts[3],
                            Preis = parts[4]
                        };
                        AutolisteSuchen.Add(wagen);                                                    // F�gt das Objekt der Liste hinzu
                    }
                }
            }
            catch (Exception ex)
            {
                rtbAusgabe.AppendText($"Fehler beim Laden der Autoinformationen: {ex.Message}");    //Statusbox ausgabe
            }
        }
    }                //Abdul
}