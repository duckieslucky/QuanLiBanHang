using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class BackupBUL
    {
        private static BackupBUL instance;

        public static BackupBUL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BackupBUL();
                }
                return instance;
            }
            set => instance = value;
        }

        public bool Backup(string path)
        {
            return DataProvider.Instance.BackupData(path);
        }

        public bool Restore(string path)
        {
            return DataProvider.Instance.RestoreData(path);
        }
    }
}
