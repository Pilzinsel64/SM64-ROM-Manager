using System;
using System.Collections.Generic;
using global::System.ComponentModel;
using System.Data;
using System.Drawing;
using global::System.IO;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;
using global::SM64_ROM_Manager.EventArguments;
using global::SM64Lib;
using global::SM64Lib.Text;
using global::SM64Lib.Text.Profiles;
using Z.Collections.Extensions;
using System.Threading.Tasks;
using SM64Lib.Text.Exporters;

namespace SM64_ROM_Manager
{
    public class TextManagerController
    {

        // C o n t r ol l e r   E v e n t s

        [EditorBrowsable(EditorBrowsableState.Never)]
        public event RequestStatusTextEventHandler RequestStatusText;
        public delegate void RequestStatusTextEventHandler(RequestValueEventArgs<string> e);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public event SettingStatusTextEventHandler SettingStatusText;
        public delegate void SettingStatusTextEventHandler(string newText);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public event SettingOtherStatusInfoEventHandler SettingOtherStatusInfo;
        public delegate void SettingOtherStatusInfoEventHandler(string text, Color foreColor);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public event RequestIsChangingTabEventHandler RequestIsChangingTab;
        public delegate void RequestIsChangingTabEventHandler(RequestValueEventArgs<bool> e);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public event RequestRomManagerEventHandler RequestRomManager;
        public delegate void RequestRomManagerEventHandler(RequestRomManagerEventArgs e);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public event ErrorBecauseNoRomLoadedEventHandler ErrorBecauseNoRomLoaded;
        public delegate void ErrorBecauseNoRomLoadedEventHandler();

        // P u b l i c   E v e n t s

        public event RequestReloadTextManagerListsEventHandler RequestReloadTextManagerLists;
        public delegate void RequestReloadTextManagerListsEventHandler();

        public event RequestReloadTextManagerLineColorsEventHandler RequestReloadTextManagerLineColors;
        public delegate void RequestReloadTextManagerLineColorsEventHandler();

        public event TextItemChangedEventHandler TextItemChanged;
        public delegate void TextItemChangedEventHandler(TextItemEventArgs e);

        public event ManyTextItemsChangedEventHandler ManyTextItemsChanged;
        public delegate void ManyTextItemsChangedEventHandler();

        public event TextItemAddedEventHandler TextItemAdded;
        public delegate void TextItemAddedEventHandler(TextItemEventArgs e);

        public event TextItemRemovedEventHandler TextItemRemoved;
        public delegate void TextItemRemovedEventHandler(TextItemEventArgs e);

        public event CurrentTextProfileInfoChangedEventHandler CurrentTextProfileInfoChanged;
        public delegate void CurrentTextProfileInfoChangedEventHandler();

        // F i e l d s

        private string dialogNamesFilePath = string.Empty;
        private bool forceUppercaseForActAndLevelNames = true;
        private bool autoDetectStartEndQuotationMarks = true;
        private bool autoFocusEditTextBox = true;
        private List<RomManager> knownRomManagers = new List<RomManager>();
        private TextProfileInfo myDefaultTextProfileInfo = null;

        // P r o p e r t i e s

        //public MyTextProfileInfoManager MyTextProfiles { get; private set; } = new MyTextProfileInfoManager();
        public bool UseSettingsForOptions { get; set; } = true;

        public bool ForceUppercaseForActAndLevelNames
        {
            get
            {
                if (UseSettingsForOptions)
                    return SettingsManager.Settings.TextManager.ForceUpperCaseForActAndLevelNames;
                else
                    return forceUppercaseForActAndLevelNames;
            }
            set
            {
                if (UseSettingsForOptions)
                    SettingsManager.Settings.TextManager.ForceUpperCaseForActAndLevelNames = value;
                else
                    forceUppercaseForActAndLevelNames = value;
            }
        }

        public bool AutoDetectStartEndQuotationMarks
        {
            get
            {
                if (UseSettingsForOptions)
                    return SettingsManager.Settings.TextManager.AutoDetectStartEndQuotationMarks;
                else
                    return autoDetectStartEndQuotationMarks;
            }
            set
            {
                if (UseSettingsForOptions)
                    SettingsManager.Settings.TextManager.AutoDetectStartEndQuotationMarks = value;
                else
                    autoDetectStartEndQuotationMarks = value;
            }
        }

