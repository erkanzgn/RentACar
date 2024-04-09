using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Eklendi";
        public static string Deleted = "Silindi";
        public static string Updated = "Güncellendi";
        public static string InvalidName = "isim geçersiz veya boş";
        public static string MaintanceTime = "Sistem Bakımda";
        public static string Listed = "Listelendi";
        public static string InvalıdObject = "Geçerli bir nesne bulunamadı";
        public static string CarCountBrandError="Bu markadan araba limitini aştınız";
        public static string FileNotFound = "Dosya bulunamadı";
        internal static string ImageLimitExceded="Fotograf limiti aşıldı";
    }
}
