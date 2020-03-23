using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using global::DevComponents.DotNetBar.Controls;
using global::DevComponents.DotNetBar.Layout;
using global::SM64_ROM_Manager.UserRequests.GUI.My.Resources;

namespace SM64_ROM_Manager.UserRequests.GUI
{
    public partial class UserRequestDialog
    {

        // F i e l d

        private readonly UserRequest request;
        private CircularProgress circularProgress = null;
        private ButtonX button_Send = null;

        // C o n s t r u c t o r

        public UserRequestDialog(UserRequestLayout requestLayout)
        {
            InitializeComponent();
            request = new UserRequest(requestLayout);
            base.Text = request.RequestName;
            CreateLayout();
            StyleManager.UpdateAmbientColors(this);
        }

        // I n i t i a l a t i o n

        private void CreateLayout()
        {
            var rootGroup = LayoutControl1.RootGroup;
            LayoutControl1.SuspendLayout();
            foreach (UserRequestProperty prop in request.Properties)
            {
                // Titel
                AddLabel(rootGroup, prop.Name, true);

                // Description
                if (!string.IsNullOrEmpty(prop.Description))
                {
                    AddLabel(rootGroup, prop.Description, false);
                }

                // Value Editor
                var switchExpr = prop.Type;
                switch (switchExpr)
                {
                    case UserRequestPropertyType.Text:
                        {
                            AddValueText(rootGroup, prop, false);
                            break;
                        }

                    case UserRequestPropertyType.LongText:
                        {
                            AddValueText(rootGroup, prop, true);
                            break;
                        }

                    case UserRequestPropertyType.Files:
                        {
                            AddValueFiles(rootGroup, prop);
                            break;
                        }
                }

                // Splitter
                AddSplitter(rootGroup, 100, 10);
            }

            // Send Button
            AddSendButton(rootGroup);
            LayoutControl1.ResumeLayout();
        }

        private void AddControlToGroup(UserRequestProperty prop, LayoutGroup group, Control control, eLayoutSizeType withType = eLayoutSizeType.Percent, int width = 100)
        {
            control.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            var item = new LayoutControlItem()
            {
                TextVisible = true,
                WidthType = withType,
                Width = width,
                HeightType = eLayoutSizeType.Absolute,
                Height = control.Height + 8,
                Control = control
            };
            if (control is TextBoxX)
            {
                item.MinSize = new Size(120, 0);
            }

            LayoutControl1.Controls.Add(control);
            group.Items.Add(item);
            if (control is TextBoxX)
            {
                // item.MinSize = New Size(120, 0)
                if (!prop.AllowEmptyState)
                {
                    var validor = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("Requied field!") { HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red };
                    SuperValidator1.SetValidator1(control, validor);
                }
            }
        }

        private void AddLabel(LayoutGroup group, string text, bool bold)
        {
            var control = new LabelX()
            {
                Text = text,
                FontBold = bold,
                Size = new Size(LayoutControl1.Width - 6, 16)
            };
            control.Size = TextRenderer.MeasureText(text, new Font(control.Font, FontStyle.Bold), control.Size);
            AddControlToGroup(null, group, control);
        }

        private void AddValueText(LayoutGroup group, UserRequestProperty prop, bool multiline)
        {
            var control = new TextBoxX()
            {
                Text = prop.Value,
                Tag = prop,
                Multiline = multiline,
                Size = new Size(75, multiline ? 75 : 20)
            };
            control.Border.Class = "TextBoxBorder";
            control.TextChanged += (sender, e) =>
            {
                var csender = sender as Control;
                ((UserRequestProperty)csender.Tag).Value = csender.Text.Trim();
            };
            AddHandlerGotFocus(control);
            AddControlToGroup(prop, group, control);
        }

        private void AddValueFiles(LayoutGroup group, UserRequestProperty prop)
        {
            var control = new UserRequestPropertyFilesEditor(prop)
            {
                Tag = prop,
                BackColor = Color.Transparent,
                Size = new Size(120, 120)
            };
            control.TextChanged += (sender, e) =>
            {
                var csender = sender as Control;
                ((UserRequestProperty)csender.Tag).Value = csender.Text.Trim();
            };
            AddControlToGroup(prop, group, control);
        }

        private void AddSendButton(LayoutGroup group)
        {
            button_Send = new ButtonX()
            {
                Text = "Send",
                Size = new Size(90, 23),
                Image = Resources.icons8_send_16px,
                ColorTable = eButtonColor.OrangeWithBackground,
                Style = eDotNetBarStyle.StyleManagerControlled
            };
            circularProgress = new CircularProgress()
            {
                ProgressBarType = eCircularProgressType.Donut,
                ProgressColor = ForeColor,
                Size = new Size(23, 23)
            };
            button_Send.Click += Button_Send_Clicked;
            AddSplitter(group, 99, button_Send.Height + 8);
            AddControlToGroup(null, group, circularProgress, eLayoutSizeType.Absolute, circularProgress.Width + 8);
            AddControlToGroup(null, group, button_Send, eLayoutSizeType.Absolute, button_Send.Width + 8);
        }

        private void AddSplitter(LayoutGroup group, int percent, int height)
        {
            var item = new LayoutSpacerItem()
            {
                WidthType = eLayoutSizeType.Percent,
                Width = percent,
                HeightType = eLayoutSizeType.Absolute,
                Height = height
            };
            group.Items.Add(item);
        }

        private void AddHandlerGotFocus(Control control)
        {
            void ah(Control c) => c.GotFocus += (sender, e) => LayoutControl1.ScrollControlIntoView((Control)sender);
            ah(control);
            foreach (Control c in control.Controls)
                ah(c);
        }

        // F e a t u r e s

        private async Task<bool> SendRequest()
        {
            var mgr = new UserRequestManager();
            return await mgr.UploadRequest(request);
        }

        // G u i

        private async void Button_Send_Clicked(object sender, EventArgs e)
        {
            bool success = false;
            if (SuperValidator1.Validate())
            {
                if (!UserRequestManager.CheckMaxAttachmentFileLength(request, 250 * 1024 * 1024))
                {
                    MessageBoxEx.Show(UserRequestGuiLangRes.MsgBox_IncludedBigFiles, UserRequestGuiLangRes.MsgBox_IncludedBigFiles_Titel, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    button_Send.Enabled = false;
                    circularProgress.Start();

                    /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
                    success = await SendRequest();
                    /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
                    circularProgress.Stop();
                    button_Send.Enabled = true;
                    /* TODO ERROR: Skipped IfDirectiveTrivia *//* TODO ERROR: Skipped DisabledTextTrivia *//* TODO ERROR: Skipped EndIfDirectiveTrivia */
                    if (success)
                    {
                        MessageBoxEx.Show(UserRequestGuiLangRes.MsgBox_SendingRequestSuccess, UserRequestGuiLangRes.MsgBox_SendingRequestSuccess_Titel, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBoxEx.Show(UserRequestGuiLangRes.MsgBox_ErrorSendingRequest, UserRequestGuiLangRes.MsgBox_ErrorSendingRequest_Titel, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}