        public bool AutoFocusEditTextBox
        {
            get
            {
                if (UseSettingsForOptions)
                    return SettingsManager.Settings.TextManager.AutoFocusEditorTextBox;
                else
                    return autoFocusEditTextBox;
            }
            set
            {
                if (UseSettingsForOptions)
                    SettingsManager.Settings.TextManager.AutoFocusEditorTextBox = value;
                else
                    autoFocusEditTextBox = value;
            }
        }

        public RomManager RomManager
        {
            get
            {
                var e = new RequestRomManagerEventArgs();
                RequestRomManager?.Invoke(e);

                if (e.RomManager is object)
                    M64TextEncoding.AutoDetectStartEndQuotationMarks = AutoDetectStartEndQuotationMarks;

                if (!knownRomManagers.Contains(e.RomManager))
                {
                    knownRomManagers.Add(e.RomManager);
                    e.RomManager.AfterRomSave += RomManager_AfterRomSave;
                }

                return e.RomManager;
            }
        }

        private void RomManager_AfterRomSave(RomManager sender, EventArgs e)
        {
        }

        public string StatusText
        {
            get
            {
                var e = new RequestValueEventArgs<string>();
                RequestStatusText?.Invoke(e);
                return e.Value;
            }

            set
            {
                SettingStatusText?.Invoke(value);
            }
        }

        // G e n e r a l   F e a t u r e s

        public void CreateNewTextProfileInfoIfUsingDefault()
        {
            if (UsingDefaultTextProfileInfo())
            {
                RomManager.CreateNewTextProfileInfo();
                CurrentTextProfileInfoChanged?.Invoke();
            }
        }

        public void ResetTextPRofileInfo()
        {
            RomManager.ResetTextProfileInfo();
            CurrentTextProfileInfoChanged?.Invoke();
        }

        public void OpenTextProfileEditor()
        {
            if (RomManager is null)
                ErrorBecauseNoRomLoaded?.Invoke();
            else if (!UsingDefaultTextProfileInfo())
            {
                CreateNewTextProfileInfoIfUsingDefault();
                var editor = new TextProfileEditor { ProfileInfo = RomManager.GetTextProfileInfo() };
                editor.ShowDialog();
            }
        }

        public bool IsChangingTab()
        {
            var e = new RequestValueEventArgs<bool>(false);
            RequestIsChangingTab?.Invoke(e);
            return e.Value;
        }

        public void SetOtherStatusInfos(string text, Color foreColor)
            => SettingOtherStatusInfo?.Invoke(text, foreColor);

        public void ExportTextProfile(string filePath)
            => GetCurrentTextProfile().WriteToFile(filePath);

        public void ImportTextProfile(string filePath)
        {
            RomManager.SetTextProfileInfo(TextProfileInfo.ReadFromFile(filePath));
            CurrentTextProfileInfoChanged?.Invoke();
        }

        // T e x t   M a n a g e r   F e a t u r e s

        private TextProfileInfo GetCurrentTextProfile()
        {
            return GetCurrentTextProfile(RomManager);
        }

        private TextProfileInfo GetCurrentTextProfile(RomManager rommgr)
        {
            return rommgr.GetTextProfileInfo();
        }

        private TextGroup GetTextGroup(string name)
        {
            return RomManager?.TextGroups?.FirstOrDefault(n => (n.TextGroupInfo.Name ?? "") == (name ?? ""));
        }

        public void SendRequestReloadTextManagerLists()
        {
            RequestReloadTextManagerLists?.Invoke();
        }

        public void SendRequestReloadTextManagerLineColors()
        {
            RequestReloadTextManagerLineColors?.Invoke();
        }

