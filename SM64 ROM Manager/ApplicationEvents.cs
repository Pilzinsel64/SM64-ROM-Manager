using System.Diagnostics;
using Microsoft.VisualBasic;
using SM64Lib.TextValueConverter;

namespace SM64_ROM_Manager.My
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
            TextValueConverter.WantIntegerValueMode += ee => ee.IntegerValueMode = SettingsManager.Settings.General.IntegerValueMode;
        }

        private void OnErrorMessage(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
        {
            if (!Debugger.IsAttached)
            {
                var exception = e.Exception.Demystify();
                var frm = new Form_ErrorDialog();
                frm.ErrorText = exception.Message + Constants.vbNewLine + Constants.vbNewLine + exception.StackTrace;
                frm.ShowDialog();
                e.ExitApplication = frm.ExitApplicaiton;
            }
        }
    }
}