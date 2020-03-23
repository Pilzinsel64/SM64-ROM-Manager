using global::System;
using global::System.ComponentModel;
using global::System.Diagnostics;

namespace SM64_ROM_Manager.ModelImporterGUI.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public InfoEditor m_InfoEditor;

            public InfoEditor InfoEditor
            {
                [DebuggerHidden]
                get
                {
                    m_InfoEditor = MyForms.Create__Instance__(m_InfoEditor);
                    return m_InfoEditor;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_InfoEditor)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_InfoEditor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ModelImporter m_ModelImporter;

            public ModelImporter ModelImporter
            {
                [DebuggerHidden]
                get
                {
                    m_ModelImporter = MyForms.Create__Instance__(m_ModelImporter);
                    return m_ModelImporter;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_ModelImporter)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ModelImporter);
                }
            }
        }
    }
}