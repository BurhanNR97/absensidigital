using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absensi_Mahasiswa
{
    public class simpan
    {
        private static String username;
        private static String nidn;
        private static String jadwal;

        public static String getUsername()
        {
            return username;
        }

        public static void setUsername(String username)
        {
            simpan.username = username;
        }

        public static String getNIDN()
        {
            return nidn;
        }

        public static void setNIDN(String nidn)
        {
            simpan.nidn = nidn;
        }

        public static String getJadwal()
        {
            return jadwal;
        }

        public static void setJadwal(String jadwal)
        {
            simpan.jadwal = jadwal;
        }
    }
}
