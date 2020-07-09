using global::System;
using global::System.ComponentModel;
using global::System.Diagnostics;

namespace SM64_ROM_Manager.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public AddressListEditor m_AddressListEditor;

            public AddressListEditor AddressListEditor
            {
                [DebuggerHidden]
                get
                {
                    m_AddressListEditor = MyForms.Create__Instance__(m_AddressListEditor);
                    return m_AddressListEditor;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_AddressListEditor)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AddressListEditor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ApplyStyleMgrStyle m_ApplyStyleMgrStyle;

            public ApplyStyleMgrStyle ApplyStyleMgrStyle
            {
                [DebuggerHidden]
                get
                {
                    m_ApplyStyleMgrStyle = MyForms.Create__Instance__(m_ApplyStyleMgrStyle);
                    return m_ApplyStyleMgrStyle;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_ApplyStyleMgrStyle)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ApplyStyleMgrStyle);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_About m_Form_About;

            public Form_About Form_About
            {
                [DebuggerHidden]
                get
                {
                    m_Form_About = MyForms.Create__Instance__(m_Form_About);
                    return m_Form_About;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Form_About)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_About);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_ErrorDialog m_Form_ErrorDialog;

            public Form_ErrorDialog Form_ErrorDialog
            {
                [DebuggerHidden]
                get
                {
                    m_Form_ErrorDialog = MyForms.Create__Instance__(m_Form_ErrorDialog);
                    return m_Form_ErrorDialog;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Form_ErrorDialog)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_ErrorDialog);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_Settings m_Form_Settings;

            public Form_Settings Form_Settings
            {
                [DebuggerHidden]
                get
                {
                    m_Form_Settings = MyForms.Create__Instance__(m_Form_Settings);
                    return m_Form_Settings;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Form_Settings)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_Settings);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_SetUpRGBA m_Form_SetUpRGBA;

            public Form_SetUpRGBA Form_SetUpRGBA
            {
                [DebuggerHidden]
                get
                {
                    m_Form_SetUpRGBA = MyForms.Create__Instance__(m_Form_SetUpRGBA);
                    return m_Form_SetUpRGBA;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Form_SetUpRGBA)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_SetUpRGBA);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_SM64TextConverter m_Form_SM64TextConverter;

            public Form_SM64TextConverter Form_SM64TextConverter
            {
                [DebuggerHidden]
                get
                {
                    m_Form_SM64TextConverter = MyForms.Create__Instance__(m_Form_SM64TextConverter);
                    return m_Form_SM64TextConverter;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Form_SM64TextConverter)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_SM64TextConverter);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Form_Stylemanager m_Form_Stylemanager;

            public Form_Stylemanager Form_Stylemanager
            {
                [DebuggerHidden]
                get
                {
                    m_Form_Stylemanager = MyForms.Create__Instance__(m_Form_Stylemanager);
                    return m_Form_Stylemanager;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Form_Stylemanager)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Form_Stylemanager);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LevelEditorInputManager m_LevelEditorInputManager;

            public LevelEditorInputManager LevelEditorInputManager
            {
                [DebuggerHidden]
                get
                {
                    m_LevelEditorInputManager = MyForms.Create__Instance__(m_LevelEditorInputManager);
                    return m_LevelEditorInputManager;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_LevelEditorInputManager)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_LevelEditorInputManager);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MainForm m_MainForm;

            public MainForm MainForm
            {
                [DebuggerHidden]
                get
                {
                    m_MainForm = MyForms.Create__Instance__(m_MainForm);
                    return m_MainForm;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_MainForm)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MainForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public PluginInstallerForm m_PluginInstallerForm;

            public PluginInstallerForm PluginInstallerForm
            {
                [DebuggerHidden]
                get
                {
                    m_PluginInstallerForm = MyForms.Create__Instance__(m_PluginInstallerForm);
                    return m_PluginInstallerForm;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_PluginInstallerForm)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_PluginInstallerForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public RGBEditInfoEditor m_RGBEditInfoEditor;

            public RGBEditInfoEditor RGBEditInfoEditor
            {
                [DebuggerHidden]
                get
                {
                    m_RGBEditInfoEditor = MyForms.Create__Instance__(m_RGBEditInfoEditor);
                    return m_RGBEditInfoEditor;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_RGBEditInfoEditor)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_RGBEditInfoEditor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public TextProfileEditor m_TextProfileEditor;

            public TextProfileEditor TextProfileEditor
            {
                [DebuggerHidden]
                get
                {
                    m_TextProfileEditor = MyForms.Create__Instance__(m_TextProfileEditor);
                    return m_TextProfileEditor;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_TextProfileEditor)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TextProfileEditor);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ValueInputDialog m_ValueInputDialog;

            public ValueInputDialog ValueInputDialog
            {
                [DebuggerHidden]
                get
                {
                    m_ValueInputDialog = MyForms.Create__Instance__(m_ValueInputDialog);
                    return m_ValueInputDialog;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_ValueInputDialog)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ValueInputDialog);
                }
            }
        }
    }
}