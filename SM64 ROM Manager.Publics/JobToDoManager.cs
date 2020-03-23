using System;
using global::System.IO;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.SettingsManager;

namespace SM64_ROM_Manager.Publics
{
    public static class JobToDoManager
    {
        internal static void ExecuteStartupJobsToDo()
        {
            ExecuteJobsToDo(JobToDoUrgency.OnNextStartup);
        }

        internal static void ExecuteExitJobsToDo()
        {
            ExecuteJobsToDo(JobToDoUrgency.OnNextExit);
        }

        private static void ExecuteJobsToDo(JobToDoUrgency urgency)
        {
            foreach (JobToDo job in Settings.JobsToDo.ToArray())
            {
                if ((job.Urgency & urgency) == urgency)
                {
                    var switchExpr = job.Type;
                    switch (switchExpr)
                    {
                        case JobToDoType.DeleteDirectory:
                            {
                                Job_RemoveDirectory(job);
                                break;
                            }

                        case JobToDoType.DeleteFile:
                            {
                                Job_RemoveFile(job);
                                break;
                            }
                    }

                    Settings.JobsToDo.Remove(job);
                }
            }
        }

        private static void Job_RemoveFile(JobToDo job)
        {
            try
            {
                File.Delete(Conversions.ToString(job.Params[0]));
            }
            catch (Exception)
            {
            }
        }

        private static void Job_RemoveDirectory(JobToDo job)
        {
            try
            {
                Directory.Delete(Conversions.ToString(job.Params[0]), Conversions.ToBoolean(job.Params[1]));
            }
            catch (Exception)
            {
            }
        }
    }
}