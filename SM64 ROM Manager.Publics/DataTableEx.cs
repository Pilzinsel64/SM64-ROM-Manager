using System.Data;
using global::System.IO;
using System.Linq;

namespace SM64_ROM_Manager.Publics
{
    public class DataTableEx : DataTable
    {
        public virtual void Load(string path)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            Load(fs);
            fs.Close();
        }

        public virtual void Load(Stream s)
        {
            var sr = new StreamReader(s);
            Load(sr);
        }

        public virtual void Load(StreamReader sr)
        {
            while (!sr.EndOfStream)
            {
                var cells = sr.ReadLine().Split(',');
                AddCollums(cells.Count());
                Rows.Add(cells);
            }
        }

        public virtual void Save(string path)
        {
            var fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
            Save(fs);
            fs.Close();
        }

        public virtual void Save(Stream s)
        {
            var sw = new StreamWriter(s);
            Save(sw);
        }

        public virtual void Save(StreamWriter sw)
        {
            foreach (DataRow row in Rows)
            {
                string line = "";
                foreach (var item in row.ItemArray)
                {
                    if (!string.IsNullOrEmpty(line))
                        line += ",";
                    line += item;
                }

                sw.WriteLine(line);
            }
        }

        private void AddCollums(int maxCount)
        {
            for (int i = Columns.Count, loopTo = maxCount - 1; i <= loopTo; i++)
                Columns.Add();
        }

        public virtual void NewRow(params object[] values)
        {
            AddCollums(values.Count());
            Rows.Add(values);
        }

        protected override void OnTableNewRow(DataTableNewRowEventArgs e)
        {
            AddCollums(e.Row.ItemArray.Count());
            base.OnTableNewRow(e);
        }

        public virtual void InsertAt(DataRow row, int index)
        {
            OnTableNewRow(new DataTableNewRowEventArgs(row));
            Rows.InsertAt(row, index);
        }
    }
}