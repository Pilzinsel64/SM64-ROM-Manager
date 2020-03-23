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

        public event TextItemAddedEventHandler TextItemAdded;
        public delegate void TextItemAddedEventHandler(TextItemEventArgs e);

        public event TextItemRemovedEventHandler TextItemRemoved;
        public delegate void TextItemRemovedEventHandler(TextItemEventArgs e);

        public event CurrentTextProfileInfoChangedEventHandler CurrentTextProfileInfoChanged;
        public delegate void CurrentTextProfileInfoChangedEventHandler();

        // F i e l d s

        private string dialogNamesFilePath = string.Empty;

        // P r o p e r t i e s

        public MyTextProfileInfoManager MyTextProfiles { get; private set; } = new MyTextProfileInfoManager();
        public bool ForceUppercaseForActAndLevelNames { get; set; } = true;

        public RomManager RomManager
        {
            get
            {
                var e = new RequestRomManagerEventArgs();
                RequestRomManager?.Invoke(e);
                if (e.RomManager is object)
                {
                    SetCurrentTextProfileToRomManager(e.RomManager);
                }

                return e.RomManager;
            }
        }

        private string DialogNamesFilePath
        {
            get
            {
                if (string.IsNullOrEmpty(dialogNamesFilePath))
                {
                    dialogNamesFilePath = Path.Combine(Publics.General.MyDataPath, @"Text Manager\dialogs.txt");
                }
                return dialogNamesFilePath;
            }
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

        public void OpenTextProfileEditor()
        {
            if (RomManager is null)
            {
                ErrorBecauseNoRomLoaded?.Invoke();
            }
            else
            {
                MyTextProfiles.LoadAllTextProfilesIfNotLoaded();
                var curTextProfile = GetCurrentTextProfile();
                var editor = new TextProfilesManagerDialog() { MyTextProfiles = MyTextProfiles };
                editor.ShowDialog();
                if (RomManager is object)
                {
                    SetCurrentTextProfileName(curTextProfile.Name);
                    RomManager.ClearTextGroups();
                    SendRequestReloadTextManagerLists();
                }
            }
        }

        public bool IsChangingTab()
        {
            var e = new RequestValueEventArgs<bool>(false);
            RequestIsChangingTab?.Invoke(e);
            return e.Value;
        }

        public void SetOtherStatusInfos(string text, Color foreColor)
        {
            SettingOtherStatusInfo?.Invoke(text, foreColor);
        }

        // T e x t   M a n a g e r   F e a t u r e s

        public void SetCurrentTextProfileToRomManager()
        {
            SetCurrentTextProfileToRomManager(RomManager);
        }

        private void SetCurrentTextProfileToRomManager(RomManager rommgr)
        {
            var curInfo = GetCurrentTextProfile(rommgr);
            if (curInfo != rommgr.TextInfoProfile)
            {
                rommgr.TextInfoProfile = curInfo;
            }
        }

        private TextProfileInfo GetCurrentTextProfile()
        {
            return GetCurrentTextProfile(RomManager);
        }

        private TextProfileInfo GetCurrentTextProfile(RomManager rommgr)
        {
            var info = GetTextProfileInfoByName(rommgr.RomConfig.SelectedTextProfileInfo);
            if (info is null)
            {
                info = MyTextProfiles.Manager.DefaultTextProfileInfo;
            }

            return info;
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

        public int GetTextGroupEntriesCount(string tableName)
        {
            return (int)RomManager.LoadTextGroup(tableName)?.Count;
        }

        public (string text, DialogHorizontalPosition horizontalPosition, DialogVerticalPosition verticalPosition, int linesPerSite) GetTextItemInfos(string tableName, int itemIndex)
        {
            var item = RomManager.LoadTextGroup(tableName)?.ElementAtOrDefault(itemIndex);
            DialogHorizontalPosition hPos = default;
            DialogVerticalPosition vPos = default;
            int lines = default;
            if (item is TextTableDialogItem)
            {
                TextTableDialogItem dialogItem = (TextTableDialogItem)item;
                hPos = dialogItem.HorizontalPosition;
                vPos = dialogItem.VerticalPosition;
                lines = dialogItem.LinesPerSite;
            }

            if (item is TextTableItem)
            {
            }

            if (item is TextArrayItem)
            {
            }

            return (item.Text, hPos, vPos, lines);
        }

        public string[] GetTextNameList(string tableName)
        {
            var group = GetTextGroup(tableName);
            var nameList = new List<string>();
            if (group.TextGroupInfo is TextTableGroupInfo)
            {
                TextTableGroupInfo tg = (TextTableGroupInfo)group.TextGroupInfo;
                if (!string.IsNullOrEmpty(tg.ItemDescriptions))
                {
                    var sr = new StringReader(tg.ItemDescriptions);
                    string line = sr.ReadLine();
                    while (!(line is null))
                    {
                        nameList.Add(line);
                        line = sr.ReadLine();
                    }

                    sr.Close();
                }
            }

            return nameList.ToArray();
        }

        public void SetTextItemText(string tableName, int tableIndex, string text)
        {
            var group = GetTextGroup(tableName);
            var item = group[tableIndex];
            item.Text = text.TrimEnd();
            group.NeedToSave = true;
            TextItemChanged?.Invoke(new TextItemEventArgs(tableName, tableIndex));
        }

        public void SetTextItemDialogData(string tableName, int tableIndex, DialogVerticalPosition vPos, DialogHorizontalPosition hPos, int linesPerSite)
        {
            var group = GetTextGroup(tableName);
            TextTableDialogItem item = (TextTableDialogItem)group[tableIndex];
            item.VerticalPosition = vPos;
            item.HorizontalPosition = hPos;
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

        public IEnumerable<string> GetAllTextProfileNames()
        {
            return MyTextProfiles.Manager.GetTextProfiles().Select(n => n.Name);
        }

        public string GetCurrentTextProfileName()
        {
            return GetCurrentTextProfile()?.Name;
        }

        public void SetCurrentTextProfileName(string name)
        {
            var selProf = GetTextProfileInfoByName(name);
            string newName;
            if (selProf is null || selProf == MyTextProfiles.Manager.DefaultTextProfileInfo)
            {
                newName = string.Empty;
            }
            else
            {
                newName = selProf.Name;
            }

            if ((RomManager.RomConfig.SelectedTextProfileInfo ?? "") != (newName ?? ""))
            {
                RomManager.RomConfig.SelectedTextProfileInfo = newName;
            }

            CurrentTextProfileInfoChanged?.Invoke();
        }

        private TextProfileInfo GetTextProfileInfoByName(string name)
        {
            TextProfileInfo prof = null;
            foreach (TextProfileInfo p in MyTextProfiles.Manager.GetTextProfiles())
            {
                if (prof is null && (p.Name ?? "") == (name ?? ""))
                {
                    prof = p;
                }
            }

            return prof;
        }
    }
}