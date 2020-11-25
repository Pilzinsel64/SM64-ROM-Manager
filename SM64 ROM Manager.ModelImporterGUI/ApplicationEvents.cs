
namespace SM64_ROM_Manager.ModelImporterGUI.My
{

    // Für MyApplication sind folgende Ereignisse verfügbar:
    // Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    // Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst.  Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung mit einem Fehler beendet wird.
    // UnhandledException: Wird bei einem Ausnahmefehler ausgelöst.
    // StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn die Anwendung bereits aktiv ist. 
    // NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.

    internal partial class MyApplication
    {
        private void OnAppStart(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
        {
            Publics.General.DoDefaultInitsBeforeApplicationStartup();
        }
    }
}