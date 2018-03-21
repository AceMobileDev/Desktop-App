using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AceCards.Domain.Models;

namespace AceCards.Repository.Abstract
{
    public interface ITestRepository
    {
        List<TestModel> GetRegisteredUsers();
    }
}
