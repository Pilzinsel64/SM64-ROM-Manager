using global::System;
using global::System.ComponentModel;
using global::System.Diagnostics;

namespace SM64_ROM_Manager.Updating.Administration.GUI.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ApplicationVersionInput m_ApplicationVersionInput;

            public ApplicationVersionInput ApplicationVersionInput
            {
                [DebuggerHidden]
                get
                {
                    m_ApplicationVersionInput = MyForms.Create__Instance__(m_ApplicationVersionInput);
                    return m_ApplicationVersionInput;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_ApplicationVersionInput)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ApplicationVersionInput);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public PackageCreationDialog m_PackageCreationDialog;

            public PackageCreationDialog PackageCreationDialog
            {
                [DebuggerHidden]
                get
                {
                    m_PackageCreationDialog = MyForms.Create__Instance__(m_PackageCreationDialog);
                    return m_PackageCreationDialog;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_PackageCreationDialog)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_PackageCreationDialog);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UpdateManagerWindow m_UpdateManagerWindow;

            public UpdateManagerWindow UpdateManagerWindow
            {
                [DebuggerHidden]
                get
                {
                    m_UpdateManagerWindow = MyForms.Create__Instance__(m_UpdateManagerWindow);
                    return m_UpdateManagerWindow;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_UpdateManagerWindow)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UpdateManagerWindow);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ToolSelectionWindow m_ToolSelectionWindow;

            public ToolSelectionWindow ToolSelectionWindow
            {
                [DebuggerHidden]
                get
                {
                    m_ToolSelectionWindow = MyForms.Create__Instance__(m_ToolSelectionWindow);
                    return m_ToolSelectionWindow;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_ToolSelectionWindow)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ToolSelectionWindow);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public UpdateServerInfoEditor m_UpdateServerInfoEditor;

            public UpdateServerInfoEditor UpdateServerInfoEditor
            {
                [DebuggerHidden]
                get
                {
                    m_UpdateServerInfoEditor = MyForms.Create__Instance__(m_UpdateServerInfoEditor);
                    return m_UpdateServerInfoEditor;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_UpdateServerInfoEditor)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_UpdateServerInfoEditor);
                }
            }
        }
    }
}