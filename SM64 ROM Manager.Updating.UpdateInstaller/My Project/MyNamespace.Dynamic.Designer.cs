using global::System;
using global::System.ComponentModel;
using global::System.Diagnostics;

namespace SM64_ROM_Manager.Updating.UpdateInstaller.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Main m_Main;

            public Main Main
            {
                [DebuggerHidden]
                get
                {
                    m_Main = MyForms.Create__Instance__(m_Main);
                    return m_Main;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Main)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Main);
                }
            }
        }
    }
}