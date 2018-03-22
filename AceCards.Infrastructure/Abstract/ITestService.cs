using System;
using System.Collections.Generic;
using System.Text;
using AceCards.Domain.Models;
using AceCards.Repository.Abstract;
using AceCards.Infrastructure.Abstract;

namespace AceCards.Infrastructure.Abstract
{
    public interface ITestService
    {
        List<TestModel> GetRegisteredUsers();
    }
}
