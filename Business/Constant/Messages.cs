using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string CarAdded = "Good Added.";
        public static string CarNameInvalid = "Invalid good name.";
        public static string MaintenanceTime = "under maintain";
        public static string CarsListed = "listed all goods";
        public static string CarDeleted = "{0} id car deleted";
        public static string CarUpdated = "Car Updated.";
        public static string CustomerAdded = "Customer added";
        public static string CustomerInvalid = "Customer İnvalid name";
        public static string CustomerDeleted = "Customer Deleted.";
        public static string CustomerListed = "Customers has been listed";
        public static string UserAdded = " User added.";
        public static string UserDeleted = "User deleted.";
        public static string UserListed = "User has been listed.";
        public static string UserInvalid = "User invalid name";
        public static string CustomerUpdated = "Customer Updated";
        public static string UserUpdated = "User updated.";
        public static string CarRented = "rent added";
        public static string CarNotReturned = "car not returned";
        public static string RentDeleted = "rent added";
        public static string RentInvalid = "rent added";
        public static string UpdatedBrand = "brand updated";
        public static string DeletedBrand = "brand deleted.";
        public static string ColorAdded = "color added";
        public static string ColorDeleted = "color deleted";
        public static string ColorUpdated = "color updated";

        public static string UserNotFound = "User not found";
        public static string PasswordError = "PasswordError";
        public static string SuccessfullLogin = "SuccessfullLogin";
        public static string UserAlreadyExists = "UserAlreadyExists";
        public static string UserRegistered = "SuccessUserRegistered";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "AuthorizationDenied";
        internal static string CarImageLimitExceeded;
    }
}
