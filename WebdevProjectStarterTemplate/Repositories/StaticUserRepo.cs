//using System.Collections;
//using System.Data;
//using Dapper;
//using WebdevProjectStarterTemplate.Models;

//namespace WebdevProjectStarterTemplate.Repositories
//{
//    public static class StaticUserRepo
//    {
//        static List<CafeUser> _users = new List<CafeUser>
//        { new CafeUser{Password="test", UserName="Rik", UniqueGuid=default } };

//        public enum AddUserResult
//        {
//            UserNameIsNotUnique,
//            GuidIsNotUnique, //zou nooit moeten voorkomen
//            Success
//        }
        
//        public static AddUserResult AddUser(CafeUser cafeUser)
//        {
//            if (cafeUser.UniqueGuid == default(Guid))
//            {
//                cafeUser.UniqueGuid = Guid.NewGuid();
//            }
            
//            if (_users.Find(x => x.UniqueGuid == cafeUser.UniqueGuid) != null)
//            {
//                return AddUserResult.GuidIsNotUnique;
//            }

//            if (_users.Find(x =>
//                    x.UserName.Equals(cafeUser.UserName, StringComparison.InvariantCultureIgnoreCase)) != null)
//            {
//                return AddUserResult.UserNameIsNotUnique;
//            }
            
//            _users.Add(cafeUser);
//            return AddUserResult.Success;
//        }

//        public static CafeUser GetUser(string username, string password)
//        {
//            return _users.FirstOrDefault(x =>
//                x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) &&
//                x.Password.Equals(password));
//        }

//        public static CafeUser GetUser(Guid guid)
//        {
//            return _users.SingleOrDefault(x => x.UniqueGuid == guid);
//        }
//    }
//}
