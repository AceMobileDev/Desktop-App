using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AceCards.Domain.Models;
using AceCards.Repository.Abstract;
using AceCards.Repository.Concrete;

namespace AceCards.Repository.Concrete
{
    public class TestRepository : ITestRepository
    {

        //Later on we will add the REST Provider

        //private readonly IRestProvider _restProvider;
        //private readonly IExceptionManager _exceptionManager;

        //public UserRepo(IRestProvider restProvider, IExceptionManager exceptionManager)
        //{
        //    _restProvider = restProvider;
        //    _exceptionManager = exceptionManager;
        //}

        public List<TestModel> GetRegisteredUsers()
        {
            List<TestModel> GetUsers = new List<TestModel>();

            try
            {
                TestModel user = new TestModel { Id = 011, Name = "Chris Valladares", isActive = true };
                GetUsers.Add(user);

            }
            catch(Exception ex)
            {
                throw ex;
            }

            return GetUsers;
        }
    }
}