        public bool IsTextOverLimit()
        {
            if (RomManager is object)
            {
                for (int itbl = 0, loopTo = RomManager.TextGroups.Length - 1; itbl <= loopTo; itbl++)
                {
                    var tbl = RomManager.TextGroups[itbl];
                    if (tbl is TextTableGroup)
                    {
                        if (this.CalcTextSpaceBytesCount(tbl.TextGroupInfo.Name, default).percent > 1)
                        {
                            return true;
                        }
                    }
                    else if (tbl is TextArrayGroup)
                    {
                        for (int iItem = 0, loopTo1 = ((TextArrayGroup)tbl).Count - 1; iItem <= loopTo1; iItem++)
                        {
                            if (this.CalcTextSpaceBytesCount(tbl.TextGroupInfo.Name, iItem).percent > 1)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public (int used, int max, int left, float percent) CalcTextSpaceBytesCount(string tableName, int itemIndex)
        {
            if (!string.IsNullOrEmpty(tableName))
            {
                var curTable = RomManager.LoadTextGroup(tableName);
                var curTextItem = curTable.ElementAtOrDefault(itemIndex);
                int max = 0;
                int used = 0;
                float percent;
                int left;
                if (curTable is TextTableGroup)
                {
                    TextTableGroup curGroupCast = (TextTableGroup)curTable;
                    max = curGroupCast.TextGroupInfo.Data.DataMaxSize;
                    used = curGroupCast.DataLength;
                }
                else if (curTable is TextArrayGroup)
                {
                    TextArrayItem curTextItemCast = (TextArrayItem)curTextItem;
                    max = curTextItemCast.ItemInfo.MaxLength;
                    used = curTextItemCast.Data.Length;
                }

                if (max > 0)
                {
                    percent = (float)(used / (double)max);
                    left = max - used;
                }
                else
                {
                    percent = 0;
                    left = max;
                }

                return (used, max, left, percent);
            }

            return default;
        }

        public int GetTextGroupInfosCount()
        {
            return RomManager.GetTextGroupInfos().Length;
        }

        public string[] GetTextGroupInfoNames()
        {
            return RomManager.GetTextGroupInfos().Select(n => n.Name).ToArray();
        }

        public (string name, string encoding, bool isDialogGroup, bool isTableGroup, bool isArrayGroup) GetTextGroupInfos(string tableName)
        {
            var info = RomManager.GetTextGroupInfos().FirstOrDefault(n => (n.Name ?? "") == (tableName ?? ""));
            if (info is object)
            {
                bool isTable = info is TextTableGroupInfo;
                bool isArray = info is TextArrayGroupInfo;
                bool isDialog = isTable && ((TextTableGroupInfo)info).TableType == TextTableType.Dialogs;
                return (info.Name, info.EncodingString, isDialog, isTable, isArray);
            }
            else
            {
                return default;
            }
        }

        public void LoadTextGroup(string tableName)
        {
            RomManager.LoadTextGroup(tableName);
        }

        private void LoadAllTextGroups()
        {
            foreach (var tgi in RomManager.GetTextProfileInfo().AllGroups)
                RomManager.LoadTextGroup(tgi.Name);
        }

        public int GetTextGroupEntriesCount(string tableName)
        {
            return (int)RomManager.LoadTextGroup(tableName)?.Count;
        }

        public (string text, DialogHorizontalPosition horizontalPosition, DialogVerticalPosition verticalPosition, DialogSoundEffect soundEffect, int linesPerSite, string dialogDescription) GetTextItemInfos(string tableName, int itemIndex)
        {
            var item = RomManager.LoadTextGroup(tableName)?.ElementAtOrDefault(itemIndex);
            DialogHorizontalPosition hPos = default;
            DialogVerticalPosition vPos = default;
            int lines = default;
            string dialogDescription = null;
            DialogSoundEffect soundEffect = default;

            if (item is TextTableDialogItem)
            {
                TextTableDialogItem dialogItem = (TextTableDialogItem)item;

                hPos = dialogItem.HorizontalPosition;
                vPos = dialogItem.VerticalPosition;
                soundEffect = dialogItem.SoundEffect;
                lines = dialogItem.LinesPerSite;

                if (dialogItem.TextGroupInfo.ItemDescriptionsList.Any())
                    dialogDescription = dialogItem.TextGroupInfo.ItemDescriptionsList[itemIndex];
            }

            if (item is TextTableItem)
            {
            }

            if (item is TextArrayItem)
            {
            }

            return (item.Text, hPos, vPos, soundEffect, lines, dialogDescription);
        }

        public string[] GetTextNameList(string tableName)
        {
            var group = GetTextGroup(tableName);
            var nameList = new List<string>();

            if (group.TextGroupInfo is TextTableGroupInfo)
            {
                TextTableGroupInfo tg = (TextTableGroupInfo)group.TextGroupInfo;
                nameList.AddRange(tg.ItemDescriptionsList);
            }

            return nameList.ToArray();
        }

        public void SetDialogItemDescription(string tableName, int tableIndex, string description)
        {
            var group = GetTextGroup(tableName);
            var item = group[tableIndex];

            if (item?.TextGroupInfo is TextTableGroupInfo)
            {
                var info = (TextTableGroupInfo)item.TextGroupInfo;
                if (info.ItemDescriptionsList.Count > tableIndex)
                {
                    info.ItemDescriptionsList[tableIndex] = description.Trim();
                    TextItemChanged?.Invoke(new TextItemEventArgs(tableName, tableIndex));
                }
            }
        }

        public void SetTextItemText(string tableName, int tableIndex, string text)
        {
            var group = GetTextGroup(tableName);
            var item = group[tableIndex];
            item.Text = text.TrimEnd();
            group.NeedToSave = true;
            TextItemChanged?.Invoke(new TextItemEventArgs(tableName, tableIndex));
        }

        public void SetTextItemDialogData(string tableName, int tableIndex, DialogVerticalPosition vPos, DialogHorizontalPosition hPos, DialogSoundEffect soundEffect, int linesPerSite)
        {
            var group = GetTextGroup(tableName);
            TextTableDialogItem item = (TextTableDialogItem)group[tableIndex];
            item.VerticalPosition = vPos;
            item.HorizontalPosition = hPos;
            item.SoundEffect = soundEffect;
            item.LinesPerSite = linesPerSite;
            group.NeedToSave = true;
            TextItemChanged?.Invoke(new TextItemEventArgs(Conversions.ToString(tableIndex), tableIndex));
        }

        public void AddNewTextTableItem(string tableName)
        {
            var group = GetTextGroup(tableName);
            if (group is TextTableGroup)
            {
                TextItem item = null;
                if (((TextTableGroup)group).TextGroupInfo.TableType == TextTableType.Dialogs)
                {
                    item = new TextTableDialogItem(Array.Empty<byte>(), (TextTableGroupInfo)group.TextGroupInfo);
                }
                else
                {
                    item = new TextTableItem(Array.Empty<byte>(), (TextTableGroupInfo)group.TextGroupInfo);
                }

                group.Add(item);
                TextItemAdded?.Invoke(new TextItemEventArgs(tableName, group.Count - 1));
            }
        }

        public void RemoveTextTableItem(string tableName, int tableIndex)
        {
            var group = GetTextGroup(tableName);
            group.RemoveAt(tableIndex);
            TextItemRemoved?.Invoke(new TextItemEventArgs(tableName, tableIndex));
        }

        public void ClearTextItems(string tableName)
        {
            var group = GetTextGroup(tableName);
            if (group is object)
            {
                foreach (var item in group)
                    item.Text = string.Empty;
            }
            ManyTextItemsChanged?.Invoke();
        }

        public TextProfileInfo GetDefaultTextProfileInfo()
        {
            if (myDefaultTextProfileInfo == null)
                myDefaultTextProfileInfo  = TextProfileInfo.ReadFromFile(Path.Combine(Publics.General.MyDataPath, @"Text Manager\Profiles.json"));
            return myDefaultTextProfileInfo;
        }

        public bool UsingDefaultTextProfileInfo()
        {
            return RomManager.RomConfig.TextProfileInfo == null;
        }

        public async Task ExportTextTable(string destFilePath, string tableName)
        {
            await ExportTextTables(destFilePath, new[] { GetTextGroup(tableName) });
        }

        public async Task ExportAllTextTables(string destFilePath)
        {
            LoadAllTextGroups();
            await ExportTextTables(destFilePath, RomManager.TextGroups.ToArray());
        }

        private async Task ExportTextTables(string destFilePath, TextGroup[] groups)
        {
            var extLower = Path.GetExtension(destFilePath)?.ToLower();
            switch (extLower)
            {
                case ".txt":
                    var txtExporter = new TxtExporter();
                    await txtExporter.Export(destFilePath, groups);
                    break;
                case ".xlsx":
                    var excelExporter = new ExcelExporter();
                    await excelExporter.Export(destFilePath, groups);
                    break;
            }
        }

        public async Task ImportTextTables(string filePath)
        {
            LoadAllTextGroups();
            var excelExporter = new ExcelExporter();
            await excelExporter.Import(filePath, RomManager.TextGroups.ToArray());
            ManyTextItemsChanged?.Invoke();
        }
    }
}