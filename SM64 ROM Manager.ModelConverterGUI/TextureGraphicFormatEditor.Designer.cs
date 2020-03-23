using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SM64_ROM_Manager.ModelConverterGUI
{
    [DesignerGenerated()]
    public partial class TextureGraphicFormatEditor : DevComponents.DotNetBar.OfficeForm
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureGraphicFormatEditor));
            _ListViewEx1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            _ListViewEx1.SelectedIndexChanged += new EventHandler(ListBoxAdv_CI_Textures_ItemClick);
            _LabelX48 = new DevComponents.DotNetBar.LabelX();
            _PictureBox1 = new System.Windows.Forms.PictureBox();
            _Button_SaveColsettings = new DevComponents.DotNetBar.ButtonX();
            _ComboBox_ColType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBox_ColType.SelectedIndexChanged += new EventHandler(ComboBox_CI_ColType_SelectedIndexChanged);
            _LabelX_CollisionType = new DevComponents.DotNetBar.LabelX();
            _LabelX_MaxPixels = new DevComponents.DotNetBar.LabelX();
            _LabelX1 = new DevComponents.DotNetBar.LabelX();
            _CheckBoxX_EnableTextureAnimation = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_EnableTextureAnimation.CheckedChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _ComboBoxEx_SelectDisplaylist = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_SelectDisplaylist.SelectedIndexChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _LabelX2 = new DevComponents.DotNetBar.LabelX();
            _CheckBoxX_EnableMirrorS = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_EnableMirrorS.CheckedChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _CheckBoxX_EnableClampS = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_EnableClampS.CheckedChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _CheckBoxX_EnableCrystalEffect = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_EnableCrystalEffect.CheckedChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _LabelX3 = new DevComponents.DotNetBar.LabelX();
            _ComboBoxEx_RotateFlip = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            _ComboBoxEx_RotateFlip.SelectedIndexChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _CheckBoxX_EnableClampT = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_EnableClampT.CheckedChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _CheckBoxX_EnableMirrorT = new DevComponents.DotNetBar.Controls.CheckBoxX();
            _CheckBoxX_EnableMirrorT.CheckedChanged += new EventHandler(ButtonItem_IsScollTex_Click);
            _LabelX4 = new DevComponents.DotNetBar.LabelX();
            _LabelX5 = new DevComponents.DotNetBar.LabelX();
            _LabelX6 = new DevComponents.DotNetBar.LabelX();
            _LabelX7 = new DevComponents.DotNetBar.LabelX();
            _Panel1 = new System.Windows.Forms.Panel();
            _ContextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            _ButtonItem_CM_SelDL = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_EditCustomDisplaylists = new DevComponents.DotNetBar.ButtonItem();
            _ButtonItem_EditCustomDisplaylists.Click += new EventHandler(ButtonItem_EditCustomDisplaylists_Click);
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).BeginInit();
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).BeginInit();
            SuspendLayout();
            // 
            // ListViewEx1
            // 
            resources.ApplyResources(_ListViewEx1, "ListViewEx1");
            _ListViewEx1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            _ListViewEx1.Border.Class = "ListViewBorder";
            _ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty;
            _ListViewEx1.FocusCuesEnabled = false;
            _ListViewEx1.ForeColor = System.Drawing.Color.Black;
            _ListViewEx1.FullRowSelect = true;
            _ListViewEx1.HideSelection = false;
            _ListViewEx1.Name = "ListViewEx1";
            _ListViewEx1.UseCompatibleStateImageBehavior = false;
            // 
            // LabelX48
            // 
            // 
            // 
            // 
            _LabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(_LabelX48, "LabelX48");
            _LabelX48.Name = "LabelX48";
            _LabelX48.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // PictureBox1
            // 
            resources.ApplyResources(_PictureBox1, "PictureBox1");
            _PictureBox1.Name = "PictureBox1";
            _PictureBox1.TabStop = false;
            // 
            // Button_SaveColsettings
            // 
            _Button_SaveColsettings.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(_Button_SaveColsettings, "Button_SaveColsettings");
            _Button_SaveColsettings.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            _Button_SaveColsettings.DialogResult = System.Windows.Forms.DialogResult.OK;
            _Button_SaveColsettings.FocusCuesEnabled = false;
            _Button_SaveColsettings.Name = "Button_SaveColsettings";
            _Button_SaveColsettings.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBox_ColType
            // 
            resources.ApplyResources(_ComboBox_ColType, "ComboBox_ColType");
            _ComboBox_ColType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBox_ColType.DropDownHeight = 150;
            _ComboBox_ColType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _ComboBox_ColType.ForeColor = System.Drawing.Color.Black;
            _ComboBox_ColType.FormattingEnabled = true;
            _ComboBox_ColType.Name = "ComboBox_ColType";
            _ComboBox_ColType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX_CollisionType
            // 
            resources.ApplyResources(_LabelX_CollisionType, "LabelX_CollisionType");
            // 
            // 
            // 
            _LabelX_CollisionType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_CollisionType.Name = "LabelX_CollisionType";
            _LabelX_CollisionType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX_MaxPixels
            // 
            resources.ApplyResources(_LabelX_MaxPixels, "LabelX_MaxPixels");
            // 
            // 
            // 
            _LabelX_MaxPixels.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX_MaxPixels.Name = "LabelX_MaxPixels";
            // 
            // LabelX1
            // 
            resources.ApplyResources(_LabelX1, "LabelX1");
            // 
            // 
            // 
            _LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX1.Name = "LabelX1";
            // 
            // CheckBoxX_EnableTextureAnimation
            // 
            resources.ApplyResources(_CheckBoxX_EnableTextureAnimation, "CheckBoxX_EnableTextureAnimation");
            // 
            // 
            // 
            _CheckBoxX_EnableTextureAnimation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_EnableTextureAnimation.FocusCuesEnabled = false;
            _CheckBoxX_EnableTextureAnimation.Name = "CheckBoxX_EnableTextureAnimation";
            _CheckBoxX_EnableTextureAnimation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // ComboBoxEx_SelectDisplaylist
            // 
            resources.ApplyResources(_ComboBoxEx_SelectDisplaylist, "ComboBoxEx_SelectDisplaylist");
            _ContextMenuBar1.SetContextMenuEx(_ComboBoxEx_SelectDisplaylist, _ButtonItem_CM_SelDL);
            _ComboBoxEx_SelectDisplaylist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBoxEx_SelectDisplaylist.DropDownHeight = 150;
            _ComboBoxEx_SelectDisplaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _ComboBoxEx_SelectDisplaylist.DropDownWidth = 170;
            _ComboBoxEx_SelectDisplaylist.ForeColor = System.Drawing.Color.Black;
            _ComboBoxEx_SelectDisplaylist.FormattingEnabled = true;
            _ComboBoxEx_SelectDisplaylist.Name = "ComboBoxEx_SelectDisplaylist";
            _ComboBoxEx_SelectDisplaylist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX2
            // 
            resources.ApplyResources(_LabelX2, "LabelX2");
            // 
            // 
            // 
            _LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX2.Name = "LabelX2";
            _LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // CheckBoxX_EnableMirrorS
            // 
            resources.ApplyResources(_CheckBoxX_EnableMirrorS, "CheckBoxX_EnableMirrorS");
            // 
            // 
            // 
            _CheckBoxX_EnableMirrorS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_EnableMirrorS.FocusCuesEnabled = false;
            _CheckBoxX_EnableMirrorS.Name = "CheckBoxX_EnableMirrorS";
            _CheckBoxX_EnableMirrorS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_EnableClampS
            // 
            resources.ApplyResources(_CheckBoxX_EnableClampS, "CheckBoxX_EnableClampS");
            // 
            // 
            // 
            _CheckBoxX_EnableClampS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_EnableClampS.FocusCuesEnabled = false;
            _CheckBoxX_EnableClampS.Name = "CheckBoxX_EnableClampS";
            _CheckBoxX_EnableClampS.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_EnableCrystalEffect
            // 
            resources.ApplyResources(_CheckBoxX_EnableCrystalEffect, "CheckBoxX_EnableCrystalEffect");
            // 
            // 
            // 
            _CheckBoxX_EnableCrystalEffect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_EnableCrystalEffect.FocusCuesEnabled = false;
            _CheckBoxX_EnableCrystalEffect.Name = "CheckBoxX_EnableCrystalEffect";
            _CheckBoxX_EnableCrystalEffect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX3
            // 
            resources.ApplyResources(_LabelX3, "LabelX3");
            // 
            // 
            // 
            _LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX3.Name = "LabelX3";
            // 
            // ComboBoxEx_RotateFlip
            // 
            resources.ApplyResources(_ComboBoxEx_RotateFlip, "ComboBoxEx_RotateFlip");
            _ComboBoxEx_RotateFlip.DisplayMember = "Text";
            _ComboBoxEx_RotateFlip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            _ComboBoxEx_RotateFlip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _ComboBoxEx_RotateFlip.ForeColor = System.Drawing.Color.Black;
            _ComboBoxEx_RotateFlip.FormattingEnabled = true;
            _ComboBoxEx_RotateFlip.Name = "ComboBoxEx_RotateFlip";
            _ComboBoxEx_RotateFlip.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_EnableClampT
            // 
            resources.ApplyResources(_CheckBoxX_EnableClampT, "CheckBoxX_EnableClampT");
            // 
            // 
            // 
            _CheckBoxX_EnableClampT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_EnableClampT.FocusCuesEnabled = false;
            _CheckBoxX_EnableClampT.Name = "CheckBoxX_EnableClampT";
            _CheckBoxX_EnableClampT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // CheckBoxX_EnableMirrorT
            // 
            resources.ApplyResources(_CheckBoxX_EnableMirrorT, "CheckBoxX_EnableMirrorT");
            // 
            // 
            // 
            _CheckBoxX_EnableMirrorT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _CheckBoxX_EnableMirrorT.FocusCuesEnabled = false;
            _CheckBoxX_EnableMirrorT.Name = "CheckBoxX_EnableMirrorT";
            _CheckBoxX_EnableMirrorT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // LabelX4
            // 
            resources.ApplyResources(_LabelX4, "LabelX4");
            // 
            // 
            // 
            _LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX4.Name = "LabelX4";
            _LabelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX5
            // 
            resources.ApplyResources(_LabelX5, "LabelX5");
            // 
            // 
            // 
            _LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX5.Name = "LabelX5";
            _LabelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX6
            // 
            resources.ApplyResources(_LabelX6, "LabelX6");
            // 
            // 
            // 
            _LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX6.Name = "LabelX6";
            _LabelX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // LabelX7
            // 
            resources.ApplyResources(_LabelX7, "LabelX7");
            // 
            // 
            // 
            _LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            _LabelX7.Name = "LabelX7";
            _LabelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            // 
            // Panel1
            // 
            _Panel1.BackColor = System.Drawing.Color.Transparent;
            _Panel1.Controls.Add(_CheckBoxX_EnableClampT);
            _Panel1.Controls.Add(_LabelX48);
            _Panel1.Controls.Add(_CheckBoxX_EnableMirrorT);
            _Panel1.Controls.Add(_ComboBoxEx_RotateFlip);
            _Panel1.Controls.Add(_Button_SaveColsettings);
            _Panel1.Controls.Add(_LabelX3);
            _Panel1.Controls.Add(_PictureBox1);
            _Panel1.Controls.Add(_CheckBoxX_EnableCrystalEffect);
            _Panel1.Controls.Add(_LabelX_CollisionType);
            _Panel1.Controls.Add(_CheckBoxX_EnableClampS);
            _Panel1.Controls.Add(_ComboBox_ColType);
            _Panel1.Controls.Add(_CheckBoxX_EnableMirrorS);
            _Panel1.Controls.Add(_LabelX_MaxPixels);
            _Panel1.Controls.Add(_ComboBoxEx_SelectDisplaylist);
            _Panel1.Controls.Add(_LabelX1);
            _Panel1.Controls.Add(_LabelX7);
            _Panel1.Controls.Add(_CheckBoxX_EnableTextureAnimation);
            _Panel1.Controls.Add(_LabelX5);
            _Panel1.Controls.Add(_LabelX2);
            _Panel1.Controls.Add(_LabelX6);
            _Panel1.Controls.Add(_LabelX4);
            _Panel1.Controls.Add(_ListViewEx1);
            resources.ApplyResources(_Panel1, "Panel1");
            _Panel1.Name = "Panel1";
            // 
            // ContextMenuBar1
            // 
            _ContextMenuBar1.AntiAlias = true;
            resources.ApplyResources(_ContextMenuBar1, "ContextMenuBar1");
            _ContextMenuBar1.IsMaximized = false;
            _ContextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_CM_SelDL });
            _ContextMenuBar1.Name = "ContextMenuBar1";
            _ContextMenuBar1.Stretch = true;
            _ContextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            _ContextMenuBar1.TabStop = false;
            // 
            // ButtonItem_CM_SelDL
            // 
            _ButtonItem_CM_SelDL.AutoExpandOnClick = true;
            _ButtonItem_CM_SelDL.Name = "ButtonItem_CM_SelDL";
            _ButtonItem_CM_SelDL.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] { _ButtonItem_EditCustomDisplaylists });
            resources.ApplyResources(_ButtonItem_CM_SelDL, "ButtonItem_CM_SelDL");
            // 
            // ButtonItem1
            // 
            _ButtonItem_EditCustomDisplaylists.Image = My.Resources.Resources.icons8_edit_16px;
            _ButtonItem_EditCustomDisplaylists.Name = "ButtonItem1";
            resources.ApplyResources(_ButtonItem_EditCustomDisplaylists, "ButtonItem1");
            // 
            // TextureGraphicFormatEditor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(_ContextMenuBar1);
            Controls.Add(_Panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TextureGraphicFormatEditor";
            TopLeftCornerSize = 0;
            TopRightCornerSize = 0;
            ((System.ComponentModel.ISupportInitialize)_PictureBox1).EndInit();
            _Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_ContextMenuBar1).EndInit();
            ResumeLayout(false);
        }

        private DevComponents.DotNetBar.Controls.ListViewEx _ListViewEx1;

        internal DevComponents.DotNetBar.Controls.ListViewEx ListViewEx1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListViewEx1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListViewEx1 != null)
                {
                    _ListViewEx1.SelectedIndexChanged -= ListBoxAdv_CI_Textures_ItemClick;
                }

                _ListViewEx1 = value;
                if (_ListViewEx1 != null)
                {
                    _ListViewEx1.SelectedIndexChanged += ListBoxAdv_CI_Textures_ItemClick;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX48;

        internal DevComponents.DotNetBar.LabelX LabelX48
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX48;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX48 != null)
                {
                }

                _LabelX48 = value;
                if (_LabelX48 != null)
                {
                }
            }
        }

        private System.Windows.Forms.PictureBox _PictureBox1;

        internal System.Windows.Forms.PictureBox PictureBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PictureBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PictureBox1 != null)
                {
                }

                _PictureBox1 = value;
                if (_PictureBox1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonX _Button_SaveColsettings;

        internal DevComponents.DotNetBar.ButtonX Button_SaveColsettings
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button_SaveColsettings;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button_SaveColsettings != null)
                {
                }

                _Button_SaveColsettings = value;
                if (_Button_SaveColsettings != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBox_ColType;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_ColType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox_ColType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox_ColType != null)
                {
                    _ComboBox_ColType.SelectedIndexChanged -= ComboBox_CI_ColType_SelectedIndexChanged;
                }

                _ComboBox_ColType = value;
                if (_ComboBox_ColType != null)
                {
                    _ComboBox_ColType.SelectedIndexChanged += ComboBox_CI_ColType_SelectedIndexChanged;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_CollisionType;

        internal DevComponents.DotNetBar.LabelX LabelX_CollisionType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_CollisionType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_CollisionType != null)
                {
                }

                _LabelX_CollisionType = value;
                if (_LabelX_CollisionType != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX_MaxPixels;

        internal DevComponents.DotNetBar.LabelX LabelX_MaxPixels
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX_MaxPixels;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX_MaxPixels != null)
                {
                }

                _LabelX_MaxPixels = value;
                if (_LabelX_MaxPixels != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX1;

        internal DevComponents.DotNetBar.LabelX LabelX1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX1 != null)
                {
                }

                _LabelX1 = value;
                if (_LabelX1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_EnableTextureAnimation;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableTextureAnimation
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_EnableTextureAnimation;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_EnableTextureAnimation != null)
                {
                    _CheckBoxX_EnableTextureAnimation.CheckedChanged -= ButtonItem_IsScollTex_Click;
                }

                _CheckBoxX_EnableTextureAnimation = value;
                if (_CheckBoxX_EnableTextureAnimation != null)
                {
                    _CheckBoxX_EnableTextureAnimation.CheckedChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_SelectDisplaylist;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_SelectDisplaylist
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_SelectDisplaylist;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_SelectDisplaylist != null)
                {
                    _ComboBoxEx_SelectDisplaylist.SelectedIndexChanged -= ButtonItem_IsScollTex_Click;
                }

                _ComboBoxEx_SelectDisplaylist = value;
                if (_ComboBoxEx_SelectDisplaylist != null)
                {
                    _ComboBoxEx_SelectDisplaylist.SelectedIndexChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX2;

        internal DevComponents.DotNetBar.LabelX LabelX2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX2 != null)
                {
                }

                _LabelX2 = value;
                if (_LabelX2 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_EnableMirrorS;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableMirrorS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_EnableMirrorS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_EnableMirrorS != null)
                {
                    _CheckBoxX_EnableMirrorS.CheckedChanged -= ButtonItem_IsScollTex_Click;
                }

                _CheckBoxX_EnableMirrorS = value;
                if (_CheckBoxX_EnableMirrorS != null)
                {
                    _CheckBoxX_EnableMirrorS.CheckedChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_EnableClampS;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableClampS
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_EnableClampS;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_EnableClampS != null)
                {
                    _CheckBoxX_EnableClampS.CheckedChanged -= ButtonItem_IsScollTex_Click;
                }

                _CheckBoxX_EnableClampS = value;
                if (_CheckBoxX_EnableClampS != null)
                {
                    _CheckBoxX_EnableClampS.CheckedChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_EnableCrystalEffect;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableCrystalEffect
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_EnableCrystalEffect;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_EnableCrystalEffect != null)
                {
                    _CheckBoxX_EnableCrystalEffect.CheckedChanged -= ButtonItem_IsScollTex_Click;
                }

                _CheckBoxX_EnableCrystalEffect = value;
                if (_CheckBoxX_EnableCrystalEffect != null)
                {
                    _CheckBoxX_EnableCrystalEffect.CheckedChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX3;

        internal DevComponents.DotNetBar.LabelX LabelX3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX3 != null)
                {
                }

                _LabelX3 = value;
                if (_LabelX3 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.Controls.ComboBoxEx _ComboBoxEx_RotateFlip;

        internal DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxEx_RotateFlip
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBoxEx_RotateFlip;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBoxEx_RotateFlip != null)
                {
                    _ComboBoxEx_RotateFlip.SelectedIndexChanged -= ButtonItem_IsScollTex_Click;
                }

                _ComboBoxEx_RotateFlip = value;
                if (_ComboBoxEx_RotateFlip != null)
                {
                    _ComboBoxEx_RotateFlip.SelectedIndexChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_EnableClampT;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableClampT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_EnableClampT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_EnableClampT != null)
                {
                    _CheckBoxX_EnableClampT.CheckedChanged -= ButtonItem_IsScollTex_Click;
                }

                _CheckBoxX_EnableClampT = value;
                if (_CheckBoxX_EnableClampT != null)
                {
                    _CheckBoxX_EnableClampT.CheckedChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.Controls.CheckBoxX _CheckBoxX_EnableMirrorT;

        internal DevComponents.DotNetBar.Controls.CheckBoxX CheckBoxX_EnableMirrorT
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CheckBoxX_EnableMirrorT;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CheckBoxX_EnableMirrorT != null)
                {
                    _CheckBoxX_EnableMirrorT.CheckedChanged -= ButtonItem_IsScollTex_Click;
                }

                _CheckBoxX_EnableMirrorT = value;
                if (_CheckBoxX_EnableMirrorT != null)
                {
                    _CheckBoxX_EnableMirrorT.CheckedChanged += ButtonItem_IsScollTex_Click;
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX4;

        internal DevComponents.DotNetBar.LabelX LabelX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX4 != null)
                {
                }

                _LabelX4 = value;
                if (_LabelX4 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX5;

        internal DevComponents.DotNetBar.LabelX LabelX5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX5 != null)
                {
                }

                _LabelX5 = value;
                if (_LabelX5 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX6;

        internal DevComponents.DotNetBar.LabelX LabelX6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX6 != null)
                {
                }

                _LabelX6 = value;
                if (_LabelX6 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.LabelX _LabelX7;

        internal DevComponents.DotNetBar.LabelX LabelX7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LabelX7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LabelX7 != null)
                {
                }

                _LabelX7 = value;
                if (_LabelX7 != null)
                {
                }
            }
        }

        private System.Windows.Forms.Panel _Panel1;

        internal System.Windows.Forms.Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ContextMenuBar _ContextMenuBar1;

        internal DevComponents.DotNetBar.ContextMenuBar ContextMenuBar1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ContextMenuBar1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ContextMenuBar1 != null)
                {
                }

                _ContextMenuBar1 = value;
                if (_ContextMenuBar1 != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_CM_SelDL;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_CM_SelDL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_CM_SelDL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_CM_SelDL != null)
                {
                }

                _ButtonItem_CM_SelDL = value;
                if (_ButtonItem_CM_SelDL != null)
                {
                }
            }
        }

        private DevComponents.DotNetBar.ButtonItem _ButtonItem_EditCustomDisplaylists;

        internal DevComponents.DotNetBar.ButtonItem ButtonItem_EditCustomDisplaylists
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonItem_EditCustomDisplaylists;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonItem_EditCustomDisplaylists != null)
                {
                    _ButtonItem_EditCustomDisplaylists.Click -= ButtonItem_EditCustomDisplaylists_Click;
                }

                _ButtonItem_EditCustomDisplaylists = value;
                if (_ButtonItem_EditCustomDisplaylists != null)
                {
                    _ButtonItem_EditCustomDisplaylists.Click += ButtonItem_EditCustomDisplaylists_Click;
                }
            }
        }
    }
}