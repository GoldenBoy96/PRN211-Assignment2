using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {

        private AssSalesContext _db;

        public MemberRepository()
        {
            _db = new();
        }

        public List<Member> GetMembers() => this._db.Members.ToList();
    }
}
