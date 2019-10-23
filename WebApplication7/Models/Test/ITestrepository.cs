using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models.Test
{
    public interface ITestrepository
    {
        List<TestModel> GetAllTest();
        TestModel GetSelect(int no);
        TestModel PostTest(TestModel model);
   
        TestModel PutTest(TestModel model);
      
        TestModel DelTest(int no);
     
    }
}
