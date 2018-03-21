using System;
using System.Collections.Generic;
using System.Text;
using AceCards.Domain.Models;
using AceCards.Infrastructure.Abstract;
using AceCards.Repository.Abstract;

namespace AceCards.Infrastructure.Concrete
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepo;

        public TestService(ITestRepository testRepo)
        {
            _testRepo = testRepo;
        }

        public List<TestModel> GetRegisteredUsers()
        {
            return _testRepo.GetRegisteredUsers();
        }
    }
}
