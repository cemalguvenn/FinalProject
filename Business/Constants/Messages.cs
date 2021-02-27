using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım çalışması var";
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductListed = "Ürün Listelendi";
        public static string UnitPriceInvalid = "Geçersiz Fiyat";
        public static string ProductCountOfCategoryError = "Kategori limiti aşıldı !";
        public static string ProductNameExists = "Aynı isimde ürün mevcut";
        public static string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor!";
        public static string AuthorizationDenied = "Yetki reddedildi !";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string PasswordError="Hatalı şifre";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string UserRegistered="Kayıt yapıldı";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
