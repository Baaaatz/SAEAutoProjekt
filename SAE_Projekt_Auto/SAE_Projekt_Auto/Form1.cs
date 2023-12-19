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
        public Form1()
        {
            InitializeComponent();
            laden();
        }

         

        public void laden()
        {
            string startupPath = Environment.CurrentDirectory;
            string dateiName = "AutoDatenbank.csv";
            string dateiPfad = Path.Combine(startupPath, dateiName);            //gibt den Pfad zurück, in dem die ausführbare Datei Anwendung liegt


            if (!File.Exists(dateiPfad))
            {

                using (StreamWriter writer = File.CreateText(dateiPfad))                 // Erstellen der Datei, falls sie nicht existiert
                {

                    writer.WriteLine("Marke,Modell,Kilometerstand,Baujahr,Preis");      // Header der CSV Datei

                }

                rtbAusgabe.AppendText($"Die Datei '{dateiName}' wurde im Pfad '{startupPath}' erstellt."); //Ausgabe in Textbox
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

            if (String.IsNullOrWhiteSpace(tbMarke.Text) ||              //if Abfrage ob Textboxen leer sind
                String.IsNullOrWhiteSpace(tbModell.Text) ||
                String.IsNullOrWhiteSpace(tbKilometerstand.Text) ||
                String.IsNullOrWhiteSpace(tbBaujahr.Text) ||
                String.IsNullOrWhiteSpace(tbPreis.Text))
            {
                rtbAusgabe.Text = "Es müssen alle Felder ausgefüllt sein, um Ihr Inserat zu speichern.";
            }
            else
            {
                string marke = tbMarke.Text;
                string modell = tbModell.Text;
                string kilometerstand = tbKilometerstand.Text;
                string baujahr = tbBaujahr.Text;
                string preis = tbPreis.Text;

                Wagen neuesAuto = new Wagen
                {
                    Marke = marke,
                    Modell = modell,
                    Kilometerstand = kilometerstand,
                    Baujahr = baujahr,
                    Preis = preis
                };
                AutolisteSpeichern.Add(neuesAuto);

                SchreibeInCSV(AutolisteSpeichern);
                AutolisteSpeichern.RemoveAt(AutolisteSpeichern.Count - 1);

                tbMarke.Clear();
                tbModell.Clear();
                tbKilometerstand.Clear();
                tbBaujahr.Clear();
                tbPreis.Clear();
            }
        }

        private void SchreibeInCSV(List<Wagen> autoliste)
        {
            rtbAusgabe.Clear();   

            string dateiPfad = "AutoDatenbank.csv";

            // StreamWriter verwenden, um die CSV-Datei zu erstellen oder zu öffnen
            using (StreamWriter sw = new StreamWriter(dateiPfad,true))
            {       

                // Daten jeder Zeile schreiben
                foreach (Wagen auto in autoliste)
                {
                    sw.WriteLine($"{auto.Marke},{auto.Modell},{auto.Kilometerstand},{auto.Baujahr},{auto.Preis}");
                }
            }

            rtbAusgabe.AppendText($"Daten wurden in die CSV-Datei geschrieben: '{dateiPfad}' ");
        }

                //Daniel

                //Abdul
        private void btSuchen_Click(object sender, EventArgs e)
        {

            LadeAutoInformationen();                                // Methode zum Lese der CSV-Datei und erstellt Wagen-Objekte

            string marke = tbMarke.Text;                                    // Eingegebene Daten aus den Textboxen
            string modell = tbModell.Text;
            string kilometerstand = tbKilometerstand.Text;
            string baujahr = tbBaujahr.Text;
            string preis = tbPreis.Text;
         
            var uebereinstimmungen = AutolisteSuchen.Where(autosuche =>             // Vergleiche die eingegebenen Daten mit den Wagen-Objekten aus der Liste
            {
                if (!string.IsNullOrWhiteSpace(marke) && !autosuche.Marke.Equals(marke, StringComparison.OrdinalIgnoreCase))
                    return false;

                if (!string.IsNullOrWhiteSpace(modell) && !autosuche.Modell.Equals(modell, StringComparison.OrdinalIgnoreCase))                  //Filtert Raus ob textboxen leer oder beschrieben sind, Ignoriert leere textboxen
                    return false;

                if (!string.IsNullOrWhiteSpace(kilometerstand) && !autosuche.Kilometerstand.Equals(kilometerstand, StringComparison.OrdinalIgnoreCase))
                    return false;

                if (!string.IsNullOrWhiteSpace(baujahr) && !autosuche.Baujahr.Equals(baujahr, StringComparison.OrdinalIgnoreCase))
                    return false;

                if (!string.IsNullOrWhiteSpace(preis) && !autosuche.Preis.Equals(preis, StringComparison.OrdinalIgnoreCase))
                    return false;

                return true; 
            }
            ).ToList();

            rtbHauptausgabe.Text = "";                                          // Gib die Übereinstimmungen in die Hauptausgabe-TextBox aus
            foreach (var wagen in uebereinstimmungen)
            {
                rtbHauptausgabe.AppendText($"Marke: {wagen.Marke}, Modell: {wagen.Modell}, Kilometerstand: {wagen.Kilometerstand}km, Baujahr: {wagen.Baujahr}, Preis: {wagen.Preis}€\n");
                
            }

            rtbAusgabe.Clear();
            rtbAusgabe.AppendText($"Suche nach: {marke} {modell} {kilometerstand} {baujahr} {preis}");
        }

        private void LadeAutoInformationen()
        {
            string dateiPfad = "AutoDatenbank.csv";

            try
            {
                AutolisteSuchen.Clear();                                                 // Leere die Liste, um alte Daten zu entfernen
               
                using (StreamReader reader = new StreamReader(dateiPfad))                   // Lese die CSV-Datei Zeile für Zeile
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');                           // Trennt ,
                    
                        Wagen wagen = new Wagen                                     // Erstelle ein neues Wagen-Objekt und fülle es mit den Daten aus der CSV-Datei
                        {
                            Marke = parts[0],
                            Modell = parts[1],
                            Kilometerstand = parts[2],
                            Baujahr = parts[3],
                            Preis = parts[4]
                        };

                        AutolisteSuchen.Add(wagen);                             // Füge das Wagen-Objekt zur Liste hinzu
                    }
                }
            }
            catch (Exception ex)
            {
                rtbAusgabe.AppendText($"Fehler beim Laden der Autoinformationen: {ex.Message}");
            }
        }
    }                //Abdul
}