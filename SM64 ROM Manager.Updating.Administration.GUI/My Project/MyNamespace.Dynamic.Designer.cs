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
            public EditorWindow m_EditorWindow;

            public EditorWindow EditorWindow
            {
                [DebuggerHidden]
                get
                {
                    m_EditorWindow = MyForms.Create__Instance__(m_EditorWindow);
                    return m_EditorWindow;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_EditorWindow)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_EditorWindow);
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
        }
    }
}