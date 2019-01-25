using DM.CMS.EntityFrameworkCore;

namespace DM.CMS.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly CMSDbContext _context;

        public TestDataBuilder(CMSDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}