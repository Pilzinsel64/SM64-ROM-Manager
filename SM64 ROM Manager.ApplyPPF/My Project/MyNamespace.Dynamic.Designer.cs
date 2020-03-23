using global::System;
using global::System.ComponentModel;
using global::System.Diagnostics;

namespace SM64_ROM_Manager.ApplyPPF.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ApplyPPFDialog m_ApplyPPFDialog;

            public ApplyPPFDialog ApplyPPFDialog
            {
                [DebuggerHidden]
                get
                {
                    m_ApplyPPFDialog = MyForms.Create__Instance__(m_ApplyPPFDialog);
                    return m_ApplyPPFDialog;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_ApplyPPFDialog)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ApplyPPFDialog);
                }
            }
        }
    }
